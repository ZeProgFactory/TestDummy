using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TestDummy
{
   public class ControlsViewModel : INotifyPropertyChanged
   {
      string name = "";
      bool isEnabled = true;
      bool isAgreed;
      double sliderValue;
      string? selectedColor;
      int counter;

      public ControlsViewModel()
      {
         IncrementCommand = new Command(() => Counter++);
         ResetCommand = new Command(() =>
         {
            Counter = 0;
            Name = "";
            SliderValue = 0;
            IsAgreed = false;
            SelectedColor = null;
         });
      }

      public string Title => "Controls Test Page";
      public List<string> Colors { get; } = new() { "Red", "Green", "Blue" };

      public string Name
      {
         get => name;
         set { if (Set(ref name, value)) OnPropertyChanged(nameof(Greeting)); }
      }

      public string Greeting => string.IsNullOrEmpty(Name) ? "Hello, stranger" : $"Hello, {Name}";

      public bool IsEnabled { get => isEnabled; set => Set(ref isEnabled, value); }
      public bool IsAgreed { get => isAgreed; set => Set(ref isAgreed, value); }
      public double SliderValue { get => sliderValue; set => Set(ref sliderValue, value); }
      public string? SelectedColor { get => selectedColor; set => Set(ref selectedColor, value); }
      public int Counter { get => counter; set => Set(ref counter, value); }

      public ICommand IncrementCommand { get; }
      public ICommand ResetCommand { get; }

      public event PropertyChangedEventHandler? PropertyChanged;

      void OnPropertyChanged([CallerMemberName] string? propertyName = null)
         => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

      bool Set<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
      {
         if (EqualityComparer<T>.Default.Equals(field, value))
            return false;
         field = value;
         OnPropertyChanged(propertyName);
         return true;
      }
   }

   public partial class ControlsPage : ContentPage
   {
      public ControlsPage()
      {
         InitializeComponent();
         BindingContext = new ControlsViewModel();
      }
   }
}
