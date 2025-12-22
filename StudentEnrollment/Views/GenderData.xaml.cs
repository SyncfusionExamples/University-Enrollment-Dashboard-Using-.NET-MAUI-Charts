using Syncfusion.Maui.Charts;

namespace StudentEnrollment;

public partial class GenderData : ContentView
{
	public GenderData()
	{
		InitializeComponent();
	}
}

public class LegendExt : ChartLegend
{
    protected override double GetMaximumSizeCoefficient()
    {
        return 1;
    }
}
