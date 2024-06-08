using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class ReportListStatusTable : GeneralTable
    {
        public ReportListStatusTable() : base("ReportListStatus")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ReportListStatus(item));
            }
        }

        public List<ReportListStatus> GetList()
        {
            return base.list.ConvertAll(x => (ReportListStatus)x);
        }

    }
}
