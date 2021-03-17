using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIleUploadWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\Users\\890405\\Pictures";

            openFileDialog.Filter = "All Files (*.*)|*.*";

            openFileDialog.Title = "Choose Picture";

            openFileDialog.ShowDialog();

            if ((int)DialogResult.OK == 1)

            {

                location = openFileDialog.FileName;


                pictureBox1.ImageLocation = location;

            }
        }
    }
}
