﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Configuring_Yahoo_Sign_In_for_MVC.Startup))]
namespace Configuring_Yahoo_Sign_In_for_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
