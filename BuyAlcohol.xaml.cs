namespace Mod3LabE;

public partial class BuyAlcohol : ContentPage
{
	public BuyAlcohol()
	{
		InitializeComponent();
	}

    void OnDateSelected(object sender, System.EventArgs e)
    {
        double UsAge = DateTime.Now.Year - birthDate.Date.Year;
        Out_Alcohol.Text = UsAge.ToString();

        if (UsAge >= 21)
        {
            Out_Alcohol.Text = "It's legal to drink in the United States.";
        }
        else if (UsAge == 0)
        {
            Out_Alcohol.Text = "You've got 21 year(s) to go.";
        }
        else
        {
            Out_Alcohol.Text = "You've got " + (DateTime.Now.Year - birthDate.Date.Year) + " year(s) to go";
        }
    }
}