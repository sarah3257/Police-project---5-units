using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class TypesOfRescueTable : GeneralTable
    {
        public TypesOfRescueTable() : base("TypesOfRescue")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TypesOfRescue(item));
            }
        }

        public List<TypesOfRescue> GetList()
        {
            return base.list.ConvertAll(x => (TypesOfRescue)x);
        }
    }
}
