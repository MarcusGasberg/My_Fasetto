using Ninject;
using System;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The ioc container for our application
    /// </summary>
    public static class IoC
    {
        #region Public Properties
        /// <summary>
        /// The kernel for our IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        /// <summary>
        /// A shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static IUIManager UI => IoC.Get<IUIManager>();


        /// <summary>
        /// A shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static ApplicationViewModel ApplicationVm => IoC.Get<ApplicationViewModel>();


        /// <summary>
        /// A shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static SettingsViewModel SettingsVm => IoC.Get<SettingsViewModel>();
        #endregion

        #region Construction
        /// <summary>
        /// Sets up the IoC container, binds all information required and is ready for use
        /// NOTE: Must be called as soon as your application start up to ensure
        /// all services can be found
        /// </summary>
        public static void Setup()
        {
            //Bind all required view models
            BindViewModels();
        }

        /// <summary>
        /// Binds all singleton view models
        /// </summary>
        private static void BindViewModels()
        {
            //Bind to a single instance of ApplicationViewModel
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
            Kernel.Bind<SettingsViewModel>().ToConstant(new SettingsViewModel());
        }
        #endregion

        /// <summary>
        /// Get's a service from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
