// Copyright (c) 2024 Samsung Electronics Co., Ltd.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace Tizen.NUI.Visuals
{
    /// <summary>
    /// The visual which can display simple text.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class TextVisual : VisualBase
    {
        #region Constructor
        /// <summary>
        /// Creates an visual object.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TextVisual() : this(Interop.VisualObject.VisualObjectNew(), true)
        {
            NDalicPINVOKE.ThrowExceptionIfExists();
        }

        internal TextVisual(global::System.IntPtr cPtr, bool cMemoryOwn) : this(cPtr, cMemoryOwn, cMemoryOwn)
        {
        }

        internal TextVisual(global::System.IntPtr cPtr, bool cMemoryOwn, bool cRegister) : base(cPtr, cMemoryOwn, cRegister)
        {
            Type = (int)Tizen.NUI.Visual.Type.Text;
        }
        #endregion

        #region Visual Properties
        /// <summary>
        /// The Text property.<br />
        /// The text to display in the UTF-8 format.<br />
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Text
        {
            set
            {
                using var property = PropertyValue.GetReusable(string.IsNullOrEmpty(value) ? "" : value);
                UpdateVisualProperty((int)Tizen.NUI.TextVisualProperty.Text, property);
            }
            get
            {
                string ret = "";
                var propertyValue = GetCachedVisualProperty((int)Tizen.NUI.TextVisualProperty.Text);
                propertyValue?.Get(out ret);
                return ret;
            }
        }

        /// <summary>
        /// The requested font family to use.<br />
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string FontFamily
        {
            set
            {
                using var property = PropertyValue.GetReusable(string.IsNullOrEmpty(value) ? "" : value);
                UpdateVisualProperty((int)Tizen.NUI.TextVisualProperty.FontFamily, property);
            }
            get
            {
                string ret = "";
                var propertyValue = GetCachedVisualProperty((int)Tizen.NUI.TextVisualProperty.FontFamily);
                propertyValue?.Get(out ret);
                return ret;
            }
        }

        /// <summary>
        /// The size of font in points.<br />
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float PointSize
        {
            set
            {
                using var property = PropertyValue.GetReusable(value);
                UpdateVisualProperty((int)Tizen.NUI.TextVisualProperty.PointSize, property);
            }
            get
            {
                float ret = 0.0f;
                var propertyValue = GetCachedVisualProperty((int)Tizen.NUI.TextVisualProperty.PointSize);
                propertyValue?.Get(out ret);
                return ret;
            }
        }

        /// <summary>
        /// The single-line or multi-line layout option.<br />
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool MultiLine
        {
            set
            {
                using var property = PropertyValue.GetReusable(value);
                UpdateVisualProperty((int)Tizen.NUI.TextVisualProperty.MultiLine, property);
            }
            get
            {
                bool ret = false;
                var propertyValue = GetCachedVisualProperty((int)Tizen.NUI.TextVisualProperty.MultiLine);
                propertyValue?.Get(out ret);
                return ret;
            }
        }

        /// <summary>
        /// The line horizontal alignment.<br />
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Tizen.NUI.HorizontalAlignment HorizontalAlignment
        {
            set
            {
                using var property = PropertyValue.GetReusable((int)value);
                UpdateVisualProperty((int)Tizen.NUI.TextVisualProperty.HorizontalAlignment, property);
            }
            get
            {
                int ret = (int)Tizen.NUI.HorizontalAlignment.Begin;
                var propertyValue = GetCachedVisualProperty((int)Tizen.NUI.TextVisualProperty.HorizontalAlignment);
                propertyValue?.Get(out ret);
                return (Tizen.NUI.HorizontalAlignment)ret;
            }
        }

        /// <summary>
        /// The line vertical alignment.<br />
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Tizen.NUI.VerticalAlignment VerticalAlignment
        {
            set
            {
                using var property = PropertyValue.GetReusable((int)value);
                UpdateVisualProperty((int)Tizen.NUI.TextVisualProperty.VerticalAlignment, property);
            }
            get
            {
                int ret = (int)Tizen.NUI.VerticalAlignment.Top;
                var propertyValue = GetCachedVisualProperty((int)Tizen.NUI.TextVisualProperty.VerticalAlignment);
                propertyValue?.Get(out ret);
                return (Tizen.NUI.VerticalAlignment)ret;
            }
        }

        /// <summary>
        /// The color of the text.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Tizen.NUI.Color TextColor
        {
            set
            {
                using var property = PropertyValue.GetReusable(value);
                UpdateVisualProperty((int)Tizen.NUI.TextVisualProperty.TextColor, property);
            }
            get
            {
                Tizen.NUI.Color ret = Color.GetReusable(0.0f, 0.0f, 0.0f, 1.0f);
                var propertyValue = GetCachedVisualProperty((int)Tizen.NUI.TextVisualProperty.TextColor);
                propertyValue?.Get(ret);
                return ret;
            }
        }

        /// <summary>
        /// Whether the mark-up processing is enabled.<br />
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool EnableMarkup
        {
            set
            {
                using var property = PropertyValue.GetReusable(value);
                UpdateVisualProperty((int)Tizen.NUI.TextVisualProperty.EnableMarkup, property);
            }
            get
            {
                bool ret = false;
                var propertyValue = GetCachedVisualProperty((int)Tizen.NUI.TextVisualProperty.EnableMarkup);
                propertyValue?.Get(out ret);
                return ret;
            }
        }
        #endregion
    }
}