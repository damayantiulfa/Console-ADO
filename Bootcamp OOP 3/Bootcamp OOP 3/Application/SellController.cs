using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp_OOP_3.Models;
using System.Data.Entity;

namespace Bootcamp_OOP_3
{
    public class SellController : Interface_sell
    {
        private myContext myContext = new myContext();
        bool status = false;
  
        // === view all data=====
        public List<TB_M_Sell> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Sell.ToList();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\t Data Sell");
            Console.WriteLine("-----------------------------");
            foreach (var list in get)
            {
                Console.Write("Id :");
                Console.WriteLine(list.Id);
                Console.Write("OrderDate :");
                Console.WriteLine(list.OrderDate);

                Console.WriteLine("");
            }
            return get;
        }

        //===InsertData=======
        public bool Insert (TB_M_Sell sell)
        {
            //throw new NotImplementedException();
            
            DateTime OrderDate = DateTime.Now;
            Console.Write("Insert Your OrderDate:");
            OrderDate = Convert.ToDateTime(Console.ReadLine());

            sell.OrderDate = OrderDate;

            myContext.TB_M_Sell.Add(sell);
            Validation valid = new Validation();
            return valid.Save();
            
    }

        //==Update Data====
        public bool Update(int id, TB_M_Sell sell)
        {
        // throw new NotImplementedException();
        int Id;
        DateTime OrderDate;
        Console.Write("Insert Your Id :");
        Id = Convert.ToInt16(Console.ReadLine());
        var get = myContext.TB_M_Sell.Find(Id);
        if (get != null)
        {
            Console.Write("Update Your OrderDate :");
            OrderDate = Convert.ToDateTime(Console.ReadLine());
            get.Id = Id;
            get.OrderDate = OrderDate;
            myContext.Entry(get).State = EntityState.Modified;
            Validation valid = new Validation();
            return valid.Save();
        }
        return status;
    }
        //====Delete Data=====
        public bool Delete(int id)
        {
        //throw new NotImplementedException();
        Console.Write("Insert Your Id :");
        int Id = Convert.ToInt16(Console.ReadLine());
        var get = myContext.TB_M_Sell.Find(Id);
        if (get != null)
        {
            myContext.Entry(get).State = EntityState.Deleted;
            //var result = myContext.SaveChanges();
            Validation valid = new Validation();
            return valid.Save();
        }
        return status;
    }
      
        //=== Get By Id===========
        public TB_M_Sell get(int id)
        {
            // throw new NotImplementedException();
            Console.Write("Insert Your Id : ");
            id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Sell.SingleOrDefault();
            {
                Console.Write("Id :");
                Console.WriteLine(get.Id);
               // Console.Write("OrderDate :");
                //Console.WriteLine(get.OrderDate);
 
            }
            return get;
        }
    }


        }
    

