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
    /// The base class to describe basic shadow.
    /// </summary>
    /// <since_tizen> 9 </since_tizen>
    public abstract class ShadowBase
    {
        private static readonly Vector2 noOffset = new Vector2(0, 0);

        private static readonly Vector2 noExtents = new Vector2(0, 0);

        /// <summary>
        /// The default constructor of ShadowBase class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected ShadowBase() : this(noOffset, noExtents)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected ShadowBase(Vector2 offset, Vector2 extents)
        {
            Offset = offset == null ? null : Vector2.GetReusable(offset);
            Extents = extents == null ? null : Vector2.GetReusable(extents);
        }

        /// <summary>
        /// Create a Shadow from a property map.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected ShadowBase(PropertyMap propertyMap)
        {
            Debug.Assert(propertyMap != null);

            Offset = Vector2.GetReusable(noOffset);
            Extents = Vector2.GetReusable(noExtents);

            var transformProperty = propertyMap.Find(Visual.Property.Transform);

            if (transformProperty == null)
            {
                // No transform map
                return;
            }

            var transformMap = PropertyMap.GetReusable();

            if (transformProperty.Get(transformMap))
            {
                SetTransformMap(transformMap);
            }
            transformProperty.Dispose();
            transformMap.Dispose();
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <exception cref="ArgumentNullException"> Thrown when other is null. </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected ShadowBase(ShadowBase other) : this(other == null ? throw new ArgumentNullException(nameof(other)) : other.Offset, other.Extents)
        {
        }

        /// <summary>
        /// The position offset value (x, y) from the top left corner.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Vector2 Offset { get; internal set; }

        /// <summary>
        /// The shadow will extend its size by specified amount of length.<br />
        /// If the value is negative then the shadow will shrink.
        /// For example, when View's size is (100, 100) and the Shadow's Extents is (5, -5),
        /// the output shadow will have size (105, 95).
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Vector2 Extents { get; internal set; }

        /// <summary>
        /// Equality operator.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public static bool operator ==(ShadowBase shadow1, ShadowBase shadow2)
        {
            return object.ReferenceEquals(shadow1, null) ? object.ReferenceEquals(shadow2, null) : shadow1.Equals(shadow2);
        }

        /// <summary>
        /// Inequality operator.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public static bool operator !=(ShadowBase shadow1, ShadowBase shadow2)
        {
            return !(shadow1 == shadow2);
        }

        /// <inheritdoc/>
        /// <since_tizen> 9 </since_tizen>
        public override bool Equals(object other)
        {
            if ((other == null) || !GetType().Equals(other.GetType()))
            {
                return false;
            }

            var otherShadow = (ShadowBase)other;

            if (!((Offset == null) ? otherShadow.Offset == null : Offset.Equals(otherShadow.Offset)))
            {
                return false;
            }

            return (Extents == null) ? otherShadow.Extents == null : Extents.Equals(otherShadow.Extents);
        }

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = Offset == null ? 0 : Offset.GetHashCode();
                hash = (hash * 7) + (Extents == null ? 0 : Extents.GetHashCode());
                return hash;
            }
        }

        internal abstract bool IsEmpty();

        internal PropertyMap ToPropertyMap(BaseComponents.View attachedView)
        {
            Debug.Assert(!IsEmpty());

            var map = GetPropertyMap();
            map.SetInt(Visual.Property.CornerRadiusPolicy, (int)attachedView.CornerRadiusPolicy);
            map.SetVector4(Visual.Property.CornerRadius, attachedView.CornerRadius);

            return map;
        }

        /// <summary>
        /// Extract a property map.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual PropertyMap GetPropertyMap()
        {
            PropertyMap map = PropertyMap.GetReusable();

            using var transformMap = PropertyMap.GetReusable();

            if (!noOffset.Equals(Offset))
            {
                transformMap.SetVector2((int)VisualTransformPropertyType.OffsetPolicy, (int)VisualTransformPolicyType.Absolute, (int)VisualTransformPolicyType.Absolute);
                transformMap.SetVector2((int)VisualTransformPropertyType.Offset, Offset);
            }

            if (!noExtents.Equals(Extents))
            {
                transformMap.SetVector2((int)VisualTransformPropertyType.ExtraSize, Extents);
            }

            transformMap.SetInt((int)VisualTransformPropertyType.Origin, (int)Visual.AlignType.Center);
            transformMap.SetInt((int)VisualTransformPropertyType.AnchorPoint, (int)Visual.AlignType.Center);

            map.AddMap(Visual.Property.Transform, transformMap);

            return map;
        }

        private void SetTransformMap(PropertyMap transformMap)
        {
            if (transformMap == null)
            {
                return;
            }

            PropertyValue temp = transformMap.Find((int)VisualTransformPropertyType.Offset);
            temp?.Get(Offset);
            temp?.Dispose();
            temp = transformMap.Find((int)VisualTransformPropertyType.ExtraSize);
            temp?.Get(Extents);
            temp?.Dispose();
        }
    }
}
