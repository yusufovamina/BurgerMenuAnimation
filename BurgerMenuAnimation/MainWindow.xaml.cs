using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BurgerMenuAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
            

        private void RectMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 130;
            animation.To = 70;
            animation.Duration = TimeSpan.FromSeconds(0.2);

            RectMenu.BeginAnimation(Rectangle.WidthProperty, animation);


            AnimateElementMargin(TextBlock1, new Thickness(0, 41, 5, 0), new Thickness(0, 41, 65, 0));
            AnimateElementMargin(TextBlock2, new Thickness(0, 41, 240, 0), new Thickness(0, 41, 300, 0));
            AnimateElementMargin(TextBlock3, new Thickness(0, 41, 493, 0), new Thickness(0, 41, 553, 0));
            AnimateElementMargin(ListBox1, new Thickness(0, 135, -8, 0), new Thickness(0, 135, 56, 0));
        }

        private void RectMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 70;
            animation.To = 130;
            animation.Duration = TimeSpan.FromSeconds(0.2);

            RectMenu.BeginAnimation(Rectangle.WidthProperty, animation);

            AnimateElementMargin(TextBlock1, new Thickness(0, 41, 65, 0), new Thickness(0, 41, 5, 0));
            AnimateElementMargin(TextBlock2, new Thickness(0, 41, 300, 0), new Thickness(0, 41, 240, 0));
            AnimateElementMargin(TextBlock3, new Thickness(0, 41, 553, 0), new Thickness(0, 41, 493, 0));
            AnimateElementMargin(ListBox1, new Thickness(0, 135, 56, 0), new Thickness(0, 135, -8, 0));
        }

        private void AnimateElementMargin(FrameworkElement element, Thickness from, Thickness to)
        {
            ThicknessAnimation animation = new ThicknessAnimation();
            animation.From = from;
            animation.To = to;
            animation.Duration = TimeSpan.FromSeconds(0.2);

            Storyboard.SetTarget(animation, element);
            Storyboard.SetTargetProperty(animation, new PropertyPath(FrameworkElement.MarginProperty));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);

            storyboard.Begin();
        }



    }
}
