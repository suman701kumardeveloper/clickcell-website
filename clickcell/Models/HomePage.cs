namespace clickcell.Models
{
    public class HomePage
    {
        public HomePage(string imageSet)
        {
            InitialImageSet = imageSet;
        }

        public string InitialImageSet { get; set; }
    }
}