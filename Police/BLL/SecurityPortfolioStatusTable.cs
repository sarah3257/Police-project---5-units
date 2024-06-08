using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class SecurityPortfolioStatusTable : GeneralTable
    {
        public SecurityPortfolioStatusTable() : base("SecurityPortfolioStatus")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new SecurityPortfolioStatus(item));
            }
        }

        public List<SecurityPortfolioStatus> GetList()
        {
            return base.list.ConvertAll(x => (SecurityPortfolioStatus)x);
        }
    }
}
