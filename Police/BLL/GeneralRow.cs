using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Police.BLL
{

        public abstract class GeneralRow
        {
            public DataRow row;
            public GeneralRow()
            {

            }
            public GeneralRow(DataRow row)
            {
                this.row = row;
                FillFields();
            }
            public abstract void FillFields();
            public abstract void FillDataRow();

        }
}
