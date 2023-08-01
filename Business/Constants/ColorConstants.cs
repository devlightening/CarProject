using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class ColorConstants
    {
        public static string ColorAdded = "Color added successfully.";
        public static string ColorDeleted = "Color was successfully deleted.";
        public static string ColorUpdated = "Color information has been updated successfully.";

        public static string ColorNotAdded = "Failed to add color.";
        public static string ColorNotDeleted = "The color could not be deleted.";
        public static string ColorNotUpdated = "Failed to update color.";

        public static string AllColorGetted = "All Color information is fetched.";
        public static string AllColorNotGetted = "Failed to fetch information about colors.";

        public static string ColorGettedById = "Color is fetched";
        public static string ColorNotGettedById = "Failed to fetch color.";
        public static string ColorNameAlreadyExist = "A color with this name already exists";
    }
}