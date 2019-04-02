using Bootcamp_OOP_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    public interface Interface_sell
    {
        List<TB_M_Sell> Get();
        TB_M_Sell get(int id);
        bool Insert(TB_M_Sell sell);
        bool Update(int id, TB_M_Sell sell);
        bool Delete(int id);
    }
}
