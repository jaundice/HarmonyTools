using System.Collections;
using System.Collections.Generic;

namespace HarmonyTools
{
    internal class ScaleEnumerator : IEnumerable<Note>
    {
        private readonly Pattern _pattern;
        private readonly DoubleLinkedListEntry<Note> _root;

        internal ScaleEnumerator(DoubleLinkedListEntry<Note> root, Pattern pattern)
        {
            _root = root;
            _pattern = pattern;
        }

        public IEnumerator<Note> GetEnumerator()
        {
            var current = _root;

            //yield return current.Item;

            foreach (var interval in _pattern.Intervals)
            {
                for (var i = 0; i < interval; i++) current = current.Forward;

                yield return current.Item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}