using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorl
{
    class workWithExceptions
    {

        public void testExceptionHandling()
        {
            /*
            TextWriter writer = File.CreateText("file.txt");
            try
            {
                writer.WriteLine("Hello");
                
            } 
            catch (IOException ioe){
                Console.WriteLine(ioe.StackTrace);
            }
            finally
            {
                Console.WriteLine("I always run!");
                writer.Dispose();
            }
            */

            //using makes the finally automatically but not the catch
            try
            {
                using (TextWriter writer2 = File.CreateText("file.txt"))
                {
                    writer2.WriteLine("Hello from using!");
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }

    }
}
