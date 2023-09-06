// Copyright 2018-2021 David Morasz All Rights Reserved.
// This source code is under MIT License https://github.com/microdee/UE4-SpaceMouse/blob/master/LICENSE

using UnrealBuildTool;

public class HIDUE : ModuleRules
{
    public HIDUE(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.NoPCHs;
        bEnableUndefinedIdentifierWarnings = false;
        CppStandard = CppStandardVersion.Cpp17;

        IsRedistributableOverride = true;;
        bLegalToDistributeObjectCode = true;
        bPrecompile = true;
        PrecompileForTargets = PrecompileTargetsType.Any;

        if (Target.Platform == UnrealTargetPlatform.Linux) {
            PublicIncludePaths.AddRange(new [] {
                "/usr/include",
                "/usr/include/x86_64-linux-gnu"
            });
            PublicSystemLibraries.Add("udev");
            PublicSystemLibraryPaths.AddRange(new [] {
                "/usr/lib",
                "/usr/lib/x86_64-linux-gnu",
                "/usr/lib/aarch64-linux-gnu",
                "/usr/local/lib",
                "/usr/local/lib/x86_64-linux-gnu",
                "/usr/local/lib/aarch64-linux-gnu"
            });
        }
            
        
        PublicDependencyModuleNames.AddRange(new []
        {
            "Core",
            "CoreUObject"
        });
            
        
        PrivateDependencyModuleNames.AddRange(new []
        {
            "Engine"
        });
    }
}
