using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class TypesOfPoliceTable : GeneralTable
    {
        public TypesOfPoliceTable() : base(" TypesOfPolice")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TypesOfPolice(item));
            }
        }

        public List<TypesOfPolice> GetList()
        {
            return base.list.ConvertAll(x => (TypesOfPolice)x);
        }
    }
}
