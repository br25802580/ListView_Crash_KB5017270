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

namespace CrashWithListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyList.Items.Add("111");
            MyList.Items.Add("222");
            MyList.Items.Add("333");
            MyList.Items.Add("444");
        }

        private void AddItemBtn_Click(object sender, RoutedEventArgs e)
        {
            MyList.Items.Add("555");
        }
    }
}
