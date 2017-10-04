using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorl
{
    class WorkingWithDelegate
    {

        private delegate void myDelegate();


        public void useDelegateAction()
        {

            var func = new myDelegate(print);
            func.Invoke();

        }


        private void print()
        {
            Console.WriteLine("Hello");
        }

    }
}
