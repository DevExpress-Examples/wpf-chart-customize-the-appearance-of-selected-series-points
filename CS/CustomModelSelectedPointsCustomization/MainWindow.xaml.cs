using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace CustomModelSelectedPointsCustomization {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class IsSelectedToBrushConverter : IValueConverter {

        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture) {
            if (value is bool && targetType == typeof(Brush)) {
                bool isSelected = (bool)value;
                return isSelected ? Brushes.Black : Brushes.Red;
            }
            return null;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture) {
            throw new System.NotImplementedException();
        }
    }
}