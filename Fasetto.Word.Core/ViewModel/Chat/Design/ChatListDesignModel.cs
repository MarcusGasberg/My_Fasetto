
using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton
        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance { get; } = new ChatListDesignModel();

        #endregion
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                Name = "Anna",
                Initials = "AS",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5",
                NewContentAvailable = true
                },
                new ChatListItemViewModel
                {
                Name = "Jesse",
                Initials = "JA",
                Message = "Hey dude, here are the new icons",
                ProfilePictureRGB = "ffa800"
                },
                new ChatListItemViewModel
                {
                Name = "Parnell",
                Initials = "PL",
                Message = "The new server is up, got 192.168.1.1",
                ProfilePictureRGB = "00c541",
                IsSelected = true,
                },
                new ChatListItemViewModel
                {
                Name = "Anna",
                Initials = "AS",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                Name = "Jesse",
                Initials = "JA",
                Message = "Hey dude, here are the new icons",
                ProfilePictureRGB = "ffa800"
                },
                new ChatListItemViewModel
                {
                Name = "Parnell",
                Initials = "PL",
                Message = "The new server is up, got 192.168.1.1",
                ProfilePictureRGB = "00c541"
                },
                new ChatListItemViewModel
                {
                Name = "Anna",
                Initials = "AS",
                Message = "This chat app is awesome! I bet it will be fast too",
                ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                Name = "Jesse",
                Initials = "JA",
                Message = "Hey dude, here are the new icons",
                ProfilePictureRGB = "ffa800"
                },
                new ChatListItemViewModel
                {
                Name = "Parnell",
                Initials = "PL",
                Message = "The new server is up, got 192.168.1.1",
                ProfilePictureRGB = "00c541"
                },
            };
        }
        #endregion
    }
}
