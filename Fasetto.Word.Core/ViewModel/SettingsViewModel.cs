using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The application state as a viewmodel
    /// </summary>
    public class SettingsViewModel : BaseViewModel
    {
        #region Public Command

        public ICommand BackCommand { get; set; }
        public ICommand OpenCommand { get; set; }
        #endregion
        #region Default Constructor

        public SettingsViewModel()
        {
            BackCommand = new RelayCommand(Back);
            OpenCommand = new RelayCommand(Open);
        }

        private void Open()
        {
            IoC.ApplicationVm.SettingsMenuVisible = true;
        }

        #endregion
        #region Command helpers

        private void Back()
        {
            IoC.ApplicationVm.SettingsMenuVisible = false;
        } 
        #endregion
    }
}
