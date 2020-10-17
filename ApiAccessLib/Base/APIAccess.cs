using ApiAccessLib.DTO;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;

namespace ApiAccessLib
{
    public class APIAccess : APIAccessBase
    {
        public APIAccess()
        {
            base.SetRestClient();
        }

        public UsersListResponseModel GetUsers()
        {

            var restRequest = SetUpRestRequest(TestData.USERS, Method.GET);
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var users = JsonConvert.DeserializeObject<UsersListResponseModel>(content);

            return users;
        }

        public UserResponseModel AddUser()
        {
            var restRequest = SetUpRestRequest(TestData.USERS, Method.POST);
            AddJsonBody(restRequest);
            IRestResponse response = restClient.Execute(restRequest);

            var content = response.Content;
            var user = JsonConvert.DeserializeObject<UserResponseModel>(content);
            TestData.UserData.USER_ID = user.Data.Id;

            return user;
        }

        public UserResponseModel AddUser(UserRequestModel newUser)
        {
            var restRequest = SetUpRestRequest(TestData.USERS, Method.POST);
            AddJsonBody(restRequest, newUser);
            IRestResponse response = restClient.Execute(restRequest);

            var content = response.Content;
            var user = JsonConvert.DeserializeObject<UserResponseModel>(content);
            TestData.UserData.USER_ID = user.Data.Id;

            return user;
        }

        public UserResponseModel GetUserByID(long id)
        {
            var restRequest = SetUpRestRequest(TestData.USERS + "/" + id, Method.GET);
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var user = JsonConvert.DeserializeObject<UserResponseModel>(content);
            return user;
        }

        public GetUserByEmailResponseModel GetUserByEmail(string email)
        {
            var restRequest = SetUpRestRequest(TestData.USERS + "/?email=" + TestData.UserData.USER.Email, Method.GET);
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var user = JsonConvert.DeserializeObject<GetUserByEmailResponseModel>(content);
            
            return user;
        }

        public DeleteUserResponseModel DeleteUserById(long id)
        {
            var restRequest = SetUpRestRequest(TestData.USERS + "/" + id, Method.DELETE);
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var deleteResponse = JsonConvert.DeserializeObject<DeleteUserResponseModel>(content);
            return deleteResponse;
        }

    }
}
