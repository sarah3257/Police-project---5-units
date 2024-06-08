using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class TypesOfRescue: GeneralRow
    {
        public int Code { get; set; }
    public string Name { get; set; }
    public TypesOfRescue() : base()
    {

    }
    public TypesOfRescue(DataRow row) : base(row)
    {

    }
    public override void FillDataRow()
    {
        row["Code"] = this.Code;
        row["Name"] = this.Name;
    }

    public override void FillFields()
    {
        this.Code = Convert.ToInt32(row["Code"]);
        this.Name = row["Name"].ToString();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
}
