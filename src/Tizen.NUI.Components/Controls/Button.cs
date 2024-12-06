﻿/*
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
using System.Diagnostics;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using Tizen.NUI.Accessibility;

namespace Tizen.NUI.Components
{
    /// <summary>
    /// ClickedEventArgs is a class to record button click event arguments which will sent to user.
    /// </summary>
    /// <since_tizen> 8 </since_tizen>
    public class ClickedEventArgs : EventArgs
    {
    }

    /// <summary>
    /// SelectedChangedEventArgs is a class to record item selected arguments which will sent to user.
    /// </summary>
    /// <since_tizen> 8 </since_tizen>
    public class SelectedChangedEventArgs : EventArgs
    {
        /// <summary> Selected state </summary>
        /// <since_tizen> 8 </since_tizen>
        public bool IsSelected { get; set; }
    }

    /// <summary>
    /// Button is one kind of common component, a button clearly describes what action will occur when the user selects it.
    /// Button may contain text or an icon.
    /// </summary>
    /// <since_tizen> 6 </since_tizen>
    public partial class Button : Control
    {
        private IconOrientation? iconRelativeOrientation = IconOrientation.Left;
        private bool isSelected = false;
        private bool isSelectable = false;
        private Size2D itemSpacing;
        private LinearLayout.Alignment itemAlignment = LinearLayout.Alignment.Center;
        private HorizontalAlignment itemHorizontalAlignment = HorizontalAlignment.Center;
        private VerticalAlignment itemVerticalAlignment = VerticalAlignment.Center;

        static Button()
        {
            if (NUIApplication.IsUsingXaml)
            {
                IconRelativeOrientationProperty = BindableProperty.Create(nameof(IconRelativeOrientation), typeof(IconOrientation?), typeof(Button), null,
                    propertyChanged: SetInternalIconRelativeOrientationProperty, defaultValueCreator: GetInternalIconRelativeOrientationProperty);

                IsSelectedProperty = BindableProperty.Create(nameof(IsSelected), typeof(bool), typeof(Button), false,
                    propertyChanged: SetInternalIsSelectedProperty, defaultValueCreator: GetInternalIsSelectedProperty);

                IsSelectableProperty = BindableProperty.Create(nameof(IsSelectable), typeof(bool), typeof(Button), true,
                    propertyChanged: SetInternalIsSelectableProperty, defaultValueCreator: GetInternalIsSelectableProperty);

                IconPaddingProperty = BindableProperty.Create(nameof(IconPadding), typeof(Extents), typeof(Button), null,
                    propertyChanged: SetInternalIconPaddingProperty, defaultValueCreator: GetInternalIconPaddingProperty);

                TextPaddingProperty = BindableProperty.Create(nameof(TextPadding), typeof(Extents), typeof(Button), null,
                    propertyChanged: SetInternalTextPaddingProperty, defaultValueCreator: GetInternalTextPaddingProperty);

                ItemAlignmentProperty = BindableProperty.Create(nameof(ItemAlignment), typeof(LinearLayout.Alignment), typeof(Button), LinearLayout.Alignment.Center,
                    propertyChanged: SetInternalItemAlignmentProperty, defaultValueCreator: GetInternalItemAlignmentProperty);

                ItemHorizontalAlignmentProperty = BindableProperty.Create(nameof(ItemHorizontalAlignment), typeof(HorizontalAlignment), typeof(Button), HorizontalAlignment.Center,
                    propertyChanged: SetInternalItemHorizontalAlignmentProperty, defaultValueCreator: GetInternalItemHorizontalAlignmentProperty);

                ItemVerticalAlignmentProperty = BindableProperty.Create(nameof(ItemVerticalAlignment), typeof(VerticalAlignment), typeof(Button), VerticalAlignment.Center,
                    propertyChanged: SetInternalItemVerticalAlignmentProperty, defaultValueCreator: GetInternalItemVerticalAlignmentProperty);

                ItemSpacingProperty = BindableProperty.Create(nameof(ItemSpacing), typeof(Size2D), typeof(Button), null,
                    propertyChanged: SetInternalItemSpacingProperty, defaultValueCreator: GetInternalItemSpacingProperty);

                TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(Button), default(string),
                    propertyChanged: SetInternalTextProperty, defaultValueCreator: GetInternalTextProperty);

                TranslatableTextProperty = BindableProperty.Create(nameof(TranslatableText), typeof(string), typeof(Button), default(string),
                    propertyChanged: SetInternalTranslatableTextProperty, defaultValueCreator: GetInternalTranslatableTextProperty);

                PointSizeProperty = BindableProperty.Create(nameof(PointSize), typeof(float), typeof(Button), default(float),
                    propertyChanged: SetInternalPointSizeProperty, defaultValueCreator: GetInternalPointSizeProperty);

                FontFamilyProperty = BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(Button), default(string),
                    propertyChanged: SetInternalFontFamilyProperty, defaultValueCreator: GetInternalFontFamilyProperty);

                TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(Button), null,
                    propertyChanged: SetInternalTextColorProperty, defaultValueCreator: GetInternalTextColorProperty);

                TextAlignmentProperty = BindableProperty.Create(nameof(TextAlignment), typeof(HorizontalAlignment), typeof(Button), default(HorizontalAlignment),
                    propertyChanged: SetInternalTextAlignmentProperty, defaultValueCreator: GetInternalTextAlignmentProperty);

                IconURLProperty = BindableProperty.Create(nameof(IconURL), typeof(string), typeof(Button), default(string),
                    propertyChanged: SetInternalIconURLProperty, defaultValueCreator: GetInternalIconURLProperty);

                IconSizeProperty = BindableProperty.Create(nameof(IconSize), typeof(Size), typeof(Button), null,
                    propertyChanged: SetInternalIconSizeProperty, defaultValueCreator: GetInternalIconSizeProperty);

                TextSelectorProperty = BindableProperty.Create(nameof(TextSelector), typeof(StringSelector), typeof(Button), null,
                    propertyChanged: SetInternalTextSelectorProperty, defaultValueCreator: GetInternalTextSelectorProperty);

                TranslatableTextSelectorProperty = BindableProperty.Create(nameof(TranslatableTextSelector), typeof(StringSelector), typeof(Button), null,
                    propertyChanged: SetInternalTranslatableTextSelectorProperty, defaultValueCreator: GetInternalTranslatableTextSelectorProperty);

                TextColorSelectorProperty = BindableProperty.Create(nameof(TextColorSelector), typeof(ColorSelector), typeof(Button), null,
                    propertyChanged: SetInternalTextColorSelectorProperty, defaultValueCreator: GetInternalTextColorSelectorProperty);

                PointSizeSelectorProperty = BindableProperty.Create(nameof(PointSizeSelector), typeof(FloatSelector), typeof(Button), null,
                    propertyChanged: SetInternalPointSizeSelectorProperty, defaultValueCreator: GetInternalPointSizeSelectorProperty);

                IconURLSelectorProperty = BindableProperty.Create(nameof(IconURLSelector), typeof(StringSelector), typeof(Button), null,
                    propertyChanged: SetInternalIconURLSelectorProperty, defaultValueCreator: GetInternalIconURLSelectorProperty);
            }
        }

        /// <summary>
        /// Creates a new instance of a Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Button() : base()
        {
            Focusable = true;
        }

        /// <summary>
        /// Creates a new instance of a Button with style.
        /// </summary>
        /// <param name="style">Create Button by special style defined in UX.</param>
        /// <since_tizen> 8 </since_tizen>
        public Button(string style) : base(style)
        {
            Focusable = true;
        }

        /// <summary>
        /// Creates a new instance of a Button with style.
        /// </summary>
        /// <param name="buttonStyle">Create Button by style customized by user.</param>
        /// <since_tizen> 8 </since_tizen>
        public Button(ButtonStyle buttonStyle) : base(buttonStyle)
        {
            Focusable = true;
        }

        /// <summary>
        /// Calculates current states for the button<br />
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override AccessibilityStates AccessibilityCalculateStates()
        {
            var states = base.AccessibilityCalculateStates();

            states[AccessibilityState.Checked] = this.IsSelected;
            states[AccessibilityState.Enabled] = this.IsEnabled;

            return states;
        }

        /// <summary>
        /// An event for the button clicked signal which can be used to subscribe or unsubscribe the event handler provided by the user.<br />
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        [Obsolete("Deprecated in API8; Will be removed in API10. Please use Clicked event instead.")]
        public event EventHandler<ClickEventArgs> ClickEvent;

        /// <summary>
        /// An event for the button clicked signal which can be used to subscribe or unsubscribe the event handler provided by the user.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public event EventHandler<ClickedEventArgs> Clicked;

        /// <summary>
        /// An event for the button state changed signal which can be used to subscribe or unsubscribe the event handler provided by the user.<br />
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        [Obsolete("Deprecated in API8; Will be removed in API10. Please use View.ControlStateChangedEvent")]
        public event EventHandler<StateChangedEventArgs> StateChangedEvent
        {
            add
            {
                stateChangeHandler += value;
            }
            remove
            {
                stateChangeHandler -= value;
            }
        }

        /// <summary>
        /// Icon orientation.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public enum IconOrientation
        {
            /// <summary>
            /// Top.
            /// </summary>
            /// <since_tizen> 6 </since_tizen>
            Top,
            /// <summary>
            /// Bottom.
            /// </summary>
            /// <since_tizen> 6 </since_tizen>
            Bottom,
            /// <summary>
            /// Left.
            /// </summary>
            /// <since_tizen> 6 </since_tizen>
            Left,
            /// <summary>
            /// Right.
            /// </summary>
            /// <since_tizen> 6 </since_tizen>
            Right,
        }

        /// <summary>
        /// Button's icon part.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public ImageView Icon
        {
            get => buttonIcon;
            internal set
            {
                buttonIcon = value;
            }
        }

        /// <summary>
        /// Button's overlay image part.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public ImageView OverlayImage
        {
            get
            {
                if (null == overlayImage)
                {
                    overlayImage = CreateOverlayImage();
                    if (null != Extension)
                    {
                        Extension.ProcessOverlayImage(this, ref overlayImage);
                    }
                    if (null != overlayImage)
                    {
                        overlayImage.ExcludeLayouting = true;
                        Add(overlayImage);
                    }
                }
                return overlayImage;
            }
            internal set
            {
                overlayImage = value;
            }
        }

        /// <summary>
        /// Button's text part.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public TextLabel TextLabel
        {
            get => buttonText;
            internal set
            {
                buttonText = value;
            }
        }

        /// <summary>
        /// The last applied style object copy.
        /// </summary>
        /// <remarks>
        /// Modifying contents in style may cause unexpected behaviour.
        /// </remarks>
        /// <since_tizen> 8 </since_tizen>
        public ButtonStyle Style => (ButtonStyle)(ViewStyle as ButtonStyle)?.Clone();

        /// <summary>
        /// The text of Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public string Text
        {
            get => NUIApplication.IsUsingXaml ? (string)GetValue(TextProperty) : InternalText;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(TextProperty, value);
                }
                else
                {
                    InternalText = value;
                }
                NotifyPropertyChanged();
            }
        }

        private string InternalText
        {
            get
            {
                return TextLabel.Text;
            }
            set
            {
                TextLabel.Text = value;

                if (Accessibility.Accessibility.IsEnabled && IsHighlighted && String.IsNullOrEmpty(AccessibilityName) && GetAccessibilityNameSignal().Empty())
                {
                    EmitAccessibilityEvent(AccessibilityPropertyChangeEvent.Name);
                }
            }
        }

        /// <summary>
        /// Flag to decide Button can be selected or not.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public bool IsSelectable
        {
            get => NUIApplication.IsUsingXaml ? (bool)GetValue(IsSelectableProperty) : InternalIsSelectable;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(IsSelectableProperty, value);
                }
                else
                {
                    InternalIsSelectable = value;
                }
            }
        }

        private bool InternalIsSelectable
        {
            get => isSelectable;
            set
            {
                if (isSelectable != value)
                {
                    isSelectable = value;
                    UpdateState();
                }
            }
        }



        /// <summary>
        /// Translate text string in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public string TranslatableText
        {
            get => NUIApplication.IsUsingXaml ? (string)GetValue(TranslatableTextProperty) : InternalTranslatableText;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(TranslatableTextProperty, value);
                }
                else
                {
                    InternalTranslatableText = value;
                }
                NotifyPropertyChanged();
            }
        }

        private string InternalTranslatableText
        {
            get
            {
                return TextLabel.TranslatableText;
            }
            set
            {
                TextLabel.TranslatableText = value;
            }
        }

        /// <summary>
        /// Text point size in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public float PointSize
        {
            get => NUIApplication.IsUsingXaml ? (float)GetValue(PointSizeProperty) : InternalPointSize;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(PointSizeProperty, value);
                }
                else
                {
                    InternalPointSize = value;
                }
                NotifyPropertyChanged();
            }
        }

        private float InternalPointSize
        {
            get
            {
                return TextLabel.PointSize;
            }
            set
            {
                TextLabel.PointSize = value;
            }
        }

        /// <summary>
        /// Text font family in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public string FontFamily
        {
            get => NUIApplication.IsUsingXaml ? (string)GetValue(FontFamilyProperty) : InternalFontFamily;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(FontFamilyProperty, value);
                }
                else
                {
                    InternalFontFamily = value;
                }
                NotifyPropertyChanged();
            }
        }

        private string InternalFontFamily
        {
            get
            {
                return TextLabel.FontFamily;
            }
            set
            {
                TextLabel.FontFamily = value;
            }
        }

        /// <summary>
        /// Text color in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Color TextColor
        {
            get => NUIApplication.IsUsingXaml ? (Color)GetValue(TextColorProperty) : InternalTextColor;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(TextColorProperty, value);
                }
                else
                {
                    InternalTextColor = value;
                }
                NotifyPropertyChanged();
            }
        }

        private Color InternalTextColor
        {
            get
            {
                return TextLabel.TextColor;
            }
            set
            {
                TextLabel.TextColor = value;
            }
        }

        /// <summary>
        /// Text horizontal alignment in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public HorizontalAlignment TextAlignment
        {
            get => NUIApplication.IsUsingXaml ? (HorizontalAlignment)GetValue(TextAlignmentProperty) : InternalTextAlignment;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(TextAlignmentProperty, value);
                }
                else
                {
                    InternalTextAlignment = value;
                }
                NotifyPropertyChanged();
            }
        }

        private HorizontalAlignment InternalTextAlignment
        {
            get
            {
                return TextLabel.HorizontalAlignment;
            }
            set
            {
                TextLabel.HorizontalAlignment = value;
            }
        }

        /// <summary>
        /// Icon image's resource url in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public string IconURL
        {
            get => NUIApplication.IsUsingXaml ? (string)GetValue(IconURLProperty) : InternalIconURL;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(IconURLProperty, value);
                }
                else
                {
                    InternalIconURL = value;
                }
                NotifyPropertyChanged();
            }
        }

        private string InternalIconURL
        {
            get
            {
                return Icon.ResourceUrl;
            }
            set
            {
                Icon.ResourceUrl = value;
            }
        }

        /// <summary>
        /// Icon image's size in Button.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Size IconSize
        {
            get => NUIApplication.IsUsingXaml ? (Size)GetValue(IconSizeProperty) : InternalIconSize;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(IconSizeProperty, value);
                }
                else
                {
                    InternalIconSize = value;
                }
                NotifyPropertyChanged();
            }
        }

        private Size InternalIconSize
        {
            get => Icon.Size;
            set => Icon.Size = value;
        }

        /// <summary>
        /// Text string selector in Button.
        /// Getter returns copied selector value if exist, null otherwise.
        /// <exception cref="NullReferenceException">Thrown when setting null value.</exception>
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public StringSelector TextSelector
        {
            get => NUIApplication.IsUsingXaml ? (StringSelector)GetValue(TextSelectorProperty) : InternalTextSelector;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(TextSelectorProperty, value);
                }
                else
                {
                    InternalTextSelector = value;
                }
                NotifyPropertyChanged();
            }
        }

        private StringSelector InternalTextSelector
        {
            get => buttonText?.TextSelector == null ? null : new StringSelector(buttonText.TextSelector);
            set
            {
                if (value == null || buttonText == null)
                {
                    throw new NullReferenceException("Button.TextSelector is null");
                }
                else
                {
                    buttonText.TextSelector = value;
                }
            }
        }

        /// <summary>
        /// Translatable text string selector in Button.
        /// Getter returns copied selector value if exist, null otherwise.
        /// </summary>
        /// <exception cref="NullReferenceException">Thrown when setting null value.</exception>
        /// <since_tizen> 6 </since_tizen>
        public StringSelector TranslatableTextSelector
        {
            get => NUIApplication.IsUsingXaml ? (StringSelector)GetValue(TranslatableTextSelectorProperty) : InternalTranslatableTextSelector;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(TranslatableTextSelectorProperty, value);
                }
                else
                {
                    InternalTranslatableTextSelector = value;
                }
                NotifyPropertyChanged();
            }
        }

        private StringSelector InternalTranslatableTextSelector
        {
            get => (buttonText?.TranslatableTextSelector == null) ? null : new StringSelector(buttonText.TranslatableTextSelector);
            set
            {
                if (value == null || buttonText == null)
                {
                    throw new NullReferenceException("Button.TranslatableTextSelector is null");
                }
                else
                {
                    buttonText.TranslatableTextSelector = value;
                }
            }
        }

        /// <summary>
        /// Text color selector in Button.
        /// Getter returns copied selector value if exist, null otherwise.
        /// </summary>
        /// <exception cref="NullReferenceException">Thrown when setting null value.</exception>
        /// <since_tizen> 6 </since_tizen>
        public ColorSelector TextColorSelector
        {
            get => NUIApplication.IsUsingXaml ? (ColorSelector)GetValue(TextColorSelectorProperty) : InternalTextColorSelector;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(TextColorSelectorProperty, value);
                }
                else
                {
                    InternalTextColorSelector = value;
                }
                NotifyPropertyChanged();
            }
        }

        private ColorSelector InternalTextColorSelector
        {
            get => buttonText?.TextColorSelector == null ? null : new ColorSelector(buttonText.TextColorSelector);
            set
            {
                if (value == null || buttonText == null)
                {
                    throw new NullReferenceException("Button.TextColorSelectorProperty is null");
                }
                else
                {
                    buttonText.TextColorSelector = value;
                }
            }
        }

        /// <summary>
        /// Text font size selector in Button.
        /// Getter returns copied selector value if exist, null otherwise.
        /// </summary>
        /// <exception cref="NullReferenceException">Thrown when setting null value.</exception>
        /// <since_tizen> 6 </since_tizen>
        public FloatSelector PointSizeSelector
        {
            get => NUIApplication.IsUsingXaml ? (FloatSelector)GetValue(PointSizeSelectorProperty) : InternalPointSizeSelector;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(PointSizeSelectorProperty, value);
                }
                else
                {
                    InternalPointSizeSelector = value;
                }
                NotifyPropertyChanged();
            }
        }

        private FloatSelector InternalPointSizeSelector
        {
            get => buttonText?.PointSizeSelector == null ? null : new FloatSelector(buttonText.PointSizeSelector);
            set
            {
                if (value == null || buttonText == null)
                {
                    throw new NullReferenceException("Button.PointSizeSelector is null");
                }
                else
                {
                    buttonText.PointSizeSelector = value;
                }
            }
        }

        /// <summary>
        /// Icon image's resource url selector in Button.
        /// Getter returns copied selector value if exist, null otherwise.
        /// </summary>
        /// <exception cref="NullReferenceException">Thrown when setting null value.</exception>
        /// <since_tizen> 6 </since_tizen>
        public StringSelector IconURLSelector
        {
            get => NUIApplication.IsUsingXaml ? (StringSelector)GetValue(IconURLSelectorProperty) : InternalIconURLSelector;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(IconURLSelectorProperty, value);
                }
                else
                {
                    InternalIconURLSelector = value;
                }
                NotifyPropertyChanged();
            }
        }

        private StringSelector InternalIconURLSelector
        {
            get
            {
                Selector<string> resourceUrlSelector = buttonIcon?.ResourceUrlSelector;
                if(resourceUrlSelector == null)
                {
                    return null;
                }
                return new StringSelector(resourceUrlSelector);
            }
            set
            {
                if (value == null || buttonIcon == null)
                {
                    throw new NullReferenceException("Button.IconURLSelector is null");
                }
                else
                {
                    buttonIcon.ResourceUrlSelector = value;
                }
            }
        }

        /// <summary>
        /// Flag to decide selected state in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public bool IsSelected
        {
            get => NUIApplication.IsUsingXaml ? (bool)GetValue(IsSelectedProperty) : InternalIsSelected;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(IsSelectedProperty, value);
                }
                else
                {
                    InternalIsSelected = value;
                }
            }
        }

        private bool InternalIsSelected
        {
            get => isSelectable && isSelected;
            set
            {
                if (isSelected != value)
                {
                    isSelected = value;

                    if (isSelectable)
                    {
                        UpdateState();
                    }

                    if (Accessibility.Accessibility.IsEnabled && IsHighlighted)
                    {
                        EmitAccessibilityStateChangedEvent(AccessibilityState.Checked, value);
                    }
                }
            }
        }

        /// <summary>
        /// Flag to decide enable or disable in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public new bool IsEnabled
        {
            get => base.IsEnabled;
            set
            {
                base.IsEnabled = value;
            }
        }

        /// <summary>
        /// Icon relative orientation in Button, work only when show icon and text.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public IconOrientation? IconRelativeOrientation
        {
            get => NUIApplication.IsUsingXaml ? (IconOrientation?)GetValue(IconRelativeOrientationProperty) : InternalIconRelativeOrientation;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(IconRelativeOrientationProperty, value);
                }
                else
                {
                    InternalIconRelativeOrientation = value;
                }
            }
        }

        private IconOrientation? InternalIconRelativeOrientation
        {
            get => iconRelativeOrientation;
            set
            {
                if (iconRelativeOrientation != value)
                {
                    iconRelativeOrientation = value;
                    LayoutItems();
                }
            }
        }

        /// <summary>
        /// Icon padding in Button. It is shortcut of Icon.Padding.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Extents IconPadding
        {
            get => NUIApplication.IsUsingXaml ? (Extents)GetValue(IconPaddingProperty) : InternalIconPadding;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(IconPaddingProperty, value);
                }
                else
                {
                    InternalIconPadding = value;
                }
            }
        }

        private Extents InternalIconPadding
        {
            get => buttonIcon?.Padding;
            set
            {
                if (buttonIcon != null)
                {
                    buttonIcon.Padding = value;
                }
            }
        }

        /// <summary>
        /// Text padding in Button. It is shortcut of TextLabel.Padding.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Extents TextPadding
        {
            get => NUIApplication.IsUsingXaml ? (Extents)GetValue(TextPaddingProperty) : InternalTextPadding;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(TextPaddingProperty, value);
                }
                else
                {
                    InternalTextPadding = value;
                }
            }
        }

        private Extents InternalTextPadding
        {
            get => buttonText?.Padding;
            set
            {
                if (buttonText != null)
                {
                    buttonText.Padding = value;
                }
            }
        }

        /// <summary>
        /// The item (text or icon or both) alignment.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public LinearLayout.Alignment ItemAlignment
        {
            get => NUIApplication.IsUsingXaml ? (LinearLayout.Alignment)GetValue(ItemAlignmentProperty) : InternalItemAlignment;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(ItemAlignmentProperty, value);
                }
                else
                {
                    InternalItemAlignment = value;
                }
            }
        }

        private LinearLayout.Alignment InternalItemAlignment
        {
            get => itemAlignment;
            set
            {
                if (itemAlignment != value)
                {
                    itemAlignment = value;

                    switch (value)
                    {
                        case LinearLayout.Alignment.Begin:
                            itemHorizontalAlignment = HorizontalAlignment.Begin;
                            break;
                        case LinearLayout.Alignment.End:
                            itemHorizontalAlignment = HorizontalAlignment.End;
                            break;
                        case LinearLayout.Alignment.CenterHorizontal:
                            itemHorizontalAlignment = HorizontalAlignment.Center;
                            break;
                        case LinearLayout.Alignment.Top:
                            itemVerticalAlignment = VerticalAlignment.Top;
                            break;
                        case LinearLayout.Alignment.Bottom:
                            itemVerticalAlignment = VerticalAlignment.Bottom;
                            break;
                        case LinearLayout.Alignment.CenterVertical:
                            itemVerticalAlignment = VerticalAlignment.Center;
                            break;
                        case LinearLayout.Alignment.Center:
                            itemHorizontalAlignment = HorizontalAlignment.Center;
                            itemVerticalAlignment = VerticalAlignment.Center;
                            break;
                        default:
                            break;
                    }

                    LayoutItems();
                }
            }
        }

        /// <summary>
        /// The item (text or icon or both) horizontal alignment.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public HorizontalAlignment ItemHorizontalAlignment
        {
            get => NUIApplication.IsUsingXaml ? (HorizontalAlignment)GetValue(ItemHorizontalAlignmentProperty) : InternalItemHorizontalAlignment;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(ItemHorizontalAlignmentProperty, value);
                }
                else
                {
                    InternalItemHorizontalAlignment = value;
                }
            }
        }

        private HorizontalAlignment InternalItemHorizontalAlignment
        {
            get => itemHorizontalAlignment;
            set
            {
                if (itemHorizontalAlignment != value)
                {
                    itemHorizontalAlignment = value;
                    LayoutItems();
                }
            }
        }

        /// <summary>
        /// The item (text or icon or both) vertical alignment.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VerticalAlignment ItemVerticalAlignment
        {
            get => NUIApplication.IsUsingXaml ? (VerticalAlignment)GetValue(ItemVerticalAlignmentProperty) : InternalItemVerticalAlignment;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(ItemVerticalAlignmentProperty, value);
                }
                else
                {
                    InternalItemVerticalAlignment = value;
                }
            }
        }

        private VerticalAlignment InternalItemVerticalAlignment
        {
            get => itemVerticalAlignment;
            set
            {
                if (itemVerticalAlignment != value)
                {
                    itemVerticalAlignment = value;
                    LayoutItems();
                }
            }
        }

        /// <summary>
        /// The space between icon and text.
        /// The value is applied when there exist icon and text both.
        /// The width value is used when the items are arranged horizontally. Otherwise, the height value is used.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Size2D ItemSpacing
        {
            get => NUIApplication.IsUsingXaml ? (Size2D)GetValue(ItemSpacingProperty) : InternalItemSpacing;
            set
            {
                if (NUIApplication.IsUsingXaml)
                {
                    SetValue(ItemSpacingProperty, value);
                }
                else
                {
                    InternalItemSpacing = value;
                }
            }
        }

        private Size2D InternalItemSpacing
        {
            get => itemSpacing;
            set
            {
                itemSpacing = value;
                UpdateSizeAndSpacing();
            }
        }

        /// <summary>
        /// Called after a key event is received by the view that has had its focus set.
        /// </summary>
        /// <param name="key">The key event.</param>
        /// <returns>True if the key event should be consumed.</returns>
        /// <since_tizen> 6 </since_tizen>
        public override bool OnKey(Key key)
        {
            bool clicked = false;

            if (!IsEnabled || null == key)
            {
                return false;
            }

            if (key.State == Key.StateType.Down)
            {
                if (key.KeyPressedName == "Return")
                {
                    isPressed = true;
                    UpdateState();
                }
            }
            else if (key.State == Key.StateType.Up)
            {
                if (key.KeyPressedName == "Return")
                {
                    clicked = isPressed && IsEnabled;

                    isPressed = false;

                    if (IsSelectable)
                    {
                        IsSelected = !IsSelected;
                    }
                    else
                    {
                        UpdateState();
                    }

                    if (clicked)
                    {
                        ClickedEventArgs eventArgs = new ClickedEventArgs();
                        OnClickedInternal(eventArgs);
                    }
                }
            }
            return base.OnKey(key) || clicked;
        }

        /// <summary>
        /// Called when the control gain key input focus. Should be overridden by derived classes if they need to customize what happens when the focus is gained.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public override void OnFocusGained()
        {
            base.OnFocusGained();
            UpdateState();
        }

        /// <summary>
        /// Called when the control loses key input focus. Should be overridden by derived classes if they need to customize what happens when the focus is lost.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public override void OnFocusLost()
        {
            base.OnFocusLost();
            UpdateState();
        }

        /// <summary>
        /// Called after a touch event is received by the owning view.<br />
        /// CustomViewBehaviour.REQUIRES_TOUCH_EVENTS must be enabled during construction. See CustomView(ViewWrapperImpl.CustomViewBehaviour behaviour).<br />
        /// </summary>
        /// <param name="touch">The touch event.</param>
        /// <returns>True if the event should be consumed.</returns>
        /// <since_tizen> 8 </since_tizen>
        [Obsolete("Deprecated in API8; Will be removed in API10. Please use OnClicked instead.")]
#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member, It will be removed in API10
        public override bool OnTouch(Touch touch)
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member, It will be removed in API10
        {
            return base.OnTouch(touch);
        }

        /// <summary>
        /// Apply style to button.
        /// </summary>
        /// <param name="viewStyle">The style to apply.</param>
        /// <since_tizen> 8 </since_tizen>
        public override void ApplyStyle(ViewStyle viewStyle)
        {
            Debug.Assert(buttonIcon != null && buttonText != null);

            base.ApplyStyle(viewStyle);

            if (viewStyle is ButtonStyle buttonStyle)
            {
                styleApplying++;

                if ((Extension = buttonStyle.CreateExtension()) != null)
                {
                    bool needRelayout = false;
                    needRelayout |= Extension.ProcessIcon(this, ref buttonIcon);
                    needRelayout |= Extension.ProcessText(this, ref buttonText);

                    if (needRelayout)
                    {
                        LayoutItems();
                    }
                }

                if (buttonStyle.Overlay != null)
                {
                    OverlayImage?.ApplyStyle(buttonStyle.Overlay);
                }

                if (buttonStyle.Text != null)
                {
                    buttonText.ThemeChangeSensitive = false;
                    buttonText.ApplyStyle(buttonStyle.Text);
                }

                if (buttonStyle.Icon != null)
                {
                    buttonIcon.ApplyStyle(buttonStyle.Icon);
                }

                styleApplying--;
            }

            UpdateState();
        }

        /// <summary>
        /// ClickEventArgs is a class to record button click event arguments which will sent to user.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        [Obsolete("Deprecated in API8; Will be removed in API10. Please use ClickedEventArgs instead.")]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public class ClickEventArgs : EventArgs
        {
        }

        /// <summary>
        /// StateChangeEventArgs is a class to record button state change event arguments which will sent to user.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        [Obsolete("Deprecated in API8; Will be removed in API10. Please use View.ControlStateChangedEventArgs")]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public class StateChangedEventArgs : EventArgs
        {
            /// <summary> previous state of Button </summary>
            /// <since_tizen> 6 </since_tizen>
            /// It will be removed in API10
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:Do not declare visible instance fields")]
            [Obsolete("Deprecated in API8; Will be removed in API10")]
            public ControlStates PreviousState;
            /// <summary> current state of Button </summary>
            /// <since_tizen> 6 </since_tizen>
            /// It will be removed in API10
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:Do not declare visible instance fields")]
            [Obsolete("Deprecated in API8; Will be removed in API10")]
            public ControlStates CurrentState;
        }
    }
}
