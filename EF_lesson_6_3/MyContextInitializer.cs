using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EF_lesson_6_3
{
    class MyContextInitializer : DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext db)
        {

            Phone p1 = new Phone { Name = "Samsung Galaxy S5", Discount = 12 };
            Phone p2 = new Phone { Name = "Samsung Galaxy S4", Discount = 13 };
            Phone p3 = new Phone { Name = "iPhone5" };
            Phone p4 = new Phone { Name = "iPhone 4S" };

            
            db.Phones.AddRange(new List<Phone>() { p1, p2, p3, p4 });
            db.SaveChanges();
            //base.Seed(db);
        }
    }
}
