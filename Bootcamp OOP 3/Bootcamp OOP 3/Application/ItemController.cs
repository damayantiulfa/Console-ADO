using Bootcamp_OOP_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    class TB_M_ItemController : Interface_item
    {
        private myContext myContext = new MyContext();
        bool status = false;

        //TB_M_Suppliers supplier = new TB_M_Suppliers();
        //TB_T_Transactions transaction = new TB_T_Transactions();

        public List<TB_M_Item> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Item.Where(x => x.isDelete == false).ToList();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\t Data Item");
            Console.WriteLine("-----------------------------");
            foreach (var list in get)
            {
                Console.Write("Id :");
                Console.WriteLine(list.Id);
                Console.Write("Item Name :");
                Console.WriteLine(list.Name);
                Console.Write("Supplier Id :");
                Console.WriteLine(list.Supplier_Id);
                Console.Write("Price :");
                Console.WriteLine(list.Price);
                Console.Write("Stock :");
                Console.WriteLine(list.Stock);
            }
            return get;

        }
        // === insert data====
        public bool Insert(TB_M_Item item)
        {
            //throw new NotImplementedException();
            string name;
            int Supplier_Id, Stock;
            decimal price;
            Console.Write("Insert Your Name :");
            name = Console.ReadLine();
            Console.Write("Insert Your Supplier Id:");
            Supplier_Id = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Your Price :");
            decimal Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Insert Your Stock:");
            Stock = Convert.ToInt16(Console.ReadLine());

            item.Name = name;
            item.Supplier_Id = Supplier_Id;
            item.Price = Price;
            item.Stock = Stock;

            myContext.TB_M_Item.Add(item);
            Validation valid = new Validation();
            return valid.Save();
            
        }

        //=====Update Data============
        public bool Update(int id, TB_M_Item item)
        {
            //  throw new NotImplementedE
            string name;
            int Supplier_Id, Stock;
            decimal price;
            Console.Write("Insert Your Id :");
            int Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Item.Find(Id);
            if (get != null)
            {
                Console.Write("Update Your Name :");
                string Name = Console.ReadLine();
                Console.Write("Update Your Supplier Id:");
                Supplier_Id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Update Your Price :");
                decimal Price = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Update Your Stock:");
                Stock = Convert.ToInt16(Console.ReadLine());
                get.Name = Name;
                get.Supplier_Id = Supplier_Id;
                get.Price = Price;
                get.Stock = Stock;
                myContext.Entry(get).State = EntityState.Modified;
                Validation valid = new Validation();
                return valid.Save();
            }
            return status;
        }
        //===========get by Id=========================
        public TB_M_Item Get(int Id)
        {
            Console.Write("Insert Your Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Item.SingleOrDefault(x => x.isDelete == false);
            {
                Console.Write("Id :");
                Console.WriteLine(get.Id);
                Console.Write("Item Name :");
                Console.WriteLine(get.Name);
                Console.Write("Supplier Id :");
                Console.WriteLine(get.TB_M_Suppliers);
                Console.Write("Price");
                Console.WriteLine(get.Price);
                Console.Write("Stock");
                Console.WriteLine(get.Stock);
            }
            return get;
        }
        //========Delete Data=====================
        public bool Delete(int id)
        {
            //throw new NotImplementedException();
            Console.Write("Insert Your Id :");
            int Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Item.Find(Id);
            if (get != null)
            {
                myContext.Entry(get).State = EntityState.Deleted;
                Validation valid = new Validation();
                return valid.Save();
            }
            return status;
        }
    }
}

