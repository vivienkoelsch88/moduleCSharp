using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();

            Console.WriteLine(message.GetHelloMessage());

            while (true) { 
            //ConsoleKeyInfo saisie = Console.ReadKey(true);
                String text  = "il y a conflict";
                //if (saisie.Key == ConsoleKey.Enter)
                if (text == "")
                {
                    
                    Console.WriteLine(message.GetHelloMessage());
                    
                }
                else if (text == "exit")
                {
                    break;
                }

            }
        }
    }
}
