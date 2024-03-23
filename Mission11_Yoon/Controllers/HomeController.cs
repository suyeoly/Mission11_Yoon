using Microsoft.AspNetCore.Mvc;
using Mission11_Yoon.Models;
using Mission11_Yoon.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Yoon.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp) 
        {
            _repo = temp;
        }
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BooksListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.BookId)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerpage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            
            return View(blah);
        }
    }
}
