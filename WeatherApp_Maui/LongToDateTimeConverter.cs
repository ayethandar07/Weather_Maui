﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp_Maui
{
    public class LongToDateTimeConverter : IValueConverter
    {
        DateTime _time = new DateTime(1970,1,1,0,0,0,0);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            long dateTime = (long)value;

            string time = _time.AddSeconds(dateTime).ToString();

            return $"{time} UTC";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
