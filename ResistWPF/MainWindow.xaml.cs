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
        public MainWindow()
        {
            InitializeComponent();
            var testGame = new Game();

            //testGame.ResistIndex = testGame.SelectResistIndex;

         //   for (var i = 0; i < testGame.ResistIndex.Count; i++)
         //   {
         //       System.Diagnostics.Debug.WriteLine(testGame.ResistIndex[i]);
         //   }
        }
    }
}
