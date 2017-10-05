using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorl
{

    class WorkWithEvents
    {
        public void TestEvent()
        {
            //Synchronized stuff because just one thread
            Rooster myRooster = new Rooster();
            Person person = new Person();

            myRooster.Caw += person.SayImUp; //Add subscriber and function to the action
            myRooster.DoCaw();


        }
        
        
    }

    class Rooster
    {
        public event EventHandler Caw;

        public void DoCaw()
        {                        
            Caw(this, new MyEventArgs(DateTime.Now.ToString("HH:mm:ss tt"))); //null can be an eventArg
        }
    }


    class Person
    {
        public void SayImUp(object o, EventArgs e)
        {
            Console.WriteLine("I' m up! "+((MyEventArgs)e).Data);
        }
    }

    public class MyEventArgs : EventArgs
    {
        private string m_Data;
        public MyEventArgs(string _myData)
        {
            m_Data = _myData;
        } 

        public string Data { get { return m_Data; } }
    }


}
