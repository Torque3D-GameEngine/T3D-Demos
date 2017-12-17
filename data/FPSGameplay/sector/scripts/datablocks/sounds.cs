
// exec("./data/FPSGameplay/sector/scripts/datablocks/sounds.cs");

echo("*** LOAD SECTOR DATABLOCK - sounds.cs ***");

datablock SFXProfile(HighWinds)
{
   filename    = "data/FPSGameplay/sector/sound/highWinds.ogg";
   description = AudioLoop2d;
   preload = true;
};

datablock SFXProfile(CorridorBuzz)
{
   filename    = "data/FPSGameplay/sector/sound/robothum";
   description = AudioCloseLoop3D;
   preload = true;
};

datablock SFXProfile(CarSound)
{
   filename    = "data/FPSGameplay/sound/metalstep_mono_01";
   description = AudioClose3d;
   preload = true;
};
