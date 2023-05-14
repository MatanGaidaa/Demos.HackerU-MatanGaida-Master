using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Demos.HackerU.HomeWork.HW_16.Point;

namespace Demos.HackerU.HomeWork.HW_16
{
    public class GlobalArray<T>
    {
        public T[] array;

        public event EventHandler<GlobalEventArgs<T>> globalEvent = null;


        public GlobalArray(int fixSize)
        {
            array = new T[fixSize];

        }


        public void AddOrUpdate(int index, T item)
        {
            array[index] = item;
            globalEvent.Invoke(this, new GlobalEventArgs<T>(item, index));
        }

        public T GetData(int index)
        {
            return array[index];
        }


    }

    public class GlobalEventArgs<T> : EventArgs
    {
        public T item;
        public int index;
        public GlobalEventArgs(T Item, int index)
        {
            item = Item;
            this.index = index;
        }


    }





}
