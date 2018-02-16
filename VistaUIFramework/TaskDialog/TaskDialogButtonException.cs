﻿//--------------------------------------------------------------------
// <copyright file="TaskDialogButtonException.cs" company="myapkapp">
//     Copyright (c) myapkapp. All rights reserved.
// </copyright>                                                                
//--------------------------------------------------------------------
// This open-source project is licensed under Apache License 2.0
//--------------------------------------------------------------------

using System;

namespace MyAPKapp.VistaUIFramework.TaskDialog {
    public class TaskDialogButtonException : Exception {

        public TaskDialogButtonException() : base("Selected button is not found or belongs to other TaskDialog") {}

    }
}
