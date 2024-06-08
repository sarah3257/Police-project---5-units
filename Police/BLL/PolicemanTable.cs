using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Police.BLL
{
    public class PolicemanTable : GeneralTable
    {
        public PolicemanTable() : base("policeman")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new policeman(item));
            }
        }

        public List<policeman> GetList()
        {
            return base.list.ConvertAll(x => (policeman)x);
        }

    }
}
