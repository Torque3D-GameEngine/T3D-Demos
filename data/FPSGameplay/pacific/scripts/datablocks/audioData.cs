
echo("*** LOAD PACICIF DATABLOCK - audioData.cs ***");

singleton SFXDescription(FootStepDesc : AudioEffect )
{
   isLooping         = false;
   is3D              = true;
   ReferenceDistance = 1.0;
   MaxDistance       = 5;
};

singleton SFXDescription(AudioLoop2DLowVolumen : AudioLoop2D)
{
   volume = "0.634921";
};
