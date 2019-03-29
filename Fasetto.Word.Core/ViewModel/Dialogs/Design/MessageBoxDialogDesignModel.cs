namespace Fasetto.Word.Core
{
    /// <summary>
    /// Details for a message box dialog
    /// </summary>
    public class MessageBoxDialogDesignModel : MessageBoxDialogViewModel
    {
        #region Singleton
        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageBoxDialogDesignModel Instance { get; } = new MessageBoxDialogDesignModel();

        #endregion
        #region Constructor

        public MessageBoxDialogDesignModel()
        {
            Message = "Design time messages are fun";
            OkText = "Design time OK";
        } 
        #endregion
    }
}