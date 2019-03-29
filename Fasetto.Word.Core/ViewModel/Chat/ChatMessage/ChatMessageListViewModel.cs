using System.Collections.Generic;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for a chat message thread
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The chat thread items for the list
        /// </summary>
        public List<ChatMessageListItemViewModel> Items { get; set; }

        /// <summary>
        /// True if the attachment menu should be visible
        /// </summary>
        public bool AttachmentMenuVisible { get; set; }

        /// <summary>
        /// True if any popup menu is visible
        /// </summary>
        public bool AnyPopupVisible => AttachmentMenuVisible;

        /// <summary>
        /// The view model for the attachment menu
        /// </summary>
        public ChatAttachmentPopupMenuViewModel AttachmentPopupMenu { get; set; }
        #endregion

        #region Public Commands
        /// <summary>
        /// The command for when the attachment button is clicked
        /// </summary>
        public ICommand AttachmentButtonCommand { get; set; }

        /// <summary>
        /// The command for when the area outside the popup is clicked
        /// </summary>
        public ICommand PopupClickAwayCommand { get; set; }

        /// <summary>
        /// The Command ofr when the user clicks the send button
        /// </summary>
        public ICommand SendCommand { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChatMessageListViewModel()
        {
            //Create Commands
            AttachmentButtonCommand = new RelayCommand(AttachmentButton);
            PopupClickAwayCommand = new RelayCommand(PopupClickAway);
            SendCommand = new RelayCommand(Send);
            //Make a default menu
            AttachmentPopupMenu = new ChatAttachmentPopupMenuViewModel();
        }

        #endregion

        #region Command Methods
        /// <summary>
        /// When the attachment button is clicked show/hide the attachment popup
        /// </summary>
        private void AttachmentButton()
        {
            AttachmentMenuVisible ^= true;
        }

        /// <summary>
        /// When the area around the popup is clicked hide the popup
        /// </summary>
        private void PopupClickAway()
        {
            AttachmentMenuVisible = false;
        }

        /// <summary>
        /// Send the message when the user clicks the send button
        /// </summary>
        private async void Send()
        {
            await IoC.UI.ShowMessage(new MessageBoxDialogViewModel()
            {
                Title = "Send Message",
                Message = "Thanks for writing a nice message",
                OkText = "Ok"
            });
        }

        #endregion
    }
}
