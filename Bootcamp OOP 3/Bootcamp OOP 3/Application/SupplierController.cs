using Bootcamp_OOP_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    public class SupplierController : Interface_supplier
    {
        private myContext myContext = new myContext();
        bool status = false;
        //TB_M_Suppliers supplier = new TB_M_Suppliers();

        public List<TB_M_Suppliers> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Suppliers.Where(x => x.isDelete == false).ToList();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\t Data Supplier");
            Console.WriteLine("-----------------------------");
            foreach (var list in get)
            {
                Console.Write("Id :");
                Console.WriteLine(list.Id);
                Console.Write("Supplier Name :");
                Console.WriteLine(list.Name);
                Console.WriteLine("");
            }
            return get;

        }

        public bool Insert(TB_M_Suppliers supplier)
        {
            //throw new NotImplementedException();
            Console.Write("Insert Your Name :");
            string name = Console.ReadLine();
            supplier.Name = name;
            myContext.TB_M_Suppliers.Add(supplier);
            Validation valid = new Validation();
            return valid.Save();
            
        } 
        public bool Update (int id, TB_M_Suppliers supplier)
        {
            //  throw new NotImplementedException();
            Console.Write("Insert Your Id :");
            int Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Id);
            if (get != null)
            {
                Console.Write("Insert Your Name :");
                String Name = Console.ReadLine();
                get.Name = Name;
                myContext.Entry(get).State = EntityState.Modified;
                Validation valid = new Validation();
                return valid.Save();

            }
            return status;
        }
        public bool DeleteSupplier(int id)
        {
            // throw new NotImplementedException();
            int Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Id);
            if (get != null)
            {
                myContext.Entry(get).State = EntityState.Deleted;
                Validation valid = new Validation();
                return valid.Save();
            }
            return status;

        }

        public TB_M_Suppliers Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
 

