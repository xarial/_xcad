﻿//*********************************************************************
//xCAD
//Copyright(C) 2020 Xarial Pty Limited
//Product URL: https://www.xcad.net
//License: https://github.com/xarial/xcad/blob/master/LICENSE
//*********************************************************************

using System.ComponentModel;
using System;
using Xarial.XCad.Enums;
using System.Drawing;

namespace Xarial.XCad.Structures
{
    public class CommandSpec
    {
        public string Title { get; set; }
        public string Tooltip { get; set; }
        public Image Icon { get; set; }
        public WorkspaceTypes_e SupportedWorkspace { get; set; }
        public bool HasMenu { get; set; }
        public bool HasToolbar { get; set; }
        public bool HasTabBox { get; set; }
        public int UserId { get; set; }
        public RibbonTabTextDisplay_e TabBoxStyle { get; set; }
        public bool HasSpacer { get; set; }
    }
}
