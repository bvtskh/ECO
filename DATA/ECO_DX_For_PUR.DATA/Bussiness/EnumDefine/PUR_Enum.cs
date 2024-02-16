using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.EnumDefine
{
    public class PUR_Enum
    {
        public enum  SelectType
        {
            Finish,
            Pending,
            Duplicate
        };

        public enum SearchBy
        {
            ECN,
            ECO
        };
    }
}
