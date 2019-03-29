using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Fasetto.Word.Core;

namespace Fasetto.Word
{
    /// <summary>
    /// View model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region Private Members
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// The window resizer helper that keeps the window size correct in various states
        /// </summary>
        private WindowResizer mWindowResizer;

        /// <summary>
        /// The margin around the wiondow to allow for a drop shadow
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        private int mWindowRadius = 10;

        /// <summary>
        /// The last known dock position
        /// </summary>
        private WindowDockPosition mDockPosition = WindowDockPosition.Undocked;

        /// <summary>
        /// True if we should have a dimmed overlay on the window
        /// </summary>
        public bool DimmableOverlayVisible { get; set; }

        #endregion
        #region Public Properties


        /// <summary>
        /// The smallest width the window can go to
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 800;
        /// <summary>
        /// The smallest height the window can go to
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 550;

        public bool Borderless => (mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked);

        /// <summary>
        /// The Size of the resize border around the window,
        /// </summary>
         public int ResizeBorder => 10;

        /// <summary>
        /// The Padding of the inner content of the main window
        /// </summary>
        public Thickness InnerContentPadding { get; set; } = new Thickness(0);

        /// <summary>
        /// The size of the resize border arround the window taking into account the outer margin
        /// </summary>

        public Thickness ResizeBorderThickness => new Thickness(ResizeBorder + OuterMarginSize);

        /// <summary>
        /// The margin around the wiondow to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            //if it is maximized or docked, no border
            get => Borderless ? 0 : mOuterMarginSize;
            set => mOuterMarginSize = value;
        }

        /// <summary>
        /// The margin thickness around the window to allow for a drop shadow
        /// </summary>
        public Thickness OuterMarginSizeThickness => new Thickness(OuterMarginSize);

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public int WindowRadius
        {
            get => Borderless ? 0 : mWindowRadius;
            set => mWindowRadius = value;
        }

        /// <summary>
        /// The Corner radius of the edges of the window
        /// </summary>
        public CornerRadius WindowCornerRadius => new CornerRadius(WindowRadius);

        /// <summary>
        /// The height of the tile bar/ caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 32;
        /// <summary>
        /// THe height of the title bar / caption of the window
        /// </summary>
        public GridLength TitleHeightGridLength => new GridLength(TitleHeight + ResizeBorder);


        #endregion
        #region Commands
        /// <summary>
        /// The command to minimize the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }
        /// <summary>
        /// The command to maximize the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }
        /// <summary>
        /// The command to close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }
        /// <summary>
        /// The command to show the sytem menu of the window
        /// </summary>
        public ICommand MenuCommand { get; set; }
        #endregion
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            mWindow = window;

            //Listen out for window resizing
            mWindow.StateChanged += (sender, e) =>
            {
                WindowResized();
            };

            //Create Commands
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, mWindow.PointToScreen(Mouse.GetPosition(mWindow))));

            //Fix Window resize issue// Fix window resize issue
            mWindowResizer = new WindowResizer(mWindow);

            // Listen out for dock changes
            mWindowResizer.WindowDockChanged += (dock) =>
            {
                // Store last position
                mDockPosition = dock;

                // Fire off resize events
                WindowResized();
            };
        }
        #endregion

        #region Private Helpers
        

        /// <summary>
        /// If the window resizes to a special position (docked or maximized)
        /// this will update all required property change events to set the borders and radius values
        /// </summary>
        private void WindowResized()
        {
            // Fire off events for all properties that are affected by a resize
            OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));
        }


        #endregion
    }
}
