using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class TypesOfSecurityTable : GeneralTable
    {
        public TypesOfSecurityTable() : base(" TypesOfSecurity")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TypesOfSecurity(item));
            }
        }

        public List<TypesOfSecurity> GetList()
        {
            return base.list.ConvertAll(x => (TypesOfSecurity)x);
        }
    }
}
