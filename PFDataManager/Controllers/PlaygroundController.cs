using PFDataManager.Library.DataAccess;
using PFDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PFDataManager.Controllers
{
    /// <summary>
    /// Controller for accessing playground information.
    /// </summary>
    [Authorize]
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        [Route("FilterByAge")]
        [HttpGet]
        public async Task<List<PlaygroundModel>> FilterByAgeAsync(string age)
        {
            PlaygroundData data = new PlaygroundData();
            return await data.FilterPlaygroundsByAgeAsync(age);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quadrant"></param>
        /// <returns></returns>
        [Route("FilterByQuadrant")]
        [HttpGet]
        public async Task<List<PlaygroundModel>> FilterByQuadrantAsync(string quadrant)
        {
            PlaygroundData data = new PlaygroundData();
            return await data.FilterPlaygroundsByQuadrantAsync(quadrant);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="groundCover"></param>
        /// <returns></returns>
        [Route("FilterByGroundCover")]
        [HttpGet]
        public async Task<List<PlaygroundModel>> FilterByGroundCoverAsync(string groundCover)
        {
            PlaygroundData data = new PlaygroundData();
            return await data.FilterPlaygroundsByGroundCoverAsync(groundCover);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        [Route("FilterBySize")]
        [HttpGet]
        public async Task<List<PlaygroundModel>> FilterBySizeAsync(string size)
        {
            PlaygroundData data = new PlaygroundData();
            return await data.FilterPlaygroundsBySizeAsync(size);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessibility"></param>
        /// <returns></returns>
        [Route("FilterByAccessibility")]
        [HttpGet]
        public async Task<List<PlaygroundModel>> FilterByAccessibilityAsync(string accessibility)
        {
            PlaygroundData data = new PlaygroundData();
            return await data.FilterPlaygroundsByAccessibilityAsync(accessibility);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        [Route("FilterByMultiple")]
        [HttpPost]
        public async Task<List<PlaygroundModel>> FilterByMultiple([FromBody] IDictionary<string,string> filters)
        {
            
            PlaygroundData data = new PlaygroundData();
            return await data.FilterPlaygroundsByMultipleAsync(filters);
        }


    }

    
}
