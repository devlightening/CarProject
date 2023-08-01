using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class CarConstants
    {
        public static string CarAdded = "The car has been successfully added.";
        public static string CarDeleted = "The car was successfully deleted.";
        public static string CarUpdated = "The car information has been successfully updated.";
        public static string CarNotAdded = "The car could not be added.";
        public static string CarNotDeleted = "The car could not be deleted.";
        public static string CarNotUpdated = "The car could not be updated.";
        public static string AllCarGetted = "All car information has been brought.";
        public static string AllCarNotGetted = "The information of the cars could not be retrieved.";
        public static string CarGettedById = "The car was brought";
        public static string CarNotGettedById = "Couldn't bring the car.";
        public static string CarNameAlreadyExists = "There is a vehicle with the same name.";
        public static string CarCountOfBrandCorrect = "Maximum number of brands reached.";
    }
}