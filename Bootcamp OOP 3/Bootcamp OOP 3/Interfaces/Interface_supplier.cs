using Bootcamp_OOP_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    public interface Interface_supplier
    {
        List<TB_M_Suppliers> Get();
        TB_M_Suppliers Get(int id);
        bool Insert(TB_M_Suppliers supplier);
        bool Update(int id, TB_M_Suppliers supplier);
        bool DeleteSupplier(int id);
    }
}

