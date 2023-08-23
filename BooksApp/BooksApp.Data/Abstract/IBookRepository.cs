﻿using BooksApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Abstract
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<bool> AnyAsync(int id);
        Task<List<Book>> GetBooksWithFullDataAsync(bool? isHome = null, bool? isActive = null);
        Task<List<Book>> GetAllActiveBooksAsync(string categoryUrl = null, string authorUrl = null, string publisherUrl = null);
        Task<List<Book>> GetBooksByCategoryAsync(int categoryId);
        Task<Book> GetBookByUrlAsync(string bookUrl);
        Task<Book> GetBookByIdAsync(int id);
        Task<List<Book>> GetAllBooksWithAuthorAndPublisher(bool isDeleted);
        Task CreateBookAsync(Book book, List<int> SelectedCategoryIds);
        Task UpdateAuthorOfBooks();
        Task UpdatePublisherOfBooks();
        Task CheckBooksCategories();
        void UpdateBook(Book book);

    }
}
