﻿using PnP.Framework.Modernization.Entities;
using System.Collections.Generic;

namespace PnP.Framework.Modernization.Transform
{
    /// <summary>
    /// Interface implemented by all content transformators
    /// </summary>
    public interface IContentTransformator
    {

        /// <summary>
        /// Transforms the passed web parts into the loaded client side page
        /// </summary>
        /// <param name="webParts">List of web parts that need to be transformed</param>
        void Transform(List<WebPartEntity> webParts);
    }
}
