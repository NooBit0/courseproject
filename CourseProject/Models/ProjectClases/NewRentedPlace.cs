using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models.ProjectClases
{
    public class NewRentedPlace
    {
        public NewRentedPlace()
        {
        }

        public NewRentedPlace(int rentalPremisesId)
        {
            using (var bildings = new BildingsDbContext())
            {
                RentalPremises = bildings.RentalPremises.Where(b => b.RentalPremisesId == rentalPremisesId).First();
                Adress = bildings.RentalPremises.Where(b => b.RentalPremisesId == rentalPremisesId).Select(a => a.Building.Adress).First().ToString();
            }
        }

        public RentalPremises RentalPremises { get; set; }

        public string Adress { get; set; }

        /*public static int[] GetRentalPremisesList(string login)
        {
            var users = new UsersDbContext();
            return users.Tenants.Where(a => a.Login == login).SelectMany(a => a.TenantRentalPremises);
        }*/

        public static int GetIdformDataBase(string login)
        {
            var users = new UsersDbContext();
            int temp = users.Tenants.Where(a => a.Login == login).Select(a => a.TenantRentalPremises.FirstOrDefault().RentalPremisesId).First();

            return temp;
        }

        public static (string, string) GetImages(string login)
        {
            var users = new UsersDbContext();
            int tenantRentalPremisesId = users.Tenants.Where(a => a.Login == login).Select(a => a.TenantRentalPremises.FirstOrDefault().TenantRentalPremisesId).First();
            var bildings = new BildingsDbContext();
            string rentalPremisesImage = bildings.RentalPremises.Where(a => a.RentalPremisesId == tenantRentalPremisesId).Select(a => a.Image).FirstOrDefault();
            string bildingPremisesImage = bildings.RentalPremises.Where(a => a.RentalPremisesId == tenantRentalPremisesId).Select(a => a.Building.Image).FirstOrDefault();
            return (rentalPremisesImage, bildingPremisesImage);
        }

        public string GetBuildingImage() => RentalPremises.Building.Image;

        public string GetAdress() => Adress;

        public override string ToString()
        {
            return $"{Adress} \n\n {RentalPremises.Price.ToString()} \n\n {RentalPremises.Area.ToString()} \n\n" +
                $"{RentalPremises.RentalBeginDate.ToString()} \n\n {RentalPremises.RentalEndDate.ToString()} \n\n" +
                $"{RentalPremises.RentalNumber.ToString()}";
        }
    }
}
