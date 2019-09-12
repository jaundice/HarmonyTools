using System;

namespace HarmonyTools
{
    internal class DoubleLinkedListEntry<T>
    {
        internal DoubleLinkedListEntry(T item)
        {
            Item = item;
        }

        public T Item { get; }

        public DoubleLinkedListEntry<T> Forward { get; protected set; }

        public DoubleLinkedListEntry<T> Backward { get; protected set; }

        public void Append(DoubleLinkedListEntry<T> next)
        {
            if (Forward != null) throw new Exception("Already Forward Linked");

            if (next.Backward != null) throw new Exception("Argument is Already Backward Linked");

            Forward = next;
            next.Backward = this;
        }
    }
}