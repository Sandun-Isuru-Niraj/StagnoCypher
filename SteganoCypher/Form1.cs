using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteganoCypher
{
    public partial class Form1 : Form
    {

        public String imageToEncrypt;
        public String imageThatEncrypted;
        public String decodedMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imageToEncrypt = open.FileName;
                image.Image = new Bitmap(imageToEncrypt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String currentDirectory = Path.GetDirectoryName(imageThatEncrypted);
            if (Directory.Exists(currentDirectory))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = currentDirectory,
                    FileName = "explorer.exe"
            };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", currentDirectory));
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            String message = txt_message.Text.ToString();
            String password = txt_password.Text.ToString();

            SteganographyHelper helper = new SteganographyHelper();

            try
            {
                if (imageToEncrypt.Equals(""))
                {
                    MessageBox.Show("Image needs to Hide the Text, Please Select Image and Try Again!");
                }
                else { 
                    if (message.Equals(""))
                    {
                        MessageBox.Show("Your Message is Empty!");
                    }
                    else { 
                        String encryptedMessage = StringCipher.Encrypt(message, password);

                        Bitmap originalImage = new Bitmap(Image.FromFile(imageToEncrypt));

                        Bitmap imageWithHiddenData = SteganographyHelper.MergeText(encryptedMessage, originalImage);

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Title = "Save Encrypted Image";
                        saveFileDialog.CheckFileExists = false;
                        saveFileDialog.CheckPathExists = true;
                        saveFileDialog.DefaultExt = "bmp";
                        saveFileDialog.Filter = "Bitmap Images (*.bmp)|*.bmp|All files (*.*)|*.*";
                        saveFileDialog.FilterIndex = 2;
                        saveFileDialog.RestoreDirectory = true;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            imageThatEncrypted = saveFileDialog.FileName;
                            imageWithHiddenData.Save(imageThatEncrypted);

                            MessageBox.Show("Your Text is Hidden inside the Image");
                        }
                        else
                        {
                            MessageBox.Show("Process Aborted!");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Your Message is Too length to store inside an Image!");
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Decoded Text as a File";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Bitmap Images (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, decodedMessage);
                MessageBox.Show("Your Decoded Message saved as a Text File");
            }
            else
            {
                MessageBox.Show("Process Aborted!");
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            String drcryptPassword = txt_decryptPassword.Text.ToString();

            SteganographyHelper helper = new SteganographyHelper();

            try
            {
                string encryptedData = SteganographyHelper.ExtractText(
                new Bitmap(
                    Image.FromFile(imageToEncrypt)
            )
            );

                string decryptedData = StringCipher.Decrypt(encryptedData, drcryptPassword);
                decodedMessage = decryptedData;
                dect_message.Text = decryptedData;
            }
            catch
            {
                MessageBox.Show("Something went Wrong!");
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}
