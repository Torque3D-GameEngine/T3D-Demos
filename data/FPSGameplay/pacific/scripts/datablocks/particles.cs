
echo("*** LOAD PACICIF DATABLOCK - particles.cs ***");

datablock ParticleData(ParticleMist)
{
   textureName = "data/FPSGameplay/pacific/art/particles/mist.png";
   dragCoeffiecient = 0;
   gravityCoefficient = "-0.0854701";
   inheritedVelFactor = 0;
   constantAcceleration = -1;
   lifetimeMS = 2500;
   lifetimeVarianceMS = 0;
   useInvAlpha = 0;
   spinRandomMin = -125;
   spinRandomMax = 125;
   spinSpeed = 0.520833;

   colors[0] = "0.992126 0.992126 0.992126 0.436";
   colors[1] = "0.992126 0.992126 0.992126 0.465";
   colors[2] = "0.992126 0.992126 0.992126 0.668";
   colors[3] = "0.992126 0.992126 0.992126 0.23622";
   
   sizes[0] = 2;
   sizes[1] = 8;
   sizes[2] = 9;
   sizes[3] = "10.5";
   
   times[0] = 0.0;
   times[1] = "0.4";
   times[2] = "0.5";
   times[3] = "0.6";
   
   animTexName = "data/FPSGameplay/pacific/art/particles/mist.png";
   
   dragCoefficient = "0.889541";
};

