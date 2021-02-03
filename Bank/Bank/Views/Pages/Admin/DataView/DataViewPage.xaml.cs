using Bank.Context;
using Bank.Model;
using Bank.Views.Pages.Admin.AddDate;
using Bank.Views.Pages.Home;
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

namespace Bank.Views.Pages.Admin.DataView
{
    /// <summary>
    /// Логика взаимодействия для DataViewPage.xaml
    /// </summary>
    public partial class DataViewPage : Page
    {
        public DataViewPage()
        {
            InitializeComponent();
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataView.ItemsSource = ConnectContext.db.Passport.Where(item => item.FirstName.Contains(TxbSearch.Text) || item.Gender.Contains(TxbSearch.Text)).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataView.ItemsSource = ConnectContext.db.Passport.ToList();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                 Passport removePassort = (Passport)DataView.SelectedItem;

                if (removePassort != null)
                    if (MessageBox.Show("Вы действительно хотите удалить данные строку?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) 
                {
                    {
                        ConnectContext.db.Passport.Remove(removePassort);
                        ConnectContext.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                }
                else
                {
                    throw new Exception("Вы не выбрали ни одного элемента");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddDateView());
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
