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

namespace CourseProject.Views.UsersPages
{
    /// <summary>
    /// Логика взаимодействия для OwnerPage.xaml
    /// </summary>
    public partial class OwnerPages : Page
    {
        public OwnerPages(string login)
        {
            InitializeComponent();
            using (var user = new UsersDbContext())
            {
                InfoTextBox.Text = user.Owners.Where(item => item.Login == login).First().ToString();
            }
        }

        private void ShowStatsButton_Click(object sender, RoutedEventArgs e)
        {
            OwnerMenuFrame.Navigate(new UsersPages.OwnerPage.StatsPage());
        }

        private void ReauthorizeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
