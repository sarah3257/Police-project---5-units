using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class RescuersTable : GeneralTable
    {
        public RescuersTable() : base("Rescuers")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Rescuers(item));
            }
        }

        public List<Rescuers> GetList()
        {
            return base.list.ConvertAll(x => (Rescuers)x);
        }

    }
}
