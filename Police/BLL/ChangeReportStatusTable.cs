using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class ChangeReportStatusTable : GeneralTable
    {
        public ChangeReportStatusTable() : base("ChangeReportStatus")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ChangeReportStatus(item));
            }
        }

        public List<ChangeReportStatus> GetList()
        {
            return base.list.ConvertAll(x => (ChangeReportStatus)x);
        }
    }
}
   

