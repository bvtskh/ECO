using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.Interface
{
    public interface IECO_PURCHASE
    {
        bool InsertData(ECO_ControlSheet ECO_controlSheet);
        bool InsertData(List<ECO_ControlSheet> controlSheetList);
        List<ECO_ControlSheet> GetECNDataList(string eCNText);
        List<string> GetModelNameIsBOMExist();
        List<ECO_ControlSheet> GetECNPending();
        List<ECO_ControlSheet> GetECNlist();
        string GetModelNameByID(int id);
        string GetLocationByID(int id);
        ECO_ControlSheet GetECOcontrolSheetByID(int? id);
        List<ECO_ControlSheet> GetDataExist(string ecn, string eco, string model, string newpart);
        List<ECO_ControlSheet> GetDataByListString(List<string> ecnResult, DateTime datefrom, DateTime dateTo);
        List<string> GetModelNameNOTBOM();
        bool UpdateDataECOControlSheet(ECO_ControlSheet update);
        ECO_ControlSheet GetLastControlSheetUpdate();
        void InsertHistoryUpdateControlSheet(int id);
        bool RemoveControlsheetData(int id);
        bool IsExistedECN(string Eco);
        bool InsertControlsheetNewUpdate(List<ECO_ControlSheet> controlSheetList);
        DataTable GetDuplicateECO(DateTime datefrom, DateTime dateTo);
        IEnumerable<ECO_ControlSheet> GetDataIssueToPur(DateTime datefrom, DateTime dateTo);
        DataTable GetDataControlSheet(IEnumerable<ECO_ControlSheet> dataIssueToPur, int value);
        DataTable GetDataECOcontrolsheetSearch(int selectedIndex, string searchString);
        DataTable GetDataControlSheet(int record, DateTime datefrom, DateTime dateTo);
        List<ECO_ControlSheet> GetAllControlSheetData();
        List<Purchase_Action> GetDataPurchaseAction(DateTime datefrom, DateTime dateTo);
    }
}
