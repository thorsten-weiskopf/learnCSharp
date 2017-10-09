using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorl
{
    class WorkWithDelegate2
    {
        public void TestEvent()
        {
            myHandler mh = new myHandler();
            mh.myEvent.Invoke("my message");
        }

    }

    class myHandler
    {
        public Action<string> myEvent;

        public myHandler()
        {
            myEvent = new Action<string>(printEvent);
        }

        public void printEvent(string message)
        {
            Console.WriteLine("Print Event in out"+message);
        }
    }

    class myHandler2
    {
        public void logEvent(String msg)
        {
            Console.WriteLine("Print Event in log " + msg);
        }
    }
    


}
