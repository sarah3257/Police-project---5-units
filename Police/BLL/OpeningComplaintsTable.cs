using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class OpeningComplaintsTable : GeneralTable
    {
        public OpeningComplaintsTable() : base("OpeningComplaints")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new OpeningComplaints(item));
            }
        }

        public List<OpeningComplaints> GetList()
        {
            return base.list.ConvertAll(x => (OpeningComplaints)x);
            {
            }
        }
    }
}