// IEnumerator.cs
// Script#/Libraries/CoreLib
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System.Runtime.CompilerServices;

namespace System.Collections {

    [Imported]
    [ScriptNamespace("ss")]
    public interface IEnumerator {

        [IntrinsicProperty]
        object Current {
            get;
        }

        bool MoveNext();

        void Reset();
    }
}
