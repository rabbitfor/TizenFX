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
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IconRelativeOrientationProperty = null;

        IconOrientation? InternalIconRelativeOrientation
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

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IsSelectedProperty = null;

        bool InternalIsSelected
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

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IsSelectableProperty = null;

        bool InternalIsSelectable
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

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IconPaddingProperty = null;

        Extents InternalIconPadding
        {
            get => buttonIcon?.Padding;
            set
            {
                if (buttonIcon == null)
                {
                    return;
                }
                buttonIcon.Padding = value;
            }
        }

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextPaddingProperty = null;

        Extents InternalTextPadding
        {
            get => buttonText?.Padding;
            set
            {
                if (buttonText == null)
                {
                    return;
                }
                buttonText.Padding = value;
            }
        }

        /// <summary> The bindable property of ItemAlignment. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly BindableProperty ItemAlignmentProperty = null;

        LinearLayout.Alignment InternalItemAlignment
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

        /// <summary> The bindable property of ItemHorizontalAlignment. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly BindableProperty ItemHorizontalAlignmentProperty = null;

        HorizontalAlignment InternalItemHorizontalAlignment
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

        /// <summary> The bindable property of ItemVerticalAlignment. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly BindableProperty ItemVerticalAlignmentProperty = null;

        VerticalAlignment InternalItemVerticalAlignment
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

        /// <summary> The bindable property of ItemSpacing. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly BindableProperty ItemSpacingProperty = null;

        Size2D InternalItemSpacing
        {
            get => itemSpacing;
            set
            {
                itemSpacing = value;
                UpdateSizeAndSpacing();
            }
        }

        private IconOrientation? iconRelativeOrientation = IconOrientation.Left;
        private bool isSelected = false;
        private bool isSelectable = false;
        private Size2D itemSpacing;
        private LinearLayout.Alignment itemAlignment = LinearLayout.Alignment.Center;
        private HorizontalAlignment itemHorizontalAlignment = HorizontalAlignment.Center;
        private VerticalAlignment itemVerticalAlignment = VerticalAlignment.Center;

        static Button()
        {
            IsSelectedProperty = BindableProperty.Create(nameof(IsSelected), typeof(bool), typeof(Button), false, propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (newValue != null)
                {
                    ((Button)bindable).InternalIsSelected = (bool)newValue;
                }
            },
            defaultValueCreator: (bindable) => ((Button)bindable).InternalIsSelected);

            if (!NUIApplication.IsUsingXaml)
                return;

            TextPaddingProperty = BindableProperty.Create(nameof(TextPadding), typeof(Extents), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((Button)bindable).InternalTextPadding = (Extents)newValue;
            },
            defaultValueCreator: (bindable) => ((Button)bindable).InternalTextPadding);

            IconPaddingProperty = BindableProperty.Create(nameof(IconPadding), typeof(Extents), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((Button)bindable).InternalIconPadding = (Extents)newValue;
            },
            defaultValueCreator: (bindable) => ((Button)bindable).InternalIconPadding);

            IsSelectableProperty = BindableProperty.Create(nameof(IsSelectable), typeof(bool), typeof(Button), true, propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (newValue != null)
                {
                    ((Button)bindable).InternalIsSelectable = (bool)newValue;
                }
            },
            defaultValueCreator: (bindable) => ((Button)bindable).InternalIsSelectable);

            IconRelativeOrientationProperty = BindableProperty.Create(nameof(IconRelativeOrientation), typeof(IconOrientation?), typeof(Button), null,
                propertyChanged: (bindable, oldValue, newValue) => ((Button)bindable).InternalIconRelativeOrientation = (IconOrientation?)newValue,
                defaultValueCreator: (bindable) => ((Button)bindable).InternalIconRelativeOrientation);

            ItemAlignmentProperty = BindableProperty.Create(nameof(ItemAlignment), typeof(LinearLayout.Alignment), typeof(Button), LinearLayout.Alignment.Center, propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((Button)bindable).InternalItemAlignment = (LinearLayout.Alignment)newValue;
            },
            defaultValueCreator: (bindable) => ((Button)bindable).InternalItemAlignment);

            ItemHorizontalAlignmentProperty = BindableProperty.Create(nameof(ItemHorizontalAlignment), typeof(HorizontalAlignment), typeof(Button), HorizontalAlignment.Center, propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((Button)bindable).InternalItemHorizontalAlignment = (HorizontalAlignment)newValue;
            },
            defaultValueCreator: (bindable) => ((Button)bindable).InternalItemHorizontalAlignment);

            ItemVerticalAlignmentProperty = BindableProperty.Create(nameof(ItemVerticalAlignment), typeof(VerticalAlignment), typeof(Button), VerticalAlignment.Center, propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((Button)bindable).InternalItemVerticalAlignment = (VerticalAlignment)newValue;
            },
            defaultValueCreator: (bindable) => ((Button)bindable).InternalItemVerticalAlignment);

            ItemSpacingProperty = BindableProperty.Create(nameof(ItemSpacing), typeof(Size2D), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((Button)bindable).InternalItemSpacing = (Size2D)newValue;
            },
            defaultValueCreator: (bindable) => ((Button)bindable).InternalItemSpacing);

            TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(Button), default(string), propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                if (newValue != null)
                {
                    instance.InternalText = newValue as string;
                }
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalText;
            });

            TranslatableTextProperty = BindableProperty.Create(nameof(TranslatableText), typeof(string), typeof(Button), default(string), propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                if (newValue != null)
                {
                    instance.InternalTranslatableText = newValue as string;
                }
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalTranslatableText;
            });

            PointSizeProperty = BindableProperty.Create(nameof(PointSize), typeof(float), typeof(Button), default(float), propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                if (newValue != null)
                {
                    instance.InternalPointSize = (float)newValue;
                }
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalPointSize;
            });

            FontFamilyProperty = BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(Button), default(string), propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                if (newValue != null)
                {
                    instance.InternalFontFamily = newValue as string;
                }
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalFontFamily;
            });

            TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                if (newValue != null)
                {
                    instance.InternalTextColor = newValue as Color;
                }
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalTextColor;
            });

            TextAlignmentProperty = BindableProperty.Create(nameof(TextAlignment), typeof(HorizontalAlignment), typeof(Button), default(HorizontalAlignment), propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                if (newValue != null)
                {
                    instance.InternalTextAlignment = (HorizontalAlignment)newValue;
                }
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalTextAlignment;
            });

            IconURLProperty = BindableProperty.Create(nameof(IconURL), typeof(string), typeof(Button), default(string), propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                if (newValue != null)
                {
                    instance.InternalIconURL = newValue as string;
                }
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalIconURL;
            });

            IconSizeProperty = BindableProperty.Create(nameof(IconSize), typeof(Size), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                if (newValue != null)
                {
                    instance.InternalIconSize = newValue as Size;
                }
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalIconSize;
            });

            TextSelectorProperty = BindableProperty.Create(nameof(TextSelector), typeof(StringSelector), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                instance.InternalTextSelector = newValue as StringSelector;
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalTextSelector;
            });

            TranslatableTextSelectorProperty = BindableProperty.Create(nameof(TranslatableTextSelector), typeof(StringSelector), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                instance.InternalTranslatableTextSelector = newValue as StringSelector;
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalTranslatableTextSelector;
            });

            TextColorSelectorProperty = BindableProperty.Create(nameof(TextColorSelector), typeof(ColorSelector), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                instance.InternalTextColorSelector = newValue as ColorSelector;
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalTextColorSelector;
            });

            PointSizeSelectorProperty = BindableProperty.Create(nameof(PointSizeSelector), typeof(FloatSelector), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                instance.InternalPointSizeSelector = newValue as FloatSelector;
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalPointSizeSelector;
            });

            IconURLSelectorProperty = BindableProperty.Create(nameof(IconURLSelector), typeof(StringSelector), typeof(Button), null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var instance = (Button)bindable;
                instance.InternalIconURLSelector = newValue as StringSelector;
            },
            defaultValueCreator: (bindable) =>
            {
                var instance = (Button)bindable;
                return instance.InternalIconURLSelector;
            });
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

        protected override void SetDefaultStyle()
        {
            Padding = new Extents(32, 32, 8, 8);
            ItemSpacing = new Size2D(8, 8);
            CornerRadius = 12.0f;
            ItemHorizontalAlignment = HorizontalAlignment.Center;
            ItemVerticalAlignment = VerticalAlignment.Center;
            SetBackgroundColor(new Selector<Color>()
            {
                Normal = new Color(1.0f, 0.384f, 0.0f, 1),
                Pressed = new Color(0.85f, 0.325f, 0.0f, 1),
                Focused = new Color(1.0f, 0.827f, 0.624f, 1),
                Selected = new Color(0.624f, 0.239f, 0.0f, 1),
                Disabled = new Color(0.792f, 0.792f, 0.792f, 1),
            });


            TextLabel.TextColor = new Color("#FDFDFD");
            TextLabel.PixelSize = 24;
            TextLabel.FontSizeScale = FontSizeScale.UseSystemSetting;
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
            get => InternalText;
            set => InternalText = value;
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
            get => InternalIsSelectable;
            set => InternalIsSelectable = value;
        }

        /// <summary>
        /// Translate text string in Button.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public string TranslatableText
        {
            get => InternalTranslatableText;
            set
            {
                InternalTranslatableText = value;
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
            get => InternalPointSize;
            set
            {
                InternalPointSize = value;
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
            get => InternalFontFamily;
            set
            {
                InternalFontFamily = value;
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
            get => InternalTextColor;
            set
            {
                InternalTextColor = value;
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
            get => InternalTextAlignment;
            set
            {
                InternalTextAlignment = value;
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
            get => InternalIconURL;
            set
            {
                InternalIconURL = value;
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
            get => InternalIconSize;
            set
            {
                InternalIconSize = value;
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
            get => InternalTextSelector;
            set
            {
                InternalTextSelector = value;
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
            get => InternalTranslatableTextSelector;
            set
            {
                InternalTranslatableTextSelector = value;
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
            get => InternalTextColorSelector;
            set
            {
                InternalTextColorSelector = value;
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
            get => InternalPointSizeSelector;
            set
            {
                InternalPointSizeSelector = value;
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
            get => InternalIconURLSelector;
            set
            {
                InternalIconURLSelector = value;
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
            get => InternalIsSelected;
            set => InternalIsSelected = value;
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
            get => InternalIconRelativeOrientation;
            set => InternalIconRelativeOrientation = value;
        }

        /// <summary>
        /// Icon padding in Button. It is shortcut of Icon.Padding.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Extents IconPadding
        {
            get => InternalIconPadding;
            set => InternalIconPadding = value;
        }

        /// <summary>
        /// Text padding in Button. It is shortcut of TextLabel.Padding.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Extents TextPadding
        {
            get => InternalTextPadding;
            set => InternalTextPadding = value;
        }

        /// <summary>
        /// The item (text or icon or both) alignment.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public LinearLayout.Alignment ItemAlignment
        {
            get => InternalItemAlignment;
            set => InternalItemAlignment = value;
        }

        /// <summary>
        /// The item (text or icon or both) horizontal alignment.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public HorizontalAlignment ItemHorizontalAlignment
        {
            get => InternalItemHorizontalAlignment;
            set => InternalItemHorizontalAlignment = value;
        }

        /// <summary>
        /// The item (text or icon or both) vertical alignment.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VerticalAlignment ItemVerticalAlignment
        {
            get => InternalItemVerticalAlignment;
            set => InternalItemVerticalAlignment = value;
        }

        /// <summary>
        /// The space between icon and text.
        /// The value is applied when there exist icon and text both.
        /// The width value is used when the items are arranged horizontally. Otherwise, the height value is used.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public Size2D ItemSpacing
        {
            get => InternalItemSpacing;
            set => InternalItemSpacing = value;
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
