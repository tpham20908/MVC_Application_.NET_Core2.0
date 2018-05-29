using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.BranchModels;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BranchController : Controller
    {
        private IBranch _branch;

        public BranchController(IBranch branch)
        {
            _branch = branch;
        }

        public IActionResult Index()
        {
            var branches = _branch.GetAll()
                .Select(b => new BranchDetailModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    IsOpen = _branch.IsBranchOpen(b.Id),
                    NumberOfAssets = _branch.GetAssets(b.Id).Count(),
                    NumberOfPatrons = _branch.GetPatrons(b.Id).Count()
                });

            var model = new BranchIndexModel
            {
                Branches = branches
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var branch = _branch.Get(id);

            var model = new BranchDetailModel
            {
                Id = branch.Id,
                Name = branch.Name,
                Address = branch.Address,
                Telephone = branch.Telephone,
                OpenDate = branch.OpenDate.ToString("dd/MM/yyyy"),
                NumberOfAssets = _branch.GetAssets(branch.Id).Count(),
                NumberOfPatrons = _branch.GetPatrons(branch.Id).Count(),
                TotalAssetValue = _branch.GetAssets(id).Sum(a => a.Cost),
                ImageUrl = branch.ImageUrl,
                HoursOpen = _branch.GetBranchHours(id),
                IsOpen = _branch.IsBranchOpen(branch.Id)
            };

            return View(model);
        }
    }
}