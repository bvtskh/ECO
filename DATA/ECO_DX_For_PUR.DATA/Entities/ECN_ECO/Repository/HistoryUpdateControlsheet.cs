using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.ECO_CANON.Repository
{
    public class HistoryUpdateControlsheet
    {
        DBContext _context = new DBContext();

        public ECO_ControlSheet GetLastControlSheetUpdate()
        {
            var id = _context.HistoryUpdateControlSheets.OrderByDescending(o => o.Id).First().Last_Update_Id;
            return _context.ECO_ControlSheet.Where(w => w.Id == id).FirstOrDefault();
        }

        void InsertHistoryUpdateControlSheet(int id)
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
    }
}
