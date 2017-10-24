// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class boost_and_shoot_manTarget : TargetRules
{
	public boost_and_shoot_manTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("boost_and_shoot_man");
	}
}
