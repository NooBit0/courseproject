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
using CourseProject.Models;
using CourseProject.Views.UsersPages.TenantPages;

namespace CourseProject.Views.UsersPages
{
    /// <summary>
    /// Логика взаимодействия для TenantPage.xaml
    /// </summary>
    public partial class TenantPage : Page
    {
        private string _login;

        public TenantPage(string login)
        {
            InitializeComponent();

            _login = login;

            using (var user = new UsersDbContext())
            {
                InfoTextBox.Text = user.Tenants.Where(item => item.Login == login).First().ToString();
                BalansTextBlock.Text = user.Tenants.Where(item => item.Login == login).First().Balance.ToString();
                if (int.Parse(BalansTextBlock.Text) < 0)
                {
                    BalansTextBlock.Foreground = new SolidColorBrush(Colors.Red);
                }
            }
        }

        private void ReauthorizeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void ArendetPremisesButton_Click(object sender, RoutedEventArgs e)
        {
            TenantMenuFrame.Navigate(new ArendetPremisesPage(_login));
        }
    }
}
