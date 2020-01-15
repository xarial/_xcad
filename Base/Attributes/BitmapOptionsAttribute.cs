﻿//*********************************************************************
//xCAD
//Copyright(C) 2020 Xarial Pty Limited
//Product URL: https://www.xcad.net
//License: https://github.com/xarial/xcad/blob/master/LICENSE
//*********************************************************************

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Xarial.XCad.Utils.PageBuilder.Base;

namespace Xarial.XCad.Attributes
{
    /// <summary>
    /// Additional options for bitmap control
    /// </summary>
    /// <remarks>Applied to property of type <see cref="Image"/></remarks>
    public class BitmapOptionsAttribute : Attribute, IAttribute
    {
        public Size Size { get; private set; }

        /// <summary>
        /// Constructor for bitmap options
        /// </summary>
        /// <param name="width">Width of the bitmap</param>
        /// <param name="height">Height of the bitmap</param>
        public BitmapOptionsAttribute(int width, int height)
        {
            Size = new Size(width, height);
        }
    }
}