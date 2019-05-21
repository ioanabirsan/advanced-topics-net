using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CarService;

namespace WpfAppCarService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CarServiceClient _client = new CarServiceClient();

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS;initial catalog=AUTO;integrated security=True";

        private readonly Style _dataGridCellStyle = new Style(typeof(DataGridCell))
        {
            Setters =
            {
                new Setter(TextBlock.TextAlignmentProperty, TextAlignment.Center)
            }
        };

        private string EmailPattern = @"^[a-zA-Z0-9_.-]+@[a-z.]+.[a-z]+$";
        private string NamePattern = @"^[A-Z][A-Za-z -]{2,14}$";
        private string AutoNumberPattern = @"^([A-Z]{2}[0-9]{3}[A-Z]{3})|([A-Z]{2}[0-9]{8})$";
        private string ChassisSeriesPattern = @"^[A-Z0-9]{6}[0-9][A-Z][A-Z0-9]{1,17}$";
        private string PhoneNumberPattern = @"^\d{13}$";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            CustomersDataGrid.Visibility = Visibility.Collapsed;
            AddCustomerStackPanel.Visibility = Visibility.Collapsed;

            SearchCustomerButtonsStackPanel.Visibility = Visibility.Visible;
            SearchCustomerDataGrid.Visibility = Visibility.Visible;
            AddCustomerCarButtonsStackPanel.Visibility = Visibility.Visible;
            SearchCustomersInputGrid.Visibility = Visibility.Visible;
            AddCustomerCarInputGrid.Visibility = Visibility.Visible;
            DisplayChassisDataGrid.Visibility = Visibility.Visible;
        }

        private void ViewAllCustomersButton_OnClick(object sender, RoutedEventArgs e)
        {
            SearchCustomerButtonsStackPanel.Visibility = Visibility.Hidden;
            SearchCustomersInputGrid.Visibility = Visibility.Collapsed;
            DisplayChassisDataGrid.Visibility = Visibility.Collapsed;
            SearchCustomerDataGrid.Visibility = Visibility.Hidden;
            AddCustomerCarInputGrid.Visibility = Visibility.Hidden;
            DisplayChassisDataGrid.Visibility = Visibility.Hidden;
            AddCustomerStackPanel.Visibility = Visibility.Hidden;

            string queryString = "SELECT * FROM Clienti";
            ExecuteQuery(queryString, CustomersDataGrid);
        }

        private void ViewAllOrdersButton_OnClick(object sender, RoutedEventArgs e)
        {
            SearchCustomerButtonsStackPanel.Visibility = Visibility.Hidden;

            string queryString = "SELECT * FROM Comenzi";
            ExecuteQuery(queryString, OrdersDataGrid);
        }

        private void AddOrderButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ApplyStyle(DataTable dataTable, DataGrid dataGrid)
        {
            dataGrid.ItemsSource = dataTable.DefaultView;
            dataGrid.CanUserAddRows = false;
            dataGrid.Visibility = Visibility.Visible;
            dataGrid.Columns[0].Visibility = Visibility.Hidden;
            dataGrid.ColumnHeaderHeight = 50;
            dataGrid.CellStyle = _dataGridCellStyle;
        }

        private void ExecuteQuery(string query, DataGrid dataGrid)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();

                ApplyStyle(dataTable, dataGrid);
            }
        }

        private void SearchCustomerNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateSearchField(NamePattern, SearchCustomerNameTextBox);
        }

        private void ValidateSearchField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            FindCustomerButton.IsEnabled = isValidExpression;
            SearchDisplayInfoTextBlock.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void SearchCustomerFirstNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateSearchField(NamePattern, SearchCustomerFirstNameTextBox);
        }

        private void SearchCustomerPhoneNumberTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateSearchField(PhoneNumberPattern, SearchCustomerPhoneNumberTextBox);
        }

        private void SearchCustomerEmailTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateSearchField(EmailPattern, SearchCustomerEmailTextBox);
        }

        private void SearchCustomerEmailCheckbox_OnClick(object sender, RoutedEventArgs e)
        {
            SearchCustomerEmailTextBox.IsEnabled = SearchCustomerEmailCheckbox.IsChecked == true;
        }

        private bool FieldsCompleted(string name, string firstName, string phoneNumber)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(firstName) &&
                   !string.IsNullOrEmpty(phoneNumber);
        }

        private void FindCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            string name = SearchCustomerNameTextBox.Text;
            string firstName = SearchCustomerFirstNameTextBox.Text;
            string phoneNumber = SearchCustomerPhoneNumberTextBox.Text;

            if (!FieldsCompleted(name, firstName, phoneNumber))
            {
                SearchDisplayInfoTextBlock.Text = @"Must complete mandatory fields";
            }
            else
            {
                FindCustomerButton.IsEnabled = true;
                var client = _client.FindCustomer(name, firstName, phoneNumber);

                if (client == null)
                {
                    SearchDisplayInfoTextBlock.Text =
                        @"There is no customer with these specification.";
                }
                else
                {
                    SearchDisplayInfoTextBlock.Text = @"Customer cars are displayed bellow.";

                    string getChassis = "SELECT * FROM Sasiuri";
                    ExecuteQuery(getChassis, DisplayChassisDataGrid);

                    string getClientCars = $"SELECT * FROM Automobile WHERE ClientId = {client.Id}";
                    ExecuteQuery(getClientCars, SearchCustomerDataGrid);
                }
            }
        }

        private void FindNewCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            SearchCustomerNameTextBox.Text = "";
            SearchCustomerFirstNameTextBox.Text = "";
            SearchCustomerPhoneNumberTextBox.Text = "";
            SearchCustomerEmailTextBox.Text = "";
            SearchDisplayInfoTextBlock.Visibility = Visibility.Hidden;
        }

        private void AddCustomerCarAutoNumberTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCarField(AutoNumberPattern, AddCustomerCarAutoNumberTextBox);
        }

        private void AddCustomerCarChassisSeriesTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCarField(ChassisSeriesPattern, AddCustomerCarChassisSeriesTextBox);
            
            DataRowView row = (DataRowView)DisplayChassisDataGrid.SelectedItem;
            string codSasiu = row["CodSasiu"].ToString();

            string chassisSeries = AddCustomerCarChassisSeriesTextBox.Text;

            bool isValidExpression = chassisSeries[6].Equals(codSasiu[0]) && chassisSeries[7].Equals(codSasiu[1]);
            AddCustomerCarButton.IsEnabled = isValidExpression;
            AddCarDisplayInfoTextBlock.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void AddCustomerCarButton_OnClick(object sender, RoutedEventArgs e)
        {
            string name = SearchCustomerNameTextBox.Text;
            string firstName = SearchCustomerFirstNameTextBox.Text;
            string phoneNumber = SearchCustomerPhoneNumberTextBox.Text;
            var customer = _client.FindCustomer(name, firstName, phoneNumber);

            DataRowView row = (DataRowView)DisplayChassisDataGrid.SelectedItem;
            string codSasiu = row["CodSasiu"].ToString();
            
            Sasiu sasiu = _client.FindChassisByCode(codSasiu);

            string autoNumber = AddCustomerCarAutoNumberTextBox.Text;
            string chassisSeries = AddCustomerCarChassisSeriesTextBox.Text;
            Auto auto = new Auto()
            {
                SasiuId = sasiu.Id,
                ClientId = customer.Id,
                NumarAuto = autoNumber,
                SerieSasiu = chassisSeries
            };

            _client.AddAuto(auto);

            AddCarDisplayInfoTextBlock.Text = @"Car added.";
            AddCarDisplayInfoTextBlock.Visibility = Visibility.Visible;

            string getClientCars = $"SELECT * FROM Automobile WHERE ClientId = {customer.Id}";
            ExecuteQuery(getClientCars, SearchCustomerDataGrid);
        }

        private void AddNewCustomerCarButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddCarDisplayInfoTextBlock.Visibility = Visibility.Hidden;
            AddCustomerCarAutoNumberTextBox.Text = "";
            AddCustomerCarChassisSeriesTextBox.Text = "";
        }

        private void ValidateAddCarField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            AddCustomerCarButton.IsEnabled = isValidExpression;
            AddCarDisplayInfoTextBlock.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void AddCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddCustomerStackPanel.Visibility = Visibility.Visible;

            SearchCustomerButtonsStackPanel.Visibility = Visibility.Hidden;
            SearchCustomersInputGrid.Visibility = Visibility.Collapsed;
            DisplayChassisDataGrid.Visibility = Visibility.Collapsed;
            SearchCustomerDataGrid.Visibility = Visibility.Hidden;
            AddCustomerCarInputGrid.Visibility = Visibility.Hidden;
            DisplayChassisDataGrid.Visibility = Visibility.Hidden;
        }

        private void AddCustomerNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddCustomerFirstNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddCustomerAddressTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddCustomerCityTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddCustomerCountyTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddCustomerPhoneNumberTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddCustomerEmailCheckbox_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddCustomerEmailTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}