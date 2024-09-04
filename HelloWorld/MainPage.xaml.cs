namespace HelloWorld;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Hello_OnClicked(object sender, EventArgs e)
    {
        if (lblDisplay.Text == "Hello World")
        {
            lblDisplay.Text = "This is cool!";
        }
        else
        {
            lblDisplay.Text = "Hello World";
        }
        
    }
}