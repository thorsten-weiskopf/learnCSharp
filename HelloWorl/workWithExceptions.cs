using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorl
{
    class workWithExceptions
    {

        public void testExceptionHandling()
        {
            var list = new List<int>();
            try
            {
                var x = list[0];

            } catch (ArgumentOutOfRangeException aoe)
            {
                Console.WriteLine(aoe.StackTrace);
            } catch (Exception e)
            {
                Console.WriteLine("Catches everything else!");
            }
            finally
            {
                Console.WriteLine("I always run!");
            }

        }

    }
}
