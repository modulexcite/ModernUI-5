using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ModernUI.Controls
{
    public class ModernWindow : Window
    {
        public static readonly DependencyProperty TitleBarHeightProperty =
            DependencyProperty.Register("TitleBarHeight", typeof(int), typeof(ModernWindow), new PropertyMetadata(36));
        
        public static readonly DependencyProperty TitleBarForgroundProperty =
           DependencyProperty.Register("TitleBarForground", typeof(Brush), typeof(ModernWindow));

        

        public ModernWindow()
        {
            //DefaultStyleKey = typeof(ModernWindow);
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ModernWindow), new FrameworkPropertyMetadata(typeof(ModernWindow)));
        }



        public Brush TitleBarForground
        {
            get { return (Brush)GetValue(TitleBarForgroundProperty); }
            set { SetValue(TitleBarForgroundProperty, value); }
        }

        public int TitleBarHeight
        {
            get { return (int)GetValue(TitleBarHeightProperty); }
            set { SetValue(TitleBarHeightProperty, value); }
        }
    }
}
