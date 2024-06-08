using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class PoliceSecretary: GeneralRow
    {
        public int IDPolice { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phon { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateStartOfWork { get; set; }
    public PoliceSecretary() : base()
    {

    }
    public PoliceSecretary(DataRow row) : base(row)
    {

    }
    public override void FillDataRow()
    {
        row["IDPolice"] = this.IDPolice;
        row["FirstName"] = this.FirstName;
        row["LastName"] = this.LastName;
        row["Phon"] = this.Phon;
        row["DateOfBirth"] = this.DateOfBirth;
        row["DateStartOfWork"] = this.DateStartOfWork;
    }

    public override void FillFields()
    {
        this.IDPolice = Convert.ToInt32(row["IDPolice"]);
        this.FirstName = row["FirstName"].ToString();
        this.LastName = row["LastName"].ToString();
        this.Phon = row["Phon"].ToString();
            this.DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
            this.DateStartOfWork = Convert.ToDateTime(row["DateStartOfWork"]);

        }
        public override string ToString()
    {
        return base.ToString();
    }
}
}
