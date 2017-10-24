// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

#include "boost_and_shoot_manGameMode.h"
#include "boost_and_shoot_manCharacter.h"
#include "UObject/ConstructorHelpers.h"

Aboost_and_shoot_manGameMode::Aboost_and_shoot_manGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/SideScrollerCPP/Blueprints/SideScrollerCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
