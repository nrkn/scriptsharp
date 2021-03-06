// WindowInstance.cs
// Script#/Libraries/Web
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    /// <summary>
    /// The window object represents the current browser window, and is the top-level
    /// scripting object.
    /// </summary>
    [IgnoreNamespace]
    [Imported]
    public sealed class WindowInstance {

        private WindowInstance() {
        }

        [IntrinsicProperty]
        public bool Closed {
            get {
                return false;
            }
        }

        [IntrinsicProperty]
        public string DefaultStatus {
            get { 
                return null; 
            }
            set { 
            }
        }

        [IntrinsicProperty]
        public DocumentInstance Document {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public IFrameElement FrameElement {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public Location Location {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public WindowInstance Parent {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public WindowInstance Opener {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public int PageXOffset {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public int PageYOffset {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public WindowInstance Self {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public string Status {
            get { 
                return null; 
            }
            set { 
            }
        }

        [IntrinsicProperty]
        public WindowInstance Top {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public WindowInstance[] Frames {
            get {
                return null;
            }
        }

        /// <summary>
        /// Adds a listener for the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event such as 'load'.</param>
        /// <param name="listener">The listener to be invoked in response to the event.</param>
        public void AddEventListener(string eventName, ElementEventListener listener) {
        }

        /// <summary>
        /// Adds a listener for the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event such as 'load'.</param>
        /// <param name="listener">The listener to be invoked in response to the event.</param>
        /// <param name="useCapture">Whether the listener wants to initiate capturing the event.</param>
        public void AddEventListener(string eventName, ElementEventListener listener, bool useCapture) {
        }

        public void Close() {
        }

        public bool DispatchEvent(MutableEvent eventObject) {
            return false;
        }

        public void Navigate(string url) {
        }

        public void Print() {
        }

        /// <summary>
        /// Removes a listener for the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event such as 'load'.</param>
        /// <param name="listener">The listener to be invoked in response to the event.</param>
        public void RemoveEventListener(string eventName, ElementEventListener listener) {
        }

        /// <summary>
        /// Removes a listener for the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event such as 'load'.</param>
        /// <param name="listener">The listener to be invoked in response to the event.</param>
        /// <param name="useCapture">Whether the listener wants to initiate capturing the event.</param>
        public void RemoveEventListener(string eventName, ElementEventListener listener, bool useCapture) {
        }

        public void Scroll(int x, int y) {
        }

        public void ScrollBy(int x, int y) {
        }

        public void ScrollTo(int x, int y) {
        }

        public void PostMessage(string message, string targetOrigin) {
        }
    }
}
