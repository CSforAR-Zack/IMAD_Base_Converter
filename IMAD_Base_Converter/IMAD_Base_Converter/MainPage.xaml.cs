namespace IMAD_Base_Converter;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	void ConvertCommand(object sender, EventArgs args)
    {
		int number = 0;

        if (numberInput.Text == "")
			return;

		// Input Base: Get Number based on base system selected
		if(iBin.IsChecked)
            number = Convert.ToInt32(numberInput.Text, 2);
		else if(iOct.IsChecked)
            number = Convert.ToInt32(numberInput.Text, 8);
        else if (iDec.IsChecked)
            number = Convert.ToInt32(numberInput.Text, 10);
        else if (iHex.IsChecked)
            number = Convert.ToInt32(numberInput.Text, 16);

        // Output Base
        if (oBin.IsChecked)
            resultLabel.Text = Convert.ToString(number, 2);
        else if (oOct.IsChecked)
            resultLabel.Text = Convert.ToString(number, 8);
        else if (oDec.IsChecked)
            resultLabel.Text = Convert.ToString(number, 10);
        else if (oHex.IsChecked)
            resultLabel.Text = Convert.ToString(number, 16);
	}
}

