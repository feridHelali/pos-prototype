namespace POSApp;

public sealed partial class MainPage : Page
{
    public List<Article> ArticleList=new List<Article>();
    public List<Order> OrderList=new List<Order>();
    public double TotalAmount=0;

    public MainPage()
    {
        this.InitializeComponent();
    }

    public void OnArticleSelected(object sender, EventArgs e)
    {

    }

    public void OnProcessPaymntClicked(object sender, EventArgs e)
    {
        
    }

    public void OnNumericPadClicked(object sender, EventArgs e)
    {
        
    }

}

class Article{
   public string Name{ get; set; }
   public double Price{ get; set; }
}

class Order{
    public string Name{ get; set;}
    public double Quantity{ get; set;}
    public double Price{ get; set;}
}
