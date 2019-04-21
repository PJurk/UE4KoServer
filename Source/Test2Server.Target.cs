// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class Test2ServerTarget : TargetRules   // Change this line as shown previously
{
       public Test2ServerTarget(TargetInfo Target) : base(Target)  // Change this line as shown previously
       {
        Type = TargetType.Server;
        ExtraModuleNames.Add("Test2");    // Change this line as shown previously
       }
}