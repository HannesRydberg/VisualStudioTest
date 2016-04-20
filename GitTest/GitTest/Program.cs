using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jan", "Jansson", "880422-7744");
            Console.WriteLine("Let's git it on!");
            Console.ReadLine();
            Console.WriteLine("Gittin' it on!");
            Console.ReadLine();
            Console.WriteLine("{0} gits it!", p1.FirstName);
            Console.Write("Write something: ");
            String repeat = Console.ReadLine();
            Console.WriteLine(repeat);
            Console.ReadLine();

            List<Person> pList = new List<Person>();
            bool run = true;
            while (run)
            {
                Person p = new Person();
                Console.Write("Please enter the persons first name: ");
                p.FirstName = Console.ReadLine();
                Console.Write("Please enter the persons last name: ");
                p.LastName = Console.ReadLine();
                Console.Write("Please enter the persons personal number: ");
                p.PNbr = Console.ReadLine();
                pList.Add(p);
                Console.Write("{0} {1} added to persons. Add another person (Y/N)? ", p.FirstName, p.LastName);
                ConsoleKeyInfo input = Console.ReadKey();

                while (input.KeyChar != 'y' && input.KeyChar != 'n')
                {
                    Console.Write("\n Not a valid selection. Add another person (Y/N)?");
                    input = Console.ReadKey();
                }

                if (input.KeyChar == 'n' )
                {
                    run = false;
                }
                Console.WriteLine();
              
            }

            Console.WriteLine("The following persons have been added: ");
            foreach(Person p in pList){
                Console.WriteLine("{0} {1} {2}", p.FirstName, p.LastName, p.PNbr);

            }
            Console.WriteLine("That was everyone! Press any key to exit.");
            Console.Read();


        }
    }
}
