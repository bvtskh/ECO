using ECO_DX_For_PUR.DATA.COST_SYSTEM;
using ECO_DX_For_PUR.DATA.COST_SYSTEM.Repository;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.ECO_CANON.Repository
{
    public class PurchaseAction_Repository
    {
        DBContext _context = new DBContext();
        BOM_List_Repository _bomList_Repository = new BOM_List_Repository(new DBContextBOM());
        ZMM80_Repository _zMM80_Repository = new ZMM80_Repository();
        public List<Purchase_Action> GetDataPurchaseAction(DateTime datefrom, DateTime dateTo)
        {
            return _context.Purchase_Action.AsNoTracking().Where(w => w.ReleaseDate >= datefrom && w.ReleaseDate <= dateTo).OrderByDescending(o => o.Id).ToList();
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

        public List<Purchase_Action> GetECOListByECN(string ecnSearch)
        {
            return _context.Purchase_Action.Where(w => w.ECN == ecnSearch).ToList();
        }

        public DataTable GetDataPurchaseAction(string eCNText)
        {
            List<string> ECNlist = SplitECN(eCNText);
            List<Purchase_Action> actionList = new List<Purchase_Action>();
            DataTable dataTable = new DataTable();
            CreateColumns(dataTable);
            foreach (var ecn in ECNlist)
            {
                var controlSheetList = _context.ECO_ControlSheet.AsNoTracking().Where(w => w.ECN_ERI_No == ecn.Trim() && w.Issue_To.ToLower() == "pur").ToList(); // lay ra danh sach ecn tu control sheet.
                controlSheetList.Reverse();
                // khi co danh sach ECN thi purchase action.

                foreach (var item in controlSheetList)
                {
                    dataTable.Rows.Add();
                    DataRow rows = dataTable.Rows[dataTable.Rows.Count - 1];
                    rows["ECO Control Sheet ID"] = item.Id;
                    rows["Ngày phát hành"] = item.ECN_ReceiveDate.Value.Date.ToString("MM/dd/yyyy");
                    rows["ECN"] = item.ECN_ERI_No; // ECN
                    rows["ECO No"] = item.ECO_No; // ECO
                    rows["Model"] = item.ModelName;
                   
                    var onlyPart = CheckOnlyPart(item.OldPartCode);
                    rows["Current part(BOM 2)"] = item.OldPartCode;
                    var olPart = _bomList_Repository.GetOldPartByModelAndLocation(item.ModelFull, item.Location);
                    rows["Current part(BOM 1)"] = olPart == null ? onlyPart : olPart;
                    rows["New part"] = item.NewPartCode; // new part                                                             
                    // ZMM70 gia + vender
                    PUR_PART_PRICE oldPartPrice = _bomList_Repository.GetDataByPart(olPart);
                    PUR_PART_PRICE newPartPrice = _bomList_Repository.GetDataByPart(item.NewPartCode);

                    if (olPart == null && onlyPart != null) // nếu không tìm được oldPart và part BOM2 có có 1 part thì xét trường hợp này(lấy đúng part này làm old part)
                    {
                        var partSelect = _bomList_Repository.GetDataByPart(onlyPart.ToString());
                        rows["Current price"] = ConvertDouble(partSelect) == 0 || ConvertDouble(partSelect) == null ? "#N/A" : ConvertDouble(partSelect).ToString();
                        rows["Different"] = CheckDifferent(ConvertDouble(partSelect), ConvertDouble(newPartPrice));
                        if (IsCEHKvendor(partSelect))
                        {
                            rows["Current Vendor"] = partSelect.SUPPLIER +"-"+ partSelect.MANUFACTURER_NAME;
                        }
                        else
                        {
                            rows["Current Vendor"] = partSelect == null ? null : partSelect.SUPPLIER;
                        }
                        rows["Situation"] = CheckReport(partSelect);
                    }
                    else
                    {
                        rows["Current price"] = ConvertDouble(oldPartPrice) == 0 || ConvertDouble(oldPartPrice) == null ? "#N/A" : ConvertDouble(oldPartPrice).ToString();
                        rows["Different"] = CheckDifferent(ConvertDouble(oldPartPrice), ConvertDouble(newPartPrice));
                        if (IsCEHKvendor(oldPartPrice))
                        {
                            rows["Current Vendor"] = oldPartPrice.SUPPLIER + "-" + oldPartPrice.MANUFACTURER_NAME;
                        }
                        else
                        {
                            rows["Current Vendor"] = oldPartPrice == null ? null : oldPartPrice.SUPPLIER;
                        }
                        rows["Situation"] = CheckReport(ConvertDouble(oldPartPrice), ConvertDouble(newPartPrice), item.TVP_No, item.TVPResult);
                    }
                    if (IsCEHKvendor(newPartPrice))
                    {
                        rows["New Vendor"] = newPartPrice.SUPPLIER + "-" + newPartPrice.MANUFACTURER_NAME;
                    }
                    else
                    {
                        rows["New Vendor"] = newPartPrice == null ? null : newPartPrice.SUPPLIER;
                    }
                    rows["New price"] = ConvertDouble(newPartPrice) == 0 || ConvertDouble(newPartPrice) == null ? "#N/A" : ConvertDouble(newPartPrice).ToString();
                    rows["Location"] = item.Location;
                    rows["ECO content"] = item.ContentOfChange;
                    rows["TVP No"] = item.TVP_No;
                    rows["RESULT TVP"] = item.TVPResult;
                    rows["REASON"] = null;
                    rows["ETA UMCVN"] = _zMM80_Repository.GetETAdate(item.NewPartCode);
                    rows["Est using new part date"] = null;
                    rows["Transfered ECO date"] = null;
                    rows["Purpose transferred ECO date"] = null;
                    rows["Received ECO date"] = "";
                    rows["1st delivery"] = "";
                    rows["Action"] = "";
                }                
            }
            return dataTable;
        }

        private bool IsCEHKvendor(PUR_PART_PRICE partSelect)
        {
            if(partSelect != null)
            {
                if (partSelect.SUPPLIER == "CEHK") return true;
            }
            return false;
        }

        private object CheckReport(PUR_PART_PRICE onlyPart)
        {
            if (onlyPart !=null)
            {
               
                return "No apply-child part no use this model";
                
            }
            return null;
        }

        private object CheckOnlyPart(string oldPartCode)
        {
            if (_bomList_Repository.CheckOnlyPart(oldPartCode))
            {
                return oldPartCode;
            }
            return null;
        }

        public bool IsrunningChnage(string runningChange)
        {
           return _bomList_Repository.IsrunningChnage(runningChange);
        }

        private string CheckDifferent(double? oldPrice, double? newPrice)
        {
            if (oldPrice > 0 && newPrice > 0)
            {
                if (oldPrice - newPrice > 0)
                {
                    return $"({Math.Abs(Math.Round((double)oldPrice - (double)newPrice, 4))})";
                }
                else
                    return $"{Math.Abs(Math.Round((double)oldPrice - (double)newPrice, 4))}";
            }
            else
            {
                return "#N/A";
            }
        }
        private void CreateColumns(DataTable dataTable)
        {
            dataTable.Columns.Add("ECO Control Sheet ID", typeof(string));
            dataTable.Columns.Add("Ngày phát hành", typeof(string));
            dataTable.Columns.Add("ECN", typeof(string));
            dataTable.Columns.Add("ECO No", typeof(string));
            dataTable.Columns.Add("Model", typeof(string));
            dataTable.Columns.Add("Current part(BOM 2)", typeof(string));
            dataTable.Columns.Add("Current part(BOM 1)", typeof(string));
            dataTable.Columns.Add("New part", typeof(string));
            dataTable.Columns.Add("ECO content", typeof(string));
            dataTable.Columns.Add("Location", typeof(string));
            dataTable.Columns.Add("TVP No", typeof(string));
            dataTable.Columns.Add("RESULT TVP", typeof(string));
            dataTable.Columns.Add("Current price", typeof(string));
            dataTable.Columns.Add("New price", typeof(string));
            dataTable.Columns.Add("Different", typeof(string));
            dataTable.Columns.Add("Current Vendor", typeof(string));
            dataTable.Columns.Add("New Vendor", typeof(string));
            dataTable.Columns.Add("Situation", typeof(string));
            dataTable.Columns.Add("REASON", typeof(string));
            dataTable.Columns.Add("ETA UMCVN", typeof(string));
            dataTable.Columns.Add("Est using new part date", typeof(string));
            dataTable.Columns.Add("Transfered ECO date", typeof(string));
            dataTable.Columns.Add("Purpose transferred ECO date", typeof(string));
            dataTable.Columns.Add("Received ECO date", typeof(string));
            dataTable.Columns.Add("1st delivery", typeof(string));
            dataTable.Columns.Add("Action", typeof(string));
        }
        private string CheckReport(double? old_Price, double? new_Price, string tvpNo, string tvpResult)
        {
            if (old_Price != null && new_Price != null)
            {               
                if (old_Price == 0 || new_Price == 0)
                {
                    return "Checking-Asking QTN";
                }
                if (old_Price == new_Price)
                {
                    return "No apply-same price";
                }
                else if (old_Price < new_Price)
                {
                    return "No apply-high price";
                }
                if (!string.IsNullOrEmpty(tvpNo) && string.IsNullOrEmpty(tvpResult))
                {
                    return "Not yet have TVP result";
                }
            }
            return null;
        }

        private double? ConvertDouble(PUR_PART_PRICE rowSelect)
        {
            if (rowSelect != null)
            {
                return (double)rowSelect.UNIT_PRICE;
            }
            return 0;
        }

        private List<string> SplitECN(string eCNText)
        {
            return eCNText.Split(',').ToList();
        }

        public List<Purchase_Action> GetECNlist()
        {
            return _context.Purchase_Action.AsNoTracking().ToList();
        }

        public bool InsertData(List<Purchase_Action> dataList)
        {
            try
            {
                _context.Purchase_Action.AddRange(dataList);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw new Exception("Error!");
            }
        }

        public List<Purchase_Action> GetECOcanonList()
        {
            return _context.Purchase_Action.OrderByDescending(o => o.Id).Take(1000).ToList();
        }

        public List<Purchase_Action> GetDuplicateECO(DateTime datefrom, DateTime dateTo)
        {
            return _context.Purchase_Action.AsNoTracking()
                .Where(w => w.ECO_No != null && w.ReleaseDate >= datefrom && w.ReleaseDate <= dateTo)
                .GroupBy(p => p.ECO_No)
                .Where(g => g.Count() >= 2)
                .SelectMany(g => g).OrderByDescending(o => o.Id)
                .ToList();
        }

        public List<string> GetPartRuningChange()
        {
            return _bomList_Repository.GetPartRuningChange();
        }
    }
}
