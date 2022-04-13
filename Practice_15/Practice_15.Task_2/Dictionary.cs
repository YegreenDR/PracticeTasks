using System.Collections;
using System.Collections.Generic;

namespace Practice_15.Task_2
{
    internal class Dictionary
    {

        class MyDictionary<Tkey, Tvalue> : IEnumerable<KeyValue<Tkey, Tvalue>>
        {
            public int Count { get { return myArray.Length; } }

            private KeyValue<Tkey, Tvalue>[] myArray = new KeyValue<Tkey, Tvalue>[0];


            public void Add(Tkey key, Tvalue value)
            {

                Array.Resize(ref myArray, myArray.Length + 1);

                myArray[myArray.Length - 1] = new KeyValue<Tkey, Tvalue>() { key = key, value = value };

            }

            public IEnumerator<KeyValue<Tkey, Tvalue>> GetEnumerator()
            {
                foreach (var item in myArray)
                {
                    yield return item;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return myArray.GetEnumerator();
            }

            public Tvalue this[Tkey index]
            {
                get
                {
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        if (myArray[i].key.Equals(index))
                        {
                            return myArray[i].value;
                        }

                    }
                    throw new DllNotFoundException("Не найдено!");
                }
            }
        }


    }
}
