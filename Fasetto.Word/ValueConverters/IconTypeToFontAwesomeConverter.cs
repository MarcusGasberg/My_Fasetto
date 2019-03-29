﻿using System;
using System.Globalization;
using Fasetto.Word.Core;

namespace Fasetto.Word
{
    /// <summary>
    /// A converterter that takes in a <see cref="IconType"/> and
    /// return the FontAwesome string for that icon
    /// </summary>
    public class IconTypeToFontAwesomeConverter : BaseValueConverter<IconTypeToFontAwesomeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((IconType) value).ToFontAwesome();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}