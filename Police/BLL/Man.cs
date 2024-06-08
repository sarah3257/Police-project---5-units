using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class Man : GeneralRow
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Man() : base()
        {

        }
        public Man(DataRow row) : base(row)
        {

        }
        public override void FillDataRow()
        {
            row["Id"] = this.Id;
            row["FirstName"] = this.FirstName;
            row["LastName"] = this.LastName;
            row["PhoneNumber"] = this.PhoneNumber;
            row["Address"] = this.Address;
        }

        public override void FillFields()
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.FirstName = row["FirstName"].ToString();
            this.LastName = row["LastName"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.Address = row["Address"].ToString();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
