using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_3
{
    class MyContext : DbContext 
    {
        public MyContext():base("EF_lesson_6_3")
        { }
        public DbSet<Phone> Phones { get; set; }
        static MyContext()
        {
            Database.SetInitializer<MyContext>(new MyContextInitializer());
        }
    }
}
