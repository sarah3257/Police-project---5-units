using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class OpeningComplaints : GeneralRow
    {
        public int Code { get; set; }
        public int Secretarycode { get; set; }
        public DateTime dateComplaints { get; set; }
        public DateTime hourComplaints { get; set; }
        public string Street { get; set; }
        public int City { get; set; }
        public int HouseNumber { get; set; }
        public bool IsInSecurity { get; set; }
        public bool IsRescue { get; set; }
        public int IdMen { get; set; }
        public OpeningComplaints() : base()
        {

        }
        public OpeningComplaints(DataRow row) : base(row)
        {

        }
        public override void FillDataRow()
        {
            row["Code"] = this.Code;
            row["Secretarycode"] = this.Secretarycode;
            row["dateComplaints"] = this.dateComplaints;
            row["hourComplaints"] = this.hourComplaints;
            row["Street"] = this.Street;
            row["City"] = this.City;
            row["HouseNumber"] = this.HouseNumber;
            row["IsInSecurity"] = this.IsInSecurity;
            row["IsRescue"] = this.IsRescue;
            row["IdMen"] = this.IdMen;
        }

        public override void FillFields()
        {
            this.Code = Convert.ToInt32(row["Code"]);
            this.Secretarycode = Convert.ToInt32(row["Secretarycode"]);
            this.dateComplaints = Convert.ToDateTime(row["dateComplaints"]);
            this.hourComplaints = Convert.ToDateTime(row["hourComplaints"]);
            this.Street = row["Street"].ToString();
            this.City = Convert.ToInt32(row["City"]);
            this.HouseNumber = Convert.ToInt32(row["HouseNumber"]);
            this.IdMen = Convert.ToInt32(row["IdMen"]);
            this.IsInSecurity = Convert.ToBoolean(row["IsInSecurity"]);
            this.IsRescue = Convert.ToBoolean(row["IsRescue"]);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

