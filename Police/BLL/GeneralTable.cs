﻿using Police.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    public abstract class GeneralTable
    {
        public static Connect connect = new Connect();
        protected DataTable table;
        protected List<GeneralRow> list;

        public GeneralTable(string NameTable)
        {
            table = connect.GetTable(NameTable);
            list = new List<GeneralRow>();
        }

        public void AddItem(GeneralRow item)
        {
            list.Add(item);
            item.row = table.NewRow();
            item.FillDataRow();
            table.Rows.Add(item.row);
        }

        public void UpdateItem(GeneralRow item)
        {
            item.FillDataRow();
        }

        public void SaveChanges()
        {
            connect.UpdateTable(this.table.TableName);
        }
        public void DeleteItem(GeneralRow item)
        {
            item.row.Delete();
            list.Remove(item);
        }



    }
}
