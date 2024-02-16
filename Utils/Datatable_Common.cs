using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.Utils
{
    public class Datatable_Common
    {
        public static DataTable CreateColumnFinishAction()
        {                      
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Thời gian thực hiện");
            dataTable.Columns.Add("Ngày phát hành");
            dataTable.Columns.Add("ECN");
            dataTable.Columns.Add("ECO No");
            dataTable.Columns.Add("Model");
            dataTable.Columns.Add("Current part");
            dataTable.Columns.Add("New part");
            dataTable.Columns.Add("Current price");
            dataTable.Columns.Add("New price");
            dataTable.Columns.Add("different");
            dataTable.Columns.Add("Current Vendor");
            dataTable.Columns.Add("New Vendor");
            dataTable.Columns.Add("Location");
            dataTable.Columns.Add("ECO content");
            dataTable.Columns.Add("Situation");
            dataTable.Columns.Add("TVP No");
            dataTable.Columns.Add("TVP result");
            dataTable.Columns.Add("Reason");
            dataTable.Columns.Add("ETA UMCVN");
            dataTable.Columns.Add("Est using new part date");
            dataTable.Columns.Add("Transfered ECO date");
            dataTable.Columns.Add("Purpose Transferd ECO");
            dataTable.Columns.Add("Received ECO date");
            dataTable.Columns.Add("1st delivery");
            dataTable.Columns.Add("Action");
            return dataTable;
        }
    }
}
