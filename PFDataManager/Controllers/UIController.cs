using PFDataManager.Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PFDataManager.Controllers
{
    [RoutePrefix("api/UI")]
    public class UIController : ApiController
    {
        /// <summary>
        /// Provides the contents of the combobox for the requested filter.
        /// </summary>
        /// <param name="FilterName">Name of the filter field</param>
        /// <returns>String list of the filter options</returns>
        [Route("GetFilter")]
        public List<string> GetFilter(string FilterName)
        {
            FilterFieldsData data = new FilterFieldsData();
            return data.GetFilter(FilterName);
        }
    
    }
}
