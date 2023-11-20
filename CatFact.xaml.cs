namespace Mod3LabE;

public partial class CatFact : ContentPage
{
	public CatFact()
	{
		InitializeComponent();
	}

	public string fact = "";
	public int length = 0;

	public async void RandomClick(object? sender, EventArgs e)
	{
		if (Connectivity.Current.NetworkAccess == NetworkAccess.None)
		{
			

            Fact.Text = "No Internet Connection Available";
        }
		else
		{
            HttpClient client = new HttpClient();
            fact = await client.GetStringAsync("https://catfact.ninja/fact");
            Fact.Text = fact;
        }
	}
}