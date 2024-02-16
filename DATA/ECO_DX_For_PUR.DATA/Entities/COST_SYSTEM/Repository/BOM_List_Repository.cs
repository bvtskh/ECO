using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.COST_SYSTEM.Repository
{
    public class BOM_List_Repository
    {
        DBContextBOM _context;
        // IWO context = new CWOHelper();

        public BOM_List_Repository(DBContextBOM dbContext)
        {
            _context = dbContext;
        }
        DBContext ctx = new DBContext();
        public string GetOldPartByModelAndLocation(string modelName, string location)
        {
            string originMode = GetOriginModel(modelName);

            if(location != null)
            {
                string[] arrayLocation = location.Split(',');
                return _context.BC_BOM_LIST.AsNoTracking().Where(w => w.MODEL_ID == originMode).ToList()
                .Where(w => arrayLocation.Intersect(w.LOCATION.Split(',')).Any()).Select(s => s.PART_NO).FirstOrDefault();
            }

            return null;

        }

        private string GetOriginModel(string modelName)
        {
            var model = ctx.Model_Family.AsNoTracking().Where(w => modelName == w.Branch_Model).ToList();
            if (model.Count > 0)
            {
                foreach(var origin in model)
                {
                    if (IsExistLocation(origin.Origin_Model))
                    {
                        return origin.Origin_Model;
                    }
                }
            }
            return modelName;
            //if (model!=null)
            //{
            //    return model.Origin_Model;
            //}
            //return modelName;
        }

        private bool IsExistLocation(string origin_Model)
        {
            var modelExistLocation = _context.BC_BOM_LIST.AsNoTracking().Where(w => w.MODEL_ID == origin_Model && w.LOCATION != null).FirstOrDefault();
            if (modelExistLocation != null) return true;
            return false;
        }

        internal PUR_PART_PRICE GetDataByPart(string partName)
        {
            return _context.PUR_PART_PRICE.AsNoTracking().Where(w => w.PART_NO == partName && w.FIXED_VENDOR == true && w.CREATE_DATE == _context.PUR_PART_PRICE.Where(x => x.PART_NO == partName && x.FIXED_VENDOR != false).Max(x => x.CREATE_DATE)).FirstOrDefault();
        }

        internal bool IsrunningChnage(string runningChange)
        {
            return _context.BC_BOM_LIST.AsNoTracking().Where(w => w.PART_NO == runningChange).Select(s => s.RUNNING_CHANGE == true).FirstOrDefault();
        }

        internal List<string> GetPartRuningChange()
        {
            return _context.BC_BOM_LIST.AsNoTracking().Where(w => w.RUNNING_CHANGE == true).Select(s => s.PART_NO).Distinct().ToList();
        }

        internal bool CheckOnlyPart(string oldPartCode)
        {
           if(_context.PUR_PART_PRICE.AsNoTracking().Where(w=>w.PART_NO == oldPartCode).Count() >0)
           {
                return true;
           }
            return false;
        }
    }
}
