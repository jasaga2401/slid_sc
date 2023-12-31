using System.Collections.ObjectModel;

namespace slid_sc
{
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<YourItem> YourItemsCollection { get; set; }

        public MainPage()
        {
            InitializeComponent();

            YourItemsCollection = new ObservableCollection<YourItem>
        {
            new YourItem { Title = "Screen 1", Description = "This is the first screen.", ImageUrl = "car1.png" },
            new YourItem { Title = "Screen 2", Description = "This is the second screen.", ImageUrl = "car2.png" },
            new YourItem { Title = "Screen 3", Description = "This is the third screen.", ImageUrl = "car3.png" },
            // Add more items here
        };

            BindingContext = this;
        }

        
    }

    public class YourItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

}
