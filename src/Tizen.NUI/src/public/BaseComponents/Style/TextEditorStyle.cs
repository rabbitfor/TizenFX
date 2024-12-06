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
using System.Collections.Generic;

namespace Tizen.NUI.BaseComponents
{
    /// <summary>
    /// The style class for TextEditor.
    /// This can decorate a TextEditor instance.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class TextEditorStyle : ViewStyle
    {
        static readonly Dictionary<string, Action<TextEditor, object>> viewSetters = new Dictionary<string, Action<TextEditor, object>>()
        {
            { nameof(FontFamily), (v, o) => v.FontFamily = (string)o },
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
            { nameof(InputFontFamily), (v, o) => v.InputFontFamily = (string)o },
            { nameof(InputPointSize), (v, o) => v.InputPointSize = (float)o },
            { nameof(InputUnderline), (v, o) => v.InputUnderline = (string)o },
            { nameof(InputShadow), (v, o) => v.InputShadow = (string)o },
            { nameof(Emboss), (v, o) => v.Emboss = (string)o },
            { nameof(InputEmboss), (v, o) => v.InputEmboss = (string)o },
            { nameof(InputOutline), (v, o) => v.InputOutline = (string)o },
            { nameof(SmoothScroll), (v, o) => v.SmoothScroll = (bool)o },
            { nameof(SmoothScrollDuration), (v, o) => v.SmoothScrollDuration = (float)o },
            { nameof(EnableScrollBar), (v, o) => v.EnableScrollBar = (bool)o },
            { nameof(ScrollBarShowDuration), (v, o) => v.ScrollBarShowDuration = (float)o },
            { nameof(ScrollBarFadeDuration), (v, o) => v.ScrollBarFadeDuration = (float)o },
            { nameof(PixelSize), (v, o) => v.PixelSize = (float)o },
            { nameof(EnableSelection), (v, o) => v.EnableSelection = (bool)o },
            { nameof(MatchSystemLanguageDirection), (v, o) => v.MatchSystemLanguageDirection = (bool)o },
            { nameof(TextColor), (v, o) => v.TextColor = (Vector4)o },
            { nameof(PointSize), (v, o) => v.PointSize = (float)o },
            { nameof(PlaceholderTextColor), (v, o) => v.PlaceholderTextColor = (Color)o },
            { nameof(PrimaryCursorColor), (v, o) => v.PrimaryCursorColor = (Vector4)o },
            { nameof(FontStyle), (v, o) => v.FontStyle = (PropertyMap)o },
            { nameof(Ellipsis), (v, o) => v.Ellipsis = (bool)o },
            { nameof(LineSpacing), (v, o) => v.LineSpacing = (float)o },
            { nameof(MinLineSize), (v, o) => v.MinLineSize = (float)o },
            { nameof(RelativeLineHeight), (v, o) => v.RelativeLineHeight = (float)o },
            { nameof(FontSizeScale), (v, o) => v.FontSizeScale = (float)o },
            { nameof(SelectionPopupStyle), (v, o) => v.SelectionPopupStyle = (PropertyMap)o }
        };

        static TextEditorStyle() { }

        /// <summary>
        /// Create an empty instance.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TextEditorStyle() : base()
        {
        }

        /// <summary>
        /// The FontFamily property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string FontFamily
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The HorizontalAlignment property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public HorizontalAlignment? HorizontalAlignment
        {
            get => GetValue<HorizontalAlignment?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The VerticalAlignment property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VerticalAlignment? VerticalAlignment
        {
            get => GetValue<VerticalAlignment?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The SecondaryCursorColor property.
        /// Note that the cascade chaining set is impossible. Please set a whole value.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 SecondaryCursorColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// <summary>
        /// The EnableCursorBlink property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? EnableCursorBlink
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The CursorBlinkInterval property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? CursorBlinkInterval
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The CursorBlinkDuration property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? CursorBlinkDuration
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The CursorWidth property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int? CursorWidth
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The GrabHandleColor property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color GrabHandleColor
        {
            get => GetValue<Color>();
            set => SetValue(value);
        }

        /// <summary>
        /// The GrabHandleImage property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string GrabHandleImage
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The GrabHandlePressedImage property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string GrabHandlePressedImage
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The SelectionHandleImageLeft property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PropertyMap SelectionHandleImageLeft
        {
            get => GetValue<PropertyMap>();
            set => SetValue(value);
        }

        /// <summary>
        /// The SelectionHandleImageRight property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PropertyMap SelectionHandleImageRight
        {
            get => GetValue<PropertyMap>();
            set => SetValue(value);
        }

        /// <summary>
        /// The ScrollThreshold property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? ScrollThreshold
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The ScrollSpeed property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? ScrollSpeed
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The SelectionHighlightColor property.
        /// Note that the cascade chaining set is impossible. Please set a whole value.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 SelectionHighlightColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// <summary>
        /// The DecorationBoundingBox property.
        /// Note that the cascade chaining set is impossible. Please set a whole value.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Rectangle DecorationBoundingBox
        {
            get => GetValue<Rectangle>();
            set => SetValue(value);
        }

        /// <summary>
        /// The InputColor property.
        /// Note that the cascade chaining set is impossible. Please set a whole value.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 InputColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// <summary>
        /// The InputFontFamily property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputFontFamily
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The InputPointSize property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? InputPointSize
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The InputUnderline property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputUnderline
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The InputShadow property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputShadow
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The Emboss property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Emboss
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The InputEmboss property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputEmboss
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The InputOutline property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InputOutline
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// The SmoothScroll property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? SmoothScroll
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The SmoothScrollDuration property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? SmoothScrollDuration
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The EnableScrollBar property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? EnableScrollBar
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The ScrollBarShowDuration property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? ScrollBarShowDuration
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The ScrollBarFadeDuration property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? ScrollBarFadeDuration
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The PixelSize property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? PixelSize
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The EnableSelection property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? EnableSelection
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The text alignment to match the direction of the system language.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? MatchSystemLanguageDirection
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The TextColor property.
        /// Note that the cascade chaining set is impossible. Please set a whole value.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 TextColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// <summary>
        /// The PointSize property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? PointSize
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// The Placeholder text color.
        /// Note that the cascade chaining set is impossible. Please set a whole value.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color PlaceholderTextColor
        {
            get => GetValue<Color>();
            set => SetValue(value);
        }

        /// <summary>
        /// The PrimaryCursorColor property.
        /// Note that the cascade chaining set is impossible. Please set a whole value.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vector4 PrimaryCursorColor
        {
            get => GetValue<Vector4>();
            set => SetValue(value);
        }

        /// <summary>
        /// The FontStyle property.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PropertyMap FontStyle
        {
            get => GetValue<PropertyMap>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? Ellipsis
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// the line spacing to be used.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? LineSpacing
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// the minimum line size to be used.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? MinLineSize
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// <summary>
        /// the relative line height to be used.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? RelativeLineHeight
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public PropertyMap SelectionPopupStyle
        {
            get => GetValue<PropertyMap>();
            set => SetValue(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void ApplyTo(View view, string propertyName, object value)
        {
            if (view is TextEditor textEditor && viewSetters.TryGetValue(propertyName, out var setter))
            {
                setter(textEditor, value);
            }
            else
            {
                base.ApplyTo(view, propertyName, value);
            }
        }
    }
}
