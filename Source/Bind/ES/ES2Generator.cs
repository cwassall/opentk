﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
using Bind.GL2;
using Bind.Structures;
using Delegate=Bind.Structures.Delegate;
using Enum=Bind.Structures.Enum;

namespace Bind.ES
{
    // Generation implementation for OpenGL ES 2.0 and 3.0
    class ES2Generator : ESGenerator
    {
        public ES2Generator(Settings settings, string dirName)
            : base(settings, dirName)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../ES20");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES20";
            Settings.DefaultImportsFile = "ES20Core.cs";
            Settings.DefaultDelegatesFile = "ES20Delegates.cs";
            Settings.DefaultEnumsFile = "ES20Enums.cs";
            Settings.DefaultWrappersFile = "ES20.cs";

            Profile = "gles2";
            Version = "2.0";
        }
    }
}
