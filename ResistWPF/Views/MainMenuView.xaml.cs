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

namespace ResistWPF.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : UserControl
    {
        private ViewControl viewController;

        public MainMenuView(ViewControl vC)
        {
            viewController = vC;
            InitializeComponent();
        }

        private void HowTo_btn_Click(object sender, RoutedEventArgs e)
        {
            viewController.SetView(viewController.Help);
        }

        private void StartGame_btn_Click(object sender, RoutedEventArgs e)
        {
            viewController.GameSelect((Button)sender);
        }

        private void CtnGame_btn_Click(object sender, RoutedEventArgs e)
        {
            viewController.GameSelect((Button)sender);
        }

        private void Scoreboard_btn_Click(object sender, RoutedEventArgs e)
        {
            viewController.SetView(viewController.Score);
        }

    }
}
