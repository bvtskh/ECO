using ECO_DX_For_PUR.DATA.COST_SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.Interface
{
    public interface IPRICE
    {
        DataTable GetDataByPartNo(string partNo, int record);
        DateTime? GetLastUpdateTime();
        void SaveImportInfo(IMPORT_INFO info);
    }
}
