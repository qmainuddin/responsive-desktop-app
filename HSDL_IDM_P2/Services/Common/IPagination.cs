using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSDL_IDM_P2.Service.Common
{
    public interface IPagination
    {
        void setTotalPage(int totalPage);
        int getTotalPage();
        void setDefaultPage(int defaultPage);
        int getDefaultPage();
        void searchResultDemo(int currentPage);
        void onPagination(int currentPage);

        void setTotalRecord(int totalRecord);
    }
}
