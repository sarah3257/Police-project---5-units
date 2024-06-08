using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class ChangeReportStatus : GeneralRow
    {
        public int Code { get; set; }
        public int ReportCode { get; set; }
        public DateTime ChDate { get; set; }
        public int StatusCode { get; set; }
        #region
        
        #endregion
        public ChangeReportStatus() : base()
        {

        }
        public ChangeReportStatus(DataRow row) : base(row)
        {

        }
        public override void FillDataRow()
        {
            row["Code"] = this.Code;
            row["ReportCode"] = this.ReportCode;
            row["ChDate"] = this.ChDate;
            row["StatusCode"] = this.StatusCode;
        }

        public override void FillFields()
        {
            this.Code = Convert.ToInt32(row["Code"]);
            this.ReportCode = Convert.ToInt32(row["ReportCode"]);
            this.ChDate = Convert.ToDateTime(row["ChDate"]);
            this.StatusCode = Convert.ToInt32(row["StatusCode"]);
         
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

