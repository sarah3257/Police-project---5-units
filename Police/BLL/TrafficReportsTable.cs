using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class TrafficReportsTable : GeneralTable
    {
        public TrafficReportsTable() : base(" TrafficReports")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TrafficReports(item));
            }
        }

        public List<TrafficReports> GetList()
        {
            return base.list.ConvertAll(x => (TrafficReports)x);
        }

    }
}
