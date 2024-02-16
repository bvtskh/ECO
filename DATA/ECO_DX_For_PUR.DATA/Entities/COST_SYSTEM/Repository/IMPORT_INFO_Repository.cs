using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.COST_SYSTEM.Repository
{
    public class IMPORT_INFO_Repository
    {
        DBContextBOM _context = new DBContextBOM();

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
