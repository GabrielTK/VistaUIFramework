﻿//--------------------------------------------------------------------
// <copyright file="UnsupportedWindowsException.cs" company="MyAPKapp">
//     Copyright (c) MyAPKapp. All rights reserved.
// </copyright>                                                                
//--------------------------------------------------------------------
// This open-source project is licensed under Apache License 2.0
//--------------------------------------------------------------------

using System;

namespace MyAPKapp.VistaUIFramework {
    public class UnsupportedWindowsException : Exception {

        public UnsupportedWindowsException() : base() {}
        public UnsupportedWindowsException(string os) : base("It requires" + os + " or later") {}

    }
}
