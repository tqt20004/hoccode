using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoccode
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /////  input va output Ten + nam sinh
            string name;
            Console.WriteLine("input name");
            name = Console.ReadLine();
            Console.WriteLine("input the year that you was born");
            int bornYear = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.WriteLine("Your name is:"+ name);
            Console.WriteLine("Your born year:"+ bornYear); 
        }
    }
}
