// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class S05_TestingGroundEditorTarget : TargetRules
{
	public S05_TestingGroundEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("S05_TestingGround");
	}
}
