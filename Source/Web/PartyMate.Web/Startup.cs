﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartyMate.Web.Startup))]
namespace PartyMate.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}