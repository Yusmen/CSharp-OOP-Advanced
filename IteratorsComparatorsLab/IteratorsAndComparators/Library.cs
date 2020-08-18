using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Library:IEnumerable<Book>
    {

        private SortedSet<Book> books;

    

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books,new BookComparer());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int index;
            public Book Current => this.books[index];

            object IEnumerator.Current =>this.Current;

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                this.books = new List<Book>(books);
            }

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            => ++index < books.Count;

            public void Reset()
            {
                this.index = -1;
            }
        }
    }
}
