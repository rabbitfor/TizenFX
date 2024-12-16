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
using Tizen.NUI.Binding;
using System.ComponentModel;
using System.Globalization;

namespace Tizen.NUI
{
    /// <summary>
    /// The Color class.
    /// This class represents a color using red, green, blue, and alpha components.
    /// It provides methods to create and manipulate colors.
    /// </summary>
    [Tizen.NUI.Binding.TypeConverter(typeof(ColorTypeConverter))]
    public class Color : Disposable, ICloneable
    {
        /// <summary>
        /// Gets the alice_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color AliceBlue = new Color(0, 0, 0, 0);

        /// <summary>
        /// Gets the antique_white colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color AntiqueWhite = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the aqua colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Aqua = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the aqua_marine colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color AquaMarine = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the azure colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Azure = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the beige colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Beige = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the bisque colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Bisque = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the black colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Black = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the blanche_dalmond colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color BlancheDalmond = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the blue colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Blue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the blue_violet colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color BlueViolet = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the brown colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Brown = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the burly_wood colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color BurlyWood = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the cadet_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color CadetBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the chartreuse colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Chartreuse = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the chocolate colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Chocolate = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the coral colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Coral = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the cornflower_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color CornflowerBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the cornsilk colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Cornsilk = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the crimson colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Crimson = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the cyan colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Cyan = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_cyan colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkCyan = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_goldenrod colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkGoldenrod = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkGray = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkGrey = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_khaki colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkKhaki = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_magenta colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkMagenta = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_olive_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkOliveGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_orange colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkOrange = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_orchid colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkOrchid = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_red colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkRed = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_salmon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSalmon = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_sea_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSeaGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_slate_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSlateBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_slate_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSlateGray = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_slate_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSlateGrey = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_turquoise colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkTurquoise = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dark_violet colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkViolet = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the deep_pink colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DeepPink = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the deep_sky_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DeepSkyBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dim_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DimGray = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dim_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DimGrey = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the dodger_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DodgerBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the fire_brick colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color FireBrick = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the floral_white colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color FloralWhite = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the forest_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color ForestGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the fuchsia colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Fuchsia = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the gainsboro colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Gainsboro = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the ghost_white colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color GhostWhite = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the gold colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Gold = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the golden_rod colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color GoldenRod = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Gray = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the green colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Green = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the green_yellow colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color GreenYellow = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Grey = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the honeydew colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Honeydew = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the hot_pink colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color HotPink = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the indianred colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Indianred = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the indigo colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Indigo = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the ivory colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Ivory = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the khaki colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Khaki = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the lavender colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Lavender = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the lavender_blush colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LavenderBlush = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the lawn_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LawnGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the lemon_chiffon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LemonChiffon = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_coral colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightCoral = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_cyan colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightCyan = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_golden_rod_yellow colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightGoldenRodYellow = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightGray = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightGrey = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_pink colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightPink = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_salmon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSalmon = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_sea_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSeaGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_sky_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSkyBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_slate_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSlateGray = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_slate_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSlateGrey = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_steel_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSteelBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the light_yellow colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightYellow = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the lime colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Lime = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the lime_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LimeGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the linen colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Linen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the magenta colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Magenta = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the maroon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Maroon = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_aqua_marine colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumAquaMarine = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_orchid colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumOrchid = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_purple colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumPurple = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_sea_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumSeaGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_slate_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumSlateBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_spring_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumSpringGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_turquoise colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumTurquoise = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the medium_violetred colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumVioletred = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the midnight_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MidnightBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the mint_cream colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MintCream = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the misty_rose colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MistyRose = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the moccasin colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Moccasin = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the navajo_white colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color NavajoWhite = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the navy colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Navy = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the old_lace colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color OldLace = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the olive colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Olive = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the olive_drab colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color OliveDrab = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the orange colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Orange = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the orange_red colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color OrangeRed = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the orchid colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Orchid = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the pale_golden_rod colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PaleGoldenRod = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the pale_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PaleGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the  Pale_Turquoise colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PaleTurquoise = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the Pale_Violet_Red colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PaleVioletRed = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the Papaya_whip  colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PapayaWhip = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the Peach_puff colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PeachPuff = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the peru colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Peru = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the pink colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Pink = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the plum colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Plum = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the powder_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PowderBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the purple colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Purple = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the red colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Red = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the rosy_brown colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color RosyBrown = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the royal_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color RoyalBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the saddle_brown colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SaddleBrown = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the salmon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Salmon = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the sandy_brown colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SandyBrown = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the sea_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SeaGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the sea_shell colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SeaShell = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the sienna colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Sienna = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the silver colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Silver = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the sky_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SkyBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the slate_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SlateBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the slate_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SlateGray = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the slate_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SlateGrey = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the snow colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Snow = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the spring_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SpringGreen = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the steel_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SteelBlue = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the tan colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Tan = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the teal colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Teal = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the thistle colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Thistle = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the tomato colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Tomato = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the  transparent colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Transparent = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the turquoise colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Turquoise = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the violet colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Violet = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the wheat colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Wheat = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the white colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color White = new Color(1f, 1f, 1f, 1f);

