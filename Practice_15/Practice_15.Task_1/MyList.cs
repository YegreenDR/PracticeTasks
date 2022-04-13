using System.Collections;

namespace Practice_15.Task_1
{
    class MyList<T> : IEnumerable<T>
    {
        public int count { get { return array.Length; } }
        T[] array = new T[0];
        public void Add(T item)
        {

            Array.Resize(ref array, array.Length + 1);

            array[array.Length - 1] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
