using PropertyChanged;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Base view model that fires property changed events as needed
    /// </summary>
    
    public class BaseDialogViewModel : BaseViewModel
    {
        /// <summary>
        /// The title of the dialog
        /// </summary>
        public string Title { get; set; }
    }
}
