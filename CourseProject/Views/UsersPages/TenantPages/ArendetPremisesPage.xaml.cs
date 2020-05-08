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
using CourseProject.ViewModels;

namespace CourseProject.Views.UsersPages.TenantPages
{
    /// <summary>
    /// Логика взаимодействия для ArendetPremisesPagecs.xaml
    /// </summary>
    public partial class ArendetPremisesPage : Page
    {
        public ArendetPremisesPage(string login)
        {
            InitializeComponent();
            InfoTextBlock.Text = ViewModel.GetNewRentedPlace(login);
            (string rentalPremisesImage, string buildingImage) images = ViewModel.GetImages(login);
            BuildingImage.Source = new BitmapImage(new Uri($"/Resources/{images.buildingImage}.jpg", UriKind.Relative));
            RentalPremisesImage.Source = new BitmapImage(new Uri($"/Resources/{images.rentalPremisesImage}.jpg", UriKind.Relative));
            NavigationService.Navigate(new ArendetPremisesPage(login));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
