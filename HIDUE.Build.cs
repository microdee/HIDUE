// Copyright 2018-2021 David Morasz All Rights Reserved.
// This source code is under MIT License https://github.com/microdee/UE4-SpaceMouse/blob/master/LICENSE

using UnrealBuildTool;

public class HIDUE : ModuleRules
{
    public HIDUE(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.NoPCHs;
#if UE_5_6_OR_LATER
        CppCompileWarningSettings.UndefinedIdentifierWarningLevel = WarningLevel.Off;
#elif UE_5_5_OR_LATER
        UndefinedIdentifierWarningLevel = WarningLevel.Off;
#else
        bEnableUndefinedIdentifierWarnings = false;
#endif

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
