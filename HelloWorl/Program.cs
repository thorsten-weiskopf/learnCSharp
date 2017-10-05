
using HelloWorl;
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
            /*
            //Person p = new Person();
            var p = new Person { Age = 6, Name = "Thorty"};    //var can be used everytime, Defaultkonstruktor wird genutzt danach die Getter und Setter automatisch aufgerufen        
            Console.WriteLine("Hello World " +p.Age +" " +p.Name);
            Console.ReadKey();
            */

            //WorkingWithLists.printList();

            /*
            WorkingWithDelegate dele = new WorkingWithDelegate();
            dele.useDelegateAction();
            */

            //WorkingWithThreads.Play();
            WorkWithEvents we = new WorkWithEvents();
            we.TestEvent();

            Console.ReadKey();
        }
    }

class Person
    {
        private int age;
        private string name;

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
        public int Age { get; set; } = 2;
        public string Name { get; set; }

        //Konstruktor überladung
        public Person(): this (0, "")
        {
        }

        public Person(int age) : this(age, "")
        {
        }


        public Person (int age, string name)
        {
            this.age = age;
            this.name = name;
        }

    }


}
