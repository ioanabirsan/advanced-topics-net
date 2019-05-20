using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            SearchCustomerDockPanel.Visibility = Visibility.Visible;
            SearchCustomersDataGrid.Visibility = Visibility.Visible;
        }

        private void ViewAllCustomersButton_OnClick(object sender, RoutedEventArgs e)
        {
            SearchCustomerDockPanel.Visibility = Visibility.Hidden;
            SearchCustomersDataGrid.Visibility = Visibility.Collapsed;

            string queryString = "SELECT * FROM Clienti";
            ExecuteQuery(queryString, CustomersDataGrid);
        }

        private void ViewAllOrdersButton_OnClick(object sender, RoutedEventArgs e)
        {
            SearchCustomerDockPanel.Visibility = Visibility.Hidden;

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
            SearchDisplayInfoLabel.Content = !isValidExpression ? "The expression is not valid." : string.Empty;
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
            if (SearchCustomerEmailCheckbox.IsChecked == true)
            {
                SearchCustomerEmailTextBox.IsEnabled = true;
            }
            else
            {
                SearchCustomerEmailTextBox.IsEnabled = false;
            }
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
                SearchDisplayInfoLabel.Content = @"Must complete mandatory fields";
            }
            else
            {
                FindCustomerButton.IsEnabled = true;
                var client = _client.FindCustomer(name, firstName, phoneNumber);

                if (client == null)
                {
                    SearchDisplayInfoLabel.Content =
                        @"There is no customer with these specification.";
                }
                else
                {
                    SearchDisplayInfoLabel.Content = @"Customer cars are displayed bellow.";
                    //panelAddCustomerCar.Visible = true;

                    //string getChassis = "SELECT CodSasiu, Denumire FROM Sasiuri";
                   // ExecuteQuery(getChassis, dataGridViewChassisOptions);

                    string getClientCars = $"SELECT * FROM Automobile WHERE ClientId = {client.Id}";
                    ExecuteQuery(getClientCars, SearchCustomersDataGrid);
                }
            }
        }

        private void FindNewCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}