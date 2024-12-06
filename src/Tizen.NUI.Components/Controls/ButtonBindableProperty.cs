using System.ComponentModel;
using Tizen.NUI.Binding;

namespace Tizen.NUI.Components
{
    public partial class Button
    {
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IconRelativeOrientationProperty;

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IsSelectedProperty;

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IsSelectableProperty;

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IconPaddingProperty;

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextPaddingProperty;

        /// <summary> The bindable property of ItemAlignment. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly BindableProperty ItemAlignmentProperty;

        /// <summary> The bindable property of ItemHorizontalAlignment. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly BindableProperty ItemHorizontalAlignmentProperty;

        /// <summary> The bindable property of ItemVerticalAlignment. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly BindableProperty ItemVerticalAlignmentProperty;

        /// <summary> The bindable property of ItemSpacing. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly BindableProperty ItemSpacingProperty;

        /// <summary>
        /// TextProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextProperty;

        /// <summary>
        /// TranslatableTextProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TranslatableTextProperty;

        /// <summary>
        /// PointSizeProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty PointSizeProperty;

        /// <summary>
        /// FontFamilyProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty FontFamilyProperty;

        /// <summary>
        /// TextColorProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextColorProperty;

        /// <summary>
        /// TextAlignmentProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextAlignmentProperty;

        /// <summary>
        /// IconURLProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IconURLProperty;

        /// <summary>
        /// IconSizeProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IconSizeProperty;

        /// <summary>
        /// TextSelectorProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextSelectorProperty;

        /// <summary>
        /// TranslatableTextSelectorProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TranslatableTextSelectorProperty;

        /// <summary>
        /// TextColorSelectorProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextColorSelectorProperty;

        /// <summary>
        /// PointSizeSelectorProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty PointSizeSelectorProperty;

        /// <summary>
        /// IconURLSelectorProperty
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IconURLSelectorProperty;

        internal static void SetInternalIconRelativeOrientationProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalIconRelativeOrientation = (IconOrientation?)newValue;
            }
        }

        internal static object GetInternalIconRelativeOrientationProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalIconRelativeOrientation;
        }

        internal static void SetInternalIsSelectedProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalIsSelected = (bool)newValue;
            }
        }

        internal static object GetInternalIsSelectedProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalIsSelected;
        }

        internal static void SetInternalIsSelectableProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalIsSelectable = (bool)newValue;
            }
        }

        internal static object GetInternalIsSelectableProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalIsSelectable;
        }

        internal static void SetInternalIconPaddingProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalIconPadding = newValue as Extents;
            }
        }

        internal static object GetInternalIconPaddingProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalIconPadding;
        }

        internal static void SetInternalTextPaddingProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalTextPadding = newValue as Extents;
            }
        }

        internal static object GetInternalTextPaddingProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalTextPadding;
        }

        internal static void SetInternalItemAlignmentProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalItemAlignment = (LinearLayout.Alignment)newValue;
            }
        }

        internal static object GetInternalItemAlignmentProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalItemAlignment;
        }

        internal static void SetInternalItemHorizontalAlignmentProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalItemHorizontalAlignment = (HorizontalAlignment)newValue;
            }
        }

        internal static object GetInternalItemHorizontalAlignmentProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalItemHorizontalAlignment;
        }

        internal static void SetInternalItemVerticalAlignmentProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalItemVerticalAlignment = (VerticalAlignment)newValue;
            }
        }

        internal static object GetInternalItemVerticalAlignmentProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalItemVerticalAlignment;
        }

        internal static void SetInternalItemSpacingProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalItemSpacing = (Size2D)newValue;
            }
        }

        internal static object GetInternalItemSpacingProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalItemSpacing;
        }

        internal static void SetInternalTextProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalText = newValue as string;
            }
        }

        internal static object GetInternalTextProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalText;
        }

        internal static void SetInternalTranslatableTextProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalTranslatableText = newValue as string;
            }
        }

        internal static object GetInternalTranslatableTextProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalTranslatableText;
        }

        internal static void SetInternalPointSizeProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalPointSize = (float)newValue;
            }
        }

        internal static object GetInternalPointSizeProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalPointSize;
        }

        internal static void SetInternalFontFamilyProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalFontFamily = newValue as string;
            }
        }

        internal static object GetInternalFontFamilyProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalFontFamily;
        }

        internal static void SetInternalTextColorProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalTextColor = newValue as Color;
            }
        }

        internal static object GetInternalTextColorProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalTextColor;
        }

        internal static void SetInternalTextAlignmentProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalTextAlignment = (HorizontalAlignment)newValue;
            }
        }

        internal static object GetInternalTextAlignmentProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalTextAlignment;
        }

        internal static void SetInternalIconURLProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalIconURL = newValue as string;
            }
        }

        internal static object GetInternalIconURLProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalIconURL;
        }

        internal static void SetInternalIconSizeProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            if (newValue != null)
            {
                instance.InternalIconSize = newValue as Size;
            }
        }

        internal static object GetInternalIconSizeProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalIconSize;
        }

        internal static void SetInternalTextSelectorProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            instance.InternalTextSelector = newValue as StringSelector;
        }

        internal static object GetInternalTextSelectorProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalTextSelector;
        }

        internal static void SetInternalTranslatableTextSelectorProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            instance.InternalTranslatableTextSelector = newValue as StringSelector;
        }

        internal static object GetInternalTranslatableTextSelectorProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalTranslatableTextSelector;
        }

        internal static void SetInternalTextColorSelectorProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            instance.InternalTextColorSelector = newValue as ColorSelector;
        }

        internal static object GetInternalTextColorSelectorProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalTextColorSelector;
        }

        internal static void SetInternalPointSizeSelectorProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            instance.InternalPointSizeSelector = newValue as FloatSelector;
        }

        internal static object GetInternalPointSizeSelectorProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalPointSizeSelector;
        }

        internal static void SetInternalIconURLSelectorProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (Button)bindable;
            instance.InternalIconURLSelector = newValue as StringSelector;
        }

        internal static object GetInternalIconURLSelectorProperty(BindableObject bindable)
        {
            var instance = (Button)bindable;
            return instance.InternalIconURLSelector;
        }
    }
}
