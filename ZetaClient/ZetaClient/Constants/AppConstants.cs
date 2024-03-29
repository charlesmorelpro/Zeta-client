﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZetaClient.Entities;
using ZetaClient.Entities.Enums;

namespace ZetaClient.Constants
{
    public static class AppConstants
    {
        public static string BaseApiUrl { get; set; }
        public static string ApiKey { get; set; }
        public static UserDepartment CurrentUserDepartment { get; set; }
    }
}
