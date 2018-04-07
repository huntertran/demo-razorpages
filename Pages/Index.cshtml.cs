namespace razorpages.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "Tuan Tran @ DEV UP";
        }
    }
}
