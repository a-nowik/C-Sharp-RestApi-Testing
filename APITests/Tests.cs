using System;
using ApiAccessLib;
using ApiAccessLib.DTO;
using NUnit.Framework;



namespace APITests 
{
    public class Tests : TestBase
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            apiAccess = new APIAccess();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            apiAccess = null;
            GC.Collect();
        }

        [Test]
        [Order(1)]
        public void CheckIfUserDontExist()
        {
            UserRequestModel user = apiAccess.GetUserPayload();
            var response = apiAccess.GetUserByEmail(TestData.UserData.USER.Email);
            Assert.AreEqual(0, response.Data.Length);
        }

        [Test]
        [Order(2)]
        public void GetUsers()
        {
            var response = apiAccess.GetUsers();
            Assert.AreEqual(200, response.Code);
           // Assert.AreEqual("Female", response.Data[0].Gender.ToString());
        }

        [Test]
        [Order(3)]
        public void AddUser()
        {
            var response = apiAccess.AddUser();
            Assert.AreEqual(201, response.Code);
        }

        [Test]
        [Order(4)]
        public void GetUserById()
        {
            var response = apiAccess.GetUserByID(TestData.UserData.USER_ID);
            Assert.AreEqual(200, response.Code);
        }

        [Test]
        [Order(5)]
        public void GetUserByEmail()
        {
            var response = apiAccess.GetUserByEmail(TestData.UserData.USER.Email);
            Assert.AreEqual(TestData.UserData.USER_ID, response.Data[0].Id);
        }

        [Test]
        [Order(6)]
        public void DeleteUserById()
        {
            var response = apiAccess.DeleteUserById(TestData.UserData.USER_ID);
            Assert.AreEqual(204, response.Code);
        }

        [Test]
        [Order(7)]
        public void DeleteNotExistedUser()
        {
            var response = apiAccess.DeleteUserById(TestData.UserData.USER_ID);
            Assert.AreEqual(404, response.Code);
        }

    }
}
