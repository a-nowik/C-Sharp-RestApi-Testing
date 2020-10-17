using ApiAccessLib.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAccessLib
{
    public static class TestData
    {
        public static readonly string BASE_URL = "https://gorest.co.in/";
        public static readonly string USERS = "/public-api/users";

        public static readonly string TOKEN = "11ea50116743119d560b49d1f008b52aeb436fe7d58eaf50064a22a25fc01937";

        public static class UserData
        {
            public static long USER_ID;
            public static UserRequestModel USER;
        }
    }
}
