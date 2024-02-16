using ECO_DX_For_PUR.DATA.COST_SYSTEM;
using ECO_DX_For_PUR.DATA.Entities.PI_BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.PI_BASE.Repository
{
    public class PI_BASE_Repository
    {
        DBContext_PI_BASE _context = new DBContext_PI_BASE();
        DBContextBOM _contextBom = new DBContextBOM();
        public object GetModelList()
        {
            List<string> list = new List<string>();
            var modellist =  _context.ModelMasters.Where(w => w.CUSTOMER_SAP == "CS001").Select(s => s.MODEL_NAME).Distinct().ToList();
            foreach(var item in modellist)
            {
                var data = _contextBom.BC_BOM_LIST.Where(w => w.MODEL_ID == item).FirstOrDefault();
                if(data == null)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
