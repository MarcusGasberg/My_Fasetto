using System;
using System.Globalization;
using System.Windows;
using Fasetto.Word.Core;

namespace Fasetto.Word
{
    /// <summary>
    /// A converter that takes in a <see cref="MenuItemType"/> and return a <see cref="Visibility"/>
    /// based on the given parameter being the same as the menu item type
    /// </summary>
    public class MenuItemTypeToVisibilityConverter : BaseValueConverter<MenuItemTypeToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //If we have no parameter return invisible
            if(parameter==null)
                return Visibility.Collapsed;
            //Try and convert parameter string to enum
            if (!Enum.TryParse(parameter as string, out MenuItemType type))
                return Visibility.Collapsed;
            return value != null && (MenuItemType) value == type ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
