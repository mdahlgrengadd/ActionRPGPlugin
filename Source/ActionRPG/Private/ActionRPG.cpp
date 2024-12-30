//// Copyright Epic Games, Inc. All Rights Reserved.
//
//#include "ActionRPG.h"
//
//IMPLEMENT_PRIMARY_GAME_MODULE( FDefaultGameModuleImpl, ActionRPG, "ActionRPG" );
//
///** Logging definitions */
//DEFINE_LOG_CATEGORY(LogActionRPG);

// Copyright Epic Games, Inc. All Rights Reserved.

#include "ActionRPG.h"
#include "Modules/ModuleManager.h"

class FActionRPGModule : public IModuleInterface
{
    virtual void StartupModule() override {}
    virtual void ShutdownModule() override {}
};

IMPLEMENT_MODULE(FActionRPGModule, ActionRPG);

/** Logging definitions */
DEFINE_LOG_CATEGORY(LogActionRPG);
