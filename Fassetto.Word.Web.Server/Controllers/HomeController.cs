using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Operations;

namespace Fassetto.Word.Web.Server
{
    public class HomeController : Controller
    {
        #region Protected Members
        /// <summary>
        /// The scoped Application Context
        /// </summary>
        protected ApplicationDbContext _context;

        /// <summary>
        /// The manager for handling user creation, deletion, searching, roles, etc...
        /// </summary>
        protected UserManager<ApplicationUser> _userManager;

        /// <summary>
        /// The manager for handling sign in / out for users
        /// </summary>
        protected SignInManager<ApplicationUser> _signInManager;

        #endregion
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="context">The injected context</param>
        public HomeController(ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        #endregion
        public IActionResult Index()
        {
            //Make sure we have the database
            _context.Database.EnsureCreated();

            if (!_context.Settings.Any())
            {
                _context.Add(new SettingsDataModel()
                {
                    Name = "BackgroundColor",
                    Value = "Red"
                });

                var settingsLocally = _context.Settings.Local.Count;
                var settingsDatabase = _context.Settings.Count();

                var firstLocal = _context.Settings.Local.FirstOrDefault();
                var firstDatabase = _context.Settings.FirstOrDefault();

                _context.SaveChanges();
            }


            return View();
        }

        /// <summary>
        /// Creates our single user for now
        /// </summary>
        /// <returns></returns>
        [Route("create")]
        public async Task<IActionResult> CreateUserAsync()
        {
            var result = await _userManager.CreateAsync(new ApplicationUser()
            {
                UserName = "Slemmerten",
                Email = "mrgasberg@hotmail.com"
            }, "password");
            
            if(result.Succeeded)
                return Content("User was created", "text.html");

            return Content("User creation failed", "text.html");
        }


        /// <summary>
        /// Private are. No peeking
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [Route("private")]
        public IActionResult Private()
        {
            return Content($"This is a private area. Welcome {HttpContext.User.Identity.Name}", "text.html");
        }

        /// <summary>
        /// An auto-login page for testing
        /// </summary>
        /// <param name="returnUrl">The url to return to if successful login</param>
        /// <returns></returns>
        [Route("login")]
        public async Task<IActionResult> LoginAsync(string returnUrl)
        {
            //Sign out any previous session
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

            //Sign in user in with the valid credentials
            var result = await _signInManager.PasswordSignInAsync("Slemmerten", "password", true, false);
            if (result.Succeeded)
            {
                //if we have not return url go home
                if (string.IsNullOrEmpty(returnUrl))
                    RedirectToAction(nameof(Index));

                //Otherwise go to return url
                return Redirect(returnUrl);
            }

            return Content("Failed to login", "text/html");
        }
        /// <summary>
        /// An auto-login page for testing
        /// </summary>
        /// <param name="returnUrl">The url to return to if successful login</param>
        /// <returns></returns>
        [Route("logout")]
        public async Task<IActionResult> LogoutAsync(string returnUrl)
        {
            //Sign out the user
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
            return Content("done");
        }
    }
}
