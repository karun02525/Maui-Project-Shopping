namespace Shopping_App;

public partial class ProductScreen : ContentPage
{
    public List<Product> Items { get; set; }

    public ProductScreen()
	{
		InitializeComponent();

        Items = new List<Product>()
    {
     new Product { Name = "Product A", Description = "Description A", Price = 140.9, ImageUrl = "https://www.dealsmagnet.com/images/impulse-imp-omega-45l-laptop-backpackoffice-bagsch-o-19jEY6e9.jpg" },
      new Product { Name = "Product B", Description = "Description B", Price = 25.50, ImageUrl = "https://www.tecnocompu.com.do/42-large_default/LAPTOP-LENOVO-T450-CORE-i5-IMP.jpg" },

        new Product { Name = "Product C", Description = "Description A", Price = 4465, ImageUrl = "https://img.etimg.com/thumb/width-1200,height-1200,imgsize-789754,resizemode-75,msid-73320212/small-biz/sme-sector/the-kirana-is-a-technology-shop-too.jpg" },
      new Product { Name = "Product D", Description = "Description B", Price = 8929.3, ImageUrl = "https://preply.com/wp-content/uploads/2018/04/shopping_bags.jpg" },


        new Product { Name = "Product E", Description = "Description A", Price = 1053.99, ImageUrl = "https://c8.alamy.com/comp/P3T55C/selection-of-the-goods-in-household-shop-P3T55C.jpg" },
      new Product { Name = "Product F", Description = "Description B", Price = 243.50, ImageUrl = "https://images.herzindagi.info/image/2022/Mar/janpath-shopping-guide-main.jpg" },


        new Product { Name = "Product G", Description = "Description A", Price = 2495.99, ImageUrl = "https://cplusdesign.lk/wp-content/uploads/2023/09/Mobile-Shop-Design-Ideas-6.jpg" },
      new Product { Name = "Product H", Description = "Description B", Price = 2201.50, ImageUrl = "https://www.treetoptoyshop.com.au/cdn/shop/files/treetop-toy-shop-hero.jpg?v=1686888122&width=2400" },

        new Product { Name = "Product I", Description = "Description A", Price = 5783.99, ImageUrl = "https://miro.medium.com/v2/resize:fit:1200/1*udNENdKYbecDrZPOtiDBog.jpeg" },
      new Product { Name = "Product J", Description = "Description B", Price = 2015.50, ImageUrl = "https://ichef.bbci.co.uk/news/976/cpsprodpb/0ED2/production/_118149730_mediaitem118148499.jpg" },


        new Product { Name = "Product K", Description = "Description A", Price = 30.99, ImageUrl = "https://www.dealsmagnet.com/images/impulse-imp-omega-45l-laptop-backpackoffice-bagsch-o-19jEY6e9.jpg" },
      new Product { Name = "Product L", Description = "Description B", Price = 25.50, ImageUrl = "https://www.tecnocompu.com.do/42-large_default/LAPTOP-LENOVO-T450-CORE-i5-IMP.jpg" },



      // Add more products to the list
    };

        this.BindingContext = this;
    }
}
