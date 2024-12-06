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
using System.Collections.Generic;

namespace Tizen.NUI.BaseComponents
{
    /// <summary>
    /// The base class for Children attributes in Components.
    /// </summary>
    /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class TextFieldStyle : ViewStyle
    {
        static readonly Dictionary<string, Action<TextField, object>> viewSetters = new Dictionary<string, Action<TextField, object>>()
        {
            { nameof(PlaceholderText), (v, o) => v.PlaceholderText = (string)o },
            { nameof(PlaceholderTextFocused), (v, o) => v.PlaceholderTextFocused = (string)o },
            { nameof(FontFamily), (v, o) => v.FontFamily = (string)o },
            { nameof(MaxLength), (v, o) => v.MaxLength = (int)o },
            { nameof(ExceedPolicy), (v, o) => v.ExceedPolicy = (int)o },
            { nameof(HorizontalAlignment), (v, o) => v.HorizontalAlignment = (HorizontalAlignment)o },
            { nameof(VerticalAlignment), (v, o) => v.VerticalAlignment = (VerticalAlignment)o },
            { nameof(SecondaryCursorColor), (v, o) => v.SecondaryCursorColor = (Vector4)o },
            { nameof(EnableCursorBlink), (v, o) => v.EnableCursorBlink = (bool)o },
            { nameof(CursorBlinkInterval), (v, o) => v.CursorBlinkInterval = (float)o },
            { nameof(CursorBlinkDuration), (v, o) => v.CursorBlinkDuration = (float)o },
            { nameof(CursorWidth), (v, o) => v.CursorWidth = (int)o },
            { nameof(GrabHandleColor), (v, o) => v.GrabHandleColor = (Color)o },
            { nameof(GrabHandleImage), (v, o) => v.GrabHandleImage = (string)o },
            { nameof(GrabHandlePressedImage), (v, o) => v.GrabHandlePressedImage = (string)o },
            { nameof(SelectionHandleImageLeft), (v, o) => v.SelectionHandleImageLeft = (PropertyMap)o },
            { nameof(SelectionHandleImageRight), (v, o) => v.SelectionHandleImageRight = (PropertyMap)o },
            { nameof(ScrollThreshold), (v, o) => v.ScrollThreshold = (float)o },
            { nameof(ScrollSpeed), (v, o) => v.ScrollSpeed = (float)o },
            { nameof(SelectionHighlightColor), (v, o) => v.SelectionHighlightColor = (Vector4)o },
            { nameof(DecorationBoundingBox), (v, o) => v.DecorationBoundingBox = (Rectangle)o },
            { nameof(InputColor), (v, o) => v.InputColor = (Vector4)o },
            { nameof(EnableMarkup), (v, o) => v.EnableMarkup = (bool)o },
            { nameof(InputFontFamily), (v, o) => v.InputFontFamily = (string)o },
            { nameof(InputPointSize), (v, o) => v.InputPointSize = (float)o },
            { nameof(InputUnderline), (v, o) => v.InputUnderline = (string)o },
            { nameof(InputShadow), (v, o) => v.InputShadow = (string)o },
            { nameof(Emboss), (v, o) => v.Emboss = (string)o },
            { nameof(InputEmboss), (v, o) => v.InputEmboss = (string)o },
            { nameof(InputOutline), (v, o) => v.InputOutline = (string)o },
            { nameof(PixelSize), (v, o) => v.PixelSize = (float)o },
            { nameof(EnableSelection), (v, o) => v.EnableSelection = (bool)o },
            { nameof(Ellipsis), (v, o) => v.Ellipsis = (bool)o },
            { nameof(MatchSystemLanguageDirection), (v, o) => v.MatchSystemLanguageDirection = (bool)o },
            { nameof(TextColor), (v, o) => v.TextColor = (Color)o },
            { nameof(PointSize), (v, o) => v.PointSize = (float)o },
            { nameof(FontSizeScale), (v, o) => v.FontSizeScale = (float)o },
            { nameof(PlaceholderTextColor), (v, o) => v.PlaceholderTextColor = (Vector4)o },
            { nameof(PrimaryCursorColor), (v, o) => v.PrimaryCursorColor = (Vector4)o },
            { nameof(FontStyle), (v, o) => v.FontStyle = (PropertyMap)o },
            { nameof(SelectionPopupStyle), (v, o) => v.SelectionPopupStyle = (PropertyMap)o }
        };

        static TextFieldStyle() { }

        /// <summary>
        /// Create an empty instance.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TextFieldStyle() : base()
        {
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string PlaceholderText
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string PlaceholderTextFocused
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string FontFamily
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int? MaxLength
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int? ExceedPolicy
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public HorizontalAlignment? HorizontalAlignment
        {
            get => GetValue<HorizontalAlignment?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VerticalAlignment? VerticalAlignment
        {
            get => GetValue<VerticalAlignment?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 SecondaryCursorColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? EnableCursorBlink
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? CursorBlinkInterval
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? CursorBlinkDuration
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int? CursorWidth
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color GrabHandleColor
        {
            get => GetValue<Color>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string GrabHandleImage
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string GrabHandlePressedImage
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
        /// This will be public opened in tizen_6.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PropertyMap SelectionHandleImageLeft
        {
            get => GetValue<PropertyMap>();
            set => SetValue(value);
        }
        /// This will be public opened in tizen_6.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PropertyMap SelectionHandleImageRight
        {
            get => GetValue<PropertyMap>();
            set => SetValue(value);
        }
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? ScrollThreshold
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? ScrollSpeed
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 SelectionHighlightColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Rectangle DecorationBoundingBox
        {
            get => GetValue<Rectangle>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 InputColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? EnableMarkup
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputFontFamily
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? InputPointSize
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputUnderline
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputShadow
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Emboss
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputEmboss
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputOutline
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? PixelSize
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? EnableSelection
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? Ellipsis
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? MatchSystemLanguageDirection
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color TextColor
        {
            get => GetValue<Color>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? PointSize
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? FontSizeScale
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 PlaceholderTextColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// <summary>
        /// Gets or sets primary cursor color.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 PrimaryCursorColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PropertyMap FontStyle
        {
            get => GetValue<PropertyMap>();
            set => SetValue(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public PropertyMap SelectionPopupStyle
        {
            get => GetValue<PropertyMap>();
            set => SetValue(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void ApplyTo(View view, string propertyName, object value)
        {
            if (view is TextField textField && viewSetters.TryGetValue(propertyName, out var setter))
            {
                setter(textField, value);
            }
            else
            {
                base.ApplyTo(view, propertyName, value);
            }
        }
    }
}
