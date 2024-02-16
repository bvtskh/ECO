using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.SQLHelper
{
    public class WOHelper : IWO
    {
        DBContext _context = new DBContext();

        public List<Area> GetAreaList()
        {
            return _context.Areas.ToList();
        }

        public List<string> GetCustomer()
        {

            throw new NotImplementedException();
        }

        public string GetECONoByOrderNo(IGrouping<Guid?, WO_Relationship> group)
        {

            foreach (var item in group)
            {
                var eco = _context.WoChangings.Where(w => w.ORDER_NO == item.ORDER_NO).Select(s => s.ECO_NO).FirstOrDefault();
                if (!string.IsNullOrEmpty(eco)) return eco;
            }
            return null;
        }

        public List<WoChanging> GetPendingWO()
        {
            using(var context = new DBContext())
            {
                return context.Database.SqlQuery<WoChanging>("exec GetPendingWoChanging")
                .Where(e2 => !context.WO_Relationship.Select(e1 => e1.ORDER_NO).Contains(e2.ORDER_NO)).ToList()
                .GroupBy(e => e.ORDER_NO)
                .Select(g => g.FirstOrDefault()).ToList();
            }
        }

        // UsapServices.USAPWebServiceSoapClient service = new UsapServices.USAPWebServiceSoapClient();
        public List<WoChanging> GetWOChanging()
        {
            return _context.WoChangings.ToList();
        }

        public List<WoChanging> GetWOPlaning(int check)
        {        
            using(var context = new DBContext())
            {
                if (check == 0)// all
                {
                    return context.Database.SqlQuery<WoChanging>("exec GetAllWoChanging").ToList();
                }
                else if (check == 1) //pending
                {
                    //var dataWoChanging = _context.Database.SqlQuery<WoChanging>("exec GetPendingWoChanging").ToList();
                    //return UpdateWochanging(dataWoChanging);
                    return context.Database.SqlQuery<WoChanging>("exec GetPendingWoChanging").ToList();

                }
                return null;
            }
        }

       


        //private List<WoChanging> UpdateWochanging(List<WoChanging> dataWoChanging)
        //{
        //    foreach (var item in dataWoChanging)
        //    {
        //        _context.Database.ExecuteSqlCommand("exec UpdateWOChanging", item.ECO_NO, item.DEPT_ORD, item)
        //    }
        //}

        public List<WO_Relationship> GetWORelationList()
        {
            using(var context =new DBContext())
            {
                return context.WO_Relationship.OrderByDescending(o => o.ID).Take(1000).ToList();
            }
        }

        public bool InsertData(List<WO_Relationship> dataInsert)
        {
            try
            {
                _context.WO_Relationship.AddRange(dataInsert);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool IsChangingWO(string woPending)
        {
            WoChanging woChangingExist = GetWOPlaning(1).Where(w => w.ORDER_NO == woPending).FirstOrDefault();
            if (woChangingExist != null) return true;
            return false;
        }

        public bool IsFinishWO(string woPending)
        {
            WO_Relationship wO_Relationship = _context.WO_Relationship.Where(w => w.ORDER_NO == woPending).FirstOrDefault();
            if (wO_Relationship != null) return true;
            return false;
        }
    }
}
