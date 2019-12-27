﻿using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Shadowsocks.Util;

namespace Shadowsocks.View.ValueConverter
{
    public class LatencyToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is long bytes && bytes > 0)
            {
                return new SolidColorBrush(ColorConvert.GetLatencyColor(bytes));
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
                System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
