using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class TypesOfSecurity: GeneralRow
    {
        public int Code { get; set; }
    public string NameCity { get; set; }
    public TypesOfSecurity() : base()
    {

    }
    public TypesOfSecurity(DataRow row) : base(row)
    {

    }
    public override void FillDataRow()
    {
        row["Code"] = this.Code;
        row["Name"] = this.NameCity;
    }

    public override void FillFields()
    {
        this.Code = Convert.ToInt32(row["Code"]);
        this.NameCity = row["Name"].ToString();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
}
