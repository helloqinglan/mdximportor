//
//  BGRA.cs
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

namespace Warcraft.Core.Structures
{
    /// <summary>
    /// A structure representing an BGRA colour value.
    /// </summary>
    public struct BGRA
    {
        /// <summary>
        /// The red component.
        /// </summary>
        public byte B;

        /// <summary>
        /// The green component.
        /// </summary>
        public byte G;

        /// <summary>
        /// The blue component.
        /// </summary>
        public byte R;

        /// <summary>
        /// The alpha component.
        /// </summary>
        public byte A;

        /// <summary>
        /// Initializes a new instance of the <see cref="BGRA"/> struct from a set of byte component values.
        /// </summary>
        /// <param name="inG">The input blue component.</param>
        /// <param name="inB">The input green component.</param>
        /// <param name="inR">The input red component.</param>
        /// <param name="inA">The input alpha component.</param>
        public BGRA(byte inB, byte inG, byte inR, byte inA)
        {
            B = inB;
            G = inG;
            R = inR;
            A = inA;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BGRA"/> struct from a byte that fills all components.
        /// </summary>
        /// <param name="all">The input byte component.</param>
        public BGRA(byte all)
            : this(all, all, all, all)
        {
        }

        /// <summary>
        /// Creates a string representation of the current instance.
        /// </summary>
        /// <returns>A string representation of the current instance.</returns>
        public override string ToString()
        {
            return $"bgra({B}, {G}, {R}, {A})";
        }
    }
}