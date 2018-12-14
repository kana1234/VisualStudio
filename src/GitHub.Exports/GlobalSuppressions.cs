// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Scope = "type", Target = "GitHub.Services.Notification")]
[assembly: SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Scope = "type", Target = "GitHub.Services.ITeamExplorerServices")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "GitHub.Extensions.IServiceProviderExtensions.#AddCommandHandler(System.IServiceProvider,System.Guid,System.Int32,System.Func`1<System.Boolean>,System.Action,System.Boolean)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Scope = "type", Target = "GitHub.Helpers.ThreadingHelper+BackgroundThreadAwaiter")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "GitHub.Services.IGitHubServiceProvider.#GetService`2()")]
[assembly: SuppressMessage("Reliability", "CA2007:Do not directly await a Task", Justification = "Discouraged for VSSDK projects.")]
[assembly: SuppressMessage("Design", "CA1054:Uri parameters should not be strings")]
[assembly: SuppressMessage("Design", "CA1056:Uri properties should not be strings")]
