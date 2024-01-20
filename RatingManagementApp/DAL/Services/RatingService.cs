using RatingManagementApp.DAL.Interrfaces;
using RatingManagementApp.DAL.Services.Repository;
using RatingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RatingManagementApp.DAL.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _repository;

        public RatingService(IRatingRepository repository)
        {
            _repository = repository;
        }

        public Task<Rating> CreateRating(Rating expense)
        {
            return _repository.CreateRating(expense);
        }

        public Task<bool> DeleteRatingById(long id)
        {
            return _repository.DeleteRatingById(id);
        }

        public List<Rating> GetAllRatings()
        {
            return _repository.GetAllRatings();
        }

        public Task<Rating> GetRatingById(long id)
        {
            return _repository.GetRatingById(id); ;
        }

        public Task<Rating> UpdateRating(Rating model)
        {
            return _repository.UpdateRating(model);
        }
    }
}