using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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
            var list = Directory.GetDirectories(@"C:\Users\paynek\AppData\Local\Temp", "s*.*").ToList();

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

        private void button1_Click(object sender, EventArgs e)
        {
            var myClass = new Person();
            var index = myClass.GetOrder(c => c.LastName);
        }
    }
    public class OrderAttribute : Attribute
    {
        public readonly int Order;

        public OrderAttribute(int order)
        {
            Order = order;
        }
    }


    public class Person
    {
        [Order(2)] public int Id { get; set; }
        [Order(3)] public string FirstName { get; set; }
        [Order(1)] public string Comments { get; set; }

        [Order(0)] public string LastName { get; set; }
    }
    public static class Extensions
    {
        public static int GetOrder<T, TProp>(this T Class, Expression<Func<T, TProp>> propertySelector)
        {
            var body = (MemberExpression)propertySelector.Body;
            var propertyInfo = (PropertyInfo)body.Member;
            return propertyInfo.Order<T>();
        }
        public static int Order<T>(this PropertyInfo propertyInfo)
        {
            return typeof(T).GetProperties()
                .Where(property => Attribute.IsDefined(property, typeof(OrderAttribute)))
                .OrderBy(property => property.GetCustomAttributes<OrderAttribute>().Single().Order)
                .ToList()
                .IndexOf(propertyInfo);
        }
    }
}
