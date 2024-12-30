// // Copyright Epic Games, Inc. All Rights Reserved.

// using UnrealBuildTool;

// public class ActionRPG : ModuleRules
// {
// 	public ActionRPG(ReadOnlyTargetRules Target)
// 		: base(Target)
// 	{
// 		PrivatePCHHeaderFile = "Public/ActionRPG.h";

// 		PublicDependencyModuleNames.AddRange(
// 			new string[] {
// 				"Core",
// 				"CoreUObject",
// 				"Engine",
// 				"ModularGameplay" // Add this for UE5
// 			}
// 		);

// 		PrivateDependencyModuleNames.AddRange(
// 			new string[] {
// 				"ActionRPGLoadingScreen",
// 				"Slate",
// 				"SlateCore",
// 				"InputCore",
// 				"MoviePlayer",
// 				"GameplayAbilities",
// 				"GameplayTags",
// 				"GameplayTasks",
// 				"AIModule"
// 			}
// 		);

// 		if (Target.Platform == UnrealTargetPlatform.IOS)
// 		{
// 			PrivateDependencyModuleNames.AddRange(new string[] { "OnlineSubsystem", "OnlineSubsystemUtils" });
// 			DynamicallyLoadedModuleNames.Add("OnlineSubsystemFacebook");
// 			DynamicallyLoadedModuleNames.Add("OnlineSubsystemIOS");
// 			DynamicallyLoadedModuleNames.Add("IOSAdvertising");
// 		}
// 		else if (Target.Platform == UnrealTargetPlatform.Android)
// 		{
// 			PrivateDependencyModuleNames.AddRange(new string[] { "OnlineSubsystem", "OnlineSubsystemUtils" });
// 			DynamicallyLoadedModuleNames.Add("AndroidAdvertising");
// 			DynamicallyLoadedModuleNames.Add("OnlineSubsystemGooglePlay");
//             // Add UPL to add configrules.txt to our APK
//             string PluginPath = Utils.MakePathRelativeTo(ModuleDirectory, Target.RelativeEnginePath);
//             AdditionalPropertiesForReceipt.Add("AndroidPlugin", System.IO.Path.Combine(PluginPath, "AddRoundIcon_UPL.xml"));

//         }
//     }
// }

using UnrealBuildTool;
using System.IO;

public class ActionRPG : ModuleRules
{
    public ActionRPG(ReadOnlyTargetRules Target) : base(Target)
    {
        // Plugin-specific build settings
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        // This is the key configuration that allows shorter include paths
        PublicIncludePaths.AddRange(new string[] {
            // Adds the Public folder itself to the include path
            Path.Combine(ModuleDirectory, "Public"),
            
            // If you have additional folders under Public, add them here
            // Path.Combine(ModuleDirectory, "Public/Abilities"),
            // Path.Combine(ModuleDirectory, "Public/Items")
        });
        
        PrivateIncludePaths.AddRange(new string[] {
            // Adds the Private folder to the include path
            Path.Combine(ModuleDirectory, "Private"),
        });

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine",
            "ModularGameplay",
            "GameplayAbilities",
            "GameplayTags",
            "GameplayTasks"
        });

        PrivateDependencyModuleNames.AddRange(new string[] {
            "ActionRPGLoadingScreen",
            "Slate",
            "SlateCore",
            "InputCore",
            "MoviePlayer",
            "AIModule"
        });

        // Remove game module specific references
        if (Target.bBuildEditor == true)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[] {
                    "UnrealEd"
                }
            );
        }
    }
}