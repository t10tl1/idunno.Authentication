﻿// Copyright (c) Barry Dorrans. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1812:Avoid uninstantiated internal classes", Justification = "Instantiated via BasicAuthenticationExtensions.", Scope = "type", Target = "~T:idunno.Authentication.Basic.BasicAuthenticationHandler")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2007:Do not directly await a Task", Justification = "Not applicable to .NET Core", Scope = "type", Target = "~T:idunno.Authentication.Basic.BasicAuthenticationHandler")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Catching all exceptions on purpose", Scope = "member", Target = "~M:idunno.Authentication.Basic.BasicAuthenticationHandler.HandleAuthenticateAsync~System.Threading.Tasks.Task{Microsoft.AspNetCore.Authentication.AuthenticateResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "Error messages are not localized", Scope = "member", Target = "~M:idunno.Authentication.Basic.BasicAuthenticationHandler.HandleAuthenticateAsync~System.Threading.Tasks.Task{Microsoft.AspNetCore.Authentication.AuthenticateResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "Error messages are not localized", Scope = "member", Target = "~P:idunno.Authentication.Basic.BasicAuthenticationOptions.Realm")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "Error messages are not localized", Scope = "member", Target = "~M:idunno.Authentication.Basic.BasicAuthenticationHandler.HandleChallengeAsync(Microsoft.AspNetCore.Authentication.AuthenticationProperties)~System.Threading.Tasks.Task")]