datablock ParticleData(ParticleMainFalls01)
{
   textureName = "data/FPSGameplay/pacific/art/particles/main falls 01.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/main falls 01.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleMainFalls02)
{
   textureName = "data/FPSGameplay/pacific/art/particles/main falls 02.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/main falls 02.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleMainFalls03)
{
   textureName = "data/FPSGameplay/pacific/art/particles/main falls 03.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/main falls 03.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleRockImpactInner01)
{
   textureName = "data/FPSGameplay/pacific/art/particles/rock_impact_1_inner.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/rock_impact_1_inner.png";
   gravityCoefficient = "0.541667";
   inheritedVelFactor = "0.875";
   spinSpeed = "0.229167";
   spinRandomMin = "-416";
   spinRandomMax = "541.9";
   colors[2] = "1 1 1 0.124481";
   colors[3] = "1 1 1 0.136929";
   sizes[1] = "3";
   sizes[2] = "3";
   sizes[3] = "3";
   times[1] = "0.25";
   times[2] = "0.6875";
};

datablock ParticleData(ParticleRockImpactTop)
{
   textureName = "data/FPSGameplay/pacific/art/particles/top and top spray.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/top and top spray.png";
   gravityCoefficient = "0.124542";
   colors[1] = "0.996078 0.996078 0.996078 0.813";
   colors[2] = "1 1 1 0.581";
   colors[3] = "1 1 1 0.015748";
   sizes[1] = "1.99597";
   sizes[2] = "1.99597";
   sizes[3] = "1.99597";
   times[1] = "0.329412";
   times[2] = "0.658824";
   spinRandomMin = "-43";
   spinRandomMax = "42";
   colors[0] = "1 1 1 0";
   sizes[0] = "1.99597";
   times[3] = "0.992157";
};

datablock ParticleData(ParticleWaterDisturbance)
{
   textureName = "data/FPSGameplay/pacific/art/particles/ripple.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/ripple.png";
   lifetimeMS = "2626";
   lifetimeVarianceMS = "49";
   spinRandomMin = "0";
   spinRandomMax = "5";
   colors[0] = "1 1 1 0.173228";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0.409449";
   colors[3] = "1 1 1 0.0393701";
   sizes[1] = "10.6543";
   sizes[2] = "15.9952";
   sizes[3] = "18.6565";
   times[1] = "0.247059";
   times[2] = "0.513726";
   times[3] = "1";
   spinSpeed = "0";
   sizes[0] = "5.32564";
};

datablock ParticleData(ParticleSplinter)
{
   textureName = "data/FPSGameplay/pacific/art/particles/splinters.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/splinters.png";
   lifetimeMS = "1501";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-750";
   spinRandomMax = "666";
   colors[0] = "0.992126 0.992126 0.992126 1";
   colors[1] = "0.992126 0.992126 0.992126 1";
   colors[2] = "0.992126 0.992126 0.992126 1";
   colors[3] = "0.992126 0.992126 0.992126 1";
   sizes[1] = "0.25";
   sizes[2] = "0.25";
   sizes[3] = "0";
   times[1] = "0.247059";
   times[2] = "0.513726";
   times[3] = "0.686275";
   spinSpeed = "1";
   sizes[0] = "0.5";
   gravityCoefficient = "0.542";
   inheritedVelFactor = "0.833";
   constantAcceleration = "0.417";
};

datablock ParticleData(ParticleSplinter2)
{
   gravityCoefficient = "0.5";
   inheritedVelFactor = "0.6";
   constantAcceleration = "0.4";
   lifetimeMS = "1400";
   spinRandomMin = "-800";
   spinRandomMax = "700";
   textureName = "data/FPSGameplay/pacific/art/particles/splinters_02.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/splinters_02.png";
   sizes[0] = "0.4";
   sizes[1] = "0.2";
   sizes[2] = "0.2";
   sizes[3] = "0";
   times[3] = "0.6";
};

datablock ParticleData(ParticleSplinter3)
{
   gravityCoefficient = "0.7";
   inheritedVelFactor = "0.7";
   constantAcceleration = "0.5";
   lifetimeMS = "1800";
   lifetimeVarianceMS = "100";
   spinRandomMin = "-800";
   spinRandomMax = "900";
   textureName = "data/FPSGameplay/pacific/art/particles/splinters_03.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/splinters_03.png";
   sizes[0] = "0.3";
   sizes[1] = "0.2";
   sizes[2] = "0.2";
   sizes[3] = "0";
   times[1] = "0.2";
   times[2] = "0.4";
   times[3] = "0.5";
};

datablock ParticleData(shrinefireparticle)
{
   textureName          = "data/FPSGameplay/pacific/art/particles/explosion";
   dragCoeffiecient     = 0;
   gravityCoefficient   = -0.5;
   inheritedVelFactor   = "0.8";
   constantAcceleration = "-3";
   lifetimeMS           = "950";
   lifetimeVarianceMS   = 400;
   useInvAlpha =  false;
   spinRandomMin = -280.0;
   spinRandomMax =  280.0;

   colors[0]     = "0.992126 0.937008 0.566929 0.0944882";
   colors[1]     = "1 0.496063 0 0.299213";
   colors[2]     = "0.0944882 0.0944882 0.0944882 0";
   colors[3]     = "0.992157 0.992157 0.992157 0";

   sizes[0]      = "0.6";
   sizes[1]      = "1.3";
   sizes[2]      = 0.4;

   times[0]      = 0.0;
   times[1]      = "0.33";
   times[2]      = "1";
   dragCoefficient = 0.25;
   spinSpeed = "0.5";
   animTexName = "data/FPSGameplay/pacific/art/particles/explosion";
   sizes[3] = "0";
   times[3] = "1";
};

datablock ParticleData(FireTestParticle0)
{
   textureName          = "data/FPSGameplay/pacific/art/particles/explosion";
   dragCoeffiecient     = 0;
   gravityCoefficient   = -3.99267;
   inheritedVelFactor   = 0.0;
   constantAcceleration = -8;
   lifetimeMS           = 563;
   lifetimeVarianceMS   = 562;
   useInvAlpha =  false;
   spinRandomMin = -280.0;
   spinRandomMax =  280.0;

   colors[0]     = "1 0.897638 0.795276 0.0944882";
   colors[1]     = "1 0.496063 0 0.299213";
   colors[2]     = "0.0944882 0.0944882 0.0944882 0";

   sizes[0]      = 2.99701;
   sizes[1]      = 3.49753;
   sizes[2]      = 1.03766;

   times[0]      = 0.0;
   times[1]      = 0.121569;
   times[2]      = 1.0;
   dragCoefficient = 1.9697;
   spinSpeed = "0.5";
   animTexName = "data/FPSGameplay/pacific/art/particles/explosion";
   sizes[3] = "0";
   times[3] = "1";
};

datablock ParticleData(ParticleSteamData)
{
   textureName = "data/FPSGameplay/pacific/art/particles/smoke2.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/smoke2.png";
   lifetimeMS = "5000";
   lifetimeVarianceMS = "250";
   spinRandomMin = "-25";
   spinRandomMax = "25";
   colors[0] = "0.992126 0.992126 0.992126 0";
   colors[1] = "0.992126 0.992126 0.992126 0.207";
   colors[2] = "0.992126 0.992126 0.992126 0";
   colors[3] = "0.992126 0.992126 0.992126 1";
   sizes[1] = "33.3303";
   sizes[2] = "31.2489";
   sizes[3] = "0";
   times[1] = "0.498039";
   times[2] = "1";
   times[3] = "1";
   spinSpeed = "0.05";
   sizes[0] = "27.083";
   gravityCoefficient = "0";
   inheritedVelFactor = "0";
   constantAcceleration = "0";
};

datablock ParticleData(lavaParticle)
{
   textureName = "data/FPSGameplay/pacific/art/particles/fxpack1/waterspray.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/fxpack1/waterspray.png";
   dragCoefficient = "0.591398";
   gravityCoefficient = "0.290598";
   lifetimeMS = "3750";
   lifetimeVarianceMS = "3000";
   colors[0] = "1 0.519685 0 1";
   colors[1] = "1 0.0472441 0 1";
   colors[2] = "1 0.0705882 0 0.797";
   sizes[0] = "1.04071";
   sizes[1] = "3.99805";
   sizes[3] = "0";
   colors[3] = "1 0.207843 0 0.299";
   spinRandomMin = "0";
   spinRandomMax = "2";
   times[3] = "2";
   inheritedVelFactor = "1";
   constantAcceleration = "0.1";
   times[0] = "0";
   times[2] = "1";
};

datablock ParticleData(lavaParticleTop)
{
   textureName = "data/FPSGameplay/pacific/art/particles/fxpack1/waterspray.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/fxpack1/waterspray.png";
   dragCoefficient = "0.591398";
   gravityCoefficient = "0.290598";
   lifetimeMS = "1126";
   lifetimeVarianceMS = "1125";
   colors[0] = "1 0.580392 0 1";
   colors[1] = "1 0.603922 0 1";
   colors[2] = "1 0.509804 0 1";
   sizes[0] = "0";
   sizes[1] = "1.5";
   sizes[3] = "6";
   colors[3] = "1 0.207843 0 1";
   spinRandomMin = "0";
   spinRandomMax = "2";
   times[3] = "1";
   inheritedVelFactor = "1";
   constantAcceleration = "0.1";
   times[0] = "0";
   times[2] = "1";
   sizes[2] = "4";
   times[1] = "0.291667";
};

datablock ParticleData(LavaSteamData)
{
   textureName = "data/FPSGameplay/pacific/art/particles/smoke2.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/smoke2.png";
   lifetimeMS = "5500";
   lifetimeVarianceMS = "350";
   spinRandomMin = "-28";
   spinRandomMax = "24";
   colors[0] = "0.996078 0.780392 0.458824 0.023622";
   colors[1] = "0.996078 0.698039 0.439216 0.11811";
   colors[2] = "0.996078 0.698039 0.439216 0.0472441";
   colors[3] = "0.988235 0.788235 0.0117647 1";
   sizes[1] = "29.9976";
   sizes[2] = "15.9983";
   sizes[3] = "0";
   times[1] = "0.6";
   times[2] = "1";
   times[3] = "1";
   spinSpeed = "0.1";
   sizes[0] = "19.9994";
   gravityCoefficient = "-0.0708181";
   inheritedVelFactor = "0";
   constantAcceleration = "0";
   dragCoefficient = "0";
};

datablock ParticleData(LavaMagmaParticle)
{
   textureName = "data/FPSGameplay/pacific/art/particles/spark02.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/spark02.png";
   dragCoefficient = "0.997067";
   gravityCoefficient = "2";
   lifetimeMS = "3500";
   lifetimeVarianceMS = "1000";
   colors[0] = "1 0.88189 0 1";
   colors[1] = "1 0.834646 0 1";
   colors[2] = "1 0.0551181 0 0.866142";
   sizes[0] = "0.497467";
   sizes[1] = "1.99902";
   sizes[3] = "5.99707";
   colors[3] = "1 0.0551181 0 0.700787";
   spinRandomMin = "0";
   spinRandomMax = "4";
   times[3] = "0.898039";
   inheritedVelFactor = "0.996086";
   constantAcceleration = "0";
   times[0] = "0";
   sizes[2] = "2.99701";
   times[1] = "0.4";
   times[2] = "0.898039";
};

datablock ParticleData(LavaDisturbanceParticle)
{
   textureName = "data/FPSGameplay/pacific/art/particles/ripple.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/ripple.png";
   lifetimeMS = "8000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "0";
   spinRandomMax = "0";
   colors[0] = "1 0.614173 0 1";
   colors[1] = "1 0.322835 0 1";
   colors[2] = "0.992126 0.0551181 0 1";
   colors[3] = "1 0.0472441 0 1";
   sizes[1] = "3.99805";
   sizes[2] = "5.99402";
   sizes[3] = "5.99402";
   times[1] = "0.141176";
   times[2] = "0.286275";
   times[3] = "0.329412";
   spinSpeed = "0";
   sizes[0] = "3.99805";
   constantAcceleration = "0";
};

datablock ParticleData(WaterVortexParticle)
{
   textureName = "data/FPSGameplay/pacific/art/particles/rock impact top and side spray.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/rock impact top and side spray.png";
   lifetimeMS = "8000";
   lifetimeVarianceMS = "4800";
   spinRandomMin = "-100";
   spinRandomMax = "120";
   colors[0] = "0.643137 0.643137 0.643137 0.141";
   colors[1] = "0.913726 0.909804 0.909804 0.763";
   colors[2] = "0.917647 0.913726 0.913726 0.726";
   colors[3] = "0.933333 0.929412 0.929412 0.11811";
   sizes[1] = "8";
   sizes[2] = "4";
   sizes[3] = "2";
   times[1] = "0.25";
   times[2] = "0.5";
   times[3] = "0.8";
   spinSpeed = "0.4";
   sizes[0] = "11";
   constantAcceleration = "-2.5";
   inheritedVelFactor = "1";
};

datablock ParticleEmitterData(EmitterMist)
{
   particles = "ParticleMist";
   blendStyle = "NORMAL";
   ejectionVelocity = "5.11";
   velocityVariance = "0";
   thetaMax = "165";
   softParticles = "1";
   ambientFactor = "0.416667";
   ejectionPeriodMS = "167";
};

datablock ParticleEmitterData(EmitterMainFalls)
{
   particles = "ParticleMainFalls01";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterMainFalls02)
{
   particles = "ParticleMainFalls02";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterMainFalls03)
{
   particles = "ParticleMainFalls03";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "25";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterTopSpray)
{
   particles = "ParticleRockImpactTop";
   blendStyle = "NORMAL";
   ejectionVelocity = "1";
   velocityVariance = "0";
   ejectionPeriodMS = "272";
   ambientFactor = "0";
   periodVarianceMS = "0";
   thetaMin = "0";
   thetaMax = "90";
   phiVariance = "360";
   alignParticles = "0";
   softParticles = "0";
};

datablock ParticleEmitterData(EmitterWaterDisturbance)
{
   particles = "ParticleWaterDisturbance";
   blendStyle = "NORMAL";
   thetaMin = "7";
   thetaMax = "180";
   orientParticles = "0";
   ejectionPeriodMS = "646";
   periodVarianceMS = "24";
   ejectionVelocity = "0";
   velocityVariance = "0";
   phiVariance = "1";
   alignParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0";
   softParticles = "0";
   alignDirection = "0 0 1";
};

datablock ParticleEmitterData(EmitterRockImpact)
{
   particles = "ParticleRockImpactInner01";
   blendStyle = "NORMAL";
   ejectionPeriodMS = "167";
   velocityVariance = "0";
   softParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterTop)
{
   particles = "DefaultParticle";
   blendStyle = "NORMAL";
   ejectionPeriodMS = "417";
   ejectionVelocity = "69.05";
   velocityVariance = "59.81";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterSplinter)
{
   ejectionPeriodMS = 1;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 1.0;
   thetaMin         = 0.0;
   thetaMax         = 180.0;
   lifetimeMS       = 166;
   particles = "ParticleSplinter ParticleSplinter2 ParticleSplinter3";
   blendStyle = "NORMAL";
   ejectionOffset = "2.5";
   softnessDistance = "0";
   softParticles = "0";
   lifetimeVarianceMS = "20";
   ambientFactor = "0.416667";
};

datablock ParticleEmitterData(shrine_fire_emitter)
{
   ejectionPeriodMS = 25;
   ejectionVelocity = 0.5;
   velocityVariance = "0";
   ejectionOffset = 0;
   thetaMax = "100";
   particles = "shrinefireparticle";
   blendStyle = "ADDITIVE";
   softParticles = "1";
   softnessDistance = 1;
   periodVarianceMS = "23";
   thetaMin = "0";
};

datablock ParticleEmitterData(FireTestEmitter0)
{
   ejectionPeriodMS = 22;
   ejectionVelocity = 8;
   velocityVariance = 4;
   ejectionOffset = 0;
   thetaMax = "40";
   particles = "FireTestParticle0";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   softnessDistance = 1;
   periodVarianceMS = "10";
};

datablock ParticleEmitterData(ParticleSteamEmitter)
{
   ejectionPeriodMS = 625;
   periodVarianceMS = 10;
   ejectionVelocity = 0;
   velocityVariance = 0;
   thetaMin         = 0.0;
   thetaMax         = 39;
   lifetimeMS       = 0;
   particles = "ParticleSteamData";
   blendStyle = "NORMAL";
   ejectionOffset = "40";
   softnessDistance = "1";
   softParticles = "1";
   lifetimeVarianceMS = "0";
};

datablock ParticleEmitterData(LavaSprayEmitter)
{
   ejectionPeriodMS = "85";
   periodVarianceMS = "40";
   ejectionVelocity = "2";
   velocityVariance = "2";
   thetaMax = "45";
   particles = "lavaParticle";
   blendStyle = "NORMAL";
   ejectionOffset = "0";
   phiVariance = "10";
   softnessDistance = "10";
   softParticles = "1";
   alignDirection = "1 0 0";
   thetaMin = "5";
};

datablock ParticleEmitterData(LavaSprayTop)
{
   ejectionPeriodMS = "85";
   periodVarianceMS = "40";
   ejectionVelocity = "2";
   velocityVariance = "2";
   thetaMax = "45";
   particles = "lavaParticleTop";
   blendStyle = "NORMAL";
   ejectionOffset = "0.208";
   phiVariance = "10";
   softnessDistance = "10";
   softParticles = "1";
   alignDirection = "1 0 0";
   thetaMin = "5";
};

datablock ParticleEmitterData(LavaSteamEmitter)
{
   ejectionPeriodMS = 625;
   periodVarianceMS = 10;
   ejectionVelocity = 0;
   velocityVariance = 0;
   thetaMin         = 0.0;
   thetaMax         = 39;
   lifetimeMS       = 0;
   particles = "LavaSteamData";
   blendStyle = "NORMAL";
   ejectionOffset = "8";
   softnessDistance = "1";
   softParticles = "1";
   lifetimeVarianceMS = "0";
};

datablock ParticleEmitterData(LavaMagmaEmitter)
{
   ejectionPeriodMS = "60";
   periodVarianceMS = "0";
   ejectionVelocity = "7.5";
   velocityVariance = "0.2";
   thetaMax = "20";
   particles = "lavamagmaParticle";
   blendStyle = "NORMAL";
   ejectionOffset = "0";
   phiVariance = "360";
   softnessDistance = "1";
   softParticles = "1";
   alignDirection = "1 0 0";
   thetaMin = "12";
   orientParticles = "1";
   alignParticles = "0";
};

datablock ParticleEmitterData(LavaDisturbanceEmitter)
{
   particles = "LavaDisturbanceParticle";
   blendStyle = "NORMAL";
   thetaMin = "7";
   thetaMax = "180";
   orientParticles = "0";
   ejectionPeriodMS = "646";
   periodVarianceMS = "24";
   ejectionVelocity = "0";
   velocityVariance = "0";
   phiVariance = "1";
   alignParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0";
   softParticles = "0";
   alignDirection = "0 0 1";
};

datablock ParticleEmitterData(WaterVortexEmitter)
{
   particles = "WaterVortexParticle";
   blendStyle = "NORMAL";
   thetaMin = "7";
   thetaMax = "180";
   orientParticles = "0";
   ejectionPeriodMS = "646";
   periodVarianceMS = "24";
   ejectionVelocity = "0";
   velocityVariance = "0";
   phiVariance = "360";
   alignParticles = "0";
   softnessDistance = "1";
   ambientFactor = "0";
   softParticles = "1";
   ejectionOffset = "0";
};

// Duplicated Particles for Cave ---------------------------------------------------------------------

datablock ParticleData(ParticleMist_Cave)
{
   textureName = "data/FPSGameplay/pacific/art/particles/mist.png";
   dragCoeffiecient = 0;
   gravityCoefficient = "-0.0854701";
   inheritedVelFactor = 0;
   constantAcceleration = -1;
   lifetimeMS = 2500;
   lifetimeVarianceMS = 0;
   useInvAlpha = 0;
   spinRandomMin = -125;
   spinRandomMax = 125;
   spinSpeed = 0.520833;

   colors[0] = "0.992126 0.992126 0.992126 0.436";
   colors[1] = "0.992126 0.992126 0.992126 0.465";
   colors[2] = "0.992126 0.992126 0.992126 0.668";
   colors[3] = "0.992126 0.992126 0.992126 0.23622";
   
   sizes[0] = 2;
   sizes[1] = 8;
   sizes[2] = 9;
   sizes[3] = "10.5";
   
   times[0] = 0.0;
   times[1] = "0.4";
   times[2] = "0.5";
   times[3] = "0.6";
   
   animTexName = "data/FPSGameplay/pacific/art/particles/mist.png";
   
   dragCoefficient = "0.889541";
};

datablock ParticleData(ParticleMainFalls01_Cave)
{
   textureName = "data/FPSGameplay/pacific/art/particles/main falls 01.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/main falls 01.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleMainFalls02_Cave)
{
   textureName = "data/FPSGameplay/pacific/art/particles/main falls 02.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/main falls 02.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleMainFalls03_Cave)
{
   textureName = "data/FPSGameplay/pacific/art/particles/main falls 03.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/main falls 03.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleRockImpactInner01_Cave)
{
   textureName = "data/FPSGameplay/pacific/art/particles/rock_impact_1_inner.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/rock_impact_1_inner.png";
   gravityCoefficient = "0.541667";
   inheritedVelFactor = "0.875";
   spinSpeed = "0.229167";
   spinRandomMin = "-416";
   spinRandomMax = "541.9";
   colors[2] = "1 1 1 0.124481";
   colors[3] = "1 1 1 0.136929";
   sizes[1] = "3";
   sizes[2] = "3";
   sizes[3] = "3";
   times[1] = "0.25";
   times[2] = "0.6875";
};

datablock ParticleData(ParticleRockImpactTop_Cave)
{
   textureName = "data/FPSGameplay/pacific/art/particles/top and top spray.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/top and top spray.png";
   gravityCoefficient = "0.124542";
   colors[1] = "0.996078 0.996078 0.996078 0.813";
   colors[2] = "1 1 1 0.581";
   colors[3] = "1 1 1 0.015748";
   sizes[1] = "1.99597";
   sizes[2] = "1.99597";
   sizes[3] = "1.99597";
   times[1] = "0.329412";
   times[2] = "0.658824";
   spinRandomMin = "-43";
   spinRandomMax = "42";
   colors[0] = "1 1 1 0";
   sizes[0] = "1.99597";
   times[3] = "0.992157";
};

datablock ParticleData(ParticleWaterDisturbance_Cave)
{
   textureName = "data/FPSGameplay/pacific/art/particles/ripple.png";
   animTexName = "data/FPSGameplay/pacific/art/particles/ripple.png";
   lifetimeMS = "2626";
   lifetimeVarianceMS = "49";
   spinRandomMin = "0";
   spinRandomMax = "5";
   colors[0] = "1 1 1 0.173228";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0.409449";
   colors[3] = "1 1 1 0.0393701";
   sizes[1] = "10.6543";
   sizes[2] = "15.9952";
   sizes[3] = "18.6565";
   times[1] = "0.247059";
   times[2] = "0.513726";
   times[3] = "1";
   spinSpeed = "0";
   sizes[0] = "5.32564";
};

datablock ParticleEmitterData(EmitterMist_Cave)
{
   particles = "ParticleMist_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "5.11";
   velocityVariance = "0";
   thetaMax = "165";
   softParticles = "1";
   ambientFactor = "0.416667";
   ejectionPeriodMS = "167";
};

datablock ParticleEmitterData(EmitterMainFalls_Cave)
{
   particles = "ParticleMainFalls01_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0.416667";
};

datablock ParticleEmitterData(EmitterMainFalls02_Cave)
{
   particles = "ParticleMainFalls02_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0.416667";
};

datablock ParticleEmitterData(EmitterMainFalls03_Cave)
{
   particles = "ParticleMainFalls03_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "25";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0.416667";
};

datablock ParticleEmitterData(EmitterWaterDisturbance_Cave)
{
   particles = "ParticleWaterDisturbance_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionPeriodMS = "646";
   ambientFactor = "0.416667";
   periodVarianceMS = "24";
   thetaMin = "7";
   thetaMax = "180";
   phiVariance = "1";
   alignParticles = "1";
   softParticles = "0";
   alignDirection = "0 0 1";
};

datablock ParticleEmitterData(EmitterWaterDisturbance_Cave)
{
   particles = "ParticleWaterDisturbance_Cave";
   blendStyle = "NORMAL";
   thetaMin = "7";
   thetaMax = "180";
   orientParticles = "0";
   ejectionPeriodMS = "646";
   periodVarianceMS = "24";
   ejectionVelocity = "0";
   velocityVariance = "0";
   phiVariance = "1";
   alignParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0.416667";
   softParticles = "0";
};

datablock ParticleEmitterData(EmitterRockImpact_Cave)
{
   particles = "ParticleRockImpactInner01_Cave";
   blendStyle = "NORMAL";
   ejectionPeriodMS = "167";
   velocityVariance = "0";
   softParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0.416667";
};

datablock ParticleData( JointBreakParticle )
{
   dragCoefficient      = 1;
   gravityCoefficient   = 0.2;
   inheritedVelFactor   = 0.2;
   constantAcceleration = -0.0;
   lifetimeMS           = 600;
   lifetimeVarianceMS   = 0;
   textureName          = "data/FPSGameplay/art/particles/splash";
   colors[0]     = "0.5 0.5 0.5 1.0";
   colors[1]     = "0.5 0.5 0.5 0.5";
   colors[2]     = "0.5 0.5 0.5 0.0";
   sizes[0]      = 0.8;
   sizes[1]      = 0.3;
   sizes[2]      = 0.0;
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData( JointBreakEmitter )
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 1.0;
   ejectionOffset   = 0.0;
   thetaMin         = 85;
   thetaMax         = 85;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "JointBreakParticle";
};

datablock DebrisData( JointDebris )
{
   explodeOnMaxBounce = false;

   elasticity = 0.15;
   friction = 0.5;

   lifetime = 4.0;
   lifetimeVariance = 0.0;

   minSpinSpeed = 40;
   maxSpinSpeed = 600;

   numBounces = 4;
   bounceVariance = 0;

   staticOnMaxBounce = true;
   gravModifier = 1.0;

   useRadiusMass = true;
   baseRadius = 1;

   velocity = 5.0;
   velocityVariance = 3.0;
   
   //shapeFile = "art/shapes/actors/common/debris_player.dts";
};