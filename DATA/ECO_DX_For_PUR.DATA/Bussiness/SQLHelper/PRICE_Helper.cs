using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.COST_SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.SQLHelper
{
    public class PRICE_Helper : IPRICE
    {
        DBContextBOM _context = new DBContextBOM();
        public DataTable GetDataByPartNo(string partNo, int record)
        {
            try
            {
                IQueryable<PUR_PART_PRICE> dataList;
                if (string.IsNullOrEmpty(partNo))
                {
                    dataList = _context.PUR_PART_PRICE.OrderByDescending(o => o.CREATE_DATE).Take(record).Select(s => s);
                }
                else
                {
                    dataList = _context.PUR_PART_PRICE.Where(w => w.PART_NO.Contains(partNo)).Select(e => e);
                }
                return ToDataTable(dataList);
            }
            catch (Exception)
            {
                return null;
            }
        }
        static DataTable ToDataTable<T>(IQueryable<T> query)
        {
            try
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
                        if (item is PUR_PART_PRICE)
                        {
                            var controlSheet = item as PUR_PART_PRICE;

                            if (property.Name == "QUOTE_DATE")
                            {
                                string date = ConvertDate(controlSheet.QUOTE_DATE);
                                row[property.Name] = date;
                            }
                            else if (property.Name == "CREATE_DATE")
                            {
                                string date = ConvertDate(controlSheet.CREATE_DATE);
                                row[property.Name] = date;
                            }
                            else if (property.Name == "VALID_FROM")
                            {
                                string date = ConvertDate(controlSheet.VALID_FROM);
                                row[property.Name] = date;
                            }
                            else if (property.Name == "VALID_TO")
                            {
                                string date = ConvertDate(controlSheet.VALID_TO);
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
            catch (Exception)
            {
                return null;
            }
        }

        private static string ConvertDate(DateTime? qUOTE_DATE)
        {
            DateTime result;
            if (qUOTE_DATE != null)
            {
                if (DateTime.TryParse(qUOTE_DATE.ToString(), out result))
                {
                    return result.Date.ToString("yyyy-MM-dd");
                }
            }
            return null;
        }
        public DateTime? GetLastUpdateTime()
        {
            try
            {
                var lastUpdate = _context.IMPORT_INFO.Where(w => w.Func == "fPurPartPrice").OrderByDescending(o => o.UpdateTime).ToList();
                return lastUpdate[0].UpdateTime;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void SaveImportInfo(IMPORT_INFO info)
        {
            _context.IMPORT_INFO.Add(info);
            _context.SaveChanges();
        }
    }
}
