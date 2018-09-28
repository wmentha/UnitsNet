﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToPowerDensity
{
    public static class NumberToPowerDensityExtensions
    {
        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerCubicFoot<T>(this T value) => PowerDensity.FromDecawattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerCubicInch<T>(this T value) => PowerDensity.FromDecawattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerCubicMeter<T>(this T value) => PowerDensity.FromDecawattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerLiter<T>(this T value) => PowerDensity.FromDecawattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerCubicFoot<T>(this T value) => PowerDensity.FromDeciwattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerCubicInch<T>(this T value) => PowerDensity.FromDeciwattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerCubicMeter<T>(this T value) => PowerDensity.FromDeciwattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerLiter<T>(this T value) => PowerDensity.FromDeciwattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerCubicFoot<T>(this T value) => PowerDensity.FromGigawattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerCubicInch<T>(this T value) => PowerDensity.FromGigawattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerCubicMeter<T>(this T value) => PowerDensity.FromGigawattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerLiter<T>(this T value) => PowerDensity.FromGigawattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerCubicFoot<T>(this T value) => PowerDensity.FromKilowattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerCubicInch<T>(this T value) => PowerDensity.FromKilowattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerCubicMeter<T>(this T value) => PowerDensity.FromKilowattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerLiter<T>(this T value) => PowerDensity.FromKilowattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerCubicFoot<T>(this T value) => PowerDensity.FromMegawattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerCubicInch<T>(this T value) => PowerDensity.FromMegawattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerCubicMeter<T>(this T value) => PowerDensity.FromMegawattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerLiter<T>(this T value) => PowerDensity.FromMegawattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerCubicFoot<T>(this T value) => PowerDensity.FromMicrowattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerCubicInch<T>(this T value) => PowerDensity.FromMicrowattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerCubicMeter<T>(this T value) => PowerDensity.FromMicrowattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerLiter<T>(this T value) => PowerDensity.FromMicrowattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerCubicFoot<T>(this T value) => PowerDensity.FromMilliwattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerCubicInch<T>(this T value) => PowerDensity.FromMilliwattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerCubicMeter<T>(this T value) => PowerDensity.FromMilliwattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerLiter<T>(this T value) => PowerDensity.FromMilliwattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerCubicFoot<T>(this T value) => PowerDensity.FromNanowattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerCubicInch<T>(this T value) => PowerDensity.FromNanowattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerCubicMeter<T>(this T value) => PowerDensity.FromNanowattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerLiter<T>(this T value) => PowerDensity.FromNanowattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerCubicFoot<T>(this T value) => PowerDensity.FromPicowattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerCubicInch<T>(this T value) => PowerDensity.FromPicowattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerCubicMeter<T>(this T value) => PowerDensity.FromPicowattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerLiter<T>(this T value) => PowerDensity.FromPicowattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerCubicFoot<T>(this T value) => PowerDensity.FromTerawattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerCubicInch<T>(this T value) => PowerDensity.FromTerawattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerCubicMeter<T>(this T value) => PowerDensity.FromTerawattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerLiter<T>(this T value) => PowerDensity.FromTerawattsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerCubicFoot<T>(this T value) => PowerDensity.FromWattsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicInch(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerCubicInch<T>(this T value) => PowerDensity.FromWattsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerCubicMeter<T>(this T value) => PowerDensity.FromWattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromWattsPerLiter(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerLiter<T>(this T value) => PowerDensity.FromWattsPerLiter(Convert.ToDouble(value));

    }
}
#endif