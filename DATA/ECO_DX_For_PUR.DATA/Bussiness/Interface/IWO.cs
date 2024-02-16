using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.Interface
{
    public interface IWO
    {
        List<WoChanging> GetWOChanging();
        List<WoChanging> GetWOPlaning(int check);
        bool IsChangingWO(string woPending);
        bool InsertData(List<WO_Relationship> dataInsert);
        List<WO_Relationship> GetWORelationList();
        bool IsFinishWO(string woPending);
        List<WoChanging> GetPendingWO();
        string GetECONoByOrderNo(IGrouping<Guid?, WO_Relationship> group);
        List<Area> GetAreaList();
    }
}
