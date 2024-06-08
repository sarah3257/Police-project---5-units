using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class TrafficReports: GeneralRow
    {
        public int Code { get; set; }
        public int PoliceCode { get; set; }
        public DateTime dateReport { get; set; }
        public int ReportTypesCode { get; set; }
        #region
     
        #endregion
        public int City { get; set; }
    public string Street { get; set; }
        public int IdMen { get; set; }
        public int Price { get; set; }

    public TrafficReports() : base()
    {

    }
    public TrafficReports(DataRow row) : base(row)
    {

    }
    public override void FillDataRow()
    {
        row["Code"] = this.Code;
        row["PoliceCode"] = this.PoliceCode;
        row["dateReport"] = this.dateReport;
        row["ReportTypesCode"] = this.ReportTypesCode;
        row["City"] = this.City;
        row["Street"] = this.Street;
        row["IdMen"] = this.IdMen;
        row["Price"] = this.Price;
    }

    public override void FillFields()
    {
        this.Code = Convert.ToInt32(row["Code"]);
        this.PoliceCode = Convert.ToInt32(row["PoliceCode"]);
        this.dateReport = Convert.ToDateTime(row["dateReport"]);
        this.ReportTypesCode = Convert.ToInt32(row["ReportTypesCode"]);
        this.City = Convert.ToInt32(row["City"]);
        this.Street = row["Street"].ToString();
            this.IdMen = Convert.ToInt32(row["IdMen"]);
            this.Price = Convert.ToInt32(row["Price"]);
        }
    public override string ToString()
    {
        return base.ToString();
    }
}
}
