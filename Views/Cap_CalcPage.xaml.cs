using static Microsoft.Maui.ApplicationModel.Permissions;

namespace HVAC_APP_3.Views;

public partial class Cap_CalcPage : ContentPage
{
    double voltage;
    double startAmps;
    //double total;
    public Cap_CalcPage()
	{
		InitializeComponent();
	}
    private void Calc_Mfd(object sender, EventArgs e)
    {
        voltage = Convert.ToDouble(volts.Text);
        startAmps = Convert.ToDouble(amps.Text);

        double total = Math.Round((startAmps * 2652) / voltage);
        string printTotal = total.ToString();

        mfd.Text = printTotal;
    }
}