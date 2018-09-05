using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BluetoothSender_Windows.ViewModel.Converters
{
    public class BooleanToColorConverter : IValueConverter
    {
        private readonly String _colorBackgroundDefault = "DarkSlateGray";
        private readonly String _colorBackgroundUserControl = "#FF436060";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                bool active = value != null && (bool) value;
                return active ? _colorBackgroundUserControl : _colorBackgroundDefault;
            }
            catch (Exception)
            {
                return _colorBackgroundDefault;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
