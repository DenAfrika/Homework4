using System;
using System.Collections.Generic;

namespace ArrayHelper
{
    public class Class1
    {
        int[] a;
        public Class1(int[] a) 
        {
            this.a = a;
        }
        public Class1(int count, int step, int min)
        {
            a = new int[count];
            int sum = min;
            for (int i = 0; i < count; i++)
            {
                a[i] = sum;
                sum += step;
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int i in a)
                    sum += i;
                return sum;
            }
        }
        public Class1 Inverse()
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                b[i] = -a[i];
            return new Class1(b);
        }
        public int[] Multi(int num)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] *= num;
            return a;
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
            return max;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                foreach (int i in a)
                    if (i == max) count++;    
                return count;
            }
        }
        public Dictionary<int, int> Map
        {
            get 
            {
                Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
                foreach (int i in a)
                {
                    if (!keyValuePairs.ContainsKey(i))
                    {
                        int sum = 0;
                        foreach (int j in a)
                        {
                            if (i == j) sum++;
                        }
                        keyValuePairs.Add(i, sum);
                    }
                }
                return keyValuePairs;
            }
        }
        public override string ToString()
        {
            string str = "";
            foreach (int v in a)
                str += v + " ";
            return str;
        }

    }
}
