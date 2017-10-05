using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorl
{
    class WorkWithEvents2
    {
        public void TestEvent()
        {
            var myRooster = new Rooster2();
            var myPerson = new Person2();
            myRooster.DoCaw();
            myRooster.Caw += myPerson.SayImUp; //Add subscriber and function to the action
            myRooster.DoCaw();
            

        }
    }

    class Rooster2
    {
        public event Action Caw;

        // Add overrides += with add and remove
        /*
        public event Action Caw
        {
            add
            {

            }
            remove
            {

            }
        }
        */

        public void DoCaw()
        {
            if (Caw != null)
            {
                Console.WriteLine("Caw is not null");
                Caw();
            }
            else
            {
                Console.WriteLine("Caw is null");
            }
            
        }
    }

    class Person2
    {
        public void SayImUp()
        {
            Console.WriteLine("I' m up!");
        }
    }

}
