using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorl
{
    class WorkWithGenerics
    {

        public void TestGenerics()
        {
            var box = new Box<MyClass>();
            MyClass i = new MyClass();
            box.myValue = i;
        }


        public class Box<T> where T : class, IInterface // must be a class with implementation of IInterface
        {
            public T myValue { get; set; }
        }


        public class MyClass : IInterface
        {
           public int Generic { get; set; }
        }


        public interface IInterface
        {
            int Generic { get; set; }
        }


    }
}
