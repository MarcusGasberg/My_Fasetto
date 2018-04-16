using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// a base page for all pages to gain base functionality
    /// </summary>
    public class BasePage<VM> : Page
        where VM : BaseViewModel, new()
    {
        #region Private Members
        /// <summary>
        /// Viewmodel associated with this page
        /// </summary>
        private VM mViewModel { get; set; }
        #endregion

        #region Public Properties
        /// <summary>
        /// The animation that plays when the page first loads
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation that plays when the page unloads
        /// </summary>
        public PageAnimation PageUnLoadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// How long the animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// Viewmodel associated with this page
        /// </summary>
        public VM ViewModel
        {
            get
            {
                return mViewModel;
            }
            set
            {
                //If nothing has changed return
                if (mViewModel == value)
                    return;
                //update the value
                mViewModel = value;

                //Set the data context for this page
                this.DataContext = mViewModel;
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage()
        {
            //If we are animating in, hide to begin with
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            //Listen out for the page loading
            this.Loaded += BasePage_Loaded;

            //Create a default view model
            this.ViewModel = new VM();
        }
        #endregion

        #region Animation load / unload
        /// <summary>
        /// Once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            //Animate the page in
            await AnimateIn();
        }

        /// <summary>
        /// Animates the page in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            //Make sure we have something to do
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:
                    //Start the animation
                    await this.SlideAndFadeInFromRight(this.SlideSeconds);
                    break;
            }
        }

        /// <summary>
        /// Animates the page out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            //Make sure we have something to do
            if (this.PageUnLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageUnLoadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:
                    //Start the animation
                    await this.SlideAndFadeOutToLeft(this.SlideSeconds);
                    break;
            }
        }
        
        #endregion
    }
}
