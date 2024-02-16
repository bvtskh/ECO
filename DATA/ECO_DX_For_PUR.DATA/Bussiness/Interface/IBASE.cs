using ECO_DX_For_PUR.DATA.Entities.PI_BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.Interface
{
    public interface IBASE
    {
        List<Customer> GetCustomer();
    }
}
