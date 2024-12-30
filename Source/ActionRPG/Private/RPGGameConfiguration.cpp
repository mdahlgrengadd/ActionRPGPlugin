// RPGGameConfiguration.cpp
#include "RPGGameConfiguration.h"
#include "Misc/ConfigCacheIni.h"

void URPGGameConfiguration::SetupDefaultProjectSettings()
{
    // Check if AssetManager class is set
    FString AssetManagerClassName;
    GConfig->GetString(
        TEXT("/Script/Engine.Engine"),
        TEXT("AssetManagerClassName"),
        AssetManagerClassName,
        GEngineIni
    );

    if (AssetManagerClassName.IsEmpty())
    {
        UE_LOG(LogActionRPG, Warning, TEXT("AssetManagerClassName not set in DefaultEngine.ini. Adding configuration."));
        
        // Add the configuration
        GConfig->SetString(
            TEXT("/Script/Engine.Engine"),
            TEXT("AssetManagerClassName"),
            TEXT("/Script/ActionRPG.RPGAssetManager"),
            GEngineIni
        );
        GConfig->Flush(false, GEngineIni);
    }
}

void URPGGameConfiguration::SetupEngineConfiguration()
{
    // Check and set AssetManagerClassName
    FString AssetManagerClassName;
    GConfig->GetString(
        TEXT("/Script/Engine.Engine"),
        TEXT("AssetManagerClassName"),
        AssetManagerClassName,
        GEngineIni
    );

    if (AssetManagerClassName != TEXT("/Script/ActionRPG.RPGAssetManager"))
    {
        UE_LOG(LogActionRPG, Warning, TEXT("Setting AssetManagerClassName in DefaultEngine.ini"));
        
        GConfig->SetString(
            TEXT("/Script/Engine.Engine"),
            TEXT("AssetManagerClassName"),
            TEXT("/Script/ActionRPG.RPGAssetManager"),
            GEngineIni
        );
        GConfig->Flush(false, GEngineIni);
    }
}

void URPGGameConfiguration::VerifyGameInstance()
{
    // Check if game instance class is set
    FString GameInstanceClass;
    GConfig->GetString(
        TEXT("/Script/Engine.Engine"),
        TEXT("GameInstanceClass"),
        GameInstanceClass,
        GEngineIni
    );

    if (!GameInstanceClass.Contains(TEXT("RPGGameInstance")))
    {
        UE_LOG(LogActionRPG, Warning, TEXT("GameInstanceClass not set to RPGGameInstance. Game features may be limited."));
    }
}