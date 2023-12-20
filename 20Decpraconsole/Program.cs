using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine1
{
    public class Customer { public void Fun1() { } }
    public class Product { public static void Fun1() { } }

    namespace _20Decpraconsole
    {
        public class Customer
        {
            private string CuName = "Amit"; public string Name
            {
                get { return this.CuName; }
                set { this.CuName = value; }// value is built variable with same value
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                System.Console.WriteLine();
                Customer c = new Customer();
                c.Name = "Bobby";//set
                Console.WriteLine(c.Name);// Bobby get 
                Mine1.Product.Fun1();
                Mine1.Customer cust = new Mine1.Customer();
                cust.Fun1();
                Type t = c.Name.GetType();
                Console.WriteLine(" data type of name property " + t);
            }
        }
    }
}
