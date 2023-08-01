using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Business.Constants
{
    public static class CarImageConstants
    {
        public static string CarImagesLimitExceded = "A car can have a maximum of 5 images.";
        public static string CarImagesNotFound = "No picture of the car was found.";
        public static string CarImagesAdded = "The car image has been successfully uploaded to the system.";
        public static string CarImagesUpdated = "The car picture has been successfully updated.";
        public static string CarImagesDeleted = "The car image has been successfully deleted.";
        public static string CarImagesGettedByCarId = "Pictures of the car have been successfully retrieved.";
        public static string CarImagesGettedById = "The car was brought with the official id.";
        public static string AllCarImagesGetted = "All car pictures have been brought.";
    }
}