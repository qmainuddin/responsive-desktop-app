using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HSDL_IDM_P2.Pages.Common
{
    /// <summary>
    /// Interaction logic for InitialPage.xaml
    /// </summary>
    public partial class InitialPage : Window
    {
        public InitialPage()
        {
            InitializeComponent();
            LoginPage loginPortion = new LoginPage(this);
            initialPage_body.ShowPage(loginPortion);
            //designLoader();

        }
        public void designLoader()
        {
           // this.loadingCanvas.Children.Clear();
            UIElement rootElement;
            FileStream s = new FileStream(@"E:\learningProjects\DotNetProjects\roundedLoader.xaml", 
                FileMode.Open);
            rootElement = (UIElement)XamlReader.Load(s);
            s.Close();
            //this.loadingCanvas.Children.Add(rootElement);
//            this.loadingImg.Content = rootElement;
        }
        public void ShowModal()
        {
            Utils.Util.addWipeDownAnnimation(this.PopupContainer, this.ActualHeight);
            Utils.Util.LoadingPage = this.loadingCanvas;
            this.loadingCanvas.Visibility = Visibility.Visible;
            this.PopupContainer.SetParent(this.initialPage_body);
            this.PopupContainer.ShowHandlerDialog();
        }
        public void CloseModal()
        {
            this.PopupContainer.CloseModal();
        }
    }
}
