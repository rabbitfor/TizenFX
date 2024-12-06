/*
 * Copyright(c) 2022 Samsung Electronics Co., Ltd.
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
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Tizen.NUI.Binding;

namespace Tizen.NUI.BaseComponents
{
    /// <summary>
    /// The base class of style attributes for a view.
    /// This class provides a base for defining styles that can be applied to views.
    /// </summary>
    /// <since_tizen> 9 </since_tizen>
    public partial class ViewStyle : BindableObject, IDisposable
    {
        static readonly Dictionary<string, Action<View, object>> viewSetters = new Dictionary<string, Action<View, object>>()
        {
            { nameof(BackgroundImage), (v, o) => View.SetInternalBackgroundImageProperty(v, null, o) },
            { nameof(Focusable), (v, o) => v.Focusable = (bool)o },
            { nameof(FocusableChildren), (v, o) => v.FocusableChildren = (bool)o },
            { nameof(FocusableInTouch), (v, o) => v.FocusableInTouch = (bool)o },
            { nameof(Size2D), (v, o) => v.Size2D = (Size2D)o },
            { nameof(Opacity), (v, o) => View.SetInternalOpacityProperty(v, null, o) },
            { nameof(Position2D), (v, o) => v.Position2D = (Position2D)o },
            { nameof(PositionUsesPivotPoint), (v, o) => v.PositionUsesPivotPoint = (bool)o },
            { nameof(ParentOrigin), (v, o) => v.ParentOrigin = (Position)o },
            { nameof(PivotPoint), (v, o) => v.PivotPoint = (Position)o },
            { nameof(SizeWidth), (v, o) => v.SizeWidth = (float)o },
            { nameof(SizeHeight), (v, o) => v.SizeHeight = (float)o },
            { nameof(Position), (v, o) => v.Position = (Position)o },
            { nameof(PositionX), (v, o) => v.PositionX = (float)o },
            { nameof(PositionY), (v, o) => v.PositionY = (float)o },
            { nameof(Orientation), (v, o) => v.Orientation = (Rotation)o },
            { nameof(DrawMode), (v, o) => v.DrawMode = (DrawModeType)o },
            { nameof(SizeModeFactor), (v, o) => v.SizeModeFactor = (Vector3)o },
            { nameof(WidthResizePolicy), (v, o) => v.WidthResizePolicy = (ResizePolicyType)o },
            { nameof(HeightResizePolicy), (v, o) => v.HeightResizePolicy = (ResizePolicyType)o },
            { nameof(WidthForHeight), (v, o) => v.WidthForHeight = (bool)o },
            { nameof(HeightForWidth), (v, o) => v.HeightForWidth = (bool)o },
            { nameof(Padding), (v, o) => v.Padding = (Extents)o },
            { nameof(MinimumSize), (v, o) => v.MinimumSize = (Size2D)o },
            { nameof(MaximumSize), (v, o) => v.MaximumSize = (Size2D)o },
            { nameof(ClippingMode), (v, o) => v.ClippingMode = (ClippingModeType)o },
            { nameof(Size), (v, o) => v.Size = (Size)o },
            { nameof(Margin), (v, o) => v.Margin = (Extents)o },
            { nameof(BackgroundColor), (v, o) => View.SetInternalBackgroundColorProperty(v, null, o) },
            { nameof(Color), (v, o) => View.SetInternalColorProperty(v, null, o) },
            { nameof(BackgroundImageBorder), (v, o) => View.SetInternalBackgroundImageBorderProperty(v, null, o) },
            { nameof(ImageShadow), (v, o) => View.SetInternalImageShadowProperty(v, null, o) },
            { nameof(BoxShadow), (v, o) => View.SetInternalBoxShadowProperty(v, null, o) },
            { nameof(CornerRadius), (v, o) => v.CornerRadius = (Vector4)o },
            { nameof(CornerRadiusPolicy), (v, o) => v.CornerRadiusPolicy = (VisualTransformPolicyType)o },
            { nameof(BorderlineWidth), (v, o) => v.BorderlineWidth = (float)o },
            { nameof(BorderlineColor), (v, o) => v.BorderlineColor = (Color)o },
            { nameof(BorderlineColorSelector), (v, o) => View.SetInternalBorderlineColorSelectorProperty(v, null, o) },
            { nameof(BorderlineOffset), (v, o) => v.BorderlineOffset = (float)o },
            { nameof(ThemeChangeSensitive), (v, o) => v.ThemeChangeSensitive = (bool)o },
            { nameof(IsEnabled), (v, o) => v.IsEnabled = (bool)o },
        };

        private Dictionary<string, object> values = new Dictionary<string, object>();
        private bool disposed = false;

        static ViewStyle() { }

        /// <summary>
        /// Create an empty style instance.
        /// This constructor initializes an empty style object for a view.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public ViewStyle() { }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ViewStyle(ViewStyle viewAttributes)
        {
            CopyFrom(viewAttributes);
        }

        /// <summary>
        /// The flag that is used when creating a component with this style.
        /// If the value is true, it will include default component style defined in the default theme.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludeDefaultStyle { get; set; } = false;

        /// <summary>
        /// Gets or sets the image resource url of the background of view.
        /// The mutually exclusive with "BackgroundColor". Setting it overwrites existing "BackgroundColor".
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Selector<string> BackgroundImage
        {
            get => GetOrCreateSelectorValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? Focusable
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Whether the children of this view can be focusable by keyboard navigation. If user sets this to false, the children of this view will not be focused.
        /// Note : Default value is true.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? FocusableChildren
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Whether this view can focus by touch.
        /// If Focusable is false, FocusableInTouch is disabled.
        /// If you want to have focus on touch, you need to set both Focusable and FocusableInTouch settings to true.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? FocusableInTouch
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [Obsolete("This has been deprecated. Use Size instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Size2D Size2D
        {
            get => GetValue<Size2D>();
            set => SetValue(value);
        }

        /// <summary>
        /// Defines view's opacity value.
        /// This property allows you to specify different opacity values for various states of the view,
        /// such as normal, pressed, focused, etc.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Selector<float?> Opacity
        {
            get => GetOrCreateSelectorValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [Obsolete("This has been deprecated. Use Position instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Position2D Position2D
        {
            get => GetValue<Position2D>();
            set => SetValue(value);
        }

        /// <summary>
        /// Determines whether the pivot point should be used to determine the position of the view.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public bool? PositionUsesPivotPoint
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the origin of a view within its parent's area.<br />
        /// This is expressed in unit coordinates, such that (0.0, 0.0, 0.5) is the top-left corner of the parent, and (1.0, 1.0, 0.5) is the bottom-right corner.<br />
        /// The default parent-origin is ParentOrigin.TopLeft (0.0, 0.0, 0.5).<br />
        /// A view's position is the distance between this origin and the view's anchor-point.<br />
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Position ParentOrigin
        {
            get => GetValue<Position2D>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the pivot point of a view.<br />
        /// This is expressed in unit coordinates, such that (0.0, 0.0, 0.5) is the top-left corner of the view, and (1.0, 1.0, 0.5) is the bottom-right corner.<br />
        /// The default pivot point is PivotPoint.Center (0.5, 0.5, 0.5).<br />
        /// A view position is the distance between its parent origin and this pivot point.<br />
        /// A view's orientation is the rotation from its default orientation, the rotation is centered around its pivot point.<br />
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Position PivotPoint
        {
            get => GetValue<Position2D>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the width of the view.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public float? SizeWidth
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the height of the view.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public float? SizeHeight
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the position of the view.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Position Position
        {
            get => GetValue<Position2D>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? PositionX
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? PositionY
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Rotation Orientation
        {
            get => GetValue<Rotation>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DrawModeType? DrawMode
        {
            get => GetValue<DrawModeType?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the relative to parent size factor of the view.<br />
        /// This factor is only used when ResizePolicyType is set to either: ResizePolicyType.SizeRelativeToParent or ResizePolicyType.SizeFixedOffsetFromParent.<br />
        /// This view's size is set to the view's size multiplied by or added to this factor, depending on ResizePolicyType.<br />
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Vector3 SizeModeFactor
        {
            get => GetValue<Vector3>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the width resize policy to be used.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public ResizePolicyType? WidthResizePolicy
        {
            get => GetValue<ResizePolicyType?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the height resize policy to be used.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public ResizePolicyType? HeightResizePolicy
        {
            get => GetValue<ResizePolicyType?>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? WidthForHeight
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? HeightForWidth
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the padding for use in layout.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Extents Padding
        {
            get => GetValue<Extents>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the minimum size the view can be assigned in size negotiation.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Size2D MinimumSize
        {
            get => GetValue<Size2D>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the maximum size the view can be assigned in size negotiation.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Size2D MaximumSize
        {
            get => GetValue<Size2D>();
            set => SetValue(value);
        }

        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ClippingModeType? ClippingMode
        {
            get => GetValue<ClippingModeType?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Sets the size of a view for the width, the height, and the depth.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Size Size
        {
            get => GetValue<Size>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the Margin for use in layout.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Extents Margin
        {
            get => GetValue<Extents>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets the color of the background of view.
        /// The mutually exclusive with "BackgroundImage". Setting it overwrites existing "BackgroundImage".
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Selector<Color> BackgroundColor
        {
            get => GetOrCreateSelectorValue<Color>();
            set => SetValue(value);
        }

        /// <summary>
        /// Color
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<Color> Color
        {
            get => GetOrCreateSelectorValue<Color>();
            set => SetValue(value);
        }

        /// <summary>View BackgroundBorder</summary>
        /// This will be public opened after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<Rectangle> BackgroundImageBorder
        {
            get => GetOrCreateSelectorValue<Rectangle>();
            set => SetValue(value);
        }

        /// <summary>
        /// Describes a shadow as an image for a View.
        /// It is null by default.
        /// </summary>
        /// <remarks>
        /// If BoxShadow is not null, the ImageShadow value will be ignored.
        /// </remarks>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<ImageShadow> ImageShadow
        {
            get => GetOrCreateSelectorValue<ImageShadow>();
            set => SetValue(value);
        }

        /// <summary>
        /// Describes a box shaped shadow drawing for a View.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Selector<Shadow> BoxShadow
        {
            get => GetOrCreateSelectorValue<Shadow>();
            set => SetValue(value);
        }

        /// <summary>
        /// The radius for the rounded corners of the View.
        /// The values in Vector4 are used in clockwise order from top-left to bottom-left : Vector4(top-left-corner, top-right-corner, bottom-right-corner, bottom-left-corner).
        /// Each radius will clamp internally to the half of smaller of the view's width or height.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Vector4 CornerRadius
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// <summary>
        /// Whether the CornerRadius property value is relative (percentage [0.0f to 0.5f] of the view size) or absolute (in world units).
        /// It is absolute by default.
        /// When the policy is relative, the corner radius is relative to the smaller of the view's width and height.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public VisualTransformPolicyType? CornerRadiusPolicy
        {
            get => GetValue<VisualTransformPolicyType?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The width for the borderline of the View.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public float? BorderlineWidth
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The color for the borderline of the View.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Color BorderlineColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// <summary>
        /// The color selector for the borderline of the View.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<Color> BorderlineColorSelector
        {
            get => GetOrCreateSelectorValue<Color>();
            set => SetValue(value);
        }

        /// <summary>
        /// The Relative offset for the borderline of the View.
        /// Recommended range : [-1.0f to 1.0f].
        /// If -1.0f, draw borderline inside of the View.
        /// If 1.0f, draw borderline outside of the View.
        /// If 0.0f, draw borderline half inside and half outside.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public float? BorderlineOffset
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The ThemeChangeSensitive value of the View.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? ThemeChangeSensitive
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Flag to decide View can be enabled user interaction or not.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? IsEnabled
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }


        /// <summary>
        /// Allow null properties when merging it into other Theme.
        /// If the value is true, the null properties reset target properties of the other ViewStyle with same key when merge.
        /// It is used in <seealso cref="Theme.Merge(string)"/>, <seealso cref="Theme.Merge(Theme)"/>.
        /// It is also used in <seealso cref="Theme.GetStyle(string)"/> when the Theme has a parent and needs to merge.
        /// Please note that it is false by default.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool SolidNull { get; set; } = false;

        /// <summary>
        /// HashSet of dirty properties. Internal use only.
        /// </summary>
        internal HashSet<BindableProperty> DirtyProperties { get; private set; }

        /// <summary>Create a cloned ViewStyle.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ViewStyle Clone()
        {
            var cloned = CreateInstance();
            cloned.CopyFrom(this);

            return cloned;
        }

        /// <summary>
        /// Releases all resources used by the ViewStyle instance.
        /// The Dispose method releases all resources used by the ViewStyle instance.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public void Dispose()
        {
            Dispose(true);
            global::System.GC.SuppressFinalize(this);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ApplyTo(View view)
        {
            foreach (var (propertyName, value) in values)
            {
                if (value != null)
                    ApplyTo(view, propertyName, value);
            }
        }

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void CopyFrom(BindableObject other)
        {
            if (!(other is ViewStyle source))
            {
                return;
            }

            IncludeDefaultStyle = source.IncludeDefaultStyle;
            SolidNull = source.SolidNull;

            foreach (var (propertyName, value) in source.values)
            {
                values[propertyName] = value;
            }

            // NOTE Please remove the code in this block after clean up styles with bindable property.
            CopyBindableProperty(source);
        }

        /// <summary>
        /// Releases unmanaged and optionally managed resources.
        /// </summary>
        /// <param name="disposing"> If it true, the method has been called by a user's code to release both managed and unmanaged resources. Otherwise the method has been called by the finalizer to release only unmanaged resources.</param>
        /// <since_tizen> 9 </since_tizen>
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed state (managed objects).
                values = null;
            }

            disposed = true;
        }

        /// <summary>
        /// Method that is called when a bound property is changed.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void OnPropertyChangedWithData(BindableProperty property)
        {
            base.OnPropertyChangedWithData(property);

            if (property != null)
            {
                (DirtyProperties ?? (DirtyProperties = new HashSet<BindableProperty>())).Add(property);
            }
        }

        internal ViewStyle CreateInstance()
        {
            return (ViewStyle)Activator.CreateInstance(GetType());
        }

        /// <summary>Merge other style into the current style without creating new one.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal void MergeDirectly(ViewStyle other)
        {
            CopyFrom(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected T GetValue<T>([CallerMemberName] string propertyName = "")
        {
            if (values.TryGetValue(propertyName, out var value))
            {
                return (T)value;
            }
            return default;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected Selector<T> GetOrCreateSelectorValue<T>([CallerMemberName] string propertyName = "")
        {
            if (values.TryGetValue(propertyName, out var value))
            {
                return (Selector<T>)value;
            }

            var created = new Selector<T>();
            SetValue(created, propertyName);

            return created;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected void SetValue<T>(T value, [CallerMemberName] string propertyName = "")
        {
            // NOTE Allow null value. It is used when merging styles with solid null option
            values[propertyName] = value;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual void ApplyTo(View view, string propertyName, object value)
        {
            if (viewSetters.TryGetValue(propertyName, out var setter))
            {
                setter(view, value);
            }
        }

        // NOTE This should not be used anymore
        void CopyBindableProperty(ViewStyle source)
        {
            if (source.DirtyProperties != null)
            {
                IncludeDefaultStyle = source.IncludeDefaultStyle;
                SolidNull = source.SolidNull;

                BindableProperty.GetBindablePropertysOfType(GetType(), out var thisBindableProperties);

                if (thisBindableProperties == null)
                {
                    return;
                }

                foreach (var sourceProperty in source.DirtyProperties)
                {
                    var sourceValue = source.GetValue(sourceProperty);

                    if (sourceValue == null)
                    {
                        continue;
                    }

                    thisBindableProperties.TryGetValue(sourceProperty.PropertyName, out var destinationProperty);

                    if (destinationProperty != null)
                    {
                        InternalSetValue(destinationProperty, sourceValue);
                    }
                }
            }
        }
    }

    /// <summary> Extension methods for ViewStyle class.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ViewStyleExtension
    {
        /// <summary>Merge two styles into the new one.</summary>
        /// <exception cref="ArgumentException">Thrown when failed because of an invalid parameter.</exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static TOut Merge<TOut>(this TOut value, TOut other) where TOut : Tizen.NUI.BaseComponents.ViewStyle
        {
            var newStyle = value.Clone() as TOut;

            newStyle?.CopyFrom(other);

            return newStyle;
        }
    }
}
