// ObservableCollection.cs
// Script#/Libraries/CoreLib
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic {

    [Imported]
    [ScriptNamespace("ss")]
    [ScriptName("ObservableCollection")]
    public sealed class ObservableCollection<T> : IEnumerable<T> {

        public ObservableCollection() {
        }

        public ObservableCollection(T[] items) {
        }

        [ScriptName("length")]
        public int Count {
            get {
                return 0;
            }
        }

        public T this[int index] {
            get {
                return default(T);
            }
            set {
            }
        }

        public void Add(T item) {
        }

        public void Clear() {
        }

        public bool Contains(T item) {
            return false;
        }

        public IEnumerator<T> GetEnumerator() {
            return null;
        }

        public int IndexOf(T item) {
            return 0;
        }

        public void Insert(int index, T item) {
        }

        public bool Remove(T item) {
            return false;
        }

        public void RemoveAt(int index) {
        }

        public T[] ToArray() {
            return null;
        }
    }
}
