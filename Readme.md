<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T209781)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Chart for WPF - How to Customize the Appearance of Selected Series Points

This example shows how to create a custom series model and change the selection color for series points.

![Chart](./images/Chart.png)         

1. Create an object that represents a custom model of a particular series [CustomBar2DModel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.CustomBar2DModel) and assign it to the `Model` property of a corresponding series type ([BarSeries2D.Model](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.BarSeries2D.Model)).

2. Create the `System.Windows.Controls.ControlTemplate` object which contains a Border element to create your own custom model.

3. Assign this template to the `PointTemplate` property of a custom series model ([CustomBar2DModel.PointTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.CustomPie2DModel.PointTemplate)).

4. Create the `IsSelectedConverter`. For this, create the `IsSelectedToBrushConverter` class inherited from `IValueConverter`. Then, implement `Convert`  and `ConvertBack` methods. The `Convert` method returns the black color if the `IsSelected` value is `true` and red color -  otherwise.

5. Bind the `Border.Background` property to the [SeriesPointPresentationData.IsSelected](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.SeriesPointPresentationData.IsSelected) property with `IsSelectedToBrushConverter` from the static resource. Set the [ChartControl.SelectionMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.SelectionMode) property to `Multiple` to enable the chart selection. 

## Files to Review

* [MainWindow.xaml](./CS/CustomModelSelectedPointsCustomization/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomModelSelectedPointsCustomization/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomModelSelectedPointsCustomization/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomModelSelectedPointsCustomization/MainWindow.xaml.vb))

## Documentation

* [Series Points](https://docs.devexpress.com/WPF/6340/controls-and-libraries/charts-suite/chart-control/series/series-points)

