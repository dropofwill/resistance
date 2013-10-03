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

namespace ResistWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewControl viewCtr;

        public MainWindow()
        {
            InitializeComponent();
            viewCtr = new ViewControl();
            this.SetView(viewCtr.Menu);
        }

        public void SetView(UserControl aView)
        {
            ContentArea.Content = aView;
        }
    }

    public class ViewControl
    {
        private Views.MainMenuView _menu;
        private Views.HelpView _help;

        public UserControl Menu
        {
            get
            {
                if (_menu == null)
                    _menu = new Views.MainMenuView();
                return _menu;
            }
        }

        public UserControl Help
        {
            get
            {
                if (_help == null)
                    _help = new Views.HelpView();
                return _help;
            }
        }
    }
}
