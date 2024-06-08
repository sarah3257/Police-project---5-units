using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class PeopleAreHurtingTable : GeneralTable
    {
        public PeopleAreHurtingTable() : base("PeopleAreHurting")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new PeopleAreHurting(item));
            }
        }

        public List<PeopleAreHurting> GetList()
        {
            return base.list.ConvertAll(x => (PeopleAreHurting)x);
        }

    }
}
