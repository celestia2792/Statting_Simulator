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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Statting_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int proficiency, Tec;
        public MainWindow()
        {
            InitializeComponent();
            proficiency = 0;
            Tec = 255;
            RPbox.Text = "46";
            STbox.Text = "89";
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            bool IsWeapon = TypeBox.SelectedIndex != 1;
            Simulator IW = new(IsWeapon, Convert.ToInt32(RPbox.Text), Convert.ToInt32(STbox.Text)
                , proficiency, Tec);
            _ = IW.ShowDialog();
        }

        private void GoSetting(object sender, RoutedEventArgs e)
        {
            Setting IW = new(proficiency,Tec);
            if (IW.ShowDialog() == true)
            {
                proficiency = Convert.ToInt32(IW.PBox.Text);
                Tec = Convert.ToInt32(IW.TBox.Text);
            }
        }
    }
}
