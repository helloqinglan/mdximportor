//
//  MDXRenderFlag.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;

namespace Warcraft.MDX.Visual
{
    /// <summary>
    /// Render flags for the whole model, or for a section of it.
    /// </summary>
    [Flags]
    public enum MDXRenderFlag : ushort
    {
        /// <summary>
        /// The model is unlit.
        /// </summary>
        Unlit = 0x1,

        /// <summary>
        /// The model is unaffected by fog.
        /// </summary>
        NoFog = 0x2,

        /// <summary>
        /// The model's textures are two-sided.
        /// </summary>
        TwoSided = 0x4,

        /// <summary>
        /// Unknown.
        /// </summary>
        Unknown = 0x8,

        /// <summary>
        /// The model's Z buffer is disabled.
        /// </summary>
        DisableZBuffering = 0x10
    }
}
