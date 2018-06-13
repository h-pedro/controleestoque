using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public static class ExtensionMethods
    {
        public static Int32 Add(this DataGridViewColumnCollection lst, String columnName, String headerText, String dataPropertyName, Int32 width, Boolean visible, String format)
        {
            Int32 rs = lst.Add(columnName, headerText);
            DataGridViewColumn col = lst[lst.Count - 1];
            col.DataPropertyName = dataPropertyName;
            col.Visible = visible;
            col.Width = width;
            if (!String.IsNullOrEmpty(format))
                col.DefaultCellStyle.Format = format;
            return rs;
        }

        public static Int32 Add(this DataGridViewColumnCollection lst, String columnName, String headerText, String dataPropertyName, Int32 width, Boolean visible)
        {
            return lst.Add(columnName, headerText, dataPropertyName, width, visible, null);
        }
    }
}
