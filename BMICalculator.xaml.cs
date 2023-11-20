namespace Mod3LabE;

public partial class BMICalculator : ContentPage
{
	public BMICalculator()
	{
		InitializeComponent();
	}

    public void Button_Clicked(object sender, EventArgs e)
    {
        double pounds = Convert.ToDouble(In_weight.Text);
        double height = (12 * Convert.ToDouble(In_heightFeet.Text) + (Convert.ToDouble(In_heightInches.Text)));

        Out_text.Text = "Your BMI is " + Math.Round((pounds / (height * height) * 703), 2).ToString();
    }
}