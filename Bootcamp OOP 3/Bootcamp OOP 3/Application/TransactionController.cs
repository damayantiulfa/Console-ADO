using Bootcamp_OOP_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    public class TransactionController : Interface_Transaction
    {
        private myContext myContext = new myContext();
        bool status = false;

        //TB_M_Item item = new TB_M_Item();
        //TB_M_Sell sell = new TB_M_Sell();

      
        public List<TB_T_Transactions> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_T_Transactions.ToList();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\t Data Transaction");
            Console.WriteLine("-----------------------------");
            foreach (var list in get)
            {
                Console.Write("Id :");
                Console.WriteLine(list.Id);
                Console.Write("Quantity :");
                Console.WriteLine(list.Quantity);
                Console.Write("Item Id :");
                Console.WriteLine(list.TB_M_Item);
                Console.Write("Sell Id :");
                Console.WriteLine(list.TB_M_Sell);
                Console.WriteLine("");
            }
            return get;

        }
       

            //== insert data===
        public bool Insert(TB_T_Transactions transaction)
        {
            // throw new NotImplementedException();
            int quantity, Item_id, Sell_id;
            Console.Write("Quantity :");
            quantity = Convert.ToInt16(Console.ReadLine());
            Console.Write("Item Id :");
            Item_id = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sell Id :");
            Sell_id = Convert.ToInt16(Console.ReadLine());


            transaction.Quantity = quantity;
            transaction.TB_M_Item = Item_id;
            transaction.TB_M_Sell = Sell_id;

            myContext.TB_T_Transactions.Add(transaction);
            Validation valid = new Validation();
            return valid.Save();
           
        }

    }

        public bool Update(int id, TB_T_Transactions transaction)
        {
        //throw new NotImplementedException();

        int Quantity, Item_id, Sell_id;
        Console.Write("Insert Your Id :");
        int Id = Convert.ToInt16(Console.ReadLine());
        var get = myContext.TB_T_Transactions.Find(Id);
        if (get != null)
        {
            Console.Write("Update Quantity :");
            Quantity = Convert.ToInt16(Console.ReadLine());
            Console.Write("Update Your Item Id:");
            Item_id = Convert.ToInt16(Console.ReadLine());
            Console.Write("Update Your Sell Id :");
            Sell_id = Convert.ToInt16(Console.ReadLine());

            get.Quantity = Quantity;
            get.TB_M_Item = Item_id;
            get.TB_M_Sell = Sell_id;

            myContext.Entry(get).State = EntityState.Modified;
            Validation valid = new Validation();
            return valid.Save();
        }
        return status;

    }
        public bool Delete(TB_T_Transactions id)
        {
            throw new NotImplementedException();
        }

    }
}
