using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Pass different type of objects to the same method
 *      I have a method commonMethod which takes Customer object as param.
 *      The logic is same for both Customer and Order class.
 *      Instead of rewriting the same code for Order class how to reuse it.
 *
 * https://docs.microsoft.com/en-us/answers/questions/570261/pass-different-type-of-objects-to-the-same-method.html
 *
 * Note one class inherits Id while the other uses an interface
 *
 *      In c# you can inherit many interfaces, but only one base class.
 */

namespace ExampleLibrary.Classes
{
    public class Base
    {
        public int Id { get; set; }
    }

    public interface IBase
    {
        int Id { get; set; }
    }
    public interface IRating<T>
    {
        int Rank { get; set; }
    }

    public class Customer : IBase, IRating<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
    }

    public class Order : Base
    {
        public string Product { get; set; }
    }

    public class Contact : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class KarensOperation
    {
        public static string Common(object sender) => sender switch
        {
            Customer customer => DoSomethingWithCustomer(customer),
            Order order       => DoSomethingWithOrder(order),
            _                 => Unknown(sender)
        };

        /// <summary>
        /// For some type of operation for <see cref="Customer"/>
        /// </summary>
        /// <param name="customer">Valid Customer</param>
        /// <returns>Not much now</returns>
        public static string DoSomethingWithCustomer(Customer customer)
            => $"Customer id: {customer.Id} Name: {customer.Name}";

        /// <summary>
        /// For some type of operation for <see cref="Order"/>
        /// </summary>
        /// <param name="order">Valid order</param>
        /// <returns>Not much now</returns>
        public static string DoSomethingWithOrder(Order order) 
            => $"Customer id: {order.Id} Product: {order.Product}";

        /// <summary>
        /// Silly programmer doesn't understand how this works
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string Unknown(object sender)
        {
            var pos = sender.GetType().ToString().LastIndexOf(".", StringComparison.Ordinal) +1;
            throw new Exception($"{sender.GetType().ToString().Substring(pos)} type is not supported");
        }

    }
}