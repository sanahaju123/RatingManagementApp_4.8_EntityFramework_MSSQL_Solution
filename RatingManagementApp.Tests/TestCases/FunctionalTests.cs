

using RatingManagementApp.DAL.Interrfaces;
using RatingManagementApp.DAL.Services;
using RatingManagementApp.DAL.Services.Repository;
using RatingManagementApp.Models;
using RatingManagementApp.Tests.TestCases;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Rating = RatingManagementApp.Models.Rating;

namespace RatingManagementApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IRatingService _RatingService;
        public readonly Mock<IRatingRepository> Ratingservice = new Mock<IRatingRepository>();

        private readonly Rating _Rating;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Create_Rating()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Ratingservice.Setup(repos => repos.CreateRating(_Rating)).ReturnsAsync(_Rating);
                var result = await _RatingService.CreateRating(_Rating);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_Update_Rating()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Ratingservice.Setup(repos => repos.UpdateRating(_Rating)).ReturnsAsync(_Rating);
                var result = await _RatingService.UpdateRating(_Rating);
                if (result != null)
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
        public async Task<bool> Testfor_GetRatingById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Ratingservice.Setup(repos => repos.GetRatingById(id)).ReturnsAsync(_Rating);
                var result = await _RatingService.GetRatingById(id);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_DeleteRatingById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Ratingservice.Setup(repos => repos.DeleteRatingById(id)).ReturnsAsync(response);
                var result = await _RatingService.DeleteRatingById(id);
                //Assertion
                if (result != null)
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