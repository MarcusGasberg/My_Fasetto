using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// View model for the custom dialog
    /// </summary>
    public class DialogWindowViewModel : WindowViewModel
    {
        #region Private Members

        public string Title { get; set; }

        public Control Content { get; set; }

        #endregion
        #region Public Properties

        #endregion
        #region Commands

        #endregion
        #region Constructor

        public DialogWindowViewModel(Window window) : base(window)
        {
            WindowMinimumHeight = 100;
            WindowMinimumWidth = 250;
            TitleHeight = 30;
        }
        #endregion
    }
}
