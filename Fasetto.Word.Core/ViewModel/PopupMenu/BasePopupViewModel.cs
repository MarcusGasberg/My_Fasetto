using Fasetto.Word.Core;

namespace Fasetto.Word
{
    /// <summary>
    /// A view model for the <see cref="BubbleContent"/>
    /// </summary>
    public class BasePopupViewModel : BaseViewModel
    {
        #region Public Properties
        /// <summary>
        /// The background color of the bubble in ARGB value
        /// </summary>
        public string BubbleBackground { get; set; }
        

        /// <summary>
        /// The alignment of the bubble arrow
        /// </summary>
        public ElementHorizontalAlignment ArrowAlignment { get; set; }

        /// <summary>
        /// The content inside this pop up menu
        /// </summary>
        public BaseViewModel Content { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public BasePopupViewModel()
        {
            //TOdO: Move colors into Core and make use of it here
            BubbleBackground = "ffffff";
            ArrowAlignment = ElementHorizontalAlignment.Left;
        }
        #endregion
    }
}