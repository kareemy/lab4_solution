using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab4_solution.Pages;

public class OrderModel : PageModel
{
    private readonly ILogger<OrderModel> _logger;

    [BindProperty]
    public string Name {get; set;} = string.Empty;
    
    [BindProperty]
    [Range(1000,99999)]
    [Display(Name = "Serial Number")]
    public int SerialNumber {get; set;}
    
    [BindProperty]
    [CreditCard]
    [Display(Name = "Credit card number")]
    public string CreditCard {get; set;} = string.Empty;

    public OrderModel(ILogger<OrderModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {

    }
}
