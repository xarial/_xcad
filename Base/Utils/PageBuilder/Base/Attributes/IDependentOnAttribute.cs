﻿//*********************************************************************
//xCAD
//Copyright(C) 2020 Xarial Pty Limited
//Product URL: https://www.xcad.net
//License: https://github.com/xarial/xcad/blob/master/LICENSE
//*********************************************************************

using System;

namespace Xarial.XCad.Utils.PageBuilder.Base.Attributes
{
    public interface IDependentOnAttribute : IAttribute
    {
        Type DependencyHandler { get; }
        object[] Dependencies { get; }
    }
}
