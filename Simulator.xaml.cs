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
    /// Simulator.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Simulator : Window
    {
        public Simulator(bool IsWeapon, int Recipe_Pot, int Prev_Pot, int proficiency, int Tec)
        {
            InitializeComponent();
            MessageBox.Show($"{IsWeapon} / {Recipe_Pot} / {Prev_Pot} / {proficiency} / {Tec}");
        }
    }
}
