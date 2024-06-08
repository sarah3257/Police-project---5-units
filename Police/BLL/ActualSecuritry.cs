using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
     public class ActualSecuritry : GeneralRow
    {
        public int Code { get; set; }
        public int ComplaintCode { get; set; }
        public int Securitytypecode { get; set; }
        public DateTime BeginningtTme { get; set; }
        public DateTime EndTime { get; set; }
        public string Remarks { get; set; }
        public bool IsFinished { get; set; }
        public ActualSecuritry() : base()
        {

        }
        public ActualSecuritry(DataRow row) : base(row)
        {

        }
        public override void FillDataRow()
        {
            row["Code"] = this.Code;
            row["ComplaintCode"] = this.ComplaintCode;
            row["Securitytypecode"] = this.Securitytypecode;
            row["BeginningtTme"] = this.BeginningtTme;
            row["EndTime"] = this.EndTime;
            row["Remarks"] = this.Remarks;
            row["IsFinished"] = this.IsFinished;
        }

        public override void FillFields()
        {
            this.Code = Convert.ToInt32(row["Code"]);
            this.ComplaintCode=Convert.ToInt32 (row["ComplaintCode"]);
            this.Securitytypecode= Convert.ToInt32(row["Securitytypecode"]);
            this.BeginningtTme= Convert.ToDateTime(row["BeginningtTme"]);
            this.EndTime = Convert.ToDateTime(row["EndTime"]);
            this.Remarks = row["Remarks"].ToString();
            this.IsFinished = Convert.ToBoolean(row["IsFinished"]);

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

