using SampleBookStore.Models;

namespace SampleBookStore.Data {
    public static class DbInitializer {
        public static void Initialize(SampleBookStoreContext context) {
            // Look for any books.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            var books = new Book[]
            {
                new Book{ Name="The Great Gatsby", Author="F. Scott Fitzgerald", PublicationDate=DateTime.Parse("1925-04-10")},
                new Book{ Name="To Kill a Mockingbird", Author="Harper Lee", PublicationDate=DateTime.Parse("1960-07-11")},
                new Book{ Name="1984", Author="George Orwell", PublicationDate=DateTime.Parse("1949-06-08")},
                new Book{ Name="The Lord of the Rings", Author="J.R.R. Tolkien", PublicationDate=DateTime.Parse("1954-07-29")},
                new Book{ Name="The Catcher in the Rye", Author="J.D. Salinger", PublicationDate=DateTime.Parse("1951-07-16")},
                new Book{ Name="Moby-Dick", Author="Herman Melville", PublicationDate=DateTime.Parse("1851-10-18")},
                new Book{ Name="Pride and Prejudice", Author="Jane Austen", PublicationDate=DateTime.Parse("1813-01-28")},
                new Book{ Name="War and Peace", Author="Leo Tolstoy", PublicationDate=DateTime.Parse("1869-01-01")}
            };


            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
}
