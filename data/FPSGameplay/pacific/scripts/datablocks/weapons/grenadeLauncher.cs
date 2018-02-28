
datablock SFXProfile(GrenadeFireSound)
{
   fileName = "data/FPSGameplay/pacific/sound/grenade_launch";
   description = Audio2D;
   preload = 1;
};
singleton SFXDescription(GrenadeTimerSoundDesc : AudioEffect)
{
   isLooping = 1;
   is3D = 1;
   referenceDistance = 1;
   maxDistance = 20;
};
datablock SFXProfile(GrenadeTimerSound)
{
   fileName = "data/FPSGameplay/pacific/sound/grenade_timer";
   description = GrenadeTimerSoundDesc;
   preload = 1;
};
singleton SFXDescription(GrenadeExplosionSFXDesc : AudioEffect)
{
   is3D = 1;
   referenceDistance = 8;
   maxDistance = 20;
};
datablock SFXProfile(GrenadeExplosionSound)
{
   fileName = "data/FPSGameplay/sound/weapons/Crossbow_explosion.ogg";
   description = GrenadeExplosionSFXDesc;
   preload = 1;
};


// -------------------------------------
datablock ParticleData(GrenadeExpDust)
{
   dragCoefficient = 1;
   gravityCoefficient = -0.01;
   inheritedVelFactor = 0;
   constantAcceleration = 0;
   lifetimeMS = 2000;
   lifetimeVarianceMS = 500;
   useInvAlpha = 1;
   spinRandomMin = -90;
   spinRandomMax = 90;
   textureName = "data/FPSGameplay/pacific/art/particles/smoke2";
   colors[0] = "0.6 0.6 0.6 0.3";
   colors[1] = "0.6 0.6 0.6 0.3";
   colors[2] = "0.6 0.6 0.6 0.0";
   sizes[0] = 1.6;
   sizes[1] = 2.3;
   sizes[2] = 2.5;
   times[0] = 0;
   times[1] = 0.7;
   times[2] = 1;
};
datablock ParticleEmitterData(GrenadeExpDustEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;
   ejectionVelocity = 15;
   velocityVariance = 0;
   ejectionOffset = 0;
   thetaMin = 85;
   thetaMax = 85;
   phiReferenceVel = 0;
   phiVariance = 360;
   overrideAdvances = 0;
   lifetimeMS = 150;
   particles = "GrenadeExpDust";
};
// -------------------------------------

datablock ParticleData(GrenadeExpSparks)
{
   dragCoefficient = 1;
   gravityCoefficient = 0;
   inheritedVelFactor = 0.2;
   constantAcceleration = 0;
   lifetimeMS = 500;
   lifetimeVarianceMS = 250;
   textureName = "data/FPSGameplay/art/particles/ricochet";
   colors[0] = "0.6 0.4 0.3 1";
   colors[1] = "0.6 0.4 0.3 1";
   colors[2] = "1.0 0.4 0.3 0";
   sizes[0] = 0.5;
   sizes[1] = 0.75;
   sizes[2] = 1;
   times[0] = 0;
   times[1] = 0.5;
   times[2] = 1;
};
datablock ParticleEmitterData(GrenadeExpSparksEmitter)
{
   ejectionPeriodMS = 2;
   periodVarianceMS = 0;
   ejectionVelocity = 20;
   velocityVariance = 10;
   ejectionOffset = 0;
   thetaMin = 0;
   thetaMax = 120;
   phiReferenceVel = 0;
   phiVariance = 360;
   overrideAdvances = 0;
   orientParticles = 1;
   lifetimeMS = 100;
   particles = "GrenadeExpSparks";
};
// -------------------------------------

datablock ParticleData(GrenadeExpSmoke)
{
   textureName = "data/FPSGameplay/pacific/art/particles/smoke2";
   dragCoeffiecient = 0;
   gravityCoefficient = -0.4;
   inheritedVelFactor = 0;
   constantAcceleration = 0;
   lifetimeMS = 1000;
   lifetimeVarianceMS = 600;
   useInvAlpha = 1;
   spinRandomMin = -80;
   spinRandomMax = 80;
   colors[0] = "0.9 0.8 0.7 0";
   colors[1] = "0.2 0.2 0.2 0.8";
   colors[2] = "0.4 0.4 0.4 0";
   sizes[0] = 6;
   sizes[1] = 10;
   sizes[2] = 15;
   times[0] = 0;
   times[1] = 0.5;
   times[2] = 1;
};
datablock ParticleEmitterData(GrenadeExpSmokeEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;
   ejectionVelocity = 4.8;
   velocityVariance = 2;
   thetaMin = 0;
   thetaMax = 180;
   ejectionOffset = 2;
   particles = "GrenadeExpSmoke";
};

// -------------------------------------

datablock ExplosionData(GrenadeSubExplosion)
{
   offset = 0.25;
   emitter[0] = GrenadeExpSparksEmitter;
};

