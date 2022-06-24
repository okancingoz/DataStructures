using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Array<T> : IEnumerable<T>, ICloneable
{
    public T[] InnerList;
    public int Count { get; private set; } // Count is also iterator
    public int Capacity => InnerList.Length;

    public Array()
    {
        InnerList = new T[2];
        Count = 0;
    }

    public Array(params T[] initial)
    {
        InnerList = new T[initial.Length];
        Count = 0;
        foreach (var item in initial)
        {
            Add(item);
        }
    }

    public Array(IEnumerable<T> collection)
    {
        InnerList = new T[collection.ToArray().Length];
        Count = 0;
        foreach (var item in collection)
        {
            Add(item);
        }
    }

    public void Add(T item)
    {
        if (Count == InnerList.Length)
        {
            DoubleArray();
        }
        InnerList[Count] = item;
        Count++;
    }

    public void AddRange(IEnumerable<T> collection)
    {
        InnerList = new T[collection.ToArray().Length];
        Count = 0;
        foreach (var item in collection)
        {
            Add(item);
        }
    }
    private void DoubleArray()
    {
        var temp = new T[InnerList.Length * 2];
        /*
        for (int i = 0; i < InnerList.Length; i++)
        {
            temp[i] = InnerList[i];
        }
        InnerList = temp;
        */
        System.Array.Copy(InnerList, temp, InnerList.Length);
        InnerList = temp;
    }

    public T Remove()
    {
        if (Count == 0)
            throw new Exception("There is no more item to be removed from the array.");
        if (Count == InnerList.Length / 2)
        {
            HalfArray();
        }

        var temp = InnerList[Count - 1];
        if (Count > 0)
            Count--;
        return temp;
    }

    public bool Remove(T item)
    { 
      
      for (int i = 0; i < InnerList.Length; i++)
      {
        if (InnerList[i].Equals(item))
        {   
            int iter = i;
            while (iter != InnerList.Length-1)
            {   
                InnerList[iter] = InnerList[iter+1];
                iter++;
            }
            return true;
        }
      }  
      return false;
    }

    private void HalfArray()
    {
        if (InnerList.Length > 2)
        {
            var temp = new T[InnerList.Length / 2];
            System.Array.Copy(InnerList, temp, temp.Length);
            InnerList = temp;
        }
    }

    public object Clone()
    {
        //return this.MemberwiseClone();
        var arr = new Array<T>();
        foreach (var item in arr)
        {
            arr.Add(item);
        }
        return arr; // deep copy
    }

    public IEnumerator<T> GetEnumerator()
    {
        return InnerList.Select(x => x).GetEnumerator();
        // return InnerList.Take(Count).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
