﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Shadowsocks.Util;

namespace Shadowsocks.View.ValueConverter
{
    public class TotalDownloadRawBackgroundBrushConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int index)
            {
                if (targetType == typeof(Brush))
                {
                    return System.Convert.ToBoolean(index & 1) ? ColorConvert.TotalDownloadRawBrush1 : ColorConvert.TotalDownloadRawBrush2;
                }
            }
            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
