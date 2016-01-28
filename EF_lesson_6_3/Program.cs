using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                foreach(Phone ph in db.Phones)
                {
                    Console.WriteLine("Ident - {0}, Name - {1}", ph.Ident, ph.Name);
                }
                Console.ReadLine();
            }
        }
    }
}
