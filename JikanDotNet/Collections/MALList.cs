using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace JikanDotNet
{
    public class MALList<T> : IJsonObject, IList<T>, IList where T : IMalEntity
    {
        protected List<T> InnerList;

        public int Count => this.InnerList.Count;
        bool ICollection<T>.IsReadOnly => ((ICollection<T>)this.InnerList).IsReadOnly;
        bool IList.IsFixedSize => true;
        bool IList.IsReadOnly => ((IList)this.InnerList).IsReadOnly;
        bool ICollection.IsSynchronized => false;
        object ICollection.SyncRoot => ((ICollection)this.InnerList).SyncRoot;

        object IList.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public T this[long malId] => this.InnerList.Find(t => t.MalId.Equals(malId));

        T IList<T>.this[int index]
        {
            get => this.InnerList[index];
            set => this.InnerList[index] = value;
        }

        public MALList() => this.InnerList = new List<T>();
        public MALList(int capacity) => this.InnerList = new List<T>(capacity);
        public MALList(IEnumerable<T> objs) => this.InnerList = new List<T>(objs);

        void ICollection<T>.Add(T item) => this.InnerList.Add(item);
        int IList.Add(object value) => ((IList)this.InnerList).Add(value);
        public void Clear() => this.InnerList.Clear();
        bool ICollection<T>.Contains(T item) => this.InnerList.Contains(item);
        bool IList.Contains(object value) => ((IList)this.InnerList).Contains(value);
        void ICollection<T>.CopyTo(T[] array, int arrayIndex) => this.InnerList.CopyTo(array, arrayIndex);
        void ICollection.CopyTo(Array array, int index) => ((ICollection)this.InnerList).CopyTo(array, index);
        int IList<T>.IndexOf(T item) => this.InnerList.IndexOf(item);
        int IList.IndexOf(object value) => ((IList)this.InnerList).IndexOf(value);
        void IList<T>.Insert(int index, T item) => this.InnerList.Insert(index, item);
        void IList.Insert(int index, object value) => ((IList)this.InnerList).Insert(index, value);
        bool ICollection<T>.Remove(T item) => this.InnerList.Remove(item);
        void IList.Remove(object value) => ((IList)this.InnerList).Remove(value);
        public void RemoveAt(int index) => this.InnerList.RemoveAt(index);
        public IEnumerator<T> GetEnumerator() => this.InnerList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => this.InnerList.GetEnumerator();

        // Other Methods
        public bool Exists(Predicate<T> match) => this.InnerList.Exists(match);
        public T Find(Predicate<T> match) => this.InnerList.Find(match);
        public MALList<T> FindAll(Predicate<T> match) => new MALList<T>(this.InnerList.FindAll(match));
        public void ForEach(Action<T> action) => this.InnerList.ForEach(action);
        public MALList<T> GetRange(int index, int count) => new MALList<T>(this.InnerList.GetRange(index, count));
        public bool TrueForAll(Predicate<T> match) => this.InnerList.TrueForAll(match);

        /// <summary>
        /// Converts this instance into its JSON-indented equivalent string.
        /// </summary>
        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

        /// <summary>
        /// Converts the inheriting class into a JSON string using the specified <see cref="JsonSerializerSettings"/>.
        /// </summary>
        /// <param name="serializerSettings">The <see cref="JsonSerializerSettings"/> used when serializing the object.</param>
        public string ToJson(JsonSerializerSettings serializerSettings) => JsonConvert.SerializeObject(this, serializerSettings);
    }
}
