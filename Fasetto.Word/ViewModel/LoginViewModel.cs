using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// View model for the a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties
        /// <summary>
        /// Email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Flag indicating if LoginIsRunning
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion
        #region Commands
        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }
        #endregion
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            //Create Commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
        }

        #endregion

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async() => 
            {
                await Task.Delay(500);
                var email = this.Email;
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure(); //Never store password in variable!!    
            });
        }
    }
}
