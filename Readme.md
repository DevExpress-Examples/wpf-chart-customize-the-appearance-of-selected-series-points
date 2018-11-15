<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CustomModelSelectedPointsCustomization/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/CustomModelSelectedPointsCustomization/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/CustomModelSelectedPointsCustomization/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomModelSelectedPointsCustomization/MainWindow.xaml.vb))
<!-- default file list end -->
# How to customize the appearance of selected series points


This example shows how to change the selection color for series points. For this, it's necessary to create a custom series model.<br /><br />
<p>To accomplish this, do the following:</p>
<p>1. Create an object that represents a custom model of a particular series (<a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsCustomBar2DModeltopic"><u>CustomBar2DModel</u></a>) and assign it to the<strong> Model</strong> property of a corresponding series type (<a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsBarSeries2D_Modeltopic"><u>BarSeries2D.Model</u></a>): <a href="https://www.devexpress.com/Support/Center/p/E4593">E4593: How to create custom models for chart series </a><br /><br />2. Create the <strong>System.Windows.Controls.ControlTemplate</strong> object which contains a Border element to create your own custom model.<br /><br />3. Assign this template to the PointTemplate property of a series custom model (<a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsCustomBar2DModel_PointTemplatetopic"><u>CustomBar2DModel.PointTemplate</u></a>). <br /><br />4. Create the IsSelectedConverter. For this, create the <strong>IsSelectedToBrushConverter</strong> class inheritted from <strong>IValueConverter</strong>. Then, implement<strong> Convert</strong> and <strong>ConvertBack</strong> methods. The <strong>Convert</strong> method will return the black color if the <strong>IsSelected</strong> value is<strong>  true</strong> and red color -  otherwise.<br /><br />5. Bind the <strong>Border.Background</strong> property to the <strong>SeriesPointPresentationData.IsSelected</strong> property using the <strong>IsSelectedToBrushConverter </strong>from the static resource. <br /><br /> Note that the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_SelectionModetopic">ChartControl.SelectionMode</a> property must be set to<strong> Multiple</strong> to enable the chart selection. </p>

<br/>


