using RatingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RatingManagementApp.DAL.Services.Repository
{
    public class RatingRepository : IRatingRepository
    {
        private readonly DatabaseContext _dbContext;
        public RatingRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Rating> CreateRating(Rating expense)
        {
            try
            {
                var result =  _dbContext.Ratings.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteRatingById(long id)
        {
            try
            {
                _dbContext.Ratings.Remove(_dbContext.Ratings.Single(a => a.RatingId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Rating> GetAllRatings()
        {
            try
            {
                var result = _dbContext.Ratings.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Rating> GetRatingById(long id)
        {
            try
            {
                return await _dbContext.Ratings.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Rating> UpdateRating(Rating model)
        {
            var ex = await _dbContext.Ratings.FindAsync(model.RatingId);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}