using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCustomGenericCollection
{
    public class MyGeneric<T> : IList<T>, IEnumerator<T>
    {
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();


        object IEnumerator.Current => throw new NotImplementedException();


        T[] myList = new T[0];
        public void Add(T item)
        {
            Array.Resize(ref myList, myList.Length + 1);
            myList[myList.Length - 1] = item;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            foreach (var Titem in myList)
            {
                if (Titem.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)this;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(myList);
        }
        int index = -1;
        public bool MoveNext()
        {
            if (++index < myList.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public T Current { get { return myList[index]; } }

    }

    /*
     Collection : 
     Generic Collection – Non Generic Collection

     IEnumarator ve IEnumarable
     Foreach gibi dongu kullanılmaya yarar.Dongu yordamlarını içerir.

    ICollection
    Tüm generic olmayan koleksiyonlar için boyutları, numaralandırma ve senkronizasyon

    IList : 
	Ekleme silme güncelleme metotlarını sağlayan yapıdır IList

    IDictionary
	Anahtar değer yapısı ile dizi saklamaya yarar

     
     
     */
}
