// Copyright (C) Mihail Krasovsky 2022.

using UnrealBuildTool;
using System.Collections.Generic;

public class LestaTaskEditorTarget : TargetRules
{
	public LestaTaskEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "LestaTask" } );
	}
}
