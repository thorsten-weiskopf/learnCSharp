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
        //Often in C#
        //Action is a Delegate that returns noting and can have 0 ore more arg.
        //Func is a Delegate that returns something and can have 0 ore more arg.

        public void useDelegateAction()
        {

            //action
            var action = new Action<int>(print);
            action.Invoke(1);
            //func
            var func = new Func<int, int, int>(printAndCount);
            var count = func.Invoke(5,5);

        }


        private void print(int i)
        {
            Console.WriteLine("Action " + i);
        }
        private int printAndCount(int i, int a)
        {
            Console.WriteLine("Func " + i +" " +a);
            return i+a;
        }

    }
}
