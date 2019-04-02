using Bootcamp_OOP_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    class Program
    {


        static void Main(string[] args)
        {
            Interface_supplier interface_supplier = new SupplierController();
            TB_M_Suppliers supplier = new TB_M_Suppliers();

            Interface_item interface_item = new TB_M_ItemController();
            TB_M_Item item = new TB_M_Item();

            Interface_sell interface_sell = new SellController();
            TB_M_Sell sell = new TB_M_Sell();

            Interface_Transaction interface_transaction = new TransactionController();
            TB_T_Transactions transaction = new TB_T_Transactions();
            int id = 0;

            Console.WriteLine("\t Pilihan Menu");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Menu Supplier");
            Console.WriteLine("2. Menu Item");
            Console.WriteLine("3. Menu Sell");
            Console.WriteLine("4  Menu Transaction");
            Console.WriteLine("=====================================");
            Console.WriteLine("Tentukan Pilihanmu :");
            int numbermenu = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\t Action            ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. View All Data");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4  Delete");
            Console.WriteLine("=====================================");
            Console.WriteLine("Tentukan Pilihanmu :");

            int numberitem = Convert.ToInt16(Console.ReadLine());
            if (numbermenu == 1)
            {
                switch (numberitem)
                {
                    case 1:
                        interface_supplier.Get();
                        break;
                    case 2:
                        interface_supplier.Insert(supplier);
                        break;
                    case 3:
                        interface_supplier.Update(id, supplier);
                        break;
                    case 4:
                        interface_supplier.DeleteSupplier(id);
                        break;

                }

            }
            else if (numbermenu == 2)
            {
                switch (numberitem)
                {
                    case 1:
                        interface_item.Get();
                        break;
                    case 2:
                        interface_item.Insert(item);
                        break;
                    case 3:
                        interface_item.Update(id, item);
                        break;
                    case 4:
                        interface_item.Delete(id);
                        break;

                }
            }

            else if (numbermenu == 3)
            {
                switch (numberitem)
                {
                    case 1:
                        interface_sell.Get();
                        break;
                    case 2:
                        interface_sell.Insert(sell);
                        break;
                    case 3:
                        interface_sell.Update(id, sell);
                        break;
                    case 4:
                        interface_sell.Delete(id);
                        break;

                }
            }
            else if (numbermenu == 4)
            {
                switch (numberitem)
                {
                    case 1:
                        interface_transaction.Get();
                        break;
                    case 2:
                        interface_transaction.Insert(transaction);
                        break;
                    case 3:
                        interface_transaction.Update(id, transaction);
                        break;
                    case 4:
                        interface_transaction.Delete(id);
                        break;

                }
            }
            else
            {
                Console.WriteLine("Data Not Found");
            }
                Console.Read();
        }
    }
}

