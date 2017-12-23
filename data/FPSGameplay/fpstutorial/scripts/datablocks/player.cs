//----------------------------------------------------------------------------
// Foot puffs
//----------------------------------------------------------------------------

datablock ParticleData(LightPuff)
{
   dragCoefficient      = "1.99902";
   gravityCoefficient   = "-0.01221";
   inheritedVelFactor   = "0.598826";
   constantAcceleration = 0.0;
   lifetimeMS           = 800;
   lifetimeVarianceMS   = 100;
   useInvAlpha          = true;
   spinRandomMin        = -35.0;
   spinRandomMax        = 35.0;
   colors[0]     = "1.0 1.0 1.0 1.0";
   colors[1]     = "1.0 1.0 1.0 0.0";
   sizes[0]      = "0.0976622";
   sizes[1]      = "0.799609";
   times[0]      = "0.298039";
   times[1]      = 1.0;
   textureName = "data/FPSGameplay/art/particles/flare.png";
   animTexName = "data/FPSGameplay/art/particles/flare.png";
   times[2] = "1";
};


//----------------------------------------------------------------------------
