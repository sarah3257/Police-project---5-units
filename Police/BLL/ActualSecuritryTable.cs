using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class ActualSecuritryTable : GeneralTable
    {
        public ActualSecuritryTable() : base("ActualSecuritry")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ActualSecuritry(item));
            }
        }

        public List<ActualSecuritry> GetList()
        {
            return base.list.ConvertAll(x => (ActualSecuritry)x);
        }
    }
}

