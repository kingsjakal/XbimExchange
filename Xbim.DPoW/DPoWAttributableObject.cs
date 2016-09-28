﻿using System.Collections.Generic;

namespace Xbim.DPoW
{
    /// <summary>
    /// Abstract class containing set of attributes. All descendants of this class can have an arbitrary list of attributes
    /// </summary>
    public abstract class DPoWAttributableObject
    {
        /// <summary>
        /// Arbitrary list of attributes
        /// </summary>
        public List<Attribute> Attributes { get; set; }
    }
}
