using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for the <see cref="BubbleContent"/>
    /// </summary>
    public class ChatAttachmentPopupMenuViewModel : BasePopupViewModel
    {
        #region Public Properties
        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChatAttachmentPopupMenuViewModel()
        {
            Content = new MenuViewModel()
            {
                Items = new List<MenuItemViewModel>()
                {
                    new MenuItemViewModel() {MenuItemType = MenuItemType.Header, Text = "Attach a file..."},
                    new MenuItemViewModel() {Text = "From Computer", IconType = IconType.File},
                    new MenuItemViewModel() {Text = "From Pictures", IconType = IconType.Picture},
                }
            };
        }
        #endregion
    }
}