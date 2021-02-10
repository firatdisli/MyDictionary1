using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary1
{
    class MyDictionary<K,V>
    {
        K[] Key;
        V[] Value;
        public MyDictionary()
        {
            Key = new K[0];
            Value = new V[0];
        }
        public void Add(K key,V value)
        {
            K[] temporaryKey = Key;
            V[] temporaryValue = Value;

            Key = new K[Key.Length + 1];
            Value = new V[Value.Length + 1];

            for (int i = 0; i <temporaryKey.Length; i++)
            {
                Key[i] = temporaryKey[i];
                Value[i] = temporaryValue[i];

            }
            Key[Key.Length - 1] = key;
            Value[Value.Length - 1] = value;
        }

        public int Lenght
        {
            get { return Key.Length; }
        }

    }
}
