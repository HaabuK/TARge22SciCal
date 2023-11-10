namespace TARge22SciCalc;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

//#if __MACCATALYST__
//            // This code will be included only when running on macOS with Mac Catalyst

//            // Create your UI elements
//            var label = new Label
//            {
//                Text = "Hello MAUI on Mac Catalyst!",
//                FontSize = 50,
//                HorizontalOptions = LayoutOptions.CenterAndExpand,
//                VerticalOptions = LayoutOptions.CenterAndExpand
//            };

//            // Add UI elements to the layout
//            var stackLayout = new StackLayout
//            {
//                Children = { label }
//            };

//            // Set the content of the page
//            Content = stackLayout;
//#endif
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