datablock ExplosionData(GrenadeLauncherExplosion)
{
   ParticleEmitter = GrenadeExpFireEmitter;
   particleDensity = 75;
   particleRadius = 2.5;
   emitter[0] = GrenadeExpDustEmitter;
   emitter[1] = GrenadeExpSparksEmitter;
   emitter[2] = GrenadeExpSmokeEmitter;
   subExplosion[0] = GrenadeSubExplosion;
   shakeCamera = 1;
   camShakeFreq = "10.0 11.0 9.0";
   camShakeAmp = "15.0 15.0 15.0";
   camShakeDuration = 1.5;
   camShakeRadius = 20;
   debrisThetaMin = 10;
   debrisThetaMax = 60;
   debrisNum = 4;
   debrisNumVariance = 2;
   debrisVelocity = 25;
   debrisVelocityVariance = 5;
   lightStartRadius = 18;
   lightEndRadius = 5;
   lightStartColor = "0.7 0.5 0.3 1";
   lightEndColor = "0 0 0 0";
};

datablock ItemData(GrenadeLauncherAmmo)
{
   category = "Ammo";
   className = "Ammo";
   shapeFile = "data/FPSGameplay/art/shapes/weapons/shared/rocket.dts";
   mass = 1;
   elasticity = 0.2;
   friction = 0.6;
   pickUpName = "Grenade Ammo";
   maxInventory = 10000;
};

datablock LightDescription(GrenadeLauncherProjectileLightDesc)
{
   color = "1.0 0.0 0";
   range = 7;
};

datablock ProjectileData(GrenadeLauncherProjectile)
{
   projectileShapeName = "data/FPSGameplay/art/shapes/weapons/shared/rocket.dts";
   directDamage = 0;
   radiusDamage = 2;
   damageRadius = 3;
   areaImpulse = 1;
   impactForce = 5;
   Explosion = GroundMinorExplosion;
   waterExplosion = WaterMinorExplosion;
   ParticleEmitter = "";
   muzzleVelocity = 10;
   velInheritFactor = 0.5;
   armingDelay = 2976;
   lifetime = 5984;
   fadeDelay = 1472;
   bounceElasticity = 0.4;
   bounceFriction = 0;
   isBallistic = 1;
   gravityMod = 1;
   sound = GrenadeTimerSound;
   lightDesc = GrenadeLauncherProjectileLightDesc;
   scale = "2 2 2";
};

datablock ShapeBaseImageData(GrenadeLauncherImage)
{
   shapeFile = "data/FPSGameplay/pacific/art/shapes/weapons/emptymodel.dae";
   emap = 1;
   mountPoint = 0;
   firstPerson = 0;
   offset = "0 0.25 0";
   eyeOffset = "0.45 0.55 -0.5";
   correctMuzzleVector = 0;
   className = "WeaponImage";
   Ammo = GrenadeLauncherAmmo;
   Projectile = GrenadeLauncherProjectile;
   projectileType = Projectile;
   shellExitDir = "1.0 0.3 1.0";
   shellExitOffset = "0.15 -0.56 -0.1";
   shellExitVariance = 15;
   shellVelocity = 3;
   stateName[0] = "Preactivate";
   stateTransitionOnLoaded[0] = "Activate";
   stateTransitionOnNoAmmo[0] = "NoAmmo";
   stateName[1] = "Activate";
   stateTransitionOnTimeout[1] = "Ready";
   stateTimeoutValue[1] = 0.5;
   stateSequence[1] = "Activate";
   stateName[2] = "Ready";
   stateTransitionOnNoAmmo[2] = "NoAmmo";
   stateTransitionOnTriggerDown[2] = "Fire";
   stateName[3] = "Fire";
   stateTransitionOnTimeout[3] = "Reload";
   stateTimeoutValue[3] = 0.425;
   stateFire[3] = 1;
   stateRecoil[3] = "HeavyRecoil";
   stateAllowImageChange[3] = 0;
   stateSequence[3] = "Fire";
   stateScript[3] = "onFire";
   stateSound[3] = GrenadeFireSound;
   stateName[4] = "Reload";
   stateTransitionOnNoAmmo[4] = "NoAmmo";
   stateTransitionOnTimeout[4] = "Ready";
   stateTimeoutValue[4] = 0.425;
   stateAllowImageChange[4] = 0;
   stateSequence[4] = "Reload";
   stateEjectShell[4] = 1;
   stateName[5] = "NoAmmo";
   stateTransitionOnAmmo[5] = "Reload";
   stateSequence[5] = "NoAmmo";
   stateTransitionOnTriggerDown[5] = "DryFire";
   stateName[6] = "DryFire";
   stateTimeoutValue[6] = 1;
   stateTransitionOnTimeout[6] = "NoAmmo";
   stateScript[6] = "onDryFire";
};

