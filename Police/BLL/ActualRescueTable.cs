using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class ActualRescueTable : GeneralTable
    {
        public ActualRescueTable() : base("ActualRescue")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ActualRescue(item));
            }
        }

        public List<ActualRescue> GetList()
        {
            return base.list.ConvertAll(x => (ActualRescue)x);
        }
    }
}
    

