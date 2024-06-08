using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class PolicemanInSafety: GeneralRow
    {
        public int Code { get; set; }
        public int SecurityCode { get; set; }
        public int PoliceCode { get; set; }

    public PolicemanInSafety() : base()
    {

    }
    public PolicemanInSafety(DataRow row) : base(row)
    {

    }
    public override void FillDataRow()
    {
        row["Code"] = this.Code;
        row["SecurityCode"] = this.SecurityCode;
        row["PoliceCode"] = this.PoliceCode;
    }

    public override void FillFields()
    {
        this.Code = Convert.ToInt32(row["Code"]);
        this.SecurityCode = Convert.ToInt32(row["SecurityCode"]);
        this.PoliceCode = Convert.ToInt32(row["PoliceCode"]);
     
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
}
