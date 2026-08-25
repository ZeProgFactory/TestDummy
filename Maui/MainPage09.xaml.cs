namespace Maui;

public partial class MainPage09 : ContentPage
{
   int count = 0;

   public MainPage09()
   {
      InitializeComponent();
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
