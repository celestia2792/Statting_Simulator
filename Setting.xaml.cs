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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Statting_Simulator
{
    /// <summary>
    /// Setting.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Setting : Window
    {
        private int Temp_P;
        private int Temp_T;
        public Setting(int Prof, int Tec)
        {
            InitializeComponent();
            PBox.Text = $"{Prof}";
            TBox.Text = $"{Tec}";
            Temp_P = Prof;
            Temp_T = Tec;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(PBox.Text) < 0 || Convert.ToInt32(PBox.Text) > 300 ||
                    Convert.ToInt32(TBox.Text) > 255 || Convert.ToInt32(TBox.Text) < 0)
                    throw new Exception();
            }
            catch (Exception)
            {
                PBox.Text = $"{Temp_P}";
                TBox.Text = $"{Temp_T}";
                MessageBox.Show("유효한 값을 입력해주세요");
                return;
            }
            DialogResult = true;
        }
    }
}
