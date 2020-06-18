using System;
using System.Collections.Generic;
using System.Text;

namespace CBS_Homework___Base_2
{
    class Book
    {
        Title title;
        Author author;
        Content content;
        

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

    }
}
