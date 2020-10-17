using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAccessLib.DTO
{
    public partial class UserResponseModel
    {
        public long Code { get; set; }
        public object Meta { get; set; }
        public Data Data { get; set; }
    }

    public partial class Data
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
