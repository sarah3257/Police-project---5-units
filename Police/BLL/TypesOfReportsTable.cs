using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class TypesOfReportsTable : GeneralTable
    {
        public TypesOfReportsTable() : base("TypesOfReports")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TypesOfReports(item));
            }
        }

        public List<TypesOfReports> GetList()
        {
            return base.list.ConvertAll(x => (TypesOfReports)x);
        }
    }
}
