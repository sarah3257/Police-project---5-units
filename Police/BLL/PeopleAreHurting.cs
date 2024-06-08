using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class PeopleAreHurting: GeneralRow
    {
        public int Code { get; set; }
        public int ActualSecurityCode { get; set; }
    public string IDMen { get; set; }
        public int PortfolioStatus { get; set; }
       
        public PeopleAreHurting() : base()
    {

    }
    public PeopleAreHurting(DataRow row) : base(row)
    {

    }
    public override void FillDataRow()
    {
        row["Code"] = this.Code;
        row["ActualSecurityCode"] = this.ActualSecurityCode;
            row["IDMen"] = this.IDMen;
            row["PortfolioStatus"] = this.PortfolioStatus;

        }

    public override void FillFields()
    {
        this.Code = Convert.ToInt32(row["Code"]);
        this.ActualSecurityCode = Convert.ToInt32(row["ActualSecurityCode"]);
        this.IDMen = row["IDMen"].ToString();
        this.PortfolioStatus = Convert.ToInt32(row["PortfolioStatus"]);
          
        }
    public override string ToString()
    {
        return base.ToString();
    }
}
}
