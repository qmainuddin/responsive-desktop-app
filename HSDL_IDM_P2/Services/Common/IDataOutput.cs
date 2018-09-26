using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSDL_IDM_P2.Service.Common
{
    public interface IDataOutput
    {
        void outputDataReady(Object obj);
        void outputDataFailed(Exception ex);
    }
}
