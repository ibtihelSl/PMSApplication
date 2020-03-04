﻿using Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using PMSApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CustomUserStore : UserStore<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public CustomUserStore(pmsContext context) : base(context)
        {

        }
    }
}
