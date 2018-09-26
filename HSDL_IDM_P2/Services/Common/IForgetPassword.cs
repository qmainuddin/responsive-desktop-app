using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSDL_IDM_P2.Service.Common
{
    interface IForgetPassword
    {
        void forgetPassword(object userBO, IDataOutput iDataOutput);
    }
}
