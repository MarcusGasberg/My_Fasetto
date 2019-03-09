using Fasetto.Word.Core;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        #region Dependcy Properties

        /// <summary>
        /// The current page to show in the page host
        /// </summary>
        public BasePage CurrentPage
        {
            get => (BasePage)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }

        /// <summary>
        /// Registers <see cref="CurrentPage"/> as a dependency property
        /// </summary>
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new UIPropertyMetadata(CurrentPagePropertyChanged));

        #endregion

        #region Constructor
        /// <summary>
        /// Default 
        /// Constructor
        /// </summary>
        public PageHost()
        {
            InitializeComponent();
            //If we are in design mode show the current page
            //As the dependency object doesnt fire
            if(DesignerProperties.GetIsInDesignMode(this))
                NewPage.Content = (BasePage)new ApplicationPageValueConverter().Convert(IoC.Get<ApplicationViewModel>().CurrentPage);
        }

        #endregion

        #region Property Changed Event
        /// <summary>
        /// Called when the <see cref="CurrentPage"/> has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
            //Get the frames
            var newPageFrame = (d as PageHost).NewPage;
            var oldPageFrame = (d as PageHost).OldPage;

            //Store the current pagee content as the old page
            var oldPageContent = newPageFrame.Content;

            //Remove the current page from new page frame
            newPageFrame.Content = null;

            //Move the previous page into the old page frame
            oldPageFrame.Content = oldPageContent;

            //Animate out previous page when the Loaded event fires
            //right after this call due to moving frames
            if (oldPageContent is BasePage oldPage)
            {
                //Tell old page to animate out
                oldPage.ShouldAnimateOut = true;

                //Once it is done, remove it
                Task.Delay((int)(oldPage.SlideSeconds*1000)).ContinueWith((T)=>
                {
                    //Remove old page
                    Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
                    
                });
            }

            //Set the new page content
            newPageFrame.Content = e.NewValue;
        }
        #endregion
    }
}
