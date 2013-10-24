using System;
using System.Windows.Data;

namespace Recipe_05_07
{
    enum DistanceType
    {
        Miles,
        Kilometres
    }

    class DistanceConverter
    {
        public string Convert(double amount, DistanceType sourceType)
        {
            if (DistanceType.Miles.Equals(sourceType))
            {
                return string.Format("{0:0.##} km", amount * 1.609344);
            }
            else if (DistanceType.Kilometres.Equals(sourceType))
            {
                return string.Format("{0:0.##} miles", amount * 0.621371192);
            }

            throw new ArgumentOutOfRangeException("sourceType", sourceType,
                "Source must be in Miles or Kilometres");
        }
    }

    class DoubleToString : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                return ((double)value).ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                string input = value as string;

                if (string.IsNullOrEmpty(input))
                {
                    return 0;
                }

                return double.Parse(input);
            }
            catch
            {
                return 0;
            }
        }
    }
}
