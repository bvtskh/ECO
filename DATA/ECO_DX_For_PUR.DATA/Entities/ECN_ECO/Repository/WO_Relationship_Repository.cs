using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.ECO_CANON.Repository
{
    public class WO_Relationship_Repository
    {
        DBContext _context = new DBContext();
        public bool InsertData(Tbl_WO_Relationship tbl_WO_Relationship)
        {
            try
            {
                _context.Tbl_WO_Relationship.Add(tbl_WO_Relationship);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tbl_WO_Relationship> GetdataWOList(string searchStr, int number)
        {
            if (string.IsNullOrEmpty(searchStr))
            {
                return _context.Tbl_WO_Relationship.OrderByDescending(o => o.ID).Take(number).ToList();
            }
            return _context.Tbl_WO_Relationship.Where(w => w.AI.Contains(searchStr) || w.SMTA.Contains(searchStr) || w.SMTB.Contains(searchStr) || w.SMT.Contains(searchStr) || w.FAT1.Contains(searchStr)||  w.FAT2.Contains(searchStr) || w.FAT3.Contains(searchStr))
                .OrderByDescending(o => o.ID).Take(number).ToList();
        }

        public bool InsertData(List<Tbl_WO_Relationship> wOList)
        {
            try
            {
                _context.Tbl_WO_Relationship.AddRange(wOList);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsExistWO(string textWO,int indexEnum)
        {
            if (!string.IsNullOrEmpty(textWO))
            {
                switch (indexEnum)
                {
                    case 0:
                        {
                            var existValue = _context.Tbl_WO_Relationship.Where(w => w.AI == textWO).FirstOrDefault();
                            if (existValue != null) return true;
                        }
                        break;
                    case 1:
                        {
                            var existValue = _context.Tbl_WO_Relationship.Where(w => w.SMTA == textWO).FirstOrDefault();
                            if (existValue != null) return true;
                        }
                        break;
                    case 2:
                        {
                            var existValue = _context.Tbl_WO_Relationship.Where(w => w.SMTB == textWO).FirstOrDefault();
                            if (existValue != null) return true;
                        }
                        break;
                    case 3:
                        {
                            var existValue = _context.Tbl_WO_Relationship.Where(w => w.SMT == textWO).FirstOrDefault();
                            if (existValue != null) return true;
                        }
                        break;
                    case 4:
                        {
                            var existValue = _context.Tbl_WO_Relationship.Where(w => w.FAT1 == textWO).FirstOrDefault();
                            if (existValue != null) return true;
                        }
                        break;
                    case 5:
                        {
                            var existValue = _context.Tbl_WO_Relationship.Where(w => w.FAT2 == textWO).FirstOrDefault();
                            if (existValue != null) return true;
                        }
                        break;
                    case 6:
                        {
                            var existValue = _context.Tbl_WO_Relationship.Where(w => w.FAT3 == textWO).FirstOrDefault();
                            if (existValue != null) return true;
                        }
                        break;

                    default: return false;
                }
            }
            return false;
        }
        private enum WOlist { AI, SMTA, SMTB, SMT, FAT1, FAT2, FAT3 }
    }
}
