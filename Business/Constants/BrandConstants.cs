using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class BrandConstants
    {
        public static string BrandAdded = "The brand has been successfully added.";
        public static string BrandDeleted = "The brand has been successfully deleted.";
        public static string BrandUpdated = "Brand information has been successfully updated.";
        public static string BrandNotAdded = "The brand could not be added.";
        public static string BrandNotDeleted = "The brand could not be deleted.";
        public static string BrandNotUpdated = "The brand could not be updated.";
        public static string AllBrandGetted = "All Brand information has been brought.";
        public static string AllBrandNotGetted = "Brand information could not be retrieved.";
        public static string BrandGettedById = "Brand brought";
        public static string BrandNotGettedById = "The brand could not be brought.";
        public static string MaximumBrandLimitExceeded = "The brand limit you can add has been exceeded.";
        public static string BrandNameExists = "A brand with this name already exists.";
        public static string BrandIsHaveCarCantDeleted = "You cannot delete the brand because it is a vehicle belonging to this brand.";
    }
}