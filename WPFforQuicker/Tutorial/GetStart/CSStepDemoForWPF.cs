using Quicker.Public;
using System.Windows;
using System.Windows.Controls;

namespace WPFforQuicker.Tutorial.GetStart
{
    public class CSStepDemoForWPF
    {
        public static void Exec(IStepContext context)
        {
            //一个窗口
            var window = new Window()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            //设置文字内容
            window.Content = new TextBlock()
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Text = "Hello World!",
                FontSize = 50
            };
            //显示窗口
            window.Show();
        }
        public static void UIThreadDemo()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                //在这里写上你的代码
            });
        }
    }
}
