
echo("*** LOAD PACICIF DATABLOCK - audioProfiles.cs ***");

singleton SFXProfile(sfxEvening2)
{
   fileName = "data/FPSGameplay/pacific/sound/evening2.ogg";
   preload = "1";
   description = "AudioLoop2D";
};

singleton SFXProfile(sfxGrassAmbiance)
{
   description = "AudioLoop2DLowVolumen";
   fileName = "data/FPSGameplay/pacific/sound/grassambiance.ogg";
};


singleton SFXProfile(UnderwaterBubblesSound)
{
filename = "data/FPSGameplay/pacific/sound/underwater_ambiance.ogg";
description = AudioLoop2D;
preload = true;
};

datablock SFXProfile(OOBWarningSnd)
{
   filename = "data/FPSGameplay/sound/orc_pain.ogg";
   description = "AudioLoop2D";
   preload = false;
};

singleton SFXProfile(Grass_Step_Sound)
{
   filename    = "data/FPSGameplay/pacific/sound/grassstepsingle.ogg";
   description = FootStepDesc;
   preload = true;
};

singleton SFXProfile(Dirt_Step_Sound)
{
   filename    = "data/FPSGameplay/pacific/sound/dirtstep.ogg";
   description = FootStepDesc;
   preload = true;
};

singleton SFXProfile(Sand_Step_Sound)
{
   filename    = "data/FPSGameplay/pacific/sound/sandstep.ogg";
   description = FootStepDesc;
   preload = true;
};
