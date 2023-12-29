namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Collections = new List<object>
            {
                new object(),
            };
            BindingContext = this;

        }

        public List<object> Collections { get; set; }
    }

}
