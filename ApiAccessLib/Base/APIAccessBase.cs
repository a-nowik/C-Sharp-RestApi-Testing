using ApiAccessLib.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAccessLib
{
    public abstract class APIAccessBase
    {

        protected IRestClient restClient;
        protected void SetRestClient()
        {
            restClient = new RestClient(TestData.BASE_URL);
        }

        protected IRestRequest SetUpRestRequest(string path, Method method)
        {
            var restRequest = new RestRequest(path, method);

            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            if(method == Method.PUT || method == Method.POST || method == Method.PATCH || method == Method.DELETE)
            {
                restRequest.AddHeader("authorization", String.Format("Bearer {0}", TestData.TOKEN));
            }

            return restRequest;
        }

        private UserRequestModel AddUserPayload(string name, string gender)
        {
            string uniqueSuffix = DateTime.Now.Ticks.ToString();
            string email = String.Format("{0}{1}@gmail.com", name.Replace(" ", ""), uniqueSuffix.Substring(uniqueSuffix.Length - 8));
            UserRequestModel user = new UserRequestModel()
            {
                Name = name,
                Email = email,
                Gender = gender,
                Status = "Active"
            };
            TestData.UserData.USER = user;
            return user;
        }

        public UserRequestModel GetUserPayload()
        {
            return AddUserPayload("Tester Tester", "Female");
        }

        protected void AddJsonBody(IRestRequest restRequest)
        {
            UserRequestModel userRequest = AddUserPayload("Tester Tester", "Male");
            string userRequestPayload = JsonConvert.SerializeObject(userRequest);
            restRequest.AddJsonBody(userRequestPayload);
        }

        protected void AddJsonBody(IRestRequest restRequest, UserRequestModel user) 
        {
            string userRequestPayload = JsonConvert.SerializeObject(user);
            restRequest.AddJsonBody(userRequestPayload);
        }
    }
}
