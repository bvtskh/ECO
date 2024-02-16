using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.ECO_CANON.Repository
{
    public class PE_DM_ControlSheet_Repository
    {
        DBContext _context = new DBContext();
        public DataTable GetDataControlSheet(int record, DateTime datefrom, DateTime dateTo)
        {
            var query = _context.ECO_ControlSheet.Where(w=>w.ECN_ReceiveDate >= datefrom && w.ECN_ReceiveDate <=dateTo).OrderByDescending(o=>o.ECN_ReceiveDate).Take(record).Select(e => e);

            DataTable dataTable = ToDataTable(query);
            return dataTable;
        }
        static DataTable ToDataTable<T>(IQueryable<T> query)
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
                    if(item is ECO_ControlSheet)
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

        public DataTable GetDataControlSheet(IQueryable<ECO_ControlSheet> dataIssueToPur, int value)
        {
            DataTable dataTable = ToDataTable(dataIssueToPur.Take(value));
            return dataTable;
        }

        public IQueryable<ECO_ControlSheet> GetDataIssueToPur(DateTime datefrom, DateTime dateTo)
        {
            return _context.ECO_ControlSheet.Where(w=>w.ECN_ReceiveDate >= datefrom && w.ECN_ReceiveDate <= dateTo).OrderByDescending(o=>o.ECN_ReceiveDate).Where(w => w.Issue_To.ToLower().Trim() == "pur").Select(e => e);
        }

        public DataTable GetDataPurControlSheet(int record)
        {
            var query = _context.ECO_ControlSheet.OrderByDescending(o => o.Id).Where(w=>w.Issue_To.ToLower().Trim() == "pur").Take(record).Select(e => e);
            DataTable dataTable = ToDataTable(query);
            return dataTable;
        }

        public DataTable GetDataSearch(int selectedIndex, string searchString)
        {
            DataTable dataTable;
            if (selectedIndex == 0)
            {
                var query =  _context.ECO_ControlSheet.OrderByDescending(o=>o.ECN_ReceiveDate).Where(w => w.ECN_ERI_No.Contains(searchString)).ToList().AsQueryable();
                return dataTable = ToDataTable(query);
            }
            else if(selectedIndex == 1)
            {
                return dataTable = ToDataTable(_context.ECO_ControlSheet.OrderByDescending(o => o.ECN_ReceiveDate).Where(w => w.ECO_No.Contains(searchString)).ToList().AsQueryable());
            }
            else if (selectedIndex == 2)
            {
                return dataTable = ToDataTable(_context.ECO_ControlSheet.OrderByDescending(o => o.ECN_ReceiveDate).Where(w => w.ModelName.Contains(searchString)).ToList().AsQueryable());
            }
            else if (selectedIndex == 3)
            {
                return dataTable = ToDataTable(_context.ECO_ControlSheet.OrderByDescending(o => o.ECN_ReceiveDate).Where(w => w.No.ToString().Contains(searchString)).ToList().AsQueryable());
            }
           
            return null;
        }

        public bool IsExistedECN(string Eco)
        {
            if(Eco != null)
            {
                var result = _context.ECO_ControlSheet.Where(w => w.ECO_No.Trim() == Eco.Trim()).FirstOrDefault();
                if (result != null) 
                    return true;
            }
            return false;
        }

        public List<ECO_ControlSheet> Getlist()
        {
            return _context.ECO_ControlSheet.Where(w => w.ECO_No!=null && w.ECO_No.Count() > 1).ToList();
        }

        public bool InsertData(ECO_ControlSheet ecoControlSheet)
        {
            try
            {
                _context.ECO_ControlSheet.Add(ecoControlSheet);
                _context.SaveChanges();
                 return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        public bool RemoveData(int id)
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

        public bool UpdateData(int id)
        {
            try
            {
                ECO_ControlSheet updateControlSheet = _context.ECO_ControlSheet.Where(w => w.Id == id).FirstOrDefault();
                _context.Entry(updateControlSheet).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool UpdateData(ECO_ControlSheet update)
        {
            try
            {
                ECO_ControlSheet updateControlSheet = _context.ECO_ControlSheet.Where(w => w.Id == update.Id).FirstOrDefault();
                updateControlSheet = update;
                _context.Set<ECO_ControlSheet>().AddOrUpdate(updateControlSheet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
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

        public DataTable GetDuplicateECO(DateTime datefrom, DateTime dateTo)
        {
            DataTable dataTable;
            var dataDuplicate = _context.ECO_ControlSheet
                .Where(e => e.ECO_No != null && e.ECN_ReceiveDate >=datefrom && e.ECN_ReceiveDate <= dateTo)
                .GroupBy(g => g.ECO_No)
                    .Where(w => w.Count() > 1).SelectMany(group => group).OrderByDescending(o=>o.ECN_ReceiveDate).ToList().AsQueryable();
            return dataTable = ToDataTable(dataDuplicate);
        }

        //public List<string> getListECN()
        //{
        //    DateTime date = new DateTime(2021, 1, 1);
        //   // return _context.ECO_ControlSheet.Where(w => w.ECN_ReceiveDate > date  && w.ECO_No !=null).Select(s => s.ECO_No).ToList().Select(w=>w.Count()>1).ToList();
        //}
    }
}
