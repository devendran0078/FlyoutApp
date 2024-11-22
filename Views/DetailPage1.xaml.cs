namespace FlyoutApp.Views;

public partial class DetailPage1 : ContentPage
{
	public DetailPage1()
	{
		InitializeComponent();
	}
	private void OnSubmitClicked(object sender, EventArgs e)
        {
            // Get values from controls
            string name = NameEntry.Text;
            string description = DescriptionEditor.Text;
            string category = CategoryPicker.SelectedItem?.ToString() ?? "None";

            // Display the result
            ResultLabel.Text = $"Name: {name}\nDescription: {description}\nCategory: {category}";
        }
}