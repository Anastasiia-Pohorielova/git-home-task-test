using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework_Collection
{
    class Stockroom<TmyType> : IEnumerable<TmyType>, IEnumerator<TmyType>
    {
        private LinkedList<TmyType> stuff = new LinkedList<TmyType>();
        private LinkedListNode<TmyType> stuffNode;
        
        public TmyType Current
        {
            get
            {
                return stuffNode.Value;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (stuffNode == null)
            {
                stuffNode = stuff.First;
            }
            else { stuffNode = stuffNode.Next; }

            return stuffNode != null;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Add(TmyType stockItem)
        {
             stuff.AddLast(stockItem);
        }

        public void RemoveAt(int position)
        {
            stuffNode = stuff.First;

            for (int i = 0; i < position-1; i++)
            {
                stuffNode = stuffNode.Next;
            }

            stuff.Remove(stuffNode);
        }

        public IEnumerator<TmyType> GetEnumerator()
        {
            stuffNode = null;
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}