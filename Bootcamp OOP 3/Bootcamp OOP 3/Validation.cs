using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    public class Validation
    {
        public static MyContext myContext = new MyContext();
        bool status = false;

        public Validation(MyContext _myContext)
        {
            myContext = _myContext;
        }
        public Validation() { }

        public bool Save()
        {
            var result = myContext.SaveChanges();
            if (Convert.ToInt16(result) > 0)
            {
                status = true;
                Console.WriteLine("Success");
            }
            else
            {
                status = false;
                Console.WriteLine("Not Success");
            }
            return status;
        }
    }
}

