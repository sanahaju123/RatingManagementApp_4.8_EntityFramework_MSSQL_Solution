using RatingManagement.Models;
using RatingManagementApp.DAL.Interrfaces;
using RatingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RatingManagementApp.Controllers
{
    public class RatingController : ApiController
    {
        private readonly IRatingService _service;
        public RatingController(IRatingService service)
        {
            _service = service;
        }
        public RatingController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Rating/CreateRating")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateRating([FromBody] Rating model)
        {
            var leaveExists = await _service.GetRatingById(model.RatingId);
            var result = await _service.CreateRating(model);
            return Ok(new Response { Status = "Success", Message = "Rating created successfully!" });
        }


        [HttpPut]
        [Route("api/Rating/UpdateRating")]
        public async Task<IHttpActionResult> UpdateRating([FromBody] Rating model)
        {
            var result = await _service.UpdateRating(model);
            return Ok(new Response { Status = "Success", Message = "Rating updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Rating/DeleteRating")]
        public async Task<IHttpActionResult> DeleteRating(long id)
        {
            var result = await _service.DeleteRatingById(id);
            return Ok(new Response { Status = "Success", Message = "Rating deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Rating/GetRatingById")]
        public async Task<IHttpActionResult> GetRatingById(long id)
        {
            var expense = await _service.GetRatingById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Rating/GetAllRatings")]
        public async Task<IEnumerable<Rating>> GetAllRatings()
        {
            return _service.GetAllRatings();
        }
    }
}
