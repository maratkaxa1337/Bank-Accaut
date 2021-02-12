using Bank.Model;
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

namespace Bank.Views.Pages.Admin.Edit
{
    /// <summary>
    /// Логика взаимодействия для EditView.xaml
    /// </summary>
    public partial class EditView : Page
    {
        private Passport selectitem;

        public EditView(Passport selectitem)
        {
            InitializeComponent();
            this.selectitem = selectitem;
            TxbFirst.Text = selectitem.FirstName;
            TxbLastName.Text = selectitem.LastName;
            TxbPatronymic.Text = selectitem.Patronymic;
            DateResults.SelectedDate = selectitem.DateResults;
            TxbIssuedWhom.Text = selectitem.IssuedWhom;
            TxbGender.Text = selectitem.Gender;
            TxbBritch.Text = selectitem.BirthPlace;
            DateBritch.SelectedDate = selectitem.DateBrith;
            TxbPassportSerial.Text = Convert.ToString(selectitem.PassportSeries);
            TxbPassportNumber.Text = Convert.ToString(selectitem.PassportNumber);

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
