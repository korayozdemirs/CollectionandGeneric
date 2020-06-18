using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCustomCollection
{
    public class AhmetList : IList
    {
        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        object[] obj = new object[0];
        public int Add(object value)
        {
            Array.Resize(ref obj, obj.Length + 1);
            obj[obj.Length - 1] = value;
            return obj.Length;
        }

        public void Clear()
        {
            obj = new object[0];
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            int maxArray = obj.Length;
            Array.Resize(ref obj, obj.Length + 1);
            for (int i = maxArray; i > index; i--)
            {
                obj[i] = obj[i - 1];
            }
            obj[index] = value;
        }
        int counter = 0;
        public void Remove(object value)
        {
            foreach (var item in obj)
            {
                if (item != value)
                {
                    obj[counter] = item;
                    counter++;
                }
            }
            Array.Resize(ref obj, obj.Length - 1);
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < obj.Length - 1; i++)
            {
                obj[i] = obj[i + 1];
            }
            Array.Resize(ref obj, obj.Length - 1);

        }
    }
}
