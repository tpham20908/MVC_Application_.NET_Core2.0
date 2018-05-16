using Contoso.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.ViewComponents
{
    public class CustomerInfoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AdventureWorksContext context = new AdventureWorksContext();
            int rand = new Random().Next(1000, 20000);
            var cust = await context.Person.FirstOrDefaultAsync(c => c.BusinessEntityId == rand);

            return View(cust);
        }
    }
}
