using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class PolicemanInSafetyTable : GeneralTable
    {
        public PolicemanInSafetyTable() : base("PolicemanInSafety")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new PolicemanInSafety(item));
            }
        }

        public List<PolicemanInSafety> GetList()
        {
            return base.list.ConvertAll(x => (PolicemanInSafety)x);
        }

    }
}
