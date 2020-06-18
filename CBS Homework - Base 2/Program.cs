using System;

namespace CBS_Homework___Base_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Title title = new Title()
            {
                title = "1984"
            };

            Author author = new Author()
            {
                author = "George Orwell"
            };

            Content content = new Content()
            {
                content = "Dystopia in which a person degrades under the influence of a totalitarian state"
            };

            Book book = new Book(title, author, content);
            book.Show();
            Console.ResetColor();
        }
    }
}
