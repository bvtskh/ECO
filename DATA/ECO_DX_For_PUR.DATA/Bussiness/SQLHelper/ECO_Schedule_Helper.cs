using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.SQLHelper
{

    public class ECO_Schedule_Helper : IECO_SCHEDULE
    {
        DBContext _context = new DBContext();
        public bool InsertEcoSchedule(ECOSchedule ecoSchedule)
        {
            try
            {
                _context.ECOSchedules.Add(ecoSchedule);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public List<ECOSchedule> GetAllDataECOSchedule()
        {
            using (DBContext context = new DBContext())
            {
                return context.ECOSchedules.OrderByDescending(o => o.ID).ToList();
            }
        }

        public bool IsExistECOData(ECOSchedule ecoSchedule)
        {
            var ecoExist = _context.ECOSchedules.Where(w=> w.ECN_DCI_NO == ecoSchedule.ECN_DCI_NO && w.MODEL == ecoSchedule.MODEL).FirstOrDefault();
            if (ecoExist != null) return true;
            return false;
        }

        public ECOSchedule GetExistECOData(ECOSchedule ecoSchedule)
        {
            var ecoExist = _context.ECOSchedules.Where(w => w.ECN_DCI_NO == ecoSchedule.ECN_DCI_NO && w.MODEL == ecoSchedule.MODEL).FirstOrDefault();
            if (ecoExist != null) return ecoExist;
            return null;
        }

        public bool UpdateECOSchedule(ECOSchedule dataUpdate, int id)
        {
            try
            {
                var currentData = _context.ECOSchedules.Where(w => w.ID == id).FirstOrDefault();
                currentData.RECEIVE_DOCUMENT_DATE = dataUpdate.RECEIVE_DOCUMENT_DATE;
                currentData.IMPLEMENT_DATE = dataUpdate.IMPLEMENT_DATE;
                currentData.START_APPROVE_DATE = dataUpdate.START_APPROVE_DATE;
                currentData.ECN_DCI_NO = dataUpdate.ECN_DCI_NO;
                currentData.ECO_NO = dataUpdate.ECO_NO;
                currentData.MODEL = dataUpdate.MODEL;
                currentData.CONTENT_CHANGE = dataUpdate.CONTENT_CHANGE;
                currentData.REMARK = dataUpdate.REMARK;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool InsertEcoSchedule(List<ECOSchedule> ecoSchedule)
        {
            try
            {
                _context.ECOSchedules.AddRange(ecoSchedule);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool InsertAndUpdateEcoSchedule(List<ECOSchedule> ecoSchedule)
        {
            try
            {
                foreach (var item in ecoSchedule)
                {
                    var existData = GetExistECOData(item);
                    if (existData != null)
                    {
                        existData.RECEIVE_DOCUMENT_DATE = item.RECEIVE_DOCUMENT_DATE;
                        existData.IMPLEMENT_DATE = item.IMPLEMENT_DATE;
                        existData.START_APPROVE_DATE = item.START_APPROVE_DATE;
                        existData.MODEL = item.MODEL;
                        existData.CONTENT_CHANGE = item.CONTENT_CHANGE;
                        existData.ECN_DCI_NO = item.ECN_DCI_NO;
                        existData.ECO_NO = item.ECO_NO;
                        existData.REMARK = item.REMARK;
                    }
                    else
                    {
                        _context.ECOSchedules.Add(item);
                    }
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
