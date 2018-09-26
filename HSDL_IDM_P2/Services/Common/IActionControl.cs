using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HSDL_IDM_P2.Service.Common
{
    public interface IActionControl
    {
        void checkBoxChecked(object sender, RoutedEventArgs e);
        void CloseAlertPopUpWindow(bool status);
    }
}
