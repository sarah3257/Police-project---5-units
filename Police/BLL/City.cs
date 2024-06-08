using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public class City : GeneralRow
    {
        public int CodeCity { get; set; }
        public string NameCity { get; set; }
        public City():base()
        {

        }
        public City(DataRow row):base(row)
        {

        }
        public override void FillDataRow()
        {
            row["CodeCity"] = this.CodeCity;
            row["NameCity"] = this.NameCity;
        }

        public override void FillFields()
        {
            this.CodeCity = Convert.ToInt32(row["CodeCity"]);
            this.NameCity = row["NameCity"].ToString();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
