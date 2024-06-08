using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class Rescuers :GeneralRow
    {
        public int Code { get; set; }
        public int RescuerCode { get; set; }
        public int PoliceCode { get; set; }
    public Rescuers() : base()
    {

    }
    public Rescuers(DataRow row) : base(row)
    {

    }
    public override void FillDataRow()
    {
        row["Code"] = this.Code;
        row["RescuerCode"] = this.RescuerCode;
        row["PoliceCode"] = this.PoliceCode;
    }

    public override void FillFields()
    {
        this.Code = Convert.ToInt32(row["Code"]);
        this.RescuerCode = Convert.ToInt32(row["RescuerCode"]);
        this.PoliceCode = Convert.ToInt32(row["PoliceCode"]);
      
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
}
