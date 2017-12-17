
echo("*** LOAD MARS DATABLOCK - environment.cs ***");

// ENVIROMENTAL EFFECTS GO HERE (PRECIPITATION - LIGHTNING)

// ----------------------------------------------------------------------------
// Rain
// ----------------------------------------------------------------------------

datablock PrecipitationData(HeavyRain2)
{
   dropTexture = "data/FPSGameplay/mars/art/environment/mist";
   splashTexture = "data/FPSGameplay/mars/art/environment/mist2";
   dropSize = 10;
   splashSize = 0.1;
   useTrueBillboards = false;
   splashMS = 250;
};

datablock PrecipitationData(HeavyRain3)
{
   dropTexture = "data/FPSGameplay/mars/art/environment/shine";
   splashTexture = "data/FPSGameplay/mars/art/environment/mist2";
   dropSize = 20;
   splashSize = 0.1;
   useTrueBillboards = false;
   splashMS = 250;
};

// ----------------------------------------------------------------------------
// Dust/sand storm(s)
// ----------------------------------------------------------------------------

datablock SFXProfile(Sandstormsound)
{
   filename = "data/FPSGameplay/mars/sound/environment/waste";
   description = AudioLoop2d;
   volume = 1.0;
};

datablock PrecipitationData(Sandstorm)
{
   soundProfile = "Sandstormsound";

   dropTexture = "data/FPSGameplay/mars/art/environment/sandstorm";
   splashTexture = "data/FPSGameplay/mars/art/environment/sandstorm2";
   dropSize = 10;
   splashSize = 2;
   useTrueBillboards = false;
   splashMS = 250;
};

datablock SFXProfile(dustsound)
{
   filename = "data/FPSGameplay/mars/sound/environment/dust";
   description = AudioLoop2d;
};

datablock PrecipitationData(dustspecks)
{
   soundProfile = "dustsound";

   dropTexture = "data/FPSGameplay/mars/art/environment/dust";
   splashTexture = "data/FPSGameplay/mars/art/environment/dust2";
   dropSize = 0.25;
   splashSize = 0.25;
   useTrueBillboards = false;
   splashMS = 250;
};

// ----------------------------------------------------------------------------
// Snow
// ----------------------------------------------------------------------------

datablock PrecipitationData(HeavySnow)
{
   dropTexture = "data/FPSGameplay/mars/art/environment/snow";
   splashTexture = "data/FPSGameplay/mars/art/environment/snow";
   dropSize = 0.27;
   splashSize = 0.27;
   useTrueBillboards = false;
   splashMS = 50;
};
