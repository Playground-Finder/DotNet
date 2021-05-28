using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDataManager.Library.DataAccess
{
    public class FilterFieldsData
    {
        /// <summary>
        /// Provides the combobox entries for the specified filter
        /// </summary>
        /// <param name="FilterName">The name of the filter</param>
        /// <returns>A string list of the filter options</returns>
        public List<string> GetFilter(string FilterName)
        {
            //TODO: These should be extracted to a localization file, not hard coded here. 
            switch (FilterName)
            {
                case "AgeFilter":
                    return new List<string> { "Junior", "Senior", "Junior/Senior" };
                case "AccessibilityFilter":
                    return new List<string> { "WheelChair", "Elderly" };
                case "GroundCoverFilter":
                    return new List<string> { "Artificial Turf","Asphalt","Rock Cover","Rubber Chips","Rubber Matted","Sand","Wood Cover" };
                case "SizeFilter":
                    return new List<string> { "Small", "Large" };
                case "QuadrantFilter":
                    return new List<string> { "NW","NE","SE","SW"};
                default:
                    return new List<string> { "null" };
            }
        }

    }
}
