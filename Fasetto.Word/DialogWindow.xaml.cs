using System.Windows;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        #region Private members

        /// <summary>
        /// The viewmodel for this window
        /// </summary>
        private DialogWindowViewModel _viewModel;
        #endregion
        #region Public properties
        /// <summary>
        /// The viewmodel for this window
        /// </summary>
        public DialogWindowViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                _viewModel = value;
                //Update the data context
                DataContext = _viewModel;
            } 
        }
        #endregion
        #region Constructor

        public DialogWindow()
        {
            InitializeComponent();

        } 
        #endregion
    }
}
