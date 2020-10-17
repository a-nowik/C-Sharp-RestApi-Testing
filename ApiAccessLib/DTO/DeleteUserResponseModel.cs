using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAccessLib.DTO
{
    public class DeleteUserResponseModel
    {
        public long Code { get; set; }
        public object Meta { get; set; }
        public object Data { get; set; }
    }
}
