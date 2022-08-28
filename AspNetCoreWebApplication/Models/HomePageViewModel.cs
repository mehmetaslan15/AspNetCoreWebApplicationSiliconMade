using AspNetCoreWebApplication.Entities;

namespace AspNetCoreWebApplication.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
