﻿/*
 * Copyright(c) 2019 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;

namespace Tizen.NUI
{
    /// <summary>
    /// A map of property values, the key type could be string or Property::Index.
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    public class PropertyMap : Disposable
    {
        /// <summary>
        /// Default constructor of PropertyMap class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap() : this(Interop.PropertyMap.NewPropertyMap(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// The copy constructor.
        /// </summary>
        /// <param name="other">The map to copy from.</param>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap(PropertyMap other) : this(Interop.PropertyMap.NewPropertyMap(PropertyMap.getCPtr(other)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal PropertyMap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn)
        {
        }

        /// <summary>
        /// Retrieves all keys.
        /// </summary>
        /// <returns>A list of keys.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IList<PropertyKey> Keys
        {
            get
            {
                List<PropertyKey> keys = new List<PropertyKey>();
                for (uint i = 0; i < Count(); i++)
                {
                    keys.Add(GetKeyAt(i));
                }
                return keys;
            }
        }

        /// <summary>
        /// Retrieves all values.
        /// </summary>
        /// <returns>A list of values.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IList<PropertyValue> Values
        {
            get
            {
                List<PropertyValue> values = new List<PropertyValue>();
                for (uint i = 0; i < Count(); i++)
                {
                    values.Add(GetValue(i));
                }
                return values;
            }
        }

        /// <summary>
        /// The operator to access the element with the specified string key.<br />
        /// If an element with the key does not exist, then it is created.<br />
        /// </summary>
        /// <param name="key">The key whose value to access.</param>
        /// <returns>A value for the element with the specified key.</returns>
        /// <since_tizen> 3 </since_tizen>
        public PropertyValue this[string key]
        {
            get
            {
                return ValueOfIndex(key);
            }
            set
            {
                SetValue(key, value);
            }
        }

        /// <summary>
        /// The operator to access the element with the specified index key.<br />
        /// If an element with the key does not exist, then it is created.<br />
        /// </summary>
        /// <param name="key">The key whose value to access.</param>
        /// <returns>A value for the element with the specified key.</returns>
        /// <since_tizen> 3 </since_tizen>
        public PropertyValue this[int key]
        {
            get
            {
                return ValueOfIndex(key);
            }
            set
            {
                SetValue(key, value);
            }
        }

        /// <summary>
        /// Retrieves the number of elements in the map.
        /// </summary>
        /// <returns>The number of elements in the map.</returns>
        /// <since_tizen> 3 </since_tizen>
        public uint Count()
        {
            uint ret = Interop.PropertyMap.Count(SwigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Returns whether the map is empty.
        /// </summary>
        /// <returns>Returns true if empty, false otherwise.</returns>
        /// <since_tizen> 3 </since_tizen>
        public bool Empty()
        {
            bool ret = Interop.PropertyMap.Empty(SwigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Inserts the key-value pair in the map, with the key type as string.<br />
        /// The error message would be shown if the pair with the same key already exists.
        /// </summary>
        /// <param name="key">The key to insert.</param>
        /// <param name="value">The value to insert.</param>
        /// <since_tizen> 3 </since_tizen>
        public void Insert(string key, PropertyValue value)
        {
            global::System.IntPtr cPtr = Interop.PropertyMap.Find(SwigCPtr, key);
            if (cPtr != global::System.IntPtr.Zero)
            {
                Tizen.Log.Error("NUI", $"The key {key} already exists. please do not use duplicate key");
            }
            Interop.PropertyMap.Insert(SwigCPtr, key, PropertyValue.getCPtr(value));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Inserts the key-value pair in the map, with the key type as index.<br />
        /// The error message would be shown if the pair with the same key already exists.
        /// </summary>
        /// <param name="key">The key to insert.</param>
        /// <param name="value">The value to insert.</param>
        /// <since_tizen> 3 </since_tizen>
        public void Insert(int key, PropertyValue value)
        {
            global::System.IntPtr cPtr = Interop.PropertyMap.Find(SwigCPtr, key);
            if (cPtr != global::System.IntPtr.Zero)
            {
                Tizen.Log.Error("NUI", $"The key {key} already exists. please do not use duplicate key");
            }
            Interop.PropertyMap.Insert(SwigCPtr, key, PropertyValue.getCPtr(value));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Inserts the key-value pair in the map, with the key type as string.<br />
        /// The error message would be shown if the pair with the same key already exists.
        /// </summary>
        /// <param name="key">The key to insert.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>Returns a reference to this object.</returns>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap Add(string key, PropertyValue value) => Add(key, getCPtr(value));

        /// <summary>
        /// Inserts the key-value pair in the map, with the key type as string.<br />
        /// The error message would be shown if the pair with the same key already exists.
        /// </summary>
        /// <param name="key">The key to insert.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>Returns a reference to this object.</returns>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap Add(int key, PropertyValue value) => Add(key, getCPtr(value));

        /// <summary>
        /// Inserts the keyvalue to the map.<br />
        /// The exception would be thrown if the pair with the same key already exists.
        /// </summary>
        /// <param name="keyValue">The keyvalue to insert.</param>
        /// <returns>Returns a reference to this object.</returns>
        /// <exception cref="global::System.ArgumentNullException"> Thrown when keyValue is null. </exception>
        public PropertyMap Add(KeyValue keyValue)
        {
            if (null == keyValue)
            {
                throw new global::System.ArgumentNullException(nameof(keyValue));
            }
            if (keyValue.IntegerKey != null)
            {
                Add((int)keyValue.IntegerKey, keyValue.PropertyValue);
            }
            else if (keyValue.StringKey != null)
            {
                Add(keyValue.StringKey, keyValue.PropertyValue);
            }

            return this;
        }

        /// <summary>
        /// Removes the element by the specified key.
        /// </summary>
        /// <param name="key">The index key to find.</param>
        /// <returns>True if the element is removed, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Remove(PropertyKey key)
        {
            if (null == key)
            {
                throw new global::System.ArgumentNullException(nameof(key));
            }
            bool isRemoved = false;
            if (key.Type == PropertyKey.KeyType.Index)
            {
                isRemoved = Interop.PropertyMap.Remove(SwigCPtr, key.IndexKey);
            }
            else if(key.Type == PropertyKey.KeyType.String)
            {
                isRemoved = Interop.PropertyMap.Remove(SwigCPtr, key.StringKey);
            }
            return isRemoved;
        }

        /// <summary>
        /// Removes the element by the specified integer key.
        /// </summary>
        /// <param name="key">The index key to find.</param>
        /// <returns>True if the element is removed, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Remove(int key)
        {
            return Interop.PropertyMap.Remove(SwigCPtr, key);
        }

        /// <summary>
        /// Determines whether the PropertyMap contains the specified key.
        /// </summary>
        /// <param name="key">The index key to find.</param>
        /// <returns>True if it exists, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Contains(PropertyKey key)
        {
            if (null == key)
            {
                throw new global::System.ArgumentNullException(nameof(key));
            }
            global::System.IntPtr cPtr = global::System.IntPtr.Zero;
            if (key.Type == PropertyKey.KeyType.Index)
            {
                cPtr = Interop.PropertyMap.Find(SwigCPtr, key.IndexKey);
            }
            else if (key.Type == PropertyKey.KeyType.String)
            {
                cPtr = Interop.PropertyMap.Find(SwigCPtr, key.StringKey);
            }
            return cPtr != global::System.IntPtr.Zero;
        }

        /// <summary>
        /// Retrieves the value at the specified position.
        /// </summary>
        /// <param name="position">The specified position.</param>
        /// <returns>A reference to the value at the specified position.</returns>
        /// <since_tizen> 3 </since_tizen>
        public PropertyValue GetValue(uint position)
        {
            PropertyValue ret = new PropertyValue(Interop.PropertyMap.GetValue(SwigCPtr, position), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Retrieves the key at the specified position.
        /// </summary>
        /// <param name="position">The specified position.</param>
        /// <returns>A copy of the key at the specified position.</returns>
        /// <since_tizen> 3 </since_tizen>
        public PropertyKey GetKeyAt(uint position)
        {
            PropertyKey ret = new PropertyKey(Interop.PropertyMap.GetKeyAt(SwigCPtr, position), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Finds the value for the specified key if it exists.
        /// </summary>
        /// <param name="key">The key to find.</param>
        /// <returns>The value if it exists, an empty object otherwise.</returns>
        /// <since_tizen> 3 </since_tizen>
        public PropertyValue Find(int key)
        {
            global::System.IntPtr cPtr = Interop.PropertyMap.Find(SwigCPtr, key);
            PropertyValue ret = (cPtr == global::System.IntPtr.Zero) ? null : new PropertyValue(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Finds the value for the specified keys if either exist.
        /// </summary>
        /// <param name="indexKey">The index key to find.</param>
        /// <param name="stringKey">The string key to find.</param>
        /// <returns>The value if it exists, an empty object otherwise.</returns>
        /// <since_tizen> 3 </since_tizen>
        public PropertyValue Find(int indexKey, string stringKey)
        {
            global::System.IntPtr cPtr = Interop.PropertyMap.Find(SwigCPtr, indexKey, stringKey);
            PropertyValue ret = (cPtr == global::System.IntPtr.Zero) ? null : new PropertyValue(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Clears the map.
        /// This method removes all key-value pairs from the PropertyMap.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public void Clear()
        {
            Interop.PropertyMap.Clear(SwigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Merges values from the map 'from' to the current.<br />
        /// Any values in 'from' will overwrite the values in the current map.<br />
        /// </summary>
        /// <param name="from">The map to merge from.</param>
        /// <since_tizen> 3 </since_tizen>
        public void Merge(PropertyMap from)
        {
            if (from == null)
            {
                throw new global::System.ArgumentNullException(nameof(from));
            }
            Interop.PropertyMap.Merge(SwigCPtr, PropertyMap.getCPtr(from));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Retrieves the element with the specified string key.
        /// </summary>
        /// <param name="key">The key whose value to retrieve.</param>
        /// <returns>The value for the element with the specified key.</returns>
        internal PropertyValue ValueOfIndex(string key)
        {
            PropertyValue ret = new PropertyValue(Interop.PropertyMap.ValueOfIndex(SwigCPtr, key), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Retrieves the element with the specified index key.
        /// </summary>
        /// <param name="key">The key whose value to retrieve.</param>
        /// <returns>The value for the element with the specified key.</returns>
        internal PropertyValue ValueOfIndex(int key)
        {
            PropertyValue ret = new PropertyValue(Interop.PropertyMap.ValueOfIndex(SwigCPtr, key), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetValue(PropertyKey key, PropertyValue value)
        {
            if (key.Type == PropertyKey.KeyType.Index)
            {
                Interop.PropertyMap.SetValueIntKey(SwigCPtr, key.IndexKey, PropertyValue.getCPtr(value));
            }
            else if (key.Type == PropertyKey.KeyType.String)
            {
                Interop.PropertyMap.SetValueStringKey(SwigCPtr, key.StringKey, PropertyValue.getCPtr(value));
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
        }

        internal void SetValue(int key, PropertyValue value)
        {
            Interop.PropertyMap.SetValueIntKey(SwigCPtr, key, PropertyValue.getCPtr(value));
            NDalicPINVOKE.ThrowExceptionIfExists();
        }

        internal void SetValue(string key, PropertyValue value)
        {
            Interop.PropertyMap.SetValueStringKey(SwigCPtr, key, PropertyValue.getCPtr(value));
            NDalicPINVOKE.ThrowExceptionIfExists();
        }

        /// This will not be public opened.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void ReleaseSwigCPtr(System.Runtime.InteropServices.HandleRef swigCPtr)
        {
            Interop.PropertyMap.DeletePropertyMap(swigCPtr);
        }

        internal PropertyMap Add(string key, HandleRef value)
        {
            IntPtr cPtr = Interop.PropertyMap.Find(SwigCPtr, key);
            if (cPtr != IntPtr.Zero)
            {
                Log.Error("NUI", $"The key {key} already exists. please do not use duplicate key");
            }
            Interop.PropertyMap.Add(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap Add(int key, HandleRef value)
        {
            IntPtr cPtr = Interop.PropertyMap.Find(SwigCPtr, key);
            if (cPtr != IntPtr.Zero)
            {
                Log.Error("NUI", $"The key {key} already exists. please do not use duplicate key");
            }
            Interop.PropertyMap.Add(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        bool HasDuplicateKey(string key) => Interop.PropertyMap.Find(SwigCPtr, key) != IntPtr.Zero;

        bool HasDuplicateKey(int key) => Interop.PropertyMap.Find(SwigCPtr, key) != IntPtr.Zero;

        void NotifyDuplicateKeyError(string key)
        {
            if (HasDuplicateKey(key))
            {
                Log.Error("NUI", $"The key {key} already exists. please do not use duplicate key");
            }
        }

        void NotifyDuplicateKeyError(int key)
        {
            if (HasDuplicateKey(key))
            {
                Log.Error("NUI", $"The key {key} already exists. please do not use duplicate key");
            }
        }

        internal PropertyMap AddNone(int key)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddNone(SwigCPtr, key);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddBool(string key, bool value)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddBool(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddBool(int key, bool value)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddBool(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddInt(string key, int value)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddInt(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddInt(int key, int value)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddInt(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddFloat(string key, float value)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddFloat(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddFloat(int key, float value)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddFloat(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddString(string key, string value)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddString(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddString(int key, string value)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddString(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector2(string key, float x, float y)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddVector2(SwigCPtr, key, x, y);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector2(int key, float x, float y)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddVector2(SwigCPtr, key, x, y);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector2(string key, Vector2 value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddVector2(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector2(int key, Vector2 value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddVector2(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector3(string key, Vector3 value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddVector3(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector3(int key, Vector3 value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddVector3(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector4(string key, float x, float y, float z, float w)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddVector4(SwigCPtr, key, x, y, z, w);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector4(int key, float x, float y, float z, float w)
        {
            NotifyDuplicateKeyError(key);
            Interop.PropertyMap.AddVector4(SwigCPtr, key, x, y, z, w);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector4(string key, Vector4 value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddVector4(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddVector4(int key, Vector4 value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddVector4(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddColor(string key, Color value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddVector4(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddColor(int key, Color value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddVector4(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddRectangle(string key, Rectangle value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddRectangle(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddRectangle(int key, Rectangle value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddRectangle(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddMap(string key, PropertyMap value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddMap(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap AddMap(int key, PropertyMap value)
        {
            NotifyDuplicateKeyError(key);
            if (!AddNoneIfNull(key, value))
            {
                Interop.PropertyMap.AddMap(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetNone(string key)
        {
            Interop.PropertyMap.SetNone(SwigCPtr, key);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetNone(int key)
        {
            Interop.PropertyMap.SetNone(SwigCPtr, key);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetBool(string key, bool value)
        {
            Interop.PropertyMap.SetBool(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetBool(int key, bool value)
        {
            Interop.PropertyMap.SetBool(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetInt(string key, int value)
        {
            Interop.PropertyMap.SetInt(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetInt(int key, int value)
        {
            Interop.PropertyMap.SetInt(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetFloat(string key, float value)
        {
            Interop.PropertyMap.SetFloat(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetFloat(int key, float value)
        {
            Interop.PropertyMap.SetFloat(SwigCPtr, key, value);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetString(string key, string value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetString(SwigCPtr, key, value);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetString(int key, string value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetString(SwigCPtr, key, value);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetRectangle(string key, Rectangle value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetRectangle(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetRectangle(int key, Rectangle value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetRectangle(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetVector2(string key, float x, float y)
        {
            Interop.PropertyMap.SetVector2(SwigCPtr, key, x, y);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetVector2(int key, float x, float y)
        {
            Interop.PropertyMap.SetVector2(SwigCPtr, key, x, y);
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetVector2(string key, Vector2 value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetVector2(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetVector2(int key, Vector2 value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetVector2(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetVector4(string key, Vector4 value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetVector4(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetVector4(int key, Vector4 value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetVector4(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetColor(string key, Color value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetVector4(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        internal PropertyMap SetColor(int key, Color value)
        {
            if (!SetNoneIfNull(key, value))
            {
                Interop.PropertyMap.SetVector4(SwigCPtr, key, value.SwigCPtr);
            }
            NDalicPINVOKE.ThrowExceptionIfExists();
            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override bool IsReusable => true;

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void Reuse()
        {
            if (SwigCPtr.Handle != IntPtr.Zero)
            {
                Clear();
            }
        }

        internal static PropertyMap GetReusable()
        {
            return DisposablePool.Get<PropertyMap>() ?? new PropertyMap();
        }

        private bool AddNoneIfNull(string key, object value)
        {
            if (value == null)
            {
                Interop.PropertyMap.AddNone(SwigCPtr, key);
                return true;
            }
            return false;
        }

        private bool AddNoneIfNull(int key, object value)
        {
            if (value == null)
            {
                Interop.PropertyMap.AddNone(SwigCPtr, key);
                return true;
            }
            return false;
        }

        private bool SetNoneIfNull(string key, object value)
        {
            if (value == null)
            {
                Interop.PropertyMap.SetNone(SwigCPtr, key);
                return true;
            }
            return false;
        }

        private bool SetNoneIfNull(int key, object value)
        {
            if (value == null)
            {
                Interop.PropertyMap.SetNone(SwigCPtr, key);
                return true;
            }
            return false;
        }
    }

    internal static class PropertyMapSetterHelper
    {
        internal static PropertyMap Add<T>(this PropertyMap propertyMap, int key, T value)
        {
            using (var pv = PropertyValue.CreateFromObject(value))
            {
                propertyMap.Add(key, pv);
            }
            return propertyMap;
        }

        internal static PropertyMap Add<T>(this PropertyMap propertyMap, string key, T value)
        {
            using (var pv = PropertyValue.CreateFromObject(value))
            {
                propertyMap.Add(key, pv);
            }
            return propertyMap;
        }
    }
}
