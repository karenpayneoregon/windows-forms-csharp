using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RemoveFromSecondList.Classes;

namespace RemoveFromSecondList
{
    public partial class Form1 : Form
    {
        private List<DataItem> _list2;
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            checkedListBox1.DataSource = Mocked.List();
            _list2 = Mocked.List();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            var list1 = checkedListBox1.CheckedList<DataItem>();
            if (list1.Count > 0)
            {
                _list2.RemoveAllSpecial(list1);
                if (_list2.Count > 0)
                {
                    foreach (var dataItem in _list2)
                    {
                        Console.WriteLine(dataItem.Name);
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Empty");
                }

            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < 41; index++)
            {

                if (DatesCreated.Instance.HasDates)
                {
                    Console.WriteLine($"{index + 1,-3:D2}{DatesCreated.Instance.GetNextDate():d}");
                }
                else
                {
                    return;
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

 
}
