namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for a menu item
    /// </summary>
    public class MenuItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The text to display in the menu item
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The icon for this menu item
        /// </summary>
        public IconType IconType { get; set; }

        /// <summary>
        /// The type of this menu item
        /// </summary>
        public MenuItemType MenuItemType { get; set; }
    }
}