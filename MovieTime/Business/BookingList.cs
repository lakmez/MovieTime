
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MovieTime.Business
{
    class BookingList<T> : IEnumerable
    {
        public List<T> ListBook { get; set; }
        public BookingList()
        {
            ListBook = new List<T>();
        }
        public void Add(T obj)
        {
            ListBook.Add(obj);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (T someBook in ListBook)
                yield return someBook;
        }
    }
}
