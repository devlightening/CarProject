using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {

        public static string InvalidName = "Name must be at least 2 characters";
        public static string MaintenanceTime = "maintenance break";
        public static string DailyRentalFee = "The daily rental fee cannot be 0 or less than 0";
        public static string VehicleNotFound = "No rental car found";
        public static string AutomaticIncrementField = "Auto increment field value cannot be entered";

        //EveryThingUse\\
        public static string Added = "Added";
        public static string Deleted = "Deleted";
        public static string Updated = "Updated";
        public static string Listed = "Listed";

        //CAR MESSAGES\\
        public static string AddedCar = "Added the Car";
        public static string ListedCar = "Listed the Cars.";
        public static string UpdatedCar = "Updated the Car";
        public static string DeletedCar = "Deleted the Car";
        public static string CarNameInValid = "Car name must be at least two characters";
        public static string CarPriceIsNegative = "Car daily price must be greater than 0";

        //BRAND MESSAGES\\
        public static string AddedBrand = "Added the Brand";
        public static string UpdatedBrand = "Updated the Brand";
        public static string DeletedBrand = "Deleted the Brand";
        public static string BrandNameInValid = "Brand name must be at least two charactersd";


        //COLOR MESSAGES\\
        public static string AddedColor = "Added the Color";
        public static string UpdatedColor = "Updated the Color";
        public static string DeletedColor = "Deleted the Color";
        public static string ColorNameInValid = "Color name must be at least two characters";

        //RENTAL MESSAGES\\
        public static string CarNotReturn = "İstediğiniz araç henüz teslim edilmemiş";

        //CARİMAGES MESSAGES\\
        public static string CarImagesAdded = "Added the Car Images";
        public static string CarImagesUpdated = "Updated the  Car Images";
        public static string CarImagesDeleted = "Deleted the  Car Images";
        public static string CheckIfCarImagesCarLimit = "A car can have up to 5 images.";

        //User logIn\\
        public static string AuthorizationDenied = "You are not authorized.";
        public static string UserNotFound = "User not found!";
        public static string PasswordError = "Password is incorrect!";
        public static string SuccessfulLogin = "Login successful.";
        public static string UserAlreadyExists = "This user already exists";
        public static string UserRegistered = "User registered successfully.";
        public static string AccessTokenCreated = "Access token successfully created";

        //Branch\\
        public static string AllBranchGetted = "All branches brought";
        public static string BranchGettedById = "The branch was brought";
        public static string BranchDeleted = "Branch deleted.";
        public static string BranchUpdated = "Branch updated";
        public static string BranchAdded = "Branch added.";
        public static string BranchLimitExceeded = "The maximum branch limit you can add has been exceeded.";
        public static string BranchNameAlreadyExist = "A branch with this name already exists.";


    }

}

