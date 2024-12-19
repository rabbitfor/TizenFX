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

using System.Diagnostics.CodeAnalysis;
using Tizen.NUI.BaseComponents;

namespace Tizen.NUI
{
    internal partial class DefaultThemeCreator
    {
        /// <summary>
        /// The base theme description.
        /// </summary>
        [SuppressMessage("Microsoft.Reliability", "CA2000: Dispose objects before losing scope", Justification = "The responsibility to dispose the object is transferred to the theme object.")]
        public Theme Create()
        {
            Theme theme = new Theme()
            {
                Id = DefaultId,
                Version = DefaultVersion,
            };

            // TextLabel style.
            theme.AddStyleWithoutClone("Tizen.NUI.BaseComponents.TextLabel", new TextLabelStyle()
            {
                FontFamily = Tizen.NUI.FontFamily.UseSystemSetting,
                PixelSize = 24,
                TextColor = Color.GetReusable(0.04f, 0.05f, 0.13f, 1),
                FontStyle = PropertyMap.GetReusable().AddString("weight", "regular"),
                AutoScrollLoopCount = 2,
                AutoScrollGap = 50.0f,
                AutoScrollSpeed = 80,
                FontSizeScale = Tizen.NUI.FontSizeScale.UseSystemSetting,
                AnchorColor = Color.MediumBlue,
                AnchorClickedColor = Color.DarkMagenta,
            });

            // TextField style.
            theme.AddStyleWithoutClone("Tizen.NUI.BaseComponents.TextField", new TextFieldStyle()
            {
                FontFamily = Tizen.NUI.FontFamily.UseSystemSetting,
                PixelSize = 24,
                TextColor = Color.GetReusable(0.04f, 0.05f, 0.13f, 1),
                PlaceholderTextColor = Vector4.GetReusable(0.79f, 0.79f, 0.79f, 1),
                FontStyle = PropertyMap.GetReusable().AddString("weight", "regular"),
                PrimaryCursorColor = Vector4.GetReusable(0.04f, 0.05f, 0.13f, 1),
                SecondaryCursorColor = Vector4.GetReusable(0.04f, 0.05f, 0.13f, 1),
                CursorWidth = 2,
                FontSizeScale = Tizen.NUI.FontSizeScale.UseSystemSetting,
                SelectionHighlightColor = Vector4.GetReusable(1.00f, 0.38f, 0.00f, 0.30f),
                GrabHandleColor = Color.GetReusable(1.00f, 1.00f, 1.00f, 1),
                GrabHandleImage = FrameworkInformation.ResourcePath + "IoT_handler_center_downW.png",
                SelectionHandleImageLeft = PropertyMap.GetReusable().AddString("filename",  FrameworkInformation.ResourcePath + "IoT_handler_downleftW.png"),
                SelectionHandleImageRight = PropertyMap.GetReusable().AddString("filename", FrameworkInformation.ResourcePath + "IoT_handler_downrightW.png"),
                SelectionPopupStyle = PropertyMap.GetReusable()
                .AddVector2(SelectionPopupStyleProperty.MaxSize, 1200.0f, 40.0f)
                .AddVector2(SelectionPopupStyleProperty.DividerSize, 0.0f, 0.0f)
                .AddVector4(SelectionPopupStyleProperty.DividerPadding, 0.0f, 0.0f, 0.0f, 0.0f)
                .AddMap(SelectionPopupStyleProperty.Background, PropertyMap.GetReusable().AddString(ImageVisualProperty.URL, FrameworkInformation.ResourcePath + "IoT-selection-popup-background.9.png"))
                .AddMap(SelectionPopupStyleProperty.BackgroundBorder, PropertyMap.GetReusable().AddString(ImageVisualProperty.URL, FrameworkInformation.ResourcePath + "IoT-selection-popup-border.9.png"))
                .AddVector4(SelectionPopupStyleProperty.PressedColor, 1.0f, 0.39f, 0.0f, 0.16f)
                .AddFloat(SelectionPopupStyleProperty.PressedCornerRadius, 12.0f)
                .AddFloat(SelectionPopupStyleProperty.FadeInDuration, 0.25f)
                .AddFloat(SelectionPopupStyleProperty.FadeOutDuration, 0.25f)
                .AddBool(SelectionPopupStyleProperty.EnableScrollBar, false)
                .AddVector2(SelectionPopupStyleProperty.LabelMinimumSize, 0, 40.0f)
                .AddVector4(SelectionPopupStyleProperty.LabelPadding, -4.0f, -4.0f, 0.0f, 0.0f)
                .AddMap(SelectionPopupStyleProperty.LabelTextVisual, PropertyMap.GetReusable()
                    .AddFloat(TextVisualProperty.PointSize, 6.0f)
                    .AddVector4(TextVisualProperty.TextColor, 1.00f, 0.38f, 0.00f, 1)
                    .AddString(TextVisualProperty.FontFamily, "TizenSans")
                    .AddMap(TextVisualProperty.FontStyle, PropertyMap.GetReusable().AddString("weight", "regular"))),
            });

            // TextEditor style.
            theme.AddStyleWithoutClone("Tizen.NUI.BaseComponents.TextEditor", new TextEditorStyle()
            {
                FontFamily = Tizen.NUI.FontFamily.UseSystemSetting,
                PixelSize = 24,
                TextColor = Color.GetReusable(0.04f, 0.05f, 0.13f, 1),
                PlaceholderTextColor = Color.GetReusable(0.79f, 0.79f, 0.79f, 1),
                FontStyle = PropertyMap.GetReusable().AddString("weight", "regular"),
                PrimaryCursorColor = Vector4.GetReusable(0.04f, 0.05f, 0.13f, 1),
                SecondaryCursorColor = Vector4.GetReusable(0.04f, 0.05f, 0.13f, 1),
                CursorWidth = 2,
                EnableScrollBar = true,
                ScrollBarShowDuration = 0.8f,
                ScrollBarFadeDuration = 0.5f,
                FontSizeScale = Tizen.NUI.FontSizeScale.UseSystemSetting,
                SelectionHighlightColor = Vector4.GetReusable(1.00f, 0.38f, 0.00f, 0.30f),
                GrabHandleColor = Color.GetReusable(1.00f, 1.00f, 1.00f, 1),
                GrabHandleImage = FrameworkInformation.ResourcePath + "IoT_handler_center_downW.png",
                SelectionHandleImageLeft = PropertyMap.GetReusable().AddString("filename", FrameworkInformation.ResourcePath + "IoT_handler_downleftW.png"),
                SelectionHandleImageRight = PropertyMap.GetReusable().AddString("filename", FrameworkInformation.ResourcePath + "IoT_handler_downrightW.png"),
                SelectionPopupStyle = PropertyMap.GetReusable()
                .AddVector2(SelectionPopupStyleProperty.MaxSize, 1200.0f, 40.0f)
                .AddVector2(SelectionPopupStyleProperty.DividerSize, 0.0f, 0.0f)
                .AddVector4(SelectionPopupStyleProperty.DividerPadding, 0.0f, 0.0f, 0.0f, 0.0f)
                .AddMap(SelectionPopupStyleProperty.Background, PropertyMap.GetReusable().AddString(ImageVisualProperty.URL, FrameworkInformation.ResourcePath + "IoT-selection-popup-background.9.png"))
                .AddMap(SelectionPopupStyleProperty.BackgroundBorder, PropertyMap.GetReusable().AddString(ImageVisualProperty.URL, FrameworkInformation.ResourcePath + "IoT-selection-popup-border.9.png"))
                .AddVector4(SelectionPopupStyleProperty.PressedColor, 1.0f, 0.39f, 0.0f, 0.16f)
                .AddFloat(SelectionPopupStyleProperty.PressedCornerRadius, 12.0f)
                .AddFloat(SelectionPopupStyleProperty.FadeInDuration, 0.25f)
                .AddFloat(SelectionPopupStyleProperty.FadeOutDuration, 0.25f)
                .AddBool(SelectionPopupStyleProperty.EnableScrollBar, false)
                .AddVector2(SelectionPopupStyleProperty.LabelMinimumSize, 0, 40.0f)
                .AddVector4(SelectionPopupStyleProperty.LabelPadding, -4.0f, -4.0f, 0.0f, 0.0f)
                .AddMap(SelectionPopupStyleProperty.LabelTextVisual, PropertyMap.GetReusable()
                    .AddFloat(TextVisualProperty.PointSize, 6.0f)
                    .AddVector4(TextVisualProperty.TextColor, 1.00f, 0.38f, 0.00f, 1)
                    .AddString(TextVisualProperty.FontFamily, "TizenSans")
                    .AddMap(TextVisualProperty.FontStyle, PropertyMap.GetReusable().AddString("weight", "regular")))
            });

            return theme;
        }
    }
}

