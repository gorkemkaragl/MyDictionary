using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] _keys;
        TValue[] _values;

        TKey[] tempkeys;
        TValue[] tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];

        }

        public void Add(TKey item1,TValue item2)
        {
            tempkeys = _keys;
            tempValues = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];

            for(int i = 0;i<tempkeys.Length;i++)
            {
                _keys[i] = tempkeys[i];
            }

            _keys[_keys.Length - 1] = item1;

            for(int j =0;j<tempValues.Length;j++)
            {
                _values[j] = tempValues[j];
            }

            _values[_values.Length - 1] = item2;

        }

        public TKey[] Keys
        {
            get { return _keys; }
        }
            
        public TValue[] Values
        {
            get { return _values; }
        }


    }
}
