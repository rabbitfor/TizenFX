/*
 * Copyright(c) 2021 Samsung Electronics Co., Ltd.
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
using System.Diagnostics;

namespace Tizen.NUI
{
    /// <summary>
    /// The Text Shadow for TextLabel.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class TextShadow : ICloneable, IDisposable
    {
        private bool disposed = false;
        private readonly PropertyMap propertyMap = null;

        internal delegate void PropertyChangedCallback(TextShadow instance);

        /// <summary>
        /// Constructor
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TextShadow(Color color, Vector2 offset, float blurRadius)
        {
            propertyMap = PropertyMap.GetReusable();

            Color = color;
            propertyMap.SetColor("color", Color);

            Offset = offset;
            propertyMap.SetVector2("offset", Offset);

            BlurRadius = blurRadius;
            propertyMap.SetFloat("blurRadius", BlurRadius);
        }

        /// <summary>
        /// Deep copy method
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public object Clone()
        {
            return new TextShadow((Color)Color?.Clone(), Offset, BlurRadius);
        }

        /// <summary>
        /// Deep copy method (static)
        /// This provides nullity check.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static object Clone(TextShadow instance)
        {
            return instance == null ? null : new TextShadow(instance.Color, instance.Offset, instance.BlurRadius);
        }

        /// <summary>
        /// The color for the shadow of text.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color Color { get; } = Color.Black;

        /// <summary>
        /// The offset for the shadow of text.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector2 Offset { get; } = Vector2.Zero;

        /// <summary>
        /// The blur radius of the shadow of text.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float BlurRadius { get; } = 0.0f;

        internal TextShadow(PropertyMap propertyMap)
        {
            this.propertyMap = new PropertyMap(propertyMap);
        }

        internal TextShadow(TextShadow other)
        {
            propertyMap = PropertyMap.GetReusable();

            Color = other.Color;
            propertyMap.SetColor("color", Color);

            Offset = other.Offset;
            propertyMap.SetVector2("offset", Offset);

            BlurRadius = other.BlurRadius;
            propertyMap.SetFloat("blurRadius", BlurRadius);
        }

        // NOTE Please remove after check FLUX does not use it
        static internal PropertyValue ToPropertyValue(TextShadow instance)
        {
            if (instance == null)
            {
                return new PropertyValue();
            }

            return new PropertyValue(instance.propertyMap);
        }

        static internal PropertyMap ToPropertyMap(TextShadow instance)
        {
            Debug.Assert(instance == null);
            return instance.propertyMap;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                propertyMap?.Dispose();
                Color?.Dispose();
                Offset?.Dispose();
            }
            disposed = true;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Dispose()
        {
            Dispose(true);
            global::System.GC.SuppressFinalize(this);
        }
    }
}
