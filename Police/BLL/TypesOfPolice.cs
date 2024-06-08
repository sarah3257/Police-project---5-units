using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
   public class TypesOfPolice :GeneralRow
    {
        public int TypeCode { get; set; }
    public string TypeName { get; set; }
    public TypesOfPolice() : base()
    {

    }
    public TypesOfPolice(DataRow row) : base(row)
    {

    }
    public override void FillDataRow()
    {
        row["TypeCode"] = this.TypeCode;
        row["TypeName"] = this.TypeName;
    }

    public override void FillFields()
    {
        this.TypeCode = Convert.ToInt32(row["TypeCode"]);
        this.TypeName = row["TypeName"].ToString();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
}
