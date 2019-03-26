using System;
using Microsoft.Extensions.DependencyInjection;

namespace Fassetto.Word.Web.Server.IoC
{
    /// <summary>
    /// A shorthand access class to get DI services
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// The scoped instance of the <see cref="ApplicationDbContext"/>
        /// </summary>
        public static ApplicationDbContext ApplicationDbContext =>
            IoCContainer.Provider.GetService<ApplicationDbContext>();
    }

    /// <summary>
    /// The dependency injection container making use of the built in .Net core service provider
    /// </summary>
    public static class IoCContainer
    {
        /// <summary>
        /// The service provider for this application
        /// </summary>
        public static IServiceProvider Provider { get; set; }
    }
}