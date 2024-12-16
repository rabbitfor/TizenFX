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
        public static readonly Color AntiqueWhite = AliceBlue;

        /// <summary>
        /// Gets the aqua colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Aqua = AliceBlue;

        /// <summary>
        /// Gets the aqua_marine colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color AquaMarine = AliceBlue;

        /// <summary>
        /// Gets the azure colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Azure = AliceBlue;

        /// <summary>
        /// Gets the beige colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Beige = AliceBlue;

        /// <summary>
        /// Gets the bisque colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Bisque = AliceBlue;

        /// <summary>
        /// Gets the black colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Black = AliceBlue;

        /// <summary>
        /// Gets the blanche_dalmond colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color BlancheDalmond = AliceBlue;

        /// <summary>
        /// Gets the blue colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Blue = AliceBlue;

        /// <summary>
        /// Gets the blue_violet colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color BlueViolet = AliceBlue;

        /// <summary>
        /// Gets the brown colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Brown = AliceBlue;

        /// <summary>
        /// Gets the burly_wood colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color BurlyWood = AliceBlue;

        /// <summary>
        /// Gets the cadet_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color CadetBlue = AliceBlue;

        /// <summary>
        /// Gets the chartreuse colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Chartreuse = AliceBlue;

        /// <summary>
        /// Gets the chocolate colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Chocolate = AliceBlue;

        /// <summary>
        /// Gets the coral colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Coral = AliceBlue;

        /// <summary>
        /// Gets the cornflower_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color CornflowerBlue = AliceBlue;

        /// <summary>
        /// Gets the cornsilk colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Cornsilk = AliceBlue;

        /// <summary>
        /// Gets the crimson colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Crimson = AliceBlue;

        /// <summary>
        /// Gets the cyan colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Cyan = AliceBlue;

        /// <summary>
        /// Gets the dark_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkBlue = AliceBlue;

        /// <summary>
        /// Gets the dark_cyan colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkCyan = AliceBlue;

        /// <summary>
        /// Gets the dark_goldenrod colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkGoldenrod = AliceBlue;

        /// <summary>
        /// Gets the dark_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkGray = AliceBlue;

        /// <summary>
        /// Gets the dark_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkGreen = AliceBlue;

        /// <summary>
        /// Gets the dark_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkGrey = AliceBlue;

        /// <summary>
        /// Gets the dark_khaki colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkKhaki = AliceBlue;

        /// <summary>
        /// Gets the dark_magenta colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkMagenta = AliceBlue;

        /// <summary>
        /// Gets the dark_olive_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkOliveGreen = AliceBlue;

        /// <summary>
        /// Gets the dark_orange colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkOrange = AliceBlue;

        /// <summary>
        /// Gets the dark_orchid colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkOrchid = AliceBlue;

        /// <summary>
        /// Gets the dark_red colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkRed = AliceBlue;

        /// <summary>
        /// Gets the dark_salmon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSalmon = AliceBlue;

        /// <summary>
        /// Gets the dark_sea_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSeaGreen = AliceBlue;

        /// <summary>
        /// Gets the dark_slate_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSlateBlue = AliceBlue;

        /// <summary>
        /// Gets the dark_slate_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSlateGray = AliceBlue;

        /// <summary>
        /// Gets the dark_slate_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkSlateGrey = AliceBlue;

        /// <summary>
        /// Gets the dark_turquoise colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkTurquoise = AliceBlue;

        /// <summary>
        /// Gets the dark_violet colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DarkViolet = AliceBlue;

        /// <summary>
        /// Gets the deep_pink colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DeepPink = AliceBlue;

        /// <summary>
        /// Gets the deep_sky_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DeepSkyBlue = AliceBlue;

        /// <summary>
        /// Gets the dim_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DimGray = AliceBlue;

        /// <summary>
        /// Gets the dim_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DimGrey = AliceBlue;

        /// <summary>
        /// Gets the dodger_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color DodgerBlue = AliceBlue;

        /// <summary>
        /// Gets the fire_brick colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color FireBrick = AliceBlue;

        /// <summary>
        /// Gets the floral_white colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color FloralWhite = AliceBlue;

        /// <summary>
        /// Gets the forest_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color ForestGreen = AliceBlue;

        /// <summary>
        /// Gets the fuchsia colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Fuchsia = AliceBlue;

        /// <summary>
        /// Gets the gainsboro colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Gainsboro = AliceBlue;

        /// <summary>
        /// Gets the ghost_white colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color GhostWhite = AliceBlue;

        /// <summary>
        /// Gets the gold colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Gold = AliceBlue;

        /// <summary>
        /// Gets the golden_rod colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color GoldenRod = AliceBlue;

        /// <summary>
        /// Gets the gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Gray = AliceBlue;

        /// <summary>
        /// Gets the green colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Green = AliceBlue;

        /// <summary>
        /// Gets the green_yellow colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color GreenYellow = AliceBlue;

        /// <summary>
        /// Gets the grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Grey = AliceBlue;

        /// <summary>
        /// Gets the honeydew colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Honeydew = AliceBlue;

        /// <summary>
        /// Gets the hot_pink colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color HotPink = AliceBlue;

        /// <summary>
        /// Gets the indianred colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Indianred = AliceBlue;

        /// <summary>
        /// Gets the indigo colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Indigo = AliceBlue;

        /// <summary>
        /// Gets the ivory colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Ivory = AliceBlue;

        /// <summary>
        /// Gets the khaki colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Khaki = AliceBlue;

        /// <summary>
        /// Gets the lavender colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Lavender = AliceBlue;

        /// <summary>
        /// Gets the lavender_blush colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LavenderBlush = AliceBlue;

        /// <summary>
        /// Gets the lawn_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LawnGreen = AliceBlue;

        /// <summary>
        /// Gets the lemon_chiffon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LemonChiffon = AliceBlue;

        /// <summary>
        /// Gets the light_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightBlue = AliceBlue;

        /// <summary>
        /// Gets the light_coral colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightCoral = AliceBlue;

        /// <summary>
        /// Gets the light_cyan colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightCyan = AliceBlue;

        /// <summary>
        /// Gets the light_golden_rod_yellow colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightGoldenRodYellow = AliceBlue;

        /// <summary>
        /// Gets the light_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightGray = AliceBlue;

        /// <summary>
        /// Gets the light_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightGreen = AliceBlue;

        /// <summary>
        /// Gets the light_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightGrey = AliceBlue;

        /// <summary>
        /// Gets the light_pink colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightPink = AliceBlue;

        /// <summary>
        /// Gets the light_salmon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSalmon = AliceBlue;

        /// <summary>
        /// Gets the light_sea_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSeaGreen = AliceBlue;

        /// <summary>
        /// Gets the light_sky_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSkyBlue = AliceBlue;

        /// <summary>
        /// Gets the light_slate_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSlateGray = AliceBlue;

        /// <summary>
        /// Gets the light_slate_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSlateGrey = AliceBlue;

        /// <summary>
        /// Gets the light_steel_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightSteelBlue = AliceBlue;

        /// <summary>
        /// Gets the light_yellow colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LightYellow = AliceBlue;

        /// <summary>
        /// Gets the lime colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Lime = AliceBlue;

        /// <summary>
        /// Gets the lime_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color LimeGreen = AliceBlue;

        /// <summary>
        /// Gets the linen colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Linen = AliceBlue;

        /// <summary>
        /// Gets the magenta colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Magenta = AliceBlue;

        /// <summary>
        /// Gets the maroon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Maroon = AliceBlue;

        /// <summary>
        /// Gets the medium_aqua_marine colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumAquaMarine = AliceBlue;

        /// <summary>
        /// Gets the medium_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumBlue = AliceBlue;

        /// <summary>
        /// Gets the medium_orchid colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumOrchid = AliceBlue;

        /// <summary>
        /// Gets the medium_purple colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumPurple = AliceBlue;

        /// <summary>
        /// Gets the medium_sea_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumSeaGreen = AliceBlue;

        /// <summary>
        /// Gets the medium_slate_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumSlateBlue = AliceBlue;

        /// <summary>
        /// Gets the medium_spring_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumSpringGreen = AliceBlue;

        /// <summary>
        /// Gets the medium_turquoise colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumTurquoise = AliceBlue;

        /// <summary>
        /// Gets the medium_violetred colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MediumVioletred = AliceBlue;

        /// <summary>
        /// Gets the midnight_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MidnightBlue = AliceBlue;

        /// <summary>
        /// Gets the mint_cream colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MintCream = AliceBlue;

        /// <summary>
        /// Gets the misty_rose colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color MistyRose = AliceBlue;

        /// <summary>
        /// Gets the moccasin colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Moccasin = AliceBlue;

        /// <summary>
        /// Gets the navajo_white colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color NavajoWhite = AliceBlue;

        /// <summary>
        /// Gets the navy colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Navy = AliceBlue;

        /// <summary>
        /// Gets the old_lace colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color OldLace = AliceBlue;

        /// <summary>
        /// Gets the olive colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Olive = AliceBlue;

        /// <summary>
        /// Gets the olive_drab colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color OliveDrab = AliceBlue;

        /// <summary>
        /// Gets the orange colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Orange = AliceBlue;

        /// <summary>
        /// Gets the orange_red colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color OrangeRed = AliceBlue;

        /// <summary>
        /// Gets the orchid colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Orchid = AliceBlue;

        /// <summary>
        /// Gets the pale_golden_rod colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PaleGoldenRod = AliceBlue;

        /// <summary>
        /// Gets the pale_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PaleGreen = AliceBlue;

        /// <summary>
        /// Gets the  Pale_Turquoise colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PaleTurquoise = AliceBlue;

        /// <summary>
        /// Gets the Pale_Violet_Red colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PaleVioletRed = AliceBlue;

        /// <summary>
        /// Gets the Papaya_whip  colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PapayaWhip = AliceBlue;

        /// <summary>
        /// Gets the Peach_puff colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PeachPuff = AliceBlue;

        /// <summary>
        /// Gets the peru colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Peru = AliceBlue;

        /// <summary>
        /// Gets the pink colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Pink = AliceBlue;

        /// <summary>
        /// Gets the plum colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Plum = AliceBlue;

        /// <summary>
        /// Gets the powder_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color PowderBlue = AliceBlue;

        /// <summary>
        /// Gets the purple colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Purple = AliceBlue;

        /// <summary>
        /// Gets the red colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Red = AliceBlue;

        /// <summary>
        /// Gets the rosy_brown colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color RosyBrown = AliceBlue;

        /// <summary>
        /// Gets the royal_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color RoyalBlue = AliceBlue;

        /// <summary>
        /// Gets the saddle_brown colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SaddleBrown = AliceBlue;

        /// <summary>
        /// Gets the salmon colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Salmon = AliceBlue;

        /// <summary>
        /// Gets the sandy_brown colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SandyBrown = AliceBlue;

        /// <summary>
        /// Gets the sea_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SeaGreen = AliceBlue;

        /// <summary>
        /// Gets the sea_shell colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SeaShell = AliceBlue;

        /// <summary>
        /// Gets the sienna colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Sienna = AliceBlue;

        /// <summary>
        /// Gets the silver colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Silver = AliceBlue;

        /// <summary>
        /// Gets the sky_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SkyBlue = AliceBlue;

        /// <summary>
        /// Gets the slate_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SlateBlue = AliceBlue;

        /// <summary>
        /// Gets the slate_gray colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SlateGray = AliceBlue;

        /// <summary>
        /// Gets the slate_grey colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SlateGrey = AliceBlue;

        /// <summary>
        /// Gets the snow colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Snow = AliceBlue;

        /// <summary>
        /// Gets the spring_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SpringGreen = AliceBlue;

        /// <summary>
        /// Gets the steel_blue colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color SteelBlue = AliceBlue;

        /// <summary>
        /// Gets the tan colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Tan = AliceBlue;

        /// <summary>
        /// Gets the teal colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Teal = AliceBlue;

        /// <summary>
        /// Gets the thistle colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Thistle = AliceBlue;

        /// <summary>
        /// Gets the tomato colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Tomato = AliceBlue;

        /// <summary>
        /// Gets the  transparent colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Transparent = AliceBlue;

        /// <summary>
        /// Gets the turquoise colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Turquoise = AliceBlue;

        /// <summary>
        /// Gets the violet colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Violet = AliceBlue;

        /// <summary>
        /// Gets the wheat colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color Wheat = AliceBlue;

        /// <summary>
        /// Gets the white colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color White = AliceBlue;

        /// <summary>
        /// Gets the white_smoke colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color WhiteSmoke = AliceBlue;

        /// <summary>
        /// Gets the yellow colored Color class.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public static readonly Color Yellow = AliceBlue;

        /// <summary>
        /// Gets the yellow_green colored Color class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly Color YellowGreen = AliceBlue;


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

    }

}


