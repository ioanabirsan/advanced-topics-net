using System;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageImage : Form
    {
        private readonly CarServiceApi _carService;
        private string _imageLocation = "";

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormManageImage()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, 100);
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
