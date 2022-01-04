using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    internal class MyDictonary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictonary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void MyAdd(TKey key, TValue value)
        {
            TKey[] tempKey = keys;
            TValue[] TempValue = values;
            keys =new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            for (int i = 0; i < tempKey.Length; i++)
            {
                values[i] = TempValue[i];
            }
            keys[keys.Length - 1]= key;
            values[values.Length - 1] = value;

        }
        public int MyLength
        {
            get { return keys.Length; }
        }
        public TValue[] Values
        {
            get { return values; }
        }
        public TKey[] Keys
        {
            get { return keys; }
        }

    }
}