        /// <summary>
        /// Gets the white_smoke colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color WhiteSmoke = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the yellow colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Yellow = new Color(0, 0, 0, 1);

        /// <summary>
        /// Gets the yellow_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color YellowGreen = new Color(0, 0, 0, 1);

        static Color()
        {
            Log.Debug("JYJY", "Static color initialized");
        }


        /// <summary>
        /// Default constructor
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Color() : this(0, 0, 0, 0)
        {
        }

        /// <summary>
        /// The conversion constructor from an System.Drawing.Color instance.
        /// </summary>
        /// <param name="color">System.Drawing.Color instance</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color(System.Drawing.Color color) : base(GenerateData(color.R, color.G, color.B, color.A))
        {
        }

        /// <summary>
        /// The copy constructor.
        /// </summary>
        /// <param name="other">The copy target.</param>
        /// <exception cref="ArgumentNullException"> Thrown when other is null. </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color(Color other) : base(other == null ? throw new ArgumentNullException(nameof(other)) : other.GetCPtrAsData())
        {
        }

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="r">The red component.</param>
        /// <param name="g">The green component.</param>
        /// <param name="b">The blue component.</param>
        /// <param name="a">The alpha component.</param>
        /// <since_tizen> 3 </since_tizen>
        public Color(float r, float g, float b, float a) : base(GenerateData(ValueCheck(r), ValueCheck(g), ValueCheck(b), ValueCheck(a)))
        {
        }

        /// <summary>
        /// The conversion constructor from an array of four floats.
        /// </summary>
        /// <param name="array">array Array of R,G,B,A.</param>
        /// <since_tizen> 3 </since_tizen>
        public Color(float[] array) : this(array[0], array[1], array[2], array[3])
        {
            ValueCheck(array);
        }

        // internal Color(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn)
        // {
        // }

        internal Color(ColorChangedCallback cb, float r, float g, float b, float a) : this(ValueCheck(r), ValueCheck(g), ValueCheck(b), ValueCheck(a))
        {
            callback = cb;
        }

        internal Color(ColorChangedCallback cb, Color other) : this(cb, other.R, other.G, other.B, other.A)
        {
        }

        /// <summary>
        /// The conversion constructor from text color representation.
        /// hexcode representation : #RGB #RGBA #RRGGBB #RRGGBBAA
        /// rgb representation : rgb(0-255,0-255,0-255) rgba(0-255,0-255,0-255,0.0-1.0)
        /// </summary>
        /// <param name="textColor">color text representation as Hexcode, rgb() or rgba()</param>
        /// <exception cref="ArgumentNullException">This exception is thrown when hexColor is null.</exception>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color(string textColor) : base(GenerateData(textColor ?? throw new ArgumentNullException(nameof(textColor))))
        {
        }

        internal delegate void ColorChangedCallback(float r, float g, float b, float a);
        private ColorChangedCallback callback = null;
        private const int rMask = unchecked(0x00FFFFFF);
        private const int gMask = unchecked((int)0xFF00FFFF);
        private const int bMask = unchecked((int)0xFFFF00FF);
        private const int aMask = unchecked((int)0xFFFFFF00);

        /// <summary>
        /// The red component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use the new Color(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use as follows:
        /// Color color = new Color();
        /// color.R = 0.1f;
        /// // USE like this
        /// float r = 0.1f, g = 0.5f, b = 0.9f, a = 1.0f;
        /// Color color = new Color(r, g, b, a);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float R
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use the new Color(...) constructor")]
            set
            {
                ResetCPtrAsData(((byte)(ValueCheck(value) * 255) << 24) | (GetCPtrAsData() & rMask));
                callback?.Invoke(value, G, B, A);
            }
            get => GetRData() / 255f;
        }

