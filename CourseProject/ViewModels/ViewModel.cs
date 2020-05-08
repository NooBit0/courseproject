using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Text;
using CourseProject.ButtonFunctions;
using CourseProject.Models;
using CourseProject.Models.ProjectClases;
using CourseProject.Models.Users;

namespace CourseProject.ViewModels
{
    public class ViewModel
    {
        public ViewModel()
        {
            UserDataBase = new UsersDbContext();
            CoursesProjectDataBase = new BildingsDbContext();
            CoursesProjectDataBase.Buildings.Load();
            CoursesProjectDataBase.RentalPremises.Load();
            UserDataBase.Accountants.Load();
            UserDataBase.Administrators.Load();
            UserDataBase.Owners.Load();
            UserDataBase.Tenants.Load();
            UserDataBase.TenantRentalPremises.Load();
        }

        public UsersDbContext UserDataBase { get; set; }

        public BildingsDbContext CoursesProjectDataBase { get; set; }

        public static string GetNewRentedPlace(string login) => new NewRentedPlace(NewRentedPlace.GetIdformDataBase(login)).ToString();

        public static (string, string) GetImages(string login) => NewRentedPlace.GetImages(login);

        public static bool CheckLogin(string login) => Registration.CheckLogin(login);

        public static User CheckAuthorization(string login, string password) => Authorization.CheckAuthorization(login, password);

        public static void RegistrationUser(string fullName, string login, string password) => Registration.RegistrationUser(fullName, login, password);

        public ObservableCollection<Accountant> GetAccountants() => UserDataBase.Accountants.Local;

        public ObservableCollection<Administrator> GetAdministrators() => UserDataBase.Administrators.Local;

        public ObservableCollection<Owner> GetOwners() => UserDataBase.Owners.Local;

        public ObservableCollection<Tenant> GetTenants() => UserDataBase.Tenants.Local;

        public ObservableCollection<Building> GetBildings() => CoursesProjectDataBase.Buildings.Local;

        public ObservableCollection<RentalPremises> GetRentalPremises() => CoursesProjectDataBase.RentalPremises.Local;

        public ObservableCollection<TenantRentalPremises> GetTenantRentalPremises() => UserDataBase.TenantRentalPremises.Local;

        public string GetAdress() => GetAdress();

        public void UsersDbSave() => UserDataBase.SaveChanges();

        public void CourseProjectDbSave() => CoursesProjectDataBase.SaveChanges();
    }
}
