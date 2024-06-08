using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class MenTable : GeneralTable
    {
        public MenTable() : base("Men")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Man(item));
            }
        }

        public List<Man> GetList()
        {
            return base.list.ConvertAll(x => (Man)x);
        }
    }
}


