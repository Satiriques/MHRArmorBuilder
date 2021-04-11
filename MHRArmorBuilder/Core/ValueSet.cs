using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace MHRArmorBuilder.Core
{
    /// <summary>
    /// Hashset but without null
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [DebuggerDisplay("Count = {Count}")]
    public class ValueSet<T> : ICollection<T> where T : class
    {
        private readonly HashSet<T> _hashSet = new();
        public IEnumerator<T> GetEnumerator() => _hashSet.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public void Add(T item) => AddIfNotNullAndNotPresent(item);
        private bool AddIfNotNullAndNotPresent(T value) => value != null && _hashSet.Add(value);
        public void Clear() => _hashSet.Clear();
        public bool Contains(T item) => _hashSet.Contains(item);
        public void CopyTo(T[] array, int arrayIndex) => _hashSet.CopyTo(array, arrayIndex);
        public bool Remove(T item) => _hashSet.Remove(item);
        public bool IsReadOnly => false;
        public int Count => _hashSet.Count;
    }
}