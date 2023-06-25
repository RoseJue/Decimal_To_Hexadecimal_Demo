using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Decimal_To_Hexadecimal_Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //乘10
            double a = double.Parse(Decimal.Text)*10;
            //转16进制
            Hexadecimal.Text = Convert.ToString(Convert.ToInt32(a), 16).ToUpper();
            //补齐4位
            string s = Hexadecimal.Text.ToString().PadLeft(4, '0');
            //12位与34位对调
            string str = String.Format("{0}{1}{2}{3}", $"{s[2]}", $"{s[3]}", $"{s[0]}", $"{s[1]}");
            final.Text = str;
        }
    }
}
