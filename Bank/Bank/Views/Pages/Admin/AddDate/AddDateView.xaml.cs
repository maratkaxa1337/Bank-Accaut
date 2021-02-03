using Bank.Views.Pages.Admin.DataView;
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

namespace Bank.Views.Pages.Admin.AddDate
{
    /// <summary>
    /// Логика взаимодействия для AddDateView.xaml
    /// </summary>
    public partial class AddDateView : Page
    {
        public AddDateView()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewPage());
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TxbBritch.Text = "";
            TxbFirsName.Text = "";
            TxbName.Text = "";
            TxbPassportNumber.Text = "";
            TxbPassportSerial.Text = "";
            TxbPatronymic.Text = "";
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
