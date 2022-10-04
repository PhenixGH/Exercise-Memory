using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace ExerciseMemory
{
    internal class SomeAnimation
    {
        public void Center_Screen(Window win)
        {
            double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            double screenWidth = SystemParameters.FullPrimaryScreenWidth;


            win.Top = (screenHeight - win.Height) / 0x00000002;
            win.Left = (screenWidth - win.Width) / 0x00000002;

        }

        public void Opacity_Animation<T>(T win) where T : UIElement
        {

            DoubleAnimation doubleAnimation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(1.3)
            };
            win.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
        }

        public void WidthAnimation<T>(T button, int width) where T : UIElement
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation
            {
                From = 0,
                To = width,
                Duration = TimeSpan.FromSeconds(2)
            };
            button.BeginAnimation(FrameworkElement.WidthProperty, doubleAnimation);
        }
    }
}
