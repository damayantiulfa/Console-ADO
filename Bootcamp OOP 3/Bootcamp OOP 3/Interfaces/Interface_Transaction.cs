using Bootcamp_OOP_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    public interface Interface_Transaction
    {
        List<TB_T_Transactions> Get();
        TB_T_Transactions get(int id);
        bool Insert(TB_T_Transactions transaction);
        bool Update(int id, TB_T_Transactions transaction);
        bool Delete(int id);
    }
}
