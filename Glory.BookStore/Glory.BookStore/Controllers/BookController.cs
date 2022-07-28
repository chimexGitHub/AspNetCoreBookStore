using Glory.BookStore.Models;
using Glory.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glory.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        // constructor
        public BookController()
        {
            // class instatiation
            _bookRepository = new BookRepository();
        }
        // defining all methods in our book controller

        //action method to get all books
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        // action to get the details of a single book
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        // action method to search book
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
