using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20Decpraconsole { 
 internal class Class {  // following code display all classes of System namespace
         static void Main(string[] args) {

            Assembly assem = Assembly.LoadFile("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\System.dll");
                 foreach(Type oneClass in assem.GetTypes())
            {
                  Console.WriteLine(oneClass);
            }

            Type tt = typeof(string);
            Console.WriteLine("Name {0}", tt.Name);
            Console.WriteLine(" Namespace  {0} ", tt.Namespace);
            Console.WriteLine("Base class  {0} ", tt.BaseType);
            Console.ReadLine();
        }
    }
}


