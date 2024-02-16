using ECO_DX_For_PUR.DATA.COST_SYSTEM;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.ECO_CANON.Repository
{
    public class ECO_ControlSheet_Repository
    {
        DBContext _context = new DBContext();
        DBContextBOM _contextBOM = new DBContextBOM();
        public bool InsertData(ECO_ControlSheet ECO_controlSheet)
        {
            try
            {
                _context.ECO_ControlSheet.Add(ECO_controlSheet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
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
        public List<ECO_ControlSheet> GetECNDataList(string eCNText)
        {
            try
            {
                return _context.ECO_ControlSheet.Where(w => w.ECN_ERI_No == eCNText).ToList();
            }
            catch (Exception)
            {
                return null;
            }           
        }

        public DataTable GetAllControlSheetData()
        {
            var query = _context.ECO_ControlSheet.Select(e => e);

            DataTable dataTable = ToDataTable(query);
            return dataTable;
        }
        static DataTable ToDataTable<T>(IQueryable<T> query)
        {
            DataTable dataTable = new DataTable();

            // Create columns based on the entity properties
            foreach (var property in typeof(T).GetProperties())
            {
                var n = property.Name;
                dataTable.Columns.Add(property.Name);
            }

            // Populate the DataTable with data from the query
            foreach (var item in query)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(T).GetProperties())
                {
                    row[property.Name] = property.GetValue(item);
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public List<string> GetModelNameHadBOM()
        {
            var modelECOcontrolExist = _context.ECO_ControlSheet.Select(w => w.ModelName).ToList().Distinct();
            var modelBOMExist = _contextBOM.BC_BOM_LIST.Select(w => w.MODEL_ID).ToList().Distinct();

            List<string> modelSame = new List<string>();

            foreach (var item in modelBOMExist)
            {
                foreach (var item1 in modelECOcontrolExist)
                {
                    if (item.Contains(item1))
                    {
                        modelSame.Add(item1);
                    }
                }
            }
            var SS01list =  modelSame.Where(w=>w.Contains("SS01")).ToList();
            return modelSame.Except(SS01list).ToList();
        }

        public List<ECO_ControlSheet> GetECNWaitingAction(List<string> purchaseECNaction, List<string> controlSheetECN)
        {
            List<string> EcnList = controlSheetECN.Except(purchaseECNaction).ToList();
            List<ECO_ControlSheet> result = new List<ECO_ControlSheet>();
            foreach(var item in EcnList)
            {
                var list = _context.ECO_ControlSheet.Where(w => w.ECN_ERI_No == item).ToList();
                result.AddRange(list);
                if (result.Count() >= 1000) return result;
            }
            return null;
        }

        public List<ECO_ControlSheet> GetECNlist()
        {
            return _context.ECO_ControlSheet.AsNoTracking().ToList();
        }

        public object getModelNameByID(int id)
        {
            return _context.ECO_ControlSheet.Where(w => w.Id == id).Select(s => s.ModelName).FirstOrDefault();
        }

        public object GetLocationByID(int id)
        {
            return _context.ECO_ControlSheet.Where(w => w.Id == id).Select(s => s.Location).FirstOrDefault();
        }

        public ECO_ControlSheet GetECOcontrolSheetByID(int? id)
        {
            return _context.ECO_ControlSheet.AsNoTracking().Where(w => w.Id == id).FirstOrDefault();
        }

        public List<ECO_ControlSheet> GetDataExist(string ecn, string eco, string model, string newpart)
        {
            return _context.ECO_ControlSheet.Where(w => w.ECN_ERI_No == ecn && w.ECO_No == eco && w.ModelName == model && w.NewPartCode.Contains(newpart)).ToList();
        }

        /// <summary>
        /// danh sach ECN chua action se duoc duyet va lay ra so luong ECO
        /// </summary>
        /// <param name="ecnResult"></param>
        /// <param name="datefrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public List<ECO_ControlSheet> GetDataByListString(List<string> ecnResult,DateTime datefrom, DateTime dateTo)
        {
            List<ECO_ControlSheet> result = new List<ECO_ControlSheet>();
            foreach (var item in ecnResult)
            {
                var data = _context.ECO_ControlSheet.AsNoTracking().Where(w => w.ECN_ERI_No == item && w.ECN_ReceiveDate >= datefrom && w.ECN_ReceiveDate <= dateTo && w.Issue_To.Trim().ToLower() == "pur").ToList();
                if (data.Count() > 0)
                {
                    result.AddRange(data);
                }
            }
            return result.OrderByDescending(o=>o.Id).ToList();
        }

        public List<string> GetModelNameNOTBOM()
        {
            var controlsheetModel = _context.ECO_ControlSheet.Where(w => w.ModelFull != null).Select(s => s.ModelFull).Distinct();
            var result = _contextBOM.BC_BOM_LIST
            .GroupBy(x => x.MODEL_ID)
            .Where(group => group.All(item => string.IsNullOrEmpty(item.LOCATION)))
            .Select(group =>  group.Key).Distinct()
            .ToList();
            foreach(var model in controlsheetModel)
            {
                var value = _contextBOM.BC_BOM_LIST
                .Where(x => x.MODEL_ID == model)
                .All(item => string.IsNullOrEmpty(item.LOCATION));
                if (value) result.Add(model);
            }
            return result;
        }

        //public object getpartrunningchange(List<ECO_ControlSheet> controlSheetWaitingAction)
        //{
        //    List<string> list = new List<string>();
        //    foreach (var item in controlSheetWaitingAction)
        //    {
        //        if (_contextBOM.BC_BOM_LIST.Where(w => w.PART_NO == item.NewPartCode && w.RUNNING_CHANGE == true).FirstOrDefault() != null)
        //        {
        //            list.Add(item.NewPartCode);
        //        }
        //    }
        //    return false;
        //}
    }
}
