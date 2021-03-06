﻿//---------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Microsoft">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
//    
//    The use and distribution terms for this software are covered by the
//    Common Public License 1.0 (http://opensource.org/licenses/cpl1.0.php)
//    which can be found in the file CPL.TXT at the root of this distribution.
//    By using this software in any fashion, you are agreeing to be bound by
//    the terms of this license.
//    
//    You must not remove this notice, or any other, from this software.
// </copyright>
// <summary>
// Part of the Deployment Tools Foundation project.
// </summary>
//---------------------------------------------------------------------

using System;
using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Diagnostics.CodeAnalysis;

[assembly: AssemblyDescription("Managed libraries for cabinet archive packing and unpacking")]
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]

// SECURITY: The UnmanagedCode assertions in the cabinet classes are safe, because the
// assertions are not propogated through calls to the provided callbacks.  So there
// is no way that a partially-trusted malicious client could trick a trusted cabinet
// class into executing its own unmanaged code.
[assembly: SecurityPermission(SecurityAction.RequestMinimum, Assertion=true, UnmanagedCode=true)]

// SECURITY: Review carefully!
// This assembly is designed so that partially trusted callers should be able to
// do cabinet compression and extraction in a file path where they have limited
// file I/O permission. Or they can even do in-memory compression and extraction
// with absolutely no file I/O permission.
[assembly: AllowPartiallyTrustedCallers]

[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Deployment.Compression.Cab")]
