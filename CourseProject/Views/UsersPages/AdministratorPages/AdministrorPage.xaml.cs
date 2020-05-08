using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace CourseProject.Views.UsersPages.AdministratorPages
{
    /// <summary>
    /// Логика взаимодействия для AdministrarorPage.xaml
    /// </summary>
    public partial class AdministratorPage : Page
    {
        public AdministratorPage(string login)
        {
            InitializeComponent();
            using (var user = new UsersDbContext())
            {
                InfoTextBox.Text = user.Administrators.Where(item => item.Login == login).First().ToString();
            }
        }

        private void ListUsersButton_Click(object sender, RoutedEventArgs e)
        {
            AdminMenuFrame.Navigate(new ListUsersPage());
        }

        private void ListBildingsButton_Click(object sender, RoutedEventArgs e)
        {
            AdminMenuFrame.Navigate(new ListBildingsPage());
        }

        private void ShowStatisticButton_Click(object sender, RoutedEventArgs e)
        {
            AdminMenuFrame.Navigate(new ShowStatisticPage());
        }

        private void ReauthorizeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
