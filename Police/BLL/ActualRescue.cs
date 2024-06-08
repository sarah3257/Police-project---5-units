using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class ActualRescue : GeneralRow
    {
        public int Code { get; set; }
        public int ComplaintsCode { get; set; }
        public DateTime BeginningTime { get; set; }
        public DateTime EndTime { get; set; }
        public int RescuersTypeCode { get; set; }
        public string Remarks { get; set; }
        public bool IsTheOperationComplete { get; set; }
        public ActualRescue() : base()
        {

        }
        public ActualRescue(DataRow row) : base(row)
        {

        }
        public override void FillDataRow()
        {
            row["Code"] = this.Code;
            row["ComplaintsCode"] = this.ComplaintsCode;
            row["BeginningTime"] = this.BeginningTime;
            row["EndTime"] = this.EndTime;
            row["RescuersTypeCode"] = this.RescuersTypeCode;
            row["Remarks"] = this.Remarks;
            row["IsTheOperationComplete"] = this.IsTheOperationComplete;
        }

        public override void FillFields()
        {
            this.Code = Convert.ToInt32(row["Code"]);
            this.ComplaintsCode = Convert.ToInt32(row["ComplaintsCode"]);
            this.BeginningTime = Convert.ToDateTime(row["BeginningTime"]);
            this.EndTime = Convert.ToDateTime(row["EndTime"]);
            this.RescuersTypeCode = Convert.ToInt32(row["RescuersTypeCode"]);
            this.Remarks = row["Remarks"].ToString();
            this.IsTheOperationComplete =Convert.ToBoolean( row["IsTheOperationComplete"]);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

