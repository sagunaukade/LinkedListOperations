using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableProgram
{
    public class MyMapNode<K,V>
    {
        public struct KeyValue<k,v>
        {
          public K key { get; set; }
          public v value { get; set; }
        }
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int hash = key.GetHashCode(); //632458
            int position = hash % size; //0 to 5
            return Math.Abs(position);

        }
        public V Get(K, key)
        {
            var linkedList = GetArrayPositionAndLinkedList(key);
            foreach (KeyValue<K,V>)
            {
                if (items.Key.Equal(K)
                {
                    return items.Value;
                }

            }

        }

    }
}
