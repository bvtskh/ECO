using ECO_DX_For_PUR.DATA.Bussiness.EnumDefine;
using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.SQLHelper
{
    public class ECO_Helper : IECO_PURCHASE
    {
        DBContext _context = new DBContext();

        public List<ECO_ControlSheet> GetDataByListString(List<string> ecnResult, DateTime datefrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }

        public List<ECO_ControlSheet> GetDataExist(string ecn, string eco, string model, string newpart)
        {
            throw new NotImplementedException();
        }

        public DataTable GetDuplicateECO(DateTime datefrom, DateTime dateTo)
        {
            DataTable dataTable;
            var dataDuplicate = _context.ECO_ControlSheet
                .Where(e => e.ECO_No != null && e.ECN_ReceiveDate >= datefrom && e.ECN_ReceiveDate <= dateTo)
                .GroupBy(g => g.ECO_No)
                    .Where(w => w.Count() > 1).SelectMany(group => group).OrderByDescending(o => o.ECN_ReceiveDate).ToList().AsQueryable();
            return dataTable = ToDataTable(dataDuplicate);
        }
        static DataTable ToDataTable<T>(IEnumerable<T> query)
        {
            DataTable dataTable = new DataTable();

            // Create columns based on the entity properties
            foreach (var property in typeof(T).GetProperties())
            {
                dataTable.Columns.Add(property.Name);
            }

            // Populate the DataTable with data from the query
            foreach (var item in query)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(T).GetProperties())
                {
                    if (item is ECO_ControlSheet)
                    {
                        var controlSheet = item as ECO_ControlSheet;
                        string date = ConvertDate(controlSheet.ECN_ReceiveDate);
                        if (property.Name == "ECN_ReceiveDate")
                        {
                            row[property.Name] = date;
                        }
                        else
                        {
                            row[property.Name] = property.GetValue(item);
                        }
                    }
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
        private static string ConvertDate(DateTime? eCN_ReceiveDate)
        {
            DateTime result;
            if (eCN_ReceiveDate != null)
            {
                if (DateTime.TryParse(eCN_ReceiveDate.ToString(), out result))
                {
                    return result.Date.ToString("MM/dd/yyyy");
                }
            }
            return null;
        }
        public List<ECO_ControlSheet> GetECNDataList(string eCNText)
        {
            throw new NotImplementedException();
        }

        public List<ECO_ControlSheet> GetECNlist()
        {
            throw new NotImplementedException();
        }

        public List<ECO_ControlSheet> GetECNPending()
        {
            return _context.ECO_ControlSheet
                    .Where(t2 => !_context.Purchase_Action.Any(t1 => t1.ECN == t2.ECN_ERI_No))
                    .Select(t2 => t2)
                    .ToList();
        }

        public ECO_ControlSheet GetECOcontrolSheetByID(int? id)
        {
            using(var context = new DBContext())
            {
                return _context.ECO_ControlSheet.AsNoTracking().Where(w => w.Id == id).FirstOrDefault();
            }
        }

        public ECO_ControlSheet GetLastControlSheetUpdate()
        {
            var id = _context.HistoryUpdateControlSheets.OrderByDescending(o => o.Id).First().Last_Update_Id;
            return _context.ECO_ControlSheet.Where(w => w.Id == id).FirstOrDefault();
        }

        public string GetLocationByID(int id)
        {
            throw new NotImplementedException();
        }

        public string GetModelNameByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetModelNameIsBOMExist()
        {
            throw new NotImplementedException();
        }

        public List<string> GetModelNameNOTBOM()
        {
            throw new NotImplementedException();
        }

        public bool InsertControlsheetNewUpdate(List<ECO_ControlSheet> controlSheetList)
        {
            try
            {
                _context.ECO_ControlSheet.AddRange(controlSheetList);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool InsertData(ECO_ControlSheet ECO_controlSheet)
        {
            throw new NotImplementedException();
        }

        public bool InsertData(List<ECO_ControlSheet> controlSheetList)
        {
            try
            {
                _context.ECO_ControlSheet.AddRange(controlSheetList);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public void InsertHistoryUpdateControlSheet(int id)
        {
            try
            {
                HistoryUpdateControlSheet history = new HistoryUpdateControlSheet();
                history.Last_Update_Id = id;
                history.UpdateTime = DateTime.Now;
                _context.HistoryUpdateControlSheets.Add(history);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExistedECN(string Eco)
        {
            if (Eco != null)
            {
                var result = _context.ECO_ControlSheet.Where(w => w.ECO_No.Trim() == Eco.Trim()).FirstOrDefault();
                if (result != null)
                    return true;
            }
            return false;
        }

        public bool RemoveControlsheetData(int id)
        {
            try
            {
                var controlSheet = _context.ECO_ControlSheet.Where(w => w.Id == id).FirstOrDefault();
                if (controlSheet != null)
                {
                    _context.ECO_ControlSheet.Remove(controlSheet);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool UpdateDataECOControlSheet(ECO_ControlSheet update)
        {
            try
            {
                var allDataECOcontrolsheet = _context.Database.SqlQuery<ECO_ControlSheet>("exec GetAllDataECOControlSheet").ToList();
                ECO_ControlSheet updateControlSheet = allDataECOcontrolsheet.Where(w => w.Id == update.Id).FirstOrDefault();
                updateControlSheet = update;
                _context.Set<ECO_ControlSheet>().AddOrUpdate(updateControlSheet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex )
            {
                return false;
                throw ex;
            }
        }

        public IEnumerable<ECO_ControlSheet> GetDataIssueToPur(DateTime datefrom, DateTime dateTo)
        {
            var allData = GetAllControlSheetData();
            return allData.Where(w => w.ECN_ReceiveDate >= datefrom && w.ECN_ReceiveDate <= dateTo).OrderByDescending(o => o.ECN_ReceiveDate).Where(w => w.Issue_To.ToLower().Trim() == "pur").Select(e => e);
        }

        public DataTable GetDataControlSheet(IEnumerable<ECO_ControlSheet> dataIssueToPur, int value)
        {
            DataTable dataTable = ToDataTable(dataIssueToPur.Take(value));
            return dataTable;
        }

        public DataTable GetDataECOcontrolsheetSearch(int selectedIndex, string searchString)
        {
            DataTable dataTable;
            if (selectedIndex == (int)PE_DM_Enum.SelectType.ECN)
            {
                var query = _context.ECO_ControlSheet.OrderByDescending(o => o.ECN_ReceiveDate).Where(w => w.ECN_ERI_No.Contains(searchString)).ToList().AsQueryable();
                return dataTable = ToDataTable(query);
            }
            else if (selectedIndex == (int)PE_DM_Enum.SelectType.ECO)
            {
                return dataTable = ToDataTable(_context.ECO_ControlSheet.OrderByDescending(o => o.ECN_ReceiveDate).Where(w => w.ECO_No.Contains(searchString)).ToList().AsQueryable());
            }
            else if (selectedIndex == (int)PE_DM_Enum.SelectType.Model)
            {
                return dataTable = ToDataTable(_context.ECO_ControlSheet.OrderByDescending(o => o.ECN_ReceiveDate).Where(w => w.ModelName.Contains(searchString)).ToList().AsQueryable());
            }
            else if (selectedIndex == (int)PE_DM_Enum.SelectType.NO)
            {
                return dataTable = ToDataTable(_context.ECO_ControlSheet.OrderByDescending(o => o.ECN_ReceiveDate).Where(w => w.No.ToString().Contains(searchString)).ToList().AsQueryable());
            }

            return null;
        }

        public DataTable GetDataControlSheet(int record, DateTime datefrom, DateTime dateTo)
        {
            var query = GetAllControlSheetData().Where(w => w.ECN_ReceiveDate >= datefrom && w.ECN_ReceiveDate <= dateTo).OrderByDescending(o => o.ECN_ReceiveDate).Take(record).Select(e => e);
            DataTable dataTable = ToDataTable(query);
            return dataTable;
        }

        public List<ECO_ControlSheet> GetAllControlSheetData()
        {
            return _context.Database.SqlQuery<ECO_ControlSheet>("exec GetAllDataECOControlSheet").ToList();
        }

        public List<Purchase_Action> GetDataPurchaseAction(DateTime datefrom, DateTime dateTo)
        {
            return _context.Purchase_Action.AsNoTracking().Where(w => w.ReleaseDate >= datefrom && w.ReleaseDate <= dateTo).OrderByDescending(o => o.Id).ToList();
        }
    }
}
