using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace QCodeGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UrlButton_Click(object sender, EventArgs e)
        {
            //PayloadGenerator.Bookmark generator = new PayloadGenerator.Bookmark(
            //    "https://github.com/karenpayneoregon/dataonly-timeonly",
            //    "Basic code samples for DateOnly and TimeOnly");

            //string payload = generator.ToString();

            //QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            //QRCode qrCode = new QRCode(qrCodeData);
            //Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20);


            PayloadGenerator.Url generator = new PayloadGenerator.Url("https://karenpayneoregon.github.io/");
            
            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20);

            pictureBox1.Image = qrCodeAsBitmap;

            qrCodeAsBitmap.Save("karenGitIo.png", ImageFormat.Png);




        }

        private void TextMessageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MessageTextBox.Text))
            {
                return;
            }

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(MessageTextBox.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20 );

            pictureBox1.Image = qrCodeImage;

        }

        private void MmsTextBox_Click(object sender, EventArgs e)
        {
            PayloadGenerator.OneTimePassword generator = new PayloadGenerator.OneTimePassword()
            {
                Secret = "pwq6 5q55",
                Issuer = "Google",
                Label = "test@google.com",
            };
            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(20);

            pictureBox1.Image = qrCodeAsBitmap;
        }
    }
}
