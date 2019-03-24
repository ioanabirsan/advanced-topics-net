using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CarService;
using CarService.Api;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace WindowsFormsCarService
{
    public partial class CarServiceForm : Form
    {
        private readonly CarServiceApi _carService;
        private string _imageLocation = "";

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public CarServiceForm()
        {
            InitializeComponent();
            _carService = new CarServiceApi();
        }

        private void CarServiceForm_Load(object sender, EventArgs e)
        {
            panelSearchCustomer.Visible = false;
            panelAddCustomer.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddChassis.Visible = false;
            panelAddOrder.Visible = false;
            panelAddMaterial.Visible = false;
            panelAddOperation.Visible = false;
            panelAddMechanic.Visible = false;
            panelAddNewImage.Visible = false;
        }

        private void buttonSelectCustomer_Click(object sender, EventArgs e)
        {
            panelSearchCustomer.Visible = true;
            labelSearchDisplayInfo.Text = "";
            textBoxSearchName.Text = "";
            textBoxSearchFirstName.Text = "";
            textBoxSearchEmail.Text = "";

            panelAddCustomer.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddChassis.Visible = false;
            panelAddOrder.Visible = false;
            panelAddMaterial.Visible = false;
            panelAddOperation.Visible = false;
            panelAddMechanic.Visible = false;
            panelAddNewImage.Visible = false;
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            string firstName = textBoxSearchFirstName.Text;
            string email = textBoxSearchEmail.Text;

            Client client = _carService.FindCustomer(name, firstName, email);

            if (client == null)
            {
                labelSearchDisplayInfo.Text = "There is no customer with these specification. Please add new customer.";
            }
            else
            {
                labelSearchDisplayInfo.Text = "Customer cars are displayed bellow.";
                panelAddCustomerCar.Visible = true;

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string queryString = "SELECT CodSasiu, Denumire FROM Sasiuri";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    dataGridViewChassisOptions.DataSource = dataTable;
                    dataGridViewChassisOptions.Visible = true;
                }

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string queryString = "SELECT * FROM Automobile WHERE ClientId = " + client.Id;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    dataGridViewCustomerCars.DataSource = dataTable;
                    dataGridViewCustomerCars.Visible = true;
                }
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            panelAddCustomer.Visible = true;

            panelSearchCustomer.Visible = false;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddChassis.Visible = false;
            panelAddOrder.Visible = false;
            panelAddMaterial.Visible = false;
            panelAddOperation.Visible = false;
            panelAddMechanic.Visible = false;
            panelAddNewImage.Visible = false;

            textBoxAddName.Text = "";
            textBoxAddFirstName.Text = "";
            textBoxAddAddress.Text = "";
            textBoxAddCity.Text = "";
            textBoxAddCounty.Text = "";
            textBoxAddPhoneNumber.Text = "";
            textBoxAddEmail.Text = "";
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxAddName.Text;
            string firstName = textBoxAddFirstName.Text;
            string address = textBoxAddAddress.Text;
            string city = textBoxAddCity.Text;
            string county = textBoxAddCounty.Text;
            string phoneNumber = textBoxAddPhoneNumber.Text;
            string email = textBoxAddEmail.Text;

            List<Auto> autos = new List<Auto>();
            Client client = new Client()
            {
                Nume = name,
                Prenume = firstName,
                Adresa = address,
                Localitate = city,
                Judet = county,
                Telefon = phoneNumber,
                Email = email,
                Automobile = autos
            };

            _carService.AddCustomer(client);

            labelAddCustomerDisplayInfo.Text = "Client added.";
            labelSearchDisplayInfo.Visible = true;
        }

        private void buttonCustomerDetails_Click(object sender, EventArgs e)
        {
        }

        // https://www.youtube.com/watch?v=C9s0H6yeFLQ
        private void buttonDisplayCustomers_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Clienti";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewCustomers.DataSource = dataTable;
                dataGridViewCustomers.Visible = true;
            }
        }

        private void buttonAddCustomerCar_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            string firstName = textBoxSearchFirstName.Text;
            string email = textBoxSearchEmail.Text;
            Client client = _carService.FindCustomer(name, firstName, email);

            int index = dataGridViewChassisOptions.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewChassisOptions.Rows[index];

            string codSasiu = selectedRow.Cells[0].Value.ToString();
            Sasiu sasiu = _carService.FindChassisByCode(codSasiu);

            string autoNumber = textBoxAutoNumber.Text;
            string chassisSeries = textBoxChassisSeries.Text;
            Auto auto = new Auto()
            {
                SasiuId = sasiu.Id,
                ClientId = client.Id,
                NumarAuto = autoNumber,
                SerieSasiu = chassisSeries
            };

            _carService.AddAuto(auto);
        }

        private void buttonAddChassis_Click(object sender, EventArgs e)
        {
            panelAddChassis.Visible = true;

            panelAddOperation.Visible = false;
            panelAddCustomer.Visible = false;
            panelSearchCustomer.Visible = false;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddMechanic.Visible = false;
            panelAddNewImage.Visible = false;
        }

        private void buttonAddNewChassis_Click(object sender, EventArgs e)
        {
            var chassisCode = textBoxChassisCode.Text;
            var chassisName = textBoxChassisName.Text;

            Sasiu sasiu = new Sasiu()
            {
                CodSasiu = chassisCode,
                Denumire = chassisName
            };

            _carService.AddChassis(sasiu);
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            panelAddOrder.Visible = true;

            panelAddOperation.Visible = false;
            panelAddMaterial.Visible = false;
            panelAddChassis.Visible = false;
            panelAddCustomer.Visible = false;
            panelSearchCustomer.Visible = false;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddMechanic.Visible = false;
            panelAddNewImage.Visible = false;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Nume, Prenume FROM Clienti";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddOrderSelectClient.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Denumire FROM Materiale";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailsMaterials.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Denumire FROM Operatii";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailsOperations.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Nume, Prenume FROM Mecanici";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailsMechanics.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Titlu, Data FROM Imagini";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailsImages.DataSource = dataTable;
            }
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            panelAddMaterial.Visible = true;

            panelAddOperation.Visible = false;
            panelAddChassis.Visible = false;
            panelAddCustomer.Visible = false;
            panelSearchCustomer.Visible = false;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddOrder.Visible = false;
            panelAddMechanic.Visible = false;
            panelAddNewImage.Visible = false;
        }

        private void buttonAddNewMaterial_Click(object sender, EventArgs e)
        {
            string name = textBoxAddMaterialName.Text;
            string quantityText = textBoxAddMaterialQuantity.Text;
            string priceText = textBoxAddMaterialPrice.Text;
            string dateSupplyText = dateTimePickerAddMaterialDateSupply.Text;

            decimal quantity = Convert.ToDecimal(quantityText);
            decimal price = Convert.ToDecimal(priceText);
            DateTime dateSupply = Convert.ToDateTime(dateSupplyText);

            Material material = new Material()
            {
                Denumire = name,
                Cantitate = quantity,
                DataAprovizionare = dateSupply,
                Pret = price
            };

            _carService.AddMaterial(material);
        }

        private void buttonAddNewOrder_Click(object sender, EventArgs e)
        {
            string startDateText = dateTimePickerStartDate.Text;
            string endDateText = dateTimePickerEndDate.Text;
            string stateText = comboBoxAddOrderState.SelectedItem.ToString();
            string description = textBoxAddOrderDescription.Text;
            string inService = comboBoxAddOrderInService.SelectedItem.ToString();

            if (inService.Equals("Yes"))
            {
                textBoxAddOrderKm.Enabled = true;
            }

            int index = dataGridViewAddOrderSelectClient.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAddOrderSelectClient.Rows[index];
            string clientIdText = selectedRow.Cells[0].Value.ToString();
            int clientId = Convert.ToInt32(clientIdText);

            Comanda order = new Comanda()
            {
                ClientId = clientId,
                DataFinalizare = Convert.ToDateTime(endDateText),
                DataProgramare = Convert.ToDateTime(startDateText),
                DataSystem = DateTime.Now,
                Descriere = description,
                KmBord = Convert.ToInt32(textBoxAddOrderKm.Text),
                StareComanda = StareComanda.InAsteptare,
                ValoarePiese = 0m
            };

            _carService.AddOrder(order);
        }

        private void panelAddOperation_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            panelAddOperation.Visible = true;

            panelAddMaterial.Visible = false;
            panelAddChassis.Visible = false;
            panelAddCustomer.Visible = false;
            panelSearchCustomer.Visible = false;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddOrder.Visible = false;
            panelAddMechanic.Visible = false;
            panelAddNewImage.Visible = false;
        }

        private void buttonAddNewOperation_Click(object sender, EventArgs e)
        {
            string name = textBoxAddOperationName.Text;
            string executionTime = textBoxAddOperationExecutionTime.Text;

            Operatie operation = new Operatie()
            {
                Denumire = name,
                TimpExecutie = Convert.ToDecimal(executionTime)
            };

            _carService.AddOperation(operation);
        }

        private void buttonAddMechanic_Click(object sender, EventArgs e)
        {
            panelAddMechanic.Visible = true;

            panelAddOperation.Visible = false;
            panelAddMaterial.Visible = false;
            panelAddChassis.Visible = false;
            panelAddCustomer.Visible = false;
            panelSearchCustomer.Visible = false;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddOrder.Visible = false;
            panelAddNewImage.Visible = false;
        }

        private void buttonAddNewMechanic_Click(object sender, EventArgs e)
        {
            Mecanic mechanic = new Mecanic()
            {
                Nume = textBoxAddMechanicName.Text,
                Prenume = textBoxAddMechanicFirstName.Text
            };

            _carService.AddMechnic(mechanic);
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            panelAddNewImage.Visible = true;

            panelAddMechanic.Visible = false;
            panelAddOperation.Visible = false;
            panelAddMaterial.Visible = false;
            panelAddChassis.Visible = false;
            panelAddCustomer.Visible = false;
            panelSearchCustomer.Visible = false;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddOrder.Visible = false;
        }

        // https://www.youtube.com/watch?v=sGP6u68k2hc
        private void buttonAddImagePhotoUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _imageLocation = dialog.FileName;
                    pictureBoxImage.ImageLocation = _imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image?view=netframework-4.7.2
        private void buttonAddNewImage_Click(object sender, EventArgs e)
        {
            string title = textBoxAddImageTitle.Text;
            string description = textBoxAddImageDescription.Text;
            DateTime date = Convert.ToDateTime(dateTimePickerAddImageDate.Text);
            
            Image currentImage = Image.FromFile(_imageLocation);
            byte photo = ImageToByteArray(currentImage)[0];

            Imagine image = new Imagine()
            {
                Data = date,
                Descriere = description,
                Titlu = title,
                Foto = photo
            };

            _carService.AddImage(image);
        }

        // https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
        private byte[] ImageToByteArray(Image image)
        {

            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(image, typeof(byte[]));
            return xByte;
        }
    }
}