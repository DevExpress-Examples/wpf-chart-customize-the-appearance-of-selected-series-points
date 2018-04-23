Imports System.Globalization
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Media

Namespace CustomModelSelectedPointsCustomization

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class IsSelectedToBrushConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If TypeOf value Is Boolean AndAlso targetType Is GetType(Brush) Then
                Dim isSelected As Boolean = DirectCast(value, Boolean)
                Return If(isSelected, Brushes.Black, Brushes.Red)
            End If
            Return Nothing
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New System.NotImplementedException()
        End Function
    End Class
End Namespace