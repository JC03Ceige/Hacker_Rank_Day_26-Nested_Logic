using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank_Day_26_Nested_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            var retDate = Console.ReadLine().Split(' ');            
            
            int rd = int.Parse(retDate[0]);
            int rm = int.Parse(retDate[1]);
            int ry = int.Parse(retDate[2]);

            var dueDate = Console.ReadLine().Split(' ');
            
            int dd = int.Parse(dueDate[0]);
            int dm = int.Parse(dueDate[1]);
            int dy = int.Parse(dueDate[2]);

            int fine;

            if(ry<dy)
            {
                fine = 0;
            }
            else
            {
                if (rd > dd && rm <= dm && ry <= dy)
                {
                    fine = ((rd - dd) * 15);
                }
                else if (rm > dm && ry <= dy)
                {
                    fine = (rm - dm) * 500;
                }
                else if (ry > dy)
                {
                    fine = 10000;
                }
                else
                {
                    fine = 0;
                }
            }           

            Console.WriteLine($"{fine}");

            Console.ReadKey();
        }        
    }
}
