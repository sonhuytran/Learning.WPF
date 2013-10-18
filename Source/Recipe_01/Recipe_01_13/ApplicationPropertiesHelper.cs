using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Recipe_01_13
{
    public static class ApplicationPropertiesHelper
    {
        public static T GetProperty<T>(object key)
        {
            if (Application.Current.Properties.Contains(key))
            {
                object obj = Application.Current.Properties[key];

                if (obj is T)
                {
                    return (T)obj;
                }
            }

            return default(T);
        }

        public static object GetProperty(object key)
        {
            if (Application.Current.Properties.Contains(key))
            {
                return Application.Current.Properties[key];
            }

            return null;
        }

        public static void SetProperty(object key, object value)
        {
            Application.Current.Properties[key] = value;
        }
    }
}
