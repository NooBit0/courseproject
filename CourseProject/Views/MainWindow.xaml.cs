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
using CourseProject.Models.Users;
using CourseProject.Views;

namespace CourseProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Frame.Navigate(new AuthorizationPage());
            /*
            var temp = new List<Tenant>();
            var temp1 = new List<User>();

            using (var ctx = new UsersDbContext())
            {
                var stud = new Tenant() { Login = "user3", FullName = "Putin V V", Password = "12345", RetalPremisesId = { 1, 2, 3 }, Balance = 50 };
                ctx.Tenants.Add(stud);

                ctx.SaveChanges();
            }*/

            using (var ctx = new BildingsDbContext())
            {/*
                var stud = new Building() { Adress = "Gromova", Image = "1.png" };
                ctx.Buildings.Add(stud);

                var stud1 = new RentalPremises() { Area = 45, RentalNumber = 1, Image = "2.png", BuildingID = 1 };
                ctx.RentalPremises.Add(stud1);

                var stud2 = new PriceList();
                ctx.PriceLists.Add(stud2);

                ctx.SaveChanges();
                */
                // var f = ctx.PriceLists.Where(b => b.RentalPremises.RentalPremisesId == 1).Select(a => a.RentalPremises.Building.Adress);

                // MessageBox.Show(f.FirstOrDefault());
            }
        }
    }
}
