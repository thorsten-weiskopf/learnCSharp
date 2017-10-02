
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 5;
            Console.WriteLine("Hello World " +p.Age);
            Console.ReadKey();        
        }
    }

class Person
    {
        private int age;

        //The Java Style:
        /*
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        */
        //The c# style with Attribut Manipulation
        /*
        public int Age
        {
            get { return age; }
            set { age = value > 100 ? 0 : value; } //manipulate
        }
        */
        // the c# way when things are simple
        public int Age { get; set; } = 5; //5 is default value
    }


}
