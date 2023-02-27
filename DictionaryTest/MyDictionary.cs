using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    internal class MyDictionary<T, Y>
    {
        T[] arrayK ;
        Y[] arrayV;
        T[] tempArrayK;
        Y[] tempArrayV;
        public MyDictionary()
        {
            arrayK= new T[0];
            arrayV = new Y[0];
        }

        public void Add(T Key , Y Value)
        {
            tempArrayK = arrayK;
            tempArrayV = arrayV;
            arrayK = new T[arrayK.Length + 1];
            arrayV = new Y[arrayK.Length + 1];
            for(int i = 0 ; i < tempArrayK.Length; i++)
            {
                arrayK[i] = tempArrayK[i];
            }
            for (int i = 0; i < tempArrayV.Length; i++)
            {
                arrayV[i] = tempArrayV[i];
            }
            arrayK[arrayK.Length - 1] = Key;
            arrayV[arrayV.Length - 1] = Value;
        }


        public T[] ArrayK
        {
            get { return arrayK; }
            
        }

        public Y[] ArrayV
        {
            get { return arrayV; }

        }
    }
}
