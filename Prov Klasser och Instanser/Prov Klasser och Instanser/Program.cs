using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Klasser_och_Instanser
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Book book1 = new Book();
            {
                book1.name = "Kakornas Historia";
                book1.category = "History";
                book1.cursed = false;

                
            

                Console.WriteLine("Name: " + book1.name + "Category: " + book1.category);
                Console.ReadLine();
            }




        }
    }
}
