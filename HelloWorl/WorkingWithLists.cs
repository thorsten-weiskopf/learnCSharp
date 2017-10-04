using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace HelloWorl
{
    public static class WorkingWithLists
    {

        static IList<int> list = new List<int> {1,2,3,4,5};
        
        
        public static void printList()
        {
            //for (int i=0; i<list.Count; i++)
            //{
            //    Console.WriteLine(list[i]); //In Java you have getter and setter in the collection. 
            //}

            Console.WriteLine("Min Wert: " + list.Min());
            foreach(var t in list) //var means it does not matter if ther is an sting or int inside the list
            {                
                Console.WriteLine(t); //In Java you have getter and setter in the collection.                 
            }

            //LINQs
            var evenNumbers = list.Where(i => isEven(i)).ToList<int>(); //faster // every . is the next step and only happens if things before are done
            //equal to:
            var evenNumbers2 = list.Where(i => i%2==0).ToList<int>(); //faster
            //what happens here (comes from ES 6)
            var oddNumber = list.Last(
                (i) => //bool func(int i)
                {
                 return i % 2 != 0;
                }
                );



            Console.WriteLine("##### Grade Zahlen: ");
            foreach (var t in evenNumbers)
            {               
                Console.WriteLine(t);             
            }
            Console.WriteLine("#### Letzte Ungerade: ");
            Console.WriteLine(oddNumber);

            Console.ReadKey();

            /*
             
            IEnummerable<T>
            ICollection<T>
            IList<T>

            IDictionary<T> --> HashMap in Java
            Set<T>
            Queue<T>
             */

        }

        static bool isEven(int x)
        {
            return x % 2 == 0;
        }
        

    }
}
