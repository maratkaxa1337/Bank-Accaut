using Bank.Context;
using Bank.Model;
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
            TxbFirst.Text = "";
            TxbLastName.Text = "";
            TxbPassportNumber.Text = "";
            TxbPassportSerial.Text = "";
            TxbPatronymic.Text = "";
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Passport passport1 = new Passport();
                {
                    passport1.LastName = TxbLastName.Text;
                    passport1.FirstName = TxbFirst.Text;
                    passport1.Patronymic = TxbPatronymic.Text;
                    passport1.DateResults = (DateTime)DateResults.SelectedDate;
                    passport1.IssuedWhom = TxbIssuedWhom.Text;
                    passport1.Gender = TxbGender.Text;
                    passport1.DateBrith = (DateTime)DateBritch.SelectedDate;
                    passport1.BirthPlace = TxbBritch.Text;
                    passport1.PassportSeries = Convert.ToInt32(TxbPassportSerial.Text);
                    passport1.PassportNumber = Convert.ToInt32(TxbPassportNumber.Text);


                ConnectContext.db.Passport.Add(passport1);
                ConnectContext.db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
