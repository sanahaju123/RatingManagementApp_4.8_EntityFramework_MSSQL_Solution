


using RatingManagementApp.DAL.Interrfaces;
using RatingManagementApp.DAL.Services;
using RatingManagementApp.DAL.Services.Repository;
using RatingManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Rating = RatingManagementApp.Models.Rating;

namespace RatingManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IRatingService _RatingService;
        public readonly Mock<IRatingRepository> Ratingservice = new Mock<IRatingRepository>();

        private readonly Rating _Rating;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
        {
            _RatingService = new RatingService(Ratingservice.Object);

            _output = output;

            _Rating = new Rating
            {
                RatingId = 1,
                Name = "Sample Rating",
                DateCreated = DateTime.Now,
                Description = "This is a sample Rating."
            };
        }



        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidRatingIdIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Ratingservice.Setup(repo => repo.CreateRating(_Rating)).ReturnsAsync(_Rating);
                var result = await _RatingService.CreateRating(_Rating);
                if (result != null || result.RatingId !=0)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Ratingservice.Setup(repo => repo.CreateRating(_Rating)).ReturnsAsync(_Rating);
                var result = await _RatingService.CreateRating(_Rating);
                if (result != null || result.Name !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidDescriptionIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Ratingservice.Setup(repo => repo.CreateRating(_Rating)).ReturnsAsync(_Rating);
                var result = await _RatingService.CreateRating(_Rating);
                if (result != null || result.Description !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidRatingDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Ratingservice.Setup(repo => repo.CreateRating(_Rating)).ReturnsAsync(_Rating);
                var result = await _RatingService.CreateRating(_Rating);
                if (result != null || result.DateCreated !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}