        /// <summary>
        /// The green component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use the new Color(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use as follows:
        /// Color color = new Color();
        /// color.G = 0.5f;
        /// // USE like this
        /// float r = 0.1f, g = 0.5f, b = 0.9f, a = 1.0f;
        /// Color color = new Color(r, g, b, a);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float G
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use the new Color(...) constructor")]
            set
            {
                ResetCPtrAsData(((byte)(ValueCheck(value) * 255) << 16) | (GetCPtrAsData() & gMask));
                callback?.Invoke(R, value, B, A);
            }
            get => GetGData() / 255f;
        }

        /// <summary>
        /// The blue component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use the new Color(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use as follows:
        /// Color color = new Color();
        /// color.B = 0.9f;
        /// // USE like this
        /// float r = 0.1f, g = 0.5f, b = 0.9f, a = 1.0f;
        /// Color color = new Color(r, g, b, a);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float B
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use the new Color(...) constructor")]
            set
            {
                ResetCPtrAsData(((byte)(ValueCheck(value) * 255) << 8) | (GetCPtrAsData() & bMask));
                callback?.Invoke(R, G, value, A);
            }
            get => GetBData() / 255f;
        }

        /// <summary>
        /// The alpha component.
        /// </summary>
        /// <remarks>
        /// The setter is deprecated in API8 and will be removed in API10. Use the new Color(...) constructor.
        /// </remarks>
        /// <code>
        /// // DO NOT use as follows:
        /// Color color = new Color();
        /// color.A = 1.0f;
        /// // USE like this
        /// float r = 0.1f, g = 0.5f, b = 0.9f, a = 1.0f;
        /// Color color = new Color(r, g, b, a);
        /// </code>
        /// <since_tizen> 3 </since_tizen>
        public float A
        {
            [Obsolete("Do not use this setter, that is deprecated in API8 and will be removed in API10. Use the new Color(...) constructor")]
            set
            {
                ResetCPtrAsData((byte)(ValueCheck(value) * 255) | (GetCPtrAsData() & aMask));
                callback?.Invoke(R, G, value, A);
            }
            get => GetAData() / 255f;
        }

        /// <summary>
        /// The array subscript operator overload.
        /// </summary>
        /// <param name="index">The subscript index.</param>
        /// <returns>The float at the given index.</returns>
        /// <since_tizen> 3 </since_tizen>
        public float this[uint index]
        {
            get
            {
                if (index == 0)
                {
                    return GetRData();
                }
                if (index == 1)
                {
                    return GetGData();
                }
                if (index == 2)
                {
                    return GetBData();
                }
                if (index == 3)
                {
                    return GetAData();
                }
                return 0;
            }
        }

        /// <summary>
        /// Converts the Color class to Vector4 class implicitly.
        /// </summary>
        /// <param name="color">A color to be converted to Vector4</param>
        /// <since_tizen> 3 </since_tizen>
        public static implicit operator Vector4(Color color)
        {
            if (color == null)
            {
                return null;
            }
            return new Vector4(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// Converts Vector4 class to Color class implicitly.
        /// </summary>
        /// <param name="vec">A Vector4 to be converted to color.</param>
        /// <since_tizen> 3 </since_tizen>
        public static implicit operator Color(Vector4 vec)
        {
            if (vec == null)
            {
                return null;
            }
            return new Color(vec.R, vec.G, vec.B, vec.A);
        }

        /// <summary>
        /// The addition operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The color containing the result of the addition.</returns>
        /// <exception cref="ArgumentNullException"> Thrown when arg1 is null. </exception>
        /// <since_tizen> 3 </since_tizen>
        public static Color operator +(Color arg1, Color arg2)
        {
            if (null == arg1)
            {
                throw new ArgumentNullException(nameof(arg1));
            }
            Color result = arg1.Add(arg2);
            return ValueCheck(result);
        }

        /// <summary>
        /// The subtraction operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The color containing the result of the subtraction.</returns>
        /// <exception cref="ArgumentNullException"> Thrown when arg1 is null. </exception>
        /// <since_tizen> 3 </since_tizen>
        public static Color operator -(Color arg1, Color arg2)
        {
            if (null == arg1)
            {
                throw new ArgumentNullException(nameof(arg1));
            }
            Color result = arg1.Subtract(arg2);
            return ValueCheck(result);
        }

        /// <summary>
        /// The unary negation operator.
        /// </summary>
        /// <param name="arg1">The target value.</param>
        /// <returns>The color containg the negation.</returns>
        /// <exception cref="ArgumentNullException"> Thrown when arg1 is null. </exception>
        /// <since_tizen> 3 </since_tizen>
        public static Color operator -(Color arg1)
        {
            if (null == arg1)
            {
                throw new ArgumentNullException(nameof(arg1));
            }
            Color result = arg1.Subtract();
            return ValueCheck(result);
        }

        /// <summary>
        /// The multiplication operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The color containing the result of the multiplication.</returns>
        /// <exception cref="ArgumentNullException"> Thrown when arg1 is null. </exception>
        /// <since_tizen> 3 </since_tizen>
        public static Color operator *(Color arg1, Color arg2)
        {
            if (null == arg1)
            {
                throw new ArgumentNullException(nameof(arg1));
            }
            Color result = arg1.Multiply(arg2);
            return ValueCheck(result);
        }

        /// <summary>
        /// The multiplication operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The color containing the result of the multiplication.</returns>
        /// <exception cref="ArgumentNullException"> Thrown when arg1 is null. </exception>
        /// <since_tizen> 3 </since_tizen>
        public static Color operator *(Color arg1, float arg2)
        {
            if (null == arg1)
            {
                throw new ArgumentNullException(nameof(arg1));
            }
            Color result = arg1.Multiply(arg2);
            return ValueCheck(result);
        }

        /// <summary>
        /// The division operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The color containing the result of the division.</returns>
        /// <exception cref="ArgumentNullException"> Thrown when arg1 is null. </exception>
        /// <since_tizen> 3 </since_tizen>
        public static Color operator /(Color arg1, Color arg2)
        {
            if (null == arg1)
            {
                throw new ArgumentNullException(nameof(arg1));
            }
            Color result = arg1.Divide(arg2);
            return ValueCheck(result);
        }

        /// <summary>
        /// The division operator.
        /// </summary>
        /// <param name="arg1">The first value.</param>
        /// <param name="arg2">The second value.</param>
        /// <returns>The color containing the result of the division.</returns>
        /// <exception cref="ArgumentNullException"> Thrown when arg1 is null. </exception>
        /// <since_tizen> 3 </since_tizen>
        public static Color operator /(Color arg1, float arg2)
        {
            if (null == arg1)
            {
                throw new ArgumentNullException(nameof(arg1));
            }
            Color result = arg1.Divide(arg2);
            return ValueCheck(result);
        }

        /// <summary>
        /// Checks if two color classes are same.
        /// </summary>
        /// <param name="rhs">A color to be compared.</param>
        /// <returns>If two colors are are same, then true.</returns>
        /// <since_tizen> 3 </since_tizen>
        public bool EqualTo(Color rhs)
        {
            if (ReferenceEquals(this, rhs))
            {
                return true;
            }

            return GetRData() == rhs.GetRData() && GetGData() == rhs.GetGData() && GetBData() == rhs.GetBData() && GetAData() == rhs.GetAData();
        }

        /// <summary>
        /// Checks if two color classes are different.
        /// </summary>
        /// <param name="rhs">A color to be compared.</param>
        /// <returns>If two colors are are different, then true.</returns>
        /// <since_tizen> 3 </since_tizen>
        public bool NotEqualTo(Color rhs) => !EqualTo(rhs);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public object Clone() => new Color(this);

        internal static Color ValueCheck(Color color)
        {
            float r = color.R;
            float g = color.G;
            float b = color.B;
            float a = color.A;

            if (IsInvalidValue(ref r) | IsInvalidValue(ref g) | IsInvalidValue(ref b) | IsInvalidValue(ref a))
            {
                NUILog.Error($"The value of Result is invalid! Should be between [0, 1]. Color is {color.R}, {color.G}, {color.B}, {color.A}");
            }
            color = new Color(r, g, b, a);
            return color;
        }

        internal static float ValueCheck(float value)
        {
            float refValue = value;
            if (IsInvalidValue(ref refValue))
            {
                NUILog.Error($"The value of Result is invalid! Should be between [0, 1]. float value is {value}");
            }
            return refValue;
        }

        internal static float[] ValueCheck(float[] arr)
        {
            if (null == arr)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            for (int i = 0; i < arr.Length; i++)
            {
                float refValue = arr[i];
                if (IsInvalidValue(ref refValue))
                {
                    NUILog.Error($"The value of Result is invalid! Should be between [0, 1]. arr[] is {arr[i]}");
                    arr[i] = refValue;
                }
            }
            return arr;
        }

        private static bool IsInvalidValue(ref float value)
        {
            if (value < 0.0f)
            {
                value = 0.0f;
                return true;
            }
            else if (value > 1.0f)
            {
                value = 1.0f;
                return true;
            }
            return false;
        }

        /// This will not be public opened.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void ReleaseSwigCPtr(System.Runtime.InteropServices.HandleRef swigCPtr)
        {
            Interop.Vector4.DeleteVector4(swigCPtr);
        }

        private Color Add(Color rhs) => new Color(Math.Min(R + rhs.R, 1), Math.Min(G + rhs.G, 1), Math.Min(B + rhs.B, 1), Math.Min(A + rhs.A, 1));

        private Color Subtract(Color rhs) => new Color(Math.Max(R - rhs.R, 0), Math.Max(G - rhs.G, 0), Math.Max(B - rhs.B, 0), Math.Max(A - rhs.A, 0));

        private Color Multiply(Color rhs) => new Color(Math.Min(R * rhs.R, 1), Math.Min(G * rhs.G, 1), Math.Min(B * rhs.B, 1), Math.Min(A * rhs.A, 1));

        private Color Multiply(float rhs) => new Color(Math.Min(R * rhs, 1), Math.Min(G * rhs, 1), Math.Min(B * rhs, 1), Math.Min(A * rhs, 1));

        private Color Divide(Vector4 rhs) => new Color(Math.Min(R / rhs.R, 1), Math.Min(G / rhs.G, 1), Math.Min(B / rhs.B, 1), Math.Min(A / rhs.A, 1));

        private Color Divide(float rhs) => new Color(Math.Min(R / rhs, 1), Math.Min(G / rhs, 1), Math.Min(B / rhs, 1), Math.Min(A / rhs, 1));


        private Color Subtract() =>  new Color(0, 0, 0, 0);

        private static bool EqualsColorValue(float f1, float f2)
        {
            float EPS = (float)Math.Abs(f1 * .00001);
            if (Math.Abs(f1 - f2) <= EPS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool EqualsColor(Color c1, Color c2)
        {
            return EqualsColorValue(c1.R, c2.R) && EqualsColorValue(c1.G, c2.G)
                && EqualsColorValue(c1.B, c2.B) && EqualsColorValue(c1.A, c2.A);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(System.Object obj)
        {
            Color color = obj as Color;
            bool equal = false;
            if (color == null)
            {
                return equal;
            }

            if (EqualsColor(this, color))
            {
                equal = true;
            }
            return equal;
        }

        /// <summary>
        /// The == operator.
        /// </summary>
        /// <param name="arg1">Color to compare</param>
        /// <param name="arg2">Color to be compared</param>
        /// <returns>true if Colors are equal</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool operator ==(Color arg1, Color arg2)
        {
            if (arg1 is null)
            {
                if (arg2 is null)
                    return true;

                return false;
            }

            return arg1.Equals(arg2);
        }

        /// <summary>
        /// The != operator.
        /// </summary>
        /// <param name="arg1">Color to compare</param>
        /// <param name="arg2">Color to be compared</param>
        /// <returns>true if Colors are not equal</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool operator !=(Color arg1, Color arg2) => !(arg1 == arg2);

        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        internal uint ToUint() => (uint)GetCPtrAsData();

        private byte GetRData() => (byte)((((uint)GetCPtrAsData()) & (~rMask)) >> 24);
        private byte GetGData() => (byte)((((uint)GetCPtrAsData()) & (~gMask)) >> 16);
        private byte GetBData() => (byte)((((uint)GetCPtrAsData()) & (~bMask)) >> 8);
        private byte GetAData() => (byte)(((uint)GetCPtrAsData()) & (~aMask));

        private static int GenerateData(int r, int g, int b, int a) => GenerateData((byte)r, (byte)g, (byte)b, (byte)a);

        private static int GenerateData(float r, float g, float b, float a) => GenerateData((byte)(r * 255f), (byte)(g * 255f), (byte)(b * 255f), (byte)(a * 255f));

        private static int GenerateData(byte r, byte g, byte b, byte a)
        {
            return unchecked(r << 24 | g << 16 | b << 8 | a);
        }

        /// <summary>
        /// The conversion constructor from text color representation.
        /// hexcode representation : #RGB #RGBA #RRGGBB #RRGGBBAA
        /// rgb representation : rgb(0-255,0-255,0-255) rgba(0-255,0-255,0-255,0.0-1.0)
        /// </summary>
        /// <param name="hexColor">color text representation as Hexcode, rgb() or rgba()</param>
        /// <exception cref="ArgumentNullException">This exception is thrown when hexColor is null.</exception>
        private static int GenerateData(string hexColor)
        {
            try
            {
                byte r = 0;
                byte g = 0;
                byte b = 0;
                byte a = 0;

                hexColor = hexColor.ToUpperInvariant();
                hexColor = hexColor.Replace(" ", "");

                if (hexColor.Length > 0 && hexColor[0] == '#')
                {
                    hexColor = hexColor.Replace("#", "");
                    int textColorLength = hexColor.Length;

                    if (textColorLength == 6 || textColorLength == 8) /* #RRGGBB or #RRGGBBAA */
                    {
                        r = Convert.ToByte(hexColor.Substring(0, 2), 16);
                        g = Convert.ToByte(hexColor.Substring(2, 2), 16);
                        b = Convert.ToByte(hexColor.Substring(4, 2), 16);
                        a = hexColor.Length > 6 ? Convert.ToByte(hexColor.Substring(6, 2), 16) : (byte)255;
                    }
                    else if (textColorLength == 3 || textColorLength == 4) /* #RGB */
                    {
                        r = Convert.ToByte(hexColor.Substring(0, 1), 16);
                        g = Convert.ToByte(hexColor.Substring(1, 1), 16);
                        b = Convert.ToByte(hexColor.Substring(2, 1), 16);
                        a = hexColor.Length > 3 ? Convert.ToByte(hexColor.Substring(3, 1), 16) : (byte)255;
                    }
                    else
                    {
                        throw new global::System.ArgumentException("Please check your color text code");
                    }
                }
                else // example rgb(255,255,255) or rgb(255,255,255,1.0)
                {
                    bool isRGBA = hexColor.StartsWith("RGBA(");
                    bool isRGB = hexColor.StartsWith("RGB(");

                    if (!isRGBA && !isRGB)
                    {
                        throw new global::System.ArgumentException("Please check your color text code");
                    }

                    if (isRGBA)
                        hexColor = hexColor.Substring(4);
                    if (isRGB)
                        hexColor = hexColor.Substring(3);

                    hexColor = hexColor.Replace(")", "");
                    hexColor = hexColor.Replace("(", "");

                    string[] components = hexColor.Split(',');

                    if (components.Length == 3 && isRGB)
                    {
                        r = Math.Min((byte)255, Convert.ToByte(components[0], 10));
                        g = Math.Min((byte)255, Convert.ToByte(components[1], 10));
                        b = Math.Min((byte)255, Convert.ToByte(components[2], 10));
                        a = 255;
                    }
                    else if (components.Length == 4 && isRGBA)
                    {
                        r = Math.Min((byte)255, Convert.ToByte(components[0], 10));
                        g = Math.Min((byte)255, Convert.ToByte(components[1], 10));
                        b = Math.Min((byte)255, Convert.ToByte(components[2], 10));
                        a = Math.Min((byte)255, (byte)(float.Parse(components[3], CultureInfo.InvariantCulture) * 255));
                    }
                }
                return GenerateData(r, g, b, a);
            }
            catch
            {
                throw new ArgumentException("Please check your color text code");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                Dispose(DisposeTypes.Explicit);
            }
            else if (SwigCMemOwn)
            {
                // NOTE This is to use push disposal queue to destory unmanaged reference.
                base.Dispose(false);
            }
        }
    }

}


