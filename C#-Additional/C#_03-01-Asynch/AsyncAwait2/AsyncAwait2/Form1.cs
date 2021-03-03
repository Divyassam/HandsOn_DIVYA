using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait2
{
    public partial class Form1 : Form
    {
        static Label l;

        public Form1()
        {
            InitializeComponent();
            l = new Label();
            Reader();
            this.Controls.Add(l);

        }
        private static int Counter()
        {
            int c = 0;
            string filePath = "C:\\Users\\890405\\Desktop\\New\\file.txt";
            StreamReader reader = new StreamReader(filePath);
            var text = reader.ReadToEnd();
            return text.Length;

        }
        static async Task Reader()
        {
            Task<int> task = new Task<int>(Counter);
            task.Start();
            int c = await task;
            Form1.l.Text = "The file has "+c.ToString()+" characters";
        }

    }
}
