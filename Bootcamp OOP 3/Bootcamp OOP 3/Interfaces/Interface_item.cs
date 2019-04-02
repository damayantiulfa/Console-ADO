using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_OOP_3
{
    public interface Interface_item
    {

        List<TB_M_Item> Get();
        TB_M_Item Get(int Id);
        bool Insert (TB_M_Item item);
        bool Update (int id, TB_M_Item  item);
        bool Delete (int id );
    }
}
