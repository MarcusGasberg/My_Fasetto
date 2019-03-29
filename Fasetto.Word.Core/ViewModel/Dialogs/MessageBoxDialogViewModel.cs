namespace Fasetto.Word.Core
{
    /// <summary>
    /// Details for a message box dialog
    /// </summary>
    public class MessageBoxDialogViewModel : BaseDialogViewModel
    {
        /// <summary>
        /// The message to display
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The text to display where the ok button is
        /// </summary>
        public string OkText { get; set; }
    }
}