using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace HSDL_IDM_P2.Utils
{
    public class Util
    {
        private static Grid _loadingPage = null;
        public static Grid LoadingPage
        {
            get
            {
                if (_loadingPage != null)
                {
                    return _loadingPage;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                _loadingPage = value;
            }
        }

        public static void addBounceAnnimation(UserControl control, Thickness targetThickness)
        {
            ThicknessAnimation bounceAnimation = new ThicknessAnimation();
            //BounceEase BounceOrientation = new BounceEase();
            //BounceOrientation.Bounces = 4;
            //BounceOrientation.Bounciness = 2;

            //bounceAnimation.To = new Thickness(0, 0, 0, 0); 
            //bounceAnimation.From = new Thickness(0, targetThickness.Top, 0, targetThickness.Bottom);
            //bounceAnimation.EasingFunction = BounceOrientation;
            //test
            BackEase backOrientation = new BackEase();
            backOrientation.Amplitude = 2;
            backOrientation.Ease(0.3);
            backOrientation.EasingMode = EasingMode.EaseIn;

            bounceAnimation.To = new Thickness(0, 0, 0, 0);
            bounceAnimation.From = new Thickness(0, 0, 0, targetThickness.Bottom); //targetThickness.Top, 0, targetThickness.Bottom
            bounceAnimation.EasingFunction = backOrientation;

            control.BeginAnimation(UserControl.MarginProperty, bounceAnimation);
        }

        public static void addWipeDownAnnimation(UserControl control, double startingDistance)
        {
            ThicknessAnimation backAnimation = new ThicknessAnimation();
            BackEase backOrientation = new BackEase();
            double topMargin = (-1) * startingDistance;
            backOrientation.Amplitude = .4;
            backOrientation.EasingMode = EasingMode.EaseIn;
            //double ab = backOrientation.Ease(.7);
            //App.logger.Info("Ease pace : " + ab);
            backAnimation.To = new Thickness(0, 0, 0, 0);
            backAnimation.From = new Thickness(0, topMargin, 0, startingDistance);
            backAnimation.EasingFunction = backOrientation;
            //            double ab = backAnimation.;
            //          App.logger.Info("Ease pace : " + ab);
            //backAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));
            //backAnimation.DecelerationRatio = .9;
            backAnimation.SpeedRatio = .3;
            backAnimation.Completed += BackAnimation_Completed;
            control.BeginAnimation(UserControl.MarginProperty, backAnimation);
            App.logger.Info("Deceletation Ration : " + backAnimation.DecelerationRatio);
            App.logger.Info("Acceletation Ration : " + backAnimation.AccelerationRatio);
        }

        private static void BackAnimation_Completed(object sender, EventArgs e)
        {
            _loadingPage.Visibility = Visibility.Hidden;
        }

        public static string GetExceptionMessageWithStackTrace(Exception ex)
        {
            string msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            return "Message: " + msg + Environment.NewLine + "Stack Trace: " + ex.StackTrace;
        }

        public static void WriteErrorLog(Exception ex)
        {
            App.logger.Error(GetExceptionMessageWithStackTrace(ex));
        }

        //private void goToApp()
        //{
        //    MessageBox.Show("Hi, this is sample app");
        //}

    }
}
