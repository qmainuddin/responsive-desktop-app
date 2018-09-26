using HSDL_IDM_P2.Lib.Entity.Common;
using HSDL_IDM_P2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HSDL_IDM_P2.Controllers.Lookup
{
    public class LookupController
    {
        private static LookupController _LookupController = null;
        private readonly BackgroundWorker worker;
        public List<LabelName> districtList = null;
        public Grid canvas = null;
        private LookupController()
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }
        public static LookupController getInstance()
        {
            if (_LookupController == null)
            {
                _LookupController = new LookupController();
            }
            return _LookupController;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(canvas != null)
            {
                hideLoading();
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Defs.LOOKUP_TYPE lookup_type=0;
            if(e.Argument != null)
            {
                if(e.Argument is Defs.LOOKUP_TYPE)
                {
                    lookup_type = (Defs.LOOKUP_TYPE)e.Argument;
                }
            }
            if(lookup_type == Defs.LOOKUP_TYPE.DISTRICT_LOOKUP)
            {
                this.districtList = getDistrictList();
            }
        }
        private List<LabelName> getDistrictList()
        {
            List<LabelName> a = new List<LabelName>();
            for(int i=0; i<100; i++)
            {
                a.Add(new LabelName("comilla", "কুমিল্লা", 13));
            }

            return a;
        }
        public void GenerateLookup()
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync(Defs.LOOKUP_TYPE.DISTRICT_LOOKUP);
            }
        }
        private void hideLoading()
        {
            canvas.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
