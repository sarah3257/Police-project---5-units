using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class PoliceSecretaryTable : GeneralTable
    {
        public PoliceSecretaryTable() : base("PoliceSecretary")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new PoliceSecretary(item));
            }
        }

        public List<PoliceSecretary> GetList()
        {
            return base.list.ConvertAll(x => (PoliceSecretary)x);
        }

    }
}