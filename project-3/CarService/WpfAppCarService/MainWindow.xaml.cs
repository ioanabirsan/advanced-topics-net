using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using CarService;
using Microsoft.Win32;

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

        private decimal _totalCost = 0m;
        private decimal _serviceFee = 50m;

        private string AutoNumberPattern = @"^([A-Z]{2}[0-9]{3}[A-Z]{3})|([A-Z]{2}[0-9]{8})$";
        private string ChassisSeriesPattern = @"^[A-Z0-9]{6}[0-9][A-Z][A-Z0-9]{1,17}$";
        private string EmailPattern = @"^[a-zA-Z0-9_.-]+@[a-z.]+.[a-z]+$";
        private string NamePattern = @"^[A-Z][A-Za-z -]{2,14}$";
        private string AddressPattern = @"^[A-Za-z -.,0-9]{5,50}$";
        private string CityPattern = @"[A-Z][a-z]{3,9}$";
        private string CountyPattern = @"[A-Z][a-z]{3,9}$";
        private string PhoneNumberPattern = @"^\d{13}$";
        private string OrderDescriptionPattern = @"^[A-Z][A-Za-z -,.0-9]{3,1023}$";
        private string OrderKmPattern = @"^[1-9][0-9]*$";
        private string ChassisCodePattern = @"^[0-9][A-Z]$";
        private string ChassisNamePattern = @"^[A-Z][A-Za-z0-9 -]{3,24}$";
        private string OperationNamePattern = "^[A-Z][A-Za-z ]{3,255}$";
        private string MaterialNamePattern = @"^[A-Za-z ]{3,50}$";
        private string ImageTitlePattern = @"^[a-z0-9]{1,11}.[a-z]{3}$";
        private string ImageDescriptionPattern = @"^(\w)|(\s){5,256}$";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            CustomersDataGrid.Visibility = Visibility.Collapsed;
            AddCustomerStackPanel.Visibility = Visibility.Collapsed;
            AddCustomerButtonsStackPanel.Visibility = Visibility.Collapsed;

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
            AddOrderStackPanel.Visibility = Visibility.Hidden;
            AddOrderScrollViewer.Visibility = Visibility.Hidden;

            string queryString = "SELECT * FROM Comenzi";
            ExecuteQuery(queryString, OrdersDataGrid);
        }

        private void AddOrderButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddOrderStackPanel.Visibility = Visibility.Visible;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
        }

        private void ApplyStyle(DataTable dataTable, DataGrid dataGrid)
        {
            dataGrid.ItemsSource = dataTable.DefaultView;
            dataGrid.CanUserAddRows = false;
            dataGrid.Visibility = Visibility.Visible;
            //dataGrid.Columns[0].Visibility = Visibility.Hidden;
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

            DataRowView row = (DataRowView) DisplayChassisDataGrid.SelectedItem;
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

            DataRowView row = (DataRowView) DisplayChassisDataGrid.SelectedItem;
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
            AddCustomerButtonsStackPanel.Visibility = Visibility.Visible;

            SearchCustomerButtonsStackPanel.Visibility = Visibility.Hidden;
            SearchCustomersInputGrid.Visibility = Visibility.Collapsed;
            DisplayChassisDataGrid.Visibility = Visibility.Collapsed;
            SearchCustomerDataGrid.Visibility = Visibility.Hidden;
            AddCustomerCarInputGrid.Visibility = Visibility.Hidden;
            DisplayChassisDataGrid.Visibility = Visibility.Hidden;
        }

        private void AddCustomerNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCustomerField(NamePattern, AddCustomerNameTextBox);
        }

        private void ValidateAddCustomerField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            AddNewCustomerButton.IsEnabled = isValidExpression;
            AddCustomerDisplayInfoTextBlock.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void AddCustomerFirstNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCustomerField(NamePattern, AddCustomerFirstNameTextBox);
        }

        private void AddCustomerAddressTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCustomerField(AddressPattern, AddCustomerAddressTextBox);
        }

        private void AddCustomerCityTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCustomerField(CityPattern, AddCustomerCityTextBox);
        }

        private void AddCustomerCountyTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCustomerField(CountyPattern, AddCustomerCountyTextBox);
        }

        private void AddCustomerPhoneNumberTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCustomerField(PhoneNumberPattern, AddCustomerPhoneNumberTextBox);
        }

        private void AddCustomerEmailCheckbox_OnClick(object sender, RoutedEventArgs e)
        {
            AddCustomerEmailTextBox.IsEnabled = AddCustomerEmailCheckbox.IsChecked == true;
        }

        private void AddCustomerEmailTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddCustomerField(EmailPattern, AddCustomerEmailTextBox);

            bool invalidExpression = _client.ExistsCustomer(AddCustomerEmailTextBox.Text);
            AddNewCustomerButton.IsEnabled = !invalidExpression;
            AddCustomerDisplayInfoTextBlock.Text = invalidExpression ? "Email is taken." : string.Empty;
        }

        private void AddNewCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            string name = AddCustomerNameTextBox.Text;
            string firstName = AddCustomerFirstNameTextBox.Text;
            string address = AddCustomerAddressTextBox.Text;
            string city = AddCustomerCityTextBox.Text;
            string county = AddCustomerCountyTextBox.Text;
            string phoneNumber = AddCustomerPhoneNumberTextBox.Text;
            string email = AddCustomerEmailTextBox.Text;

            if (!FieldsCompleted(name, firstName, address, city, county, phoneNumber))
            {
                AddCustomerDisplayInfoTextBlock.Text = @"Must complete mandatory fields.";
            }
            else
            {
                AddNewCustomerButton.IsEnabled = true;
                List<Auto> cars = new List<Auto>();
                Client client = new Client()
                {
                    Nume = name,
                    Prenume = firstName,
                    Adresa = address,
                    Localitate = city,
                    Judet = county,
                    Telefon = phoneNumber,
                    Email = email,
                    Automobile = cars.ToArray()
                };

                _client.AddCustomer(client);

                AddCustomerDisplayInfoTextBlock.Text = @"Client added.";
                AddCustomerDisplayInfoTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void NewCustomerButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddCustomerDisplayInfoTextBlock.Visibility = Visibility.Hidden;
            AddNewCustomerButton.IsEnabled = false;

            AddCustomerNameTextBox.Text = "";
            AddCustomerFirstNameTextBox.Text = "";
            AddCustomerAddressTextBox.Text = "";
            AddCustomerCityTextBox.Text = "";
            AddCustomerCountyTextBox.Text = "";
            AddCustomerPhoneNumberTextBox.Text = "";
            AddCustomerEmailTextBox.Text = "";
        }

        private bool FieldsCompleted(string name, string firstName, string address, string city, string county,
            string phoneNumber)
        {
            return !string.IsNullOrEmpty(name)
                   && !string.IsNullOrEmpty(firstName)
                   && !string.IsNullOrEmpty(address)
                   && !string.IsNullOrEmpty(city)
                   && !string.IsNullOrEmpty(county)
                   && !string.IsNullOrEmpty(phoneNumber);
        }

        private void ValidateAddOrderField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            AddNewOrderButton.IsEnabled = isValidExpression;
        }

        private void InServiceCheckbox_OnClick(object sender, RoutedEventArgs e)
        {
            AddOrderKmTextBox.IsEnabled = InServiceCheckbox.IsChecked == true;
        }

        private void AddOrderDescriptionTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddOrderField(OrderDescriptionPattern, AddOrderDescriptionTextBox);
        }

        private void AddOrderKmTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddOrderField(OrderKmPattern, AddOrderKmTextBox);
        }

        private void AddNewOrderButton_OnClick(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView) DisplayOrderCarsDataGrid.SelectedItem;
            string autoIdText = row["Id"].ToString();
            int autoId = Convert.ToInt32(autoIdText);

            string startDate = OrderStartDatePicker.Text;
            string endDate = OrderEndDatePicker.Text;
            string description = AddOrderDescriptionTextBox.Text;
            object state = AddOrderStateCombobox.SelectedItem;

            AddNewOrderButton.IsEnabled = true;
            Comanda order = new Comanda()
            {
                AutoId = autoId,
                DataFinalizare = Convert.ToDateTime(endDate),
                DataProgramare = Convert.ToDateTime(startDate),
                DataSystem = DateTime.Now,
                Descriere = description,
                KmBord = Convert.ToInt32(AddOrderKmTextBox.Text),
                StareComanda = getOrderState(Convert.ToString(state)),
                ValoarePiese = _totalCost
            };

            _client.AddOrder(order);

            string getOrdersQuery = $"SELECT * FROM Comenzi WHERE AutoId = {autoId}";
            ExecuteQuery(getOrdersQuery, DisplayOrderOrdersDataGrid);
        }

        private StareComanda getOrderState(string state)
        {
            switch (state)
            {
                case "Waiting":
                    return StareComanda.InAsteptare;
                case "Executed":
                    return StareComanda.Executata;
                case "Rejected":
                    return StareComanda.Refuzata;
                default:
                    return StareComanda.Necunoscuta;
            }
        }

        private void AddOrderStackPanel_OnLoaded(object sender, RoutedEventArgs e)
        {
            string getCars = "SELECT * FROM Automobile";
            ExecuteQuery(getCars, DisplayOrderCarsDataGrid);

            string getMaterials = "SELECT Id, Denumire FROM Materiale";
            ExecuteQuery(getMaterials, DisplayOrderMaterialsDataGrid);

            string getOperations = "SELECT Id, Denumire FROM Operatii";
            ExecuteQuery(getOperations, DisplayOrderOperationsDataGrid);

            string getMechanics = "SELECT Id, Nume, Prenume FROM Mecanici";
            ExecuteQuery(getMechanics, DisplayOrderMechanicsDataGrid);

            string getImages = "SELECT Id, Titlu, Data FROM Imagini";
            ExecuteQuery(getImages, DisplayOrderImagesDataGrid);

            string getOrders = "SELECT Id, Descriere, StareComanda FROM Comenzi";
            ExecuteQuery(getOrders, DisplayOrderOrdersDataGrid);
        }

        private void AddOrderDetailsButton_OnClick(object sender, RoutedEventArgs e)
        {
            List<Material> materials = new List<Material>();
            List<Operatie> operations = new List<Operatie>();
            List<Mecanic> mechanics = new List<Mecanic>();
            List<Imagine> images = new List<Imagine>();

            DataRowView selectedRow = (DataRowView) DisplayOrderOrdersDataGrid.SelectedItem;
            string autoIdText = selectedRow["Id"].ToString();
            int orderId = Convert.ToInt32(autoIdText);

            IList selectedMaterials = DisplayOrderMaterialsDataGrid.SelectedItems;
            int materialsSize = selectedMaterials.Count;

            for (var i = 0; i < materialsSize; i++)
            {
                DataRowView row = (DataRowView) DisplayOrderMaterialsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();

                Console.WriteLine(textId); // a luat bine

                int id = Convert.ToInt32(textId);

                Material material = _client.FindMaterialById(id);
                _totalCost += material.Pret;

                material.Cantitate -= 1;
                _client.UpdateMaterial(material);

                materials.Add(material);

                // merge bine
                foreach (var item in materials)
                {
                    Console.WriteLine(item.Denumire, material.Id);
                }
            }

            IList selectedOperations = DisplayOrderOperationsDataGrid.SelectedItems;
            int operationsSize = selectedOperations.Count;

            for (var i = 0; i < operationsSize; i++)
            {
                DataRowView row = (DataRowView) DisplayOrderOperationsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                Operatie operation = _client.FindOperationById(id);
                operations.Add(operation);
            }

            IList selectedMechanics = DisplayOrderMechanicsDataGrid.SelectedItems;
            int mechanicsSize = selectedMechanics.Count;

            for (var i = 0; i < mechanicsSize; i++)
            {
                DataRowView row = (DataRowView) DisplayOrderMechanicsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                Mecanic mecanic = _client.FindMecanicById(id);
                mechanics.Add(mecanic);
            }

            IList selectedImages = DisplayOrderImagesDataGrid.SelectedItems;
            int imagesSize = selectedImages.Count;

            for (var i = 0; i < imagesSize; i++)
            {
                DataRowView row = (DataRowView) DisplayOrderImagesDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                Imagine image = _client.FindImageById(id);
                images.Add(image);
            }

            DetaliuComanda orderDetails = new DetaliuComanda()
            {
                ComandaId = orderId,
                Imagini = images.ToArray(),
                Mecanici = mechanics.ToArray(),
                Materiale = materials.ToArray(),
                Operatii = operations.ToArray()
            };

            _client.AddOrderDetails(orderDetails);

            Comanda order = _client.FindOrderById(orderId);
            order.ValoarePiese = _totalCost + _serviceFee;
            _client.UpdateOrder(order);
        }

        private void DisplayOrderMaterialsDataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.RemovedItems)
                DisplayOrderMaterialsDataGrid.SelectedItems.Add(item);
        }

        private void DisplayOrderMechanicsDataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.RemovedItems)
                DisplayOrderMechanicsDataGrid.SelectedItems.Add(item);
        }

        private void DisplayOrderOperationsDataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.RemovedItems)
                DisplayOrderOperationsDataGrid.SelectedItems.Add(item);
        }

        private void DisplayOrderImagesDataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.RemovedItems)
                DisplayOrderImagesDataGrid.SelectedItems.Add(item);
        }

        private void DisplayOrderOrdersDataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.RemovedItems)
                DisplayOrderOrdersDataGrid.SelectedItems.Add(item);
        }

        private void AddChassisButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewChassisStackPanel.Visibility = Visibility.Visible;
            ChassisDataGrid.Visibility = Visibility.Collapsed;
            DisplayAllChassisStackPanel.Visibility = Visibility.Hidden;
        }

        private void ViewAllChassisButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewChassisStackPanel.Visibility = Visibility.Hidden;
            DisplayAllChassisStackPanel.Visibility = Visibility.Visible;

            string queryString = "SELECT * FROM Sasiuri";
            ExecuteQuery(queryString, ChassisDataGrid);
        }

        private void AddChassisCodeTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddChassisField(ChassisCodePattern, AddChassisCodeTextBox);
        }

        private void AddChassisNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateAddChassisField(ChassisNamePattern, AddChassisNameTextBox);
        }

        private void ValidateAddChassisField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            AddNewChassisButton.IsEnabled = isValidExpression;
            AddChassisDisplayInfoTextBlock.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void AddNewChassisButton_OnClick(object sender, RoutedEventArgs e)
        {
            var chassisCode = AddChassisCodeTextBox.Text;
            var chassisName = AddChassisNameTextBox.Text;

            if (!FieldsCompleted(chassisName, chassisCode))
            {
                AddChassisDisplayInfoTextBlock.Text = @"Must complete mandatory fields.";
            }
            else
            {
                AddNewChassisButton.IsEnabled = true;
                Sasiu sasiu = new Sasiu()
                {
                    CodSasiu = chassisCode,
                    Denumire = chassisName
                };

                _client.AddChassis(sasiu);

                AddChassisDisplayInfoTextBlock.Text = @"Chassis added.";
                AddChassisDisplayInfoTextBlock.Visibility = Visibility.Visible;
            }
        }

        private bool FieldsCompleted(string chassisName, string chassisCode)
        {
            return !string.IsNullOrEmpty(chassisCode) && !string.IsNullOrEmpty(chassisName);
        }

        private void NewChassisButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddChassisNameTextBox.Text = "";
            AddChassisCodeTextBox.Text = "";
        }

        private void DeleteChassisButton_OnClick(object sender, RoutedEventArgs e)
        {
            IList selectedChassis = ChassisDataGrid.SelectedItems;
            int chassisSize = selectedChassis.Count;

            for (var i = 0; i < chassisSize; i++)
            {
                DataRowView row = (DataRowView) ChassisDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                _client.DeleteChassis(id);
            }
        }

        private void UpdateChassisButton_OnClick(object sender, RoutedEventArgs e)
        {
            IList selectedChassis = ChassisDataGrid.SelectedItems;
            int chassisSize = selectedChassis.Count;

            for (var i = 0; i < chassisSize; i++)
            {
                DataRowView row = (DataRowView) ChassisDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                Sasiu chassis = _client.FindChassisById(id);

                chassis.CodSasiu = row["CodSasiu"].ToString();
                chassis.Denumire = row["Denumire"].ToString();

                _client.UpdateChassis(chassis);
            }
        }

        private void AddOperationNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex(OperationNamePattern);
            var isValidExpression = regex.IsMatch(AddOperationNameTextBox.Text);

            AddOperationButton.IsEnabled = isValidExpression;
            AddOperationDisplayInfoTextBlock.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void AddOperationExecutionTimeTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!string.IsNullOrEmpty(AddOperationExecutionTimeTextBox.Text))
            {
                var isValidExpression = Convert.ToDecimal(AddOperationExecutionTimeTextBox.Text) > 0;
                AddOperationButton.IsEnabled = isValidExpression;
                AddOperationDisplayInfoTextBlock.Text =
                    !isValidExpression ? "Value must be bigger than 0." : string.Empty;
            }
        }

        private void AddOperationButton_OnClick(object sender, RoutedEventArgs e)
        {
            string name = AddOperationNameTextBox.Text;
            string executionTime = AddOperationExecutionTimeTextBox.Text;

            if (!FieldsCompleted(name, executionTime))
            {
                AddOperationDisplayInfoTextBlock.Text = @"Must complete mandatory fields.";
            }
            else
            {
                AddOperationButton.IsEnabled = true;
                Operatie operation = new Operatie()
                {
                    Denumire = name,
                    TimpExecutie = Convert.ToDecimal(executionTime)
                };

                _client.AddOperation(operation);

                AddOperationDisplayInfoTextBlock.Text = @"Operation added.";
                AddOperationDisplayInfoTextBlock.Visibility = Visibility.Visible;

                OperationsTabItem_OnLoaded(sender, e);
            }
        }

        private void NewOperationButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddOperationDisplayInfoTextBlock.Visibility = Visibility.Hidden;
            AddOperationNameTextBox.Text = "";
            AddOperationExecutionTimeTextBox.Text = "";
        }

        private void UpdateOperationsButton_OnClick(object sender, RoutedEventArgs e)
        {
            IList selectedOperations = OperationsDataGrid.SelectedItems;
            int operationsSize = selectedOperations.Count;

            for (var i = 0; i < operationsSize; i++)
            {
                DataRowView row = (DataRowView) OperationsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                Operatie operation = _client.FindOperationById(id);
                operation.Denumire = row["Denumire"].ToString();
                operation.TimpExecutie = Convert.ToDecimal(row["TimpExecutie"].ToString());

                _client.UpdateOperation(operation);
            }

            OperationsTabItem_OnLoaded(sender, e);
        }

        private void DeleteOperationsButton_OnClick(object sender, RoutedEventArgs e)
        {
            IList selectedOperations = OperationsDataGrid.SelectedItems;
            int operationsSize = selectedOperations.Count;

            for (var i = 0; i < operationsSize; i++)
            {
                DataRowView row = (DataRowView) OperationsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                _client.DeleteOperation(id);
            }

            OperationsTabItem_OnLoaded(sender, e);
        }

        private void OperationsTabItem_OnLoaded(object sender, RoutedEventArgs e)
        {
            string getOperations = "SELECT * FROM Operatii";
            ExecuteQuery(getOperations, OperationsDataGrid);
        }

        private void MechanicsTabItem_OnLoaded(object sender, RoutedEventArgs e)
        {
            string getMechanics = "SELECT * FROM Mecanici";
            ExecuteQuery(getMechanics, MechanicsDataGrid);
        }

        private void AddMecanicNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateMecanicField(NamePattern, AddMecanicFirstNameTextBox);
        }

        private void AddMecanicFirstNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateMecanicField(NamePattern, AddMecanicNameTextBox);
        }

        private void ValidateMecanicField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            AddMecanicButton.IsEnabled = isValidExpression;
            AddMecanicDisplayInfoTextBlock.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void AddMecanicButton_OnClick(object sender, RoutedEventArgs e)
        {
            string name = AddMecanicNameTextBox.Text;
            string firstName = AddMecanicFirstNameTextBox.Text;

            if (!FieldsCompleted(name, firstName))
            {
                AddMecanicDisplayInfoTextBlock.Text = @"Must complete mandatory fields.";
            }
            else
            {
                AddMecanicButton.IsEnabled = true;
                Mecanic mechanic = new Mecanic()
                {
                    Nume = name,
                    Prenume = firstName
                };

                _client.AddMecanic(mechanic);

                AddMecanicDisplayInfoTextBlock.Text = @"Mecanic added.";
                AddMecanicDisplayInfoTextBlock.Visibility = Visibility.Visible;
            }

            MechanicsTabItem_OnLoaded(sender, e);
        }

        private void NewMecanicButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddMecanicDisplayInfoTextBlock.Visibility = Visibility.Hidden;
            AddMecanicFirstNameTextBox.Text = "";
            AddMecanicNameTextBox.Text = "";
        }

        private void UpdateMecanicButton_OnClick(object sender, RoutedEventArgs e)
        {
            IList selectedMechanics = MechanicsDataGrid.SelectedItems;
            int mechanicsSize = selectedMechanics.Count;

            for (var i = 0; i < mechanicsSize; i++)
            {
                DataRowView row = (DataRowView)MechanicsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                Mecanic mecanic = _client.FindMecanicById(id);
                mecanic.Nume = row["Nume"].ToString();
                mecanic.Prenume = row["Prenume"].ToString();

                _client.UpdateMecanic(mecanic);
            }

            MechanicsTabItem_OnLoaded(sender, e);
        }

        private void DeleteMecanicButton_OnClick(object sender, RoutedEventArgs e)
        {
            IList selectedMechanics = MechanicsDataGrid.SelectedItems;
            int mechanicsSize = selectedMechanics.Count;

            for (var i = 0; i < mechanicsSize; i++)
            {
                DataRowView row = (DataRowView)MechanicsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                _client.DeleteMecanic(id);
            }

            MechanicsTabItem_OnLoaded(sender, e);
        }

        private void MaterialsTabItem_OnLoaded(object sender, RoutedEventArgs e)
        {
            string getMaterials = "SELECT * FROM Materiale";
            ExecuteQuery(getMaterials, MaterialsDataGrid);
        }

        private void AddMaterialNameTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex(MaterialNamePattern);
            var isValidExpression = regex.IsMatch(AddMaterialNameTextBox.Text);

            AddMaterialButton.IsEnabled = isValidExpression;
            AddMaterialDisplayInfoTextBlock.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void ValidateMaterialInputValue(TextBox input)
        {
            if (!string.IsNullOrEmpty(input.Text))
            {
                bool isValidExpression = Convert.ToDecimal(input.Text) > 0;
                AddMaterialButton.IsEnabled = isValidExpression;
                AddMaterialDisplayInfoTextBlock.Text = !isValidExpression ? "Value must be bigger than 0." : string.Empty;
            }
        }

        private void AddMaterialQuantityTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateMaterialInputValue(AddMaterialQuantityTextBox);
        }

        private void AddMaterialPriceTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ValidateMaterialInputValue(AddMaterialPriceTextBox);
        }

        private void AddMaterialButton_OnClick(object sender, RoutedEventArgs e)
        {
            string name = AddMaterialNameTextBox.Text;
            string quantityText = AddMaterialQuantityTextBox.Text;
            string priceText = AddMaterialPriceTextBox.Text;
            string dateSupplyText = AddMaterialDatePicker.Text;

            if (!FieldsCompleted(name, quantityText, priceText))
            {
                AddMaterialDisplayInfoTextBlock.Text = @"Must complete mandatory fields.";
            }
            else
            {
                Material material = new Material()
                {
                    Denumire = name,
                    Cantitate = Convert.ToDecimal(quantityText),
                    DataAprovizionare = Convert.ToDateTime(dateSupplyText),
                    Pret = Convert.ToDecimal(priceText)
                };

                _client.AddMaterial(material);

                AddMaterialDisplayInfoTextBlock.Text = @"Material added.";
                AddMaterialDisplayInfoTextBlock.Visibility = Visibility.Visible;
            }

            MaterialsTabItem_OnLoaded(sender, e);
        }

        private void NewMaterialButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddMaterialDisplayInfoTextBlock.Visibility = Visibility.Hidden;
            AddMaterialNameTextBox.Text = "";
            AddMaterialPriceTextBox.Text = "";
            AddMaterialQuantityTextBox.Text = "";
        }

        private void UpdateMaterialsButton_OnClick(object sender, RoutedEventArgs e)
        {
            IList selectedMaterials = MaterialsDataGrid.SelectedItems;
            int materialsSize = selectedMaterials.Count;

            for (var i = 0; i < materialsSize; i++)
            {
                DataRowView row = (DataRowView)MaterialsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                Material material = _client.FindMaterialById(id);
                material.Denumire = row["Denumire"].ToString();
                material.DataAprovizionare = Convert.ToDateTime(row["DataAprovizionare"].ToString());
                material.Cantitate = Convert.ToDecimal(row["Cantitate"].ToString());
                material.Pret = Convert.ToDecimal(row["Pret"].ToString());

                _client.UpdateMaterial(material);
            }

            MaterialsTabItem_OnLoaded(sender, e);
        }

        private void DeleteMaterialsButton_OnClick(object sender, RoutedEventArgs e)
        {
            IList selectedMaterials = MaterialsDataGrid.SelectedItems;
            int materialsSize = selectedMaterials.Count;

            for (var i = 0; i < materialsSize; i++)
            {
                DataRowView row = (DataRowView)MaterialsDataGrid.SelectedItems[i];
                string textId = row["Id"].ToString();
                int id = Convert.ToInt32(textId);

                _client.DeleteMaterial(id);
            }

            MaterialsTabItem_OnLoaded(sender, e);
        }

        private void ImagesTabItem_OnLoaded(object sender, RoutedEventArgs e)
        {
            string getImages = "SELECT Id, Titlu, Descriere FROM Imagini";
            ExecuteQuery(getImages, ImagesDataGrid);
        }

        private void AddImageTitleTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void AddImageDescriptionTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           
        }

        // https://www.godo.dev/tutorials/wpf-load-external-image/
        private void UploadImageButton_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select a picture",
                Filter = @"jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                ImagePhoto.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void AddImageButton_OnClick(object sender, RoutedEventArgs e)
        {
            string title = AddImageTitleTextBox.Text;
            string description = AddImageDescriptionTextBox.Text;
            DateTime date = Convert.ToDateTime(AddImageDatePicker.Text);
            
            byte[] photo = GetJPGFromImageControl(ImagePhoto.Source as BitmapImage);

            if (!FieldsCompleted(title, description))
            {
                AddImageDisplayInfoTextBlock.Text = @"Must complete mandatory fields.";
            }
            else
            {
                AddImageButton.IsEnabled = true;
                Imagine image = new Imagine()
                {
                    Data = date,
                    Descriere = description,
                    Titlu = title,
                    Foto = photo
                };

                _client.AddImage(image);

                AddImageDisplayInfoTextBlock.Text = @"Image added.";
                AddImageDisplayInfoTextBlock.Visibility = Visibility.Visible;
            }

            ImagesTabItem_OnLoaded(sender, e);
        }

        //https://stackoverflow.com/questions/553611/wpf-image-to-byte
        private byte[] GetJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);

            return memStream.ToArray();
        }

        private void NewImageButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateImageButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteImageButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}