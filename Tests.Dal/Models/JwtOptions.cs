﻿#nullable disable

namespace Tests.Dal.Models
{
    public partial class JwtOption
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Key { get; set; }
        public int Lifetime { get; set; }
    }
}
