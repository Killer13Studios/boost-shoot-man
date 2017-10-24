// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class boost_and_shoot_manEditorTarget : TargetRules
{
	public boost_and_shoot_manEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("boost_and_shoot_man");
	}
}
