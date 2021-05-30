using PFDataManager.Library.DataAccess;
using PFDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PFDataManager.Controllers
{
    /// <summary>
    /// Controller for accessing playground information.
    /// </summary>
    [RoutePrefix("api/playground")]
    public class PlaygroundController : ApiController
    {
        /// <summary>
        /// Returns all playgrounds
        /// </summary>
        /// <returns>Playground Model List</returns>
        [Route("GetAll")]
        public List<PlaygroundModel> GetAll()
        {
            PlaygroundData data = new PlaygroundData();
            return data.GetAll();
        }
    }
}
