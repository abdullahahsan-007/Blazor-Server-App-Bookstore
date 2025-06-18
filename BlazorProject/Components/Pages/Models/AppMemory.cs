using System;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace.Models
{
    public static class AppMemory
    {

        public static string CurrentUsername { get; set; }
        public static string CurrentRole { get; set; }
        public static List<Book> Cart { get; } = new();
        public static List<string> AvailableGenres { get; set; } = new();

        public static event Action? OnChange; // Event to notify UI

        public static void AddToCart(Book book)
        {
            var existing = Cart.FirstOrDefault(b => b.Id == book.Id);
            if (existing != null)
                existing.Quantity += 1;
            else
                Cart.Add(new Book
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Price = book.Price,
                    CoverImageUrl = book.CoverImageUrl,
                    Quantity = 1
                });

            NotifyStateChanged();
        }

        public static void ClearCart()
        {
            Cart.Clear();
            NotifyStateChanged();
        }

        public static int CartCount => Cart.Sum(b => b.Quantity);

        public static void UpdateGenres(List<string> genres)
        {
            AvailableGenres = genres;
            NotifyStateChanged();
        }

        private static void NotifyStateChanged() => OnChange?.Invoke();
    }
}
