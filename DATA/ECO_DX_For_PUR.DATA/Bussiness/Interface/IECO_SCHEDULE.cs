using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.Interface
{
    public interface IECO_SCHEDULE
    {
        bool InsertEcoSchedule(ECOSchedule ecoSchedule);
        bool InsertEcoSchedule(List<ECOSchedule> ecoSchedule);
        bool InsertAndUpdateEcoSchedule(List<ECOSchedule> ecoSchedule);
        List<ECOSchedule> GetAllDataECOSchedule();
        bool IsExistECOData(ECOSchedule ecoSchedule);
        ECOSchedule GetExistECOData(ECOSchedule ecoSchedule);
        bool UpdateECOSchedule(ECOSchedule dataUpdate, int id);
    }
}
