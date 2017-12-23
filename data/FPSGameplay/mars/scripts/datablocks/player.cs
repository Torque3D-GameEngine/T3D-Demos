//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

echo("*** LOAD MARS DATABLOCKS - player.cs***");

datablock PlayerData(GideonData)
{
   renderFirstPerson = 1;
   shapeFile = "data/FPSGameplay/mars/art/shapes/actors/Gideon/gideon.dts";
   cameraMaxDist = 3;
   computeCRC = 0;
   canObserve = 1;
   cmdCategory = "Clients";
   cameraDefaultFov = 45;
   cameraMinFov = 5;
   cameraMaxFov = 45;
   debrisShapeName = "data/FPSGameplay/art/shapes/actors/common/debris_player.dts";
   Debris = PlayerDebris;
   aiAvoidThis = 1;
   
   minLookAngle = -1.4;
   maxLookAngle = 1.4;
   maxFreelookAngle = 3;
   
   mass = 100;
   drag = 1.3;
   maxDrag = 0.4;
   density = 1.1;
   maxDamage = 100;
   maxEnergy = 60;
   repairRate = 0.33;
   energyPerDamagePoint = 75;
   
   rechargeRate = 0.256;
   
   runForce = 4320;
   runEnergyDrain = 0;
   minRunEnergy = 0;
   maxForwardSpeed = 8;
   maxBackwardSpeed = 6;
   maxSideSpeed = 6;
   
   crouchForce = 405;
   maxCrouchForwardSpeed = 4;
   maxCrouchBackwardSpeed = 2;
   maxCrouchSideSpeed = 2;
   
   maxUnderwaterForwardSpeed = 8.4;
   maxUnderwaterBackwardSpeed = 7.8;
   maxUnderwaterSideSpeed = 7.8;
   
   jumpForce = 747;
   jumpEnergyDrain = 0;
   minJumpEnergy = 0;
   jumpDelay = 15;
   airControl = 0.3;
   
   recoverDelay = 9;
   recoverRunForceScale = 1.2;
   
   minImpactSpeed = 45;
   speedDamageScale = 0.4;
   
   boundingBox = "1 1 2";
   swimBoundingBox = "1 2 2";
   pickupRadius = 1;
   
   // Damage location details
   boxNormalHeadPercentage = 0.83;
   boxNormalTorsoPercentage = 0.49;
   boxHeadLeftPercentage = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage = 0;
   boxHeadFrontPercentage = 1;
   
   // Foot Prints
   decalOffset = 0.25;
   footPuffEmitter = LightPuffEmitter;
   footPuffNumParts = 10;
   footPuffRadius = 0.25;
   
   dustEmitter = LiftoffDustEmitter;
   
   Splash = PlayerSplash;
   splashVelocity = 4;
   splashAngle = 67;
   splashFreqMod = 300;
   splashVelEpsilon = 0.6;
   bubbleEmitTime = 0.4;
   splashEmitter[0] = PlayerWakeEmitter;
   splashEmitter[1] = PlayerFoamEmitter;
   splashEmitter[2] = PlayerBubbleEmitter;
   mediumSplashSoundVelocity = 10;
   hardSplashSoundVelocity = 20;
   exitSplashSoundVelocity = 5;
   
   // Controls over slope of runnable/jumpable surfaces
   runSurfaceAngle = 38;
   jumpSurfaceAngle = 80;
   maxStepHeight = 1.5;
   minJumpSpeed = 20;
   maxJumpSpeed = 30;
   
   horizMaxSpeed = 68;
   horizResistSpeed = 33;
   horizResistFactor = 0.35;
   
   upMaxSpeed = 80;
   upResistSpeed = 25;
   upResistFactor = 0.3;
   
   footstepSplashHeight = 0.35;
   
   // Footstep Sounds
   FootSoftSound = FootLightSoftSound;
   FootHardSound = FootLightHardSound;
   FootMetalSound = FootLightMetalSound;
   FootSnowSound = FootLightSnowSound;
   FootShallowSound = FootLightShallowSplashSound;
   FootWadingSound = FootLightWadingSound;
   FootUnderwaterSound = FootLightUnderwaterSound;
   groundImpactMinSpeed = 10;
   groundImpactShakeFreq = "4.0 4.0 4.0";
   groundImpactShakeAmp = "1.0 1.0 1.0";
   groundImpactShakeDuration = 0.8;
   groundImpactShakeFalloff = 10;
   
   observeParameters = "0.5 4.5 4.5";
   
   // Allowable Inventory Items
   mainWeapon = GrenadeLauncher;
   
   maxInv[Rifle] = 0;
   maxInv[BulletAmmo] = 0;
   
   maxInv[RocketLauncher] = 0;
   maxInv[RocketLauncherAmmo] = 0;
   
   maxInv[GrenadeLauncher] = 1;
   maxInv[GrenadeLauncherAmmo] = 20;
   
   maxInvRifle = 0;
   maxInvBulletAmmo = 0;
   
   maxInvGrenadeLauncher = 1;
   maxInvGrenadeLauncherAmmo = 20;
   
   maxInvRocketLauncher = 0;
   maxInvRocketLauncherAmmo = 0;
};