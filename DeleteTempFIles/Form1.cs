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

namespace DeleteTempFIles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetFilesButton_Click(object sender, EventArgs e)
        {
            var list = Directory.GetDirectories(@"C:\Users\paynek\AppData\Local\Temp", "g*.*").ToList();

            Console.WriteLine(list.Count);
            for (int index = 0; index < list.Count; index++)
            {
                try
                {
                    Directory.Delete(list[index], true);

                }
                catch (Exception exception)
                {
                    Console.WriteLine(list[index]);

                }
            }

        }
    }
}
