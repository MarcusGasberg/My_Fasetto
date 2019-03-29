using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="MenuViewModel"/>
    /// </summary>
    public class MenuDesignModel : MenuViewModel
    {
        #region Singleton
        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MenuDesignModel Instance => new MenuDesignModel();

        #endregion 
        #region Constructo

        public MenuDesignModel()
        {
            Items = new List<MenuItemViewModel>()
            {
                new MenuItemViewModel() {MenuItemType = MenuItemType.Header, Text = "Design time header..."},
                new MenuItemViewModel() {Text = "Content item 1", IconType = IconType.File},
                new MenuItemViewModel() {Text = "Content item 2", IconType = IconType.Picture},
            };
        } 
        #endregion
    }
}