//
//  MDXVertexProperty.cs
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

using System.Collections.Generic;
using JetBrains.Annotations;

namespace Warcraft.MDX.Geometry
{
    /// <summary>
    /// A quartet of bone indices into the <see cref="MDX.KeyBoneLookupTable"/>, which are associated with a vertex.
    /// </summary>
    [PublicAPI]
    public class MDXVertexProperty
    {
        /// <summary>
        /// Gets a list of bone indices.
        /// </summary>
        public List<byte> BoneIndices { get; } = new List<byte>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MDXVertexProperty"/> class.
        /// </summary>
        /// <param name="inBoneA">The first bone.</param>
        /// <param name="inBoneB">The second bone.</param>
        /// <param name="inBoneC">The third bone.</param>
        /// <param name="inBoneD">The fourth bone.</param>
        public MDXVertexProperty(byte inBoneA, byte inBoneB, byte inBoneC, byte inBoneD)
        {
            BoneIndices.Add(inBoneA);
            BoneIndices.Add(inBoneB);
            BoneIndices.Add(inBoneC);
            BoneIndices.Add(inBoneD);
        }
    }
}
