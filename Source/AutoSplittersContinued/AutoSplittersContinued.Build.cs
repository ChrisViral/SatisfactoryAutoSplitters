// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;
using Tools.DotNETCommon;

public class AutoSplittersContinued : ModuleRules
{
    public AutoSplittersContinued(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        bLegacyPublicIncludePaths = false;

        PublicIncludePaths.AddRange(
            new string[] {
                // ... add public include paths required here ...
            }
        );

        PrivateIncludePaths.AddRange(
            new string[] {
                // ... add other private include paths required here ...
            }
        );
            
        
        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core", "CoreUObject",
                "Engine",
                "InputCore",
                "OnlineSubsystem", "OnlineSubsystemNull", "OnlineSubsystemEOS", "OnlineSubsystemUtils",
                "SignificanceManager",
                "APEX", "ApexDestruction",
                "AkAudio",
                "PhysXVehicles",
                "AssetRegistry",
                "NavigationSystem",
                "ReplicationGraph",
                "AIModule",
                "GameplayTasks",
                "SlateCore", "Slate", "UMG",
                "InstancedSplines",
                "Json",
                "SML",
                "FactoryGame",
                // ... add other public dependencies that you statically link with here ...
            }
        );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "RenderCore",
                // ... add private dependencies that you statically link with here ...	
            }
        );
        
        
        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
                // ... add any modules that your module loads dynamically here ...
            }
        );
            
        var factoryGamePchPath = new DirectoryReference(Path.Combine(Target.ProjectFile.Directory.ToString(), "Source", "FactoryGame", "Public", "FactoryGame.h"));
        PrivatePCHHeaderFile = factoryGamePchPath.MakeRelativeTo(new DirectoryReference(ModuleDirectory));
    }
}