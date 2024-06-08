using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class CitiesTable : GeneralTable
    {
        public CitiesTable() : base("Cities")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new City(item));
            }
        }

        public List<City> GetList()
        {
            return base.list.ConvertAll(x => (City)x);
        }
    }
}
