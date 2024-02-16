using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.COST_SYSTEM.Repository
{
    public class ZMM80_Repository
    {
        DBContextBOM _context = new DBContextBOM();
        public void InsertZMM80(List<PUR_ZMM80> zmm80List)
        {
            try
            {
                _context.PUR_ZMM80.AddRange(zmm80List);
                _context.SaveChanges();
                
            }
            catch (Exception)
            {
                throw;
            }           
        }

        public void Count()
        {
            int a= _context.PUR_ZMM80.ToList().Count();
        }

        internal string GetETAdate(string new_Part)
        {
            if (new_Part != null)
            {
                var date = _context.PUR_ZMM80.AsNoTracking().Where(w => w.INTERNAL_MATERIAL == new_Part).Select(s => s.ETA_FACTORY_DATE).FirstOrDefault();
                if (date != null)
                {
                    return date.Value.Date.ToString("MM/dd/yyyy");
                }
            }
            return null;
        }
    }
}
