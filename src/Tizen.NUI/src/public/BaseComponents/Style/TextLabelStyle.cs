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
    /// The base class for Children attributes in Components.
    /// </summary>
    /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class TextLabelStyle : ViewStyle
    {
        static readonly Dictionary<string, Action<TextLabel, object>> viewSetters = new Dictionary<string, Action<TextLabel, object>>()
        {
            { nameof(TranslatableText), (v, o) => TextLabel.SetInternalTranslatableTextProperty(v, null, o) },
            { nameof(FontFamily), (v, o) => TextLabel.SetInternalFontFamilyProperty(v, null, o) },
            { nameof(MultiLine), (v, o) => v.MultiLine = (bool)o },
            { nameof(HorizontalAlignment), (v, o) => v.HorizontalAlignment = (HorizontalAlignment)o },
            { nameof(VerticalAlignment), (v, o) => v.VerticalAlignment = (VerticalAlignment)o },
            { nameof(EnableMarkup), (v, o) => v.EnableMarkup = (bool)o },
            { nameof(EnableAutoScroll), (v, o) => v.EnableAutoScroll = (bool)o },
            { nameof(AutoScrollSpeed), (v, o) => v.AutoScrollSpeed = (int)o },
            { nameof(AutoScrollLoopCount), (v, o) => v.AutoScrollLoopCount = (int)o },
            { nameof(AutoScrollGap), (v, o) => v.AutoScrollGap = (float)o },
            { nameof(LineSpacing), (v, o) => v.LineSpacing = (float)o },
            { nameof(RelativeLineHeight), (v, o) => v.RelativeLineHeight = (float)o },
            { nameof(Emboss), (v, o) => v.Emboss = (string)o },
            { nameof(PixelSize), (v, o) => TextLabel.SetInternalPixelSizeProperty(v, null, o) },
            { nameof(Ellipsis), (v, o) => v.Ellipsis = (bool)o },
            { nameof(AutoScrollLoopDelay), (v, o) => v.AutoScrollLoopDelay = (float)o },
            { nameof(AutoScrollStopMode), (v, o) => v.AutoScrollStopMode = (AutoScrollStopMode)o },
            { nameof(LineWrapMode), (v, o) => v.LineWrapMode = (LineWrapMode)o },
            { nameof(VerticalLineAlignment), (v, o) => v.VerticalLineAlignment = (VerticalLineAlignment)o },
            { nameof(EllipsisPosition), (v, o) => v.EllipsisPosition = (EllipsisPosition)o },
            { nameof(CharacterSpacing), (v, o) => v.CharacterSpacing = (float)o },
            { nameof(FontSizeScale), (v, o) => v.FontSizeScale = (float)o },
            { nameof(AnchorColor), (v, o) => v.AnchorColor = (Color)o },
            { nameof(AnchorClickedColor), (v, o) => v.AnchorClickedColor = (Color)o },
            { nameof(MatchSystemLanguageDirection), (v, o) => v.MatchSystemLanguageDirection = (bool)o },
            { nameof(Text), (v, o) => TextLabel.SetInternalTextProperty(v, null, o) },
            { nameof(TextColor), (v, o) => TextLabel.SetInternalTextColorProperty(v, null, o) },
            { nameof(PointSize), (v, o) => TextLabel.SetInternalPointSizeProperty(v, null, o) },
            { nameof(TextShadow), (v, o) => TextLabel.SetInternalTextShadowProperty(v, null, o) },
            { nameof(FontStyle), (v, o) => v.FontStyle = (PropertyMap)o },
        };

        static TextLabelStyle() { }

        /// <summary>
        /// Create an empty instance.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TextLabelStyle() : base()
        {
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<string> TranslatableText
        {
            get => GetOrCreateSelectorValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<string> FontFamily
        {
            get => GetOrCreateSelectorValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? MultiLine
        {
            get => GetValue<bool?>();
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
        public bool? EnableMarkup
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? EnableAutoScroll
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int? AutoScrollSpeed
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int? AutoScrollLoopCount
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? AutoScrollGap
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? LineSpacing
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

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Emboss
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<float?> PixelSize
        {
            get => GetOrCreateSelectorValue<float?>();
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
        public float? AutoScrollLoopDelay
        {
            get => GetValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public AutoScrollStopMode? AutoScrollStopMode
        {
            get => GetValue<AutoScrollStopMode?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public LineWrapMode? LineWrapMode
        {
            get => GetValue<LineWrapMode?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VerticalLineAlignment? VerticalLineAlignment
        {
            get => GetValue<VerticalLineAlignment?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public EllipsisPosition? EllipsisPosition
        {
            get => GetValue<EllipsisPosition?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? CharacterSpacing
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
        public Color AnchorColor
        {
            get => GetValue<Color>();
            set => SetValue(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color AnchorClickedColor
        {
            get => GetValue<Color>();
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
        public Selector<string> Text
        {
            get => GetOrCreateSelectorValue<string>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<Color> TextColor
        {
            get => GetOrCreateSelectorValue<Color>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<float?> PointSize
        {
            get => GetOrCreateSelectorValue<float?>();
            set => SetValue(value);
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<TextShadow> TextShadow
        {
            get => GetOrCreateSelectorValue<TextShadow>();
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
        protected override void ApplyTo(View view, string propertyName, object value)
        {
            if (view is TextLabel textLabel && viewSetters.TryGetValue(propertyName, out var setter))
            {
                setter(textLabel, value);
            }
            else
            {
                base.ApplyTo(view, propertyName, value);
            }
        }
    }
}
