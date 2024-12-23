/*
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
using System.ComponentModel;
using Tizen.NUI.Binding;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Numerics;

namespace Tizen.NUI
{

    /// <summary>
    /// A four-dimensional vector.
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    [Binding.TypeConverter(typeof(Vector4TypeConverter))]
    public class Vector4 : Disposable, ICloneable
    {
        float x;
        float y;
        float z;
        float w;

        /// <summary>
        /// The default constructor initializes the vector to 0.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Vector4() : base()
        {
        }

        /// <summary>
        /// The conversion constructor from four floats.
        /// </summary>
        /// <param name="x">The x (or r/s) component.</param>
        /// <param name="y">The y (or g/t) component.</param>
        /// <param name="z">The z (or b/p) component.</param>
        /// <param name="w">The w (or a/q) component.</param>
        /// <since_tizen> 3 </since_tizen>
        public Vector4(float x, float y, float z, float w) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// The conversion constructor from an array of four floats.
        /// </summary>
        /// <param name="array">The array of either xyzw/rgba/stpq.</param>
        /// <since_tizen> 3 </since_tizen>
        public Vector4(float[] array) : this()
        {
            if (array.Length < 4)
            {
                throw new ArgumentException($"Invalid length of {array}");
            }
            x = array[0];
            y = array[1];
            z = array[2];
            w = array[3];
        }

        /// <summary>
        /// The conversion constructor from Vector2.
        /// </summary>
        /// <param name="vec2">Vector2 to copy from, z and w are initialized to 0.</param>
        /// <since_tizen> 3 </since_tizen>
        public Vector4(Vector2 vec2) : this()
        {
            x = vec2.X;
            y = vec2.Y;
        }

        /// <summary>
        /// The conversion constructor from Vector3.
        /// </summary>
        /// <param name="vec3">Vector3 to copy from, w is initialized to 0.</param>
        /// <since_tizen> 3 </since_tizen>
        public Vector4(Vector3 vec3) : this()
        {
            x = vec3.X;
            y = vec3.Y;
            z = vec3.Z;
        }

        internal Vector4(global::System.IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn)
        {
            Log.Error("JYJY", "Please do not create Vector4 with c pointer");
            StackTrace st = new StackTrace(true);
            for (int i = 0; i < st.FrameCount; i++)
            {
                StackFrame sf = st.GetFrame(i);
                Log.Error("JYJY", "   Method " + sf.GetMethod() + ":" + sf.GetFileName() + ":" + sf.GetFileLineNumber());
            }
        }

        internal Vector4(Vector4ChangedCallback cb, float x, float y, float z, float w) : this(x, y, z, w)
        {
            callback = cb;
        }
        internal delegate void Vector4ChangedCallback(float x, float y, float z, float w);
        private Vector4ChangedCallback callback = null;

        /// <summary>
        /// Returns a Vector2 instance where both the x and y components are set to 1.0f.
        /// Actual value is (1.0f,1.0f,1.0f,1.0f).
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 One => new Vector4(1, 1, 1, 1);

        /// <summary>
        /// The vector representing the x-axis.
        /// Actual value is (1.0f,0.0f,0.0f,0.0f).
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 XAxis => new Vector4(1, 0, 0, 0);

        /// <summary>
        /// The vector representing the y-axis.
        /// Actual value is (0.0f,1.0f,0.0f,0.0f).
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 YAxis => new Vector4(0, 1, 0, 0);

        /// <summary>
        /// The vector representing the z-axis.
        /// Actual value is (0.0f,0.0f,1.0f,0.0f).
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 ZAxis => new Vector4(0, 0, 1, 0);

        /// <summary>
        /// A Vector2 object representing the zero vector.
        /// Actual value is (0.0f, 0.0f, 0.0f, 0.0f).
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 Zero => new Vector4(0, 0, 0, 0);

        /// <summary>
        /// The x component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.X = 0.1f;
        /// // USE like this
        /// float x = 0.1f, y = 0.5f, z = 0.9f, w = 1.0f;
        /// Vector4 vector4 = new Vector4(x, y, z, w);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float X
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set
            {
                x = value;
                callback?.Invoke(X, Y, Z, W);
            }
            get => x;
        }

        /// <summary>
        /// The red component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.R = 0.1f;
        /// // USE like this
        /// float r = 0.1f, g = 0.5f, b = 0.9f, a = 1.0f;
        /// Vector4 vector4 = new Vector4(r, g, b, a);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float R
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set => X = value;
            get => X;
        }

        /// <summary>
        /// The s component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.S = 0.1f;
        /// // USE like this
        /// float s = 0.1f, t = 0.5f, p = 0.9f, q = 1.0f;
        /// Vector4 vector4 = new Vector4(s, t, p, q);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float S
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set => X = value;
            get => X;
        }

        /// <summary>
        /// The y component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.Y = 0.5f;
        /// // USE like this
        /// float x = 0.1f, y = 0.5f, z = 0.9f, w = 1.0f;
        /// Vector4 vector4 = new Vector4(x, y, z, w);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float Y
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set
            {
                y = value;
                callback?.Invoke(X, Y, Z, W);
            }
            get => y;
        }

        /// <summary>
        /// The green component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.G = 0.5f;
        /// // USE like this
        /// float r = 0.1f, g = 0.5f, b = 0.9f, a = 1.0f;
        /// Vector4 vector4 = new Vector4(r, g, b, a);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float G
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set => Y = value;
            get => Y;
        }

        /// <summary>
        /// The t component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.T = 0.5f;
        /// // USE like this
        /// float s = 0.1f, t = 0.5f, p = 0.9f, q = 1.0f;
        /// Vector4 vector4 = new Vector4(s, t, p, q);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float T
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set => Y = value;
            get => Y;
        }

        /// <summary>
        /// The z component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.Z = 0.9f;
        /// // USE like this
        /// float x = 0.1f, y = 0.5f, z = 0.9f, w = 1.0f;
        /// Vector4 vector4 = new Vector4(x, y, z, w);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float Z
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set
            {
                z = value;
                callback?.Invoke(X, Y, Z, W);
            }
            get => z;
        }

        /// <summary>
        /// The blue component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.B = 0.9f;
        /// // USE like this
        /// float r = 0.1f, g = 0.5f, b = 0.9f, a = 1.0f;
        /// Vector4 vector4 = new Vector4(r, g, b, a);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float B
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set => Z  = value;
            get => Z;
        }

        /// <summary>
        /// The p component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.P = 0.9f;
        /// // USE like this
        /// float s = 0.1f, t = 0.5f, p = 0.9f, q = 1.0f;
        /// Vector4 vector4 = new Vector4(s, t, p, q);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float P
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set => Z = value;
            get => Z;
        }

        /// <summary>
        /// The w component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.W = 1.0f;
        /// // USE like this
        /// float x = 0.1f, y = 0.5f, z = 0.9f, w = 1.0f;
        /// Vector4 vector4 = new Vector4(x, y, z, w);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float W
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set
            {
                w = value;
                callback?.Invoke(X, Y, Z, W);
            }
            get => w;
        }

        /// <summary>
        /// The alpha component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.A = 1.0f;
        /// // USE like this
        /// float r = 0.1f, g = 0.5f, b = 0.9f, a = 1.0f;
        /// Vector4 vector4 = new Vector4(r, g, b, a);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float A
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set => W = value;
            get => W;
        }

        /// <summary>
        /// The q component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use like the followings!
        /// Vector4 vector4 = new Vector4();
        /// vector4.Q = 1.0f;
        /// // USE like this
        /// float s = 0.1f, t = 0.5f, p = 0.9f, q = 1.0f;
        /// Vector4 vector4 = new Vector4(s, t, p, q);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float Q
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use new Vector4(...) constructor")]
            set => W = value;
            get => W;
        }

        /// <summary>
        /// The array subscript operator overload.
        /// </summary>
        /// <param name="index">The subscript index.</param>
        /// <returns>The float at the given index.</returns>
        /// <since_tizen> 3 </since_tizen>
        public float this[uint index]
        {
            get
            {
                return ValueOfIndex(index);
            }
        }


        /// <summary>
        /// The addition operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The vector containing the result of the addition.</returns>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 operator +(Vector4 arg1, Vector4 arg2)
        {
            return arg1?.Add(arg2);
        }

        /// <summary>
        /// The subtraction operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The vector containing the result of the subtraction.</returns>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 operator -(Vector4 arg1, Vector4 arg2)
        {
            return arg1?.Subtract(arg2);
        }

        /// <summary>
        /// The unary negation operator.
        /// </summary>
        /// <param name="arg1">The target value.</param>
        /// <returns>The vector containing the negation.</returns>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 operator -(Vector4 arg1)
        {
            return arg1?.Subtract();
        }

        /// <summary>
        /// The multiplication operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The vector containing the result of the multiplication.</returns>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 operator *(Vector4 arg1, Vector4 arg2)
        {
            return arg1?.Multiply(arg2);
        }

        /// <summary>
        /// The multiplication operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The float value to scale the vector.</param>
        /// <returns>The vector containing the result of scaling.</returns>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 operator *(Vector4 arg1, float arg2)
        {
            return arg1?.Multiply(arg2);
        }

        /// <summary>
        /// The division operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The vector containing the result of the division.</returns>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 operator /(Vector4 arg1, Vector4 arg2)
        {
            return arg1?.Divide(arg2);
        }

        /// <summary>
        /// The division operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The float value to scale the vector by.</param>
        /// <returns>The vector containing the result of scaling.</returns>
        /// <since_tizen> 3 </since_tizen>
        public static Vector4 operator /(Vector4 arg1, float arg2)
        {
            return arg1?.Divide(arg2);
        }

        /// <summary>
        /// Converts the float value to Vector4 class implicitly.
        /// </summary>
        /// <param name="value">A float value to be converted to Vector4</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static implicit operator Vector4(float value)
        {
            return new Vector4(value, value, value, value);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(System.Object obj)
        {
            Vector4 vector4 = obj as Vector4;
            bool equal = false;
            if (X == vector4?.X && Y == vector4?.Y && Z == vector4?.Z && W == vector4?.W)
            {
                equal = true;
            }
            return equal;
        }

        /// <summary>
        /// Gets the hash code of this Vector4.
        /// </summary>
        /// <returns>The Hash Code.</returns>
        /// <since_tizen> 6 </since_tizen>
        public override int GetHashCode()
        {
            return base.SwigCPtr.Handle.GetHashCode();
        }

        /// <summary>
        /// Returns the length of the vector.
        /// </summary>
        /// <returns>The length.</returns>
        /// <since_tizen> 3 </since_tizen>
        public float Length()
        {
            using var handle = GetReusableNativeHandle();
            float ret = Interop.Vector4.Length(handle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Returns the length of the vector squared.<br />
        /// This is faster than using Length() when performing
        /// threshold checks as it avoids use of the square root.<br />
        /// </summary>
        /// <returns>The length of the vector squared.</returns>
        /// <since_tizen> 3 </since_tizen>
        public float LengthSquared()
        {
            using var handle = GetReusableNativeHandle();
            float ret = Interop.Vector4.LengthSquared(handle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Normalizes the vector.<br />
        /// Sets the vector to unit length whilst maintaining its direction.<br />
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public void Normalize()
        {
            using var handle = GetReusableNativeHandle();
            Interop.Vector4.Normalize(handle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Clamps the vector between minimum and maximum vectors.
        /// </summary>
        /// <param name="min">The minimum vector.</param>
        /// <param name="max">The maximum vector.</param>
        /// <since_tizen> 3 </since_tizen>
        public void Clamp(Vector4 min, Vector4 max)
        {
            using var handle = GetReusableNativeHandle();
            using var handleMin = min.GetReusableNativeHandle();
            using var handleMax = max.GetReusableNativeHandle();
            Interop.Vector4.Clamp(handle, handleMin, handleMax);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public object Clone() => new Vector4(X, Y, Z, W);

        internal static Vector4 GetVector4FromPtr(global::System.IntPtr cPtr, bool releaseCPtr)
        {
            var handle = new HandleRef(null, cPtr);
            var vector4 =  new Vector4(Interop.Vector4.XGet(handle), Interop.Vector4.YGet(handle), Interop.Vector4.ZGet(handle), Interop.Vector4.WGet(handle));

            if (releaseCPtr)
            {
                Interop.Vector4.DeleteVector4(handle);
            }

            NDalicPINVOKE.ThrowExceptionIfExists();
            return vector4;
        }

        internal static Vector4 GetVector4FromPtr(global::System.IntPtr cPtr) => GetVector4FromPtr(cPtr, true);

        internal Vector4 FillFrom(HandleRef handle)
        {
            x = Interop.Vector4.XGet(handle);
            y = Interop.Vector4.YGet(handle);
            z = Interop.Vector4.ZGet(handle);
            w = Interop.Vector4.WGet(handle);
            return this;
        }

        internal SWIGTYPE_p_float AsFloat()
        {
            using var handle = GetReusableNativeHandle();
            global::System.IntPtr cPtr = Interop.Vector4.AsFloat(handle);
            SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float Dot(Vector3 other)
        {
            using var handle = GetReusableNativeHandle();
            float ret = Interop.Vector4.DotWithVector3(handle, Vector3.getCPtr(other));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float Dot(Vector4 other)
        {
            using var handle = GetReusableNativeHandle();
            using var otherHandle = other.GetReusableNativeHandle();
            float ret = Interop.Vector4.Dot(handle, otherHandle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float Dot4(Vector4 other)
        {
            using var handle = GetReusableNativeHandle();
            using var otherHandle = other.GetReusableNativeHandle();
            float ret = Interop.Vector4.Dot4(handle, otherHandle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal Vector4 Cross(Vector4 other)
        {
            using var handle = GetReusableNativeHandle();
            using var otherHandle = other.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.Cross(handle, otherHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// This will not be public opened.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void ReleaseSwigCPtr(System.Runtime.InteropServices.HandleRef swigCPtr)
        {
            Interop.Vector4.DeleteVector4(swigCPtr);
        }

        private Vector4 Add(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.Add(handle, rhsHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 AddAssign(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.AddAssign(handle, rhsHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Subtract(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.Subtract(handle, rhsHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 SubtractAssign(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.SubtractAssign(handle, rhsHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Multiply(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.Multiply(handle, rhsHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Multiply(float rhs)
        {
            using var handle = GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.Multiply(handle, rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 MultiplyAssign(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.MultiplyAssign(handle, rhsHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 MultiplyAssign(float rhs)
        {
            using var handle = GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.MultiplyAssign(handle, rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Divide(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.Divide(handle, rhsHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Divide(float rhs)
        {
            using var handle = GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.Divide(handle, rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 DivideAssign(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.DivideAssign(handle, rhsHandle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 DivideAssign(float rhs)
        {
            using var handle = GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.DivideAssign(handle, rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Subtract()
        {
            using var handle = GetReusableNativeHandle();
            Vector4 ret = GetVector4FromPtr(Interop.Vector4.Subtract(handle));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private bool EqualTo(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            bool ret = Interop.Vector4.EqualTo(handle, rhsHandle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private bool NotEqualTo(Vector4 rhs)
        {
            using var handle = GetReusableNativeHandle();
            using var rhsHandle = rhs.GetReusableNativeHandle();
            bool ret = Interop.Vector4.NotEqualTo(handle, rhsHandle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private float ValueOfIndex(uint index)
        {
            using var handle = GetReusableNativeHandle();
            float ret = Interop.Vector4.ValueOfIndex(handle, index);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override HandleRef GetNativeHandle()
        {
            Log.Error("JYJY", "Please do not use naive SwigCPtr for Vector4");
            StackTrace st = new StackTrace(true);
            for (int i = 0; i < st.FrameCount; i++)
            {
                StackFrame sf = st.GetFrame(i);
                Log.Error("JYJY", "   Method " + sf.GetMethod() + ":" + sf.GetFileName() + ":" + sf.GetFileLineNumber());
            }

            if (!SwigCMemOwn && base.SwigCPtr.Handle == IntPtr.Zero)
            {
                Reset(Interop.Vector4.NewVector4(x, y, z, w), true);
            }

            return base.SwigCPtr;
        }

        internal override HandleRef SwigCPtr
        {
            get
            {
                Log.Error("JYJY", "Please do not use naive SwigCPtr for Vector4");
                StackTrace st = new StackTrace(true);
                for (int i = 0; i < st.FrameCount; i++)
                {
                    StackFrame sf = st.GetFrame(i);
                    Log.Error("JYJY", "   Method " + sf.GetMethod() + ":" + sf.GetFileName() + ":" + sf.GetFileLineNumber());
                }

                if (!SwigCMemOwn && base.SwigCPtr.Handle == IntPtr.Zero)
                {
                    Reset(Interop.Vector4.NewVector4(x, y, z, w), true);
                }
                return base.SwigCPtr;
            }
            set => base.SwigCPtr = value;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        internal ObjectPool<Vector4Handle> GetReusableNativeHandle()
        {
            var reusableHandle = ObjectPool<Vector4Handle>.New() ?? new ObjectPool<Vector4Handle>(new Vector4Handle(Interop.Vector4.NewVector4()));
            Interop.Vector4.SetAll(reusableHandle, x, y, z, w);
            return reusableHandle;
        }

        internal static ObjectPool<Vector4Handle> GetEmptyReusableNativeHandle(float x, float y, float z, float w)
        {
            var reusableHandle = ObjectPool<Vector4Handle>.New() ?? new ObjectPool<Vector4Handle>(new Vector4Handle(Interop.Vector4.NewVector4()));
            Interop.Vector4.SetAll(reusableHandle, x, y, z, w);
            return reusableHandle;
        }

        internal static ObjectPool<Vector4Handle> GetEmptyReusableNativeHandle() => GetEmptyReusableNativeHandle(0, 0, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                Dispose(DisposeTypes.Explicit);
            }
            else if (SwigCMemOwn && !IsDisposeQueued)
            {
                base.Dispose(false);
            }
        }

    }

}
