using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IdentityPolicy
{
    public static class SignInAccountPolicy
    {
        public static void Configure(IdentityOptions options)
        {
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;
        }
    }
}
