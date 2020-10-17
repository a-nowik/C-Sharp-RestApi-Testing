using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAccessLib.DTO
{
    public partial class GetUserByEmailResponseModel
    {
        public long Code { get; set; }
        public Meta Meta { get; set; }
        public Datum[] Data { get; set; }

    }

    //public partial class Datums
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string Gender { get; set; }
    //    public string Status { get; set; }
    //    public DateTimeOffset CreatedAt { get; set; }
    //    public DateTimeOffset UpdatedAt { get; set; }
    //}

    //public partial class Metas
    //{
    //    public Pagination Paginations { get; set; }
    //}

    //public partial class Paginations
    //{
    //    public long Total { get; set; }
    //    public long Pages { get; set; }
    //    public long Page { get; set; }
    //    public long Limit { get; set; }
    //}

}
