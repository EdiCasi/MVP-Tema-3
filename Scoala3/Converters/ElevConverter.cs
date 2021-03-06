using Scoala3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Scoala3.Converters
{
    class ElevConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null)
            {
                string nume = values[0].ToString();
                string idClasa = values[1].ToString();
                string idElev = values[2].ToString();
                return new Elev()
                {
                    Nume = nume,
                    IdClasa = idClasa,
                    IdElev = idElev
                };
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
