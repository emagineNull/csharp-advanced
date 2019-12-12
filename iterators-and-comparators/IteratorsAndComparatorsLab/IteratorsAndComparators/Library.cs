using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryEnumerator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() 
            => this.GetEnumerator();

        private class LibraryEnumerator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;

            public LibraryEnumerator(List<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public Book Current
            {
                get
                {
                    return this.books[this.index];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext() => ++this.index < this.books.Count;

            public void Reset() => this.index = -1;
        }
    }
}
