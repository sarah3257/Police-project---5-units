using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class policeman : GeneralRow
    {
        public int IDPolice { get; set; }
        public string FirsName { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TypeOfPolice { get; set; }
        public DateTime StartDate { get; set; }
        public int AccumulationPoints { get; set; }
        public policeman() : base()
        {

        }
        public policeman(DataRow row) : base(row)
        {

        }
        public override void FillDataRow()
        {
            row["IDPolice"] = this.IDPolice;
            row["FirsName"] = this.FirsName;
            row["FamilyName"] = this.FamilyName;
            row["PhoneNumber"] = this.PhoneNumber;
            row["DateOfBirth"] = this.DateOfBirth;
            row["TypeOfPolice"] = this.TypeOfPolice;
            row["StartDate"] = this.StartDate;
            row["AccumulationPoints"] = this.AccumulationPoints;
        }

        public override void FillFields()
        {
            this.IDPolice = Convert.ToInt32(row["IDPolice"]);
            this.FirsName = row["FirsName"].ToString();
            this.FamilyName = row["FamilyName"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
            this.TypeOfPolice = Convert.ToInt32(row["TypeOfPolice"]);
            this.StartDate = Convert.ToDateTime(row["StartDate"]);
            this.AccumulationPoints = Convert.ToInt32(row["AccumulationPoints"]);
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}