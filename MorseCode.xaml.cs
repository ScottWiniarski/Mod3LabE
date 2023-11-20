
namespace Mod3LabE;

public partial class MorseCode : ContentPage
{
	public MorseCode()
	{
		InitializeComponent();
	}

    string input = "";
    void Dot_Clicked(object sender, System.EventArgs e)
    {
        input += '.';
        In_char.Text = input;
    }

    void Dash_Clicked(object sender, System.EventArgs e)
    {
        input += '-';
        In_char.Text = input;
    }

    void Space_Clicked(object sender, System.EventArgs e)
    {
        Out_char.Text += Morse.MorseCoder(input);
        input = "";
    }
}