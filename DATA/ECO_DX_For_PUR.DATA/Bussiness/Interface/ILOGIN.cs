using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.Interface
{
    public interface ILOGIN
    {
        string GetCurrentVersion();
        void SaveNewVersion(Versions version);
        bool IsOldVersion(string oldValue);
    }
}
