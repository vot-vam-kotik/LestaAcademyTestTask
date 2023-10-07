// Copyright (C) Mihail Krasovsky 2022.

using UnrealBuildTool;
using System.Collections.Generic;

public class LestaTaskTarget : TargetRules
{
	public LestaTaskTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "LestaTask" } );
	}
}
