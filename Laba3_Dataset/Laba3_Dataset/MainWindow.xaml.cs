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
using Laba3_Dataset.FitnessClub1DataSetTableAdapters;

namespace Laba3_Dataset
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>Ы
    public partial class MainWindow : Window
    {
        MembersTableAdapter members = new MembersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource = members.GetDataBy();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            dg.Columns[0].Visibility = Visibility.Collapsed;
        }
    }
}
