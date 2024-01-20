using RatingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingManagementApp.DAL.Interrfaces
{
    public interface IRatingService
    {
        List<Rating> GetAllRatings();
        Task<Rating> CreateRating(Rating expense);
        Task<Rating> GetRatingById(long id);
        Task<bool> DeleteRatingById(long id);
        Task<Rating> UpdateRating(Rating model);
    }
}
