
echo("*** LOAD MARS DATABLOCK - audioData.cs ***");

//-----------------------------------------------------------------------------
// 3D Sounds
//-----------------------------------------------------------------------------

datablock SFXDescription( Shore01Looping3d : AudioEffect )
{
  volume   = 1.0;
  isLooping= true;

  is3D     = true;
  ReferenceDistance = 20;
  maxDistance = 65;
};

datablock SFXDescription( TreeGrove01Looping3d : AudioEffect )
{
  volume   = 1.0;
  isLooping= true;

  is3D     = true;
  ReferenceDistance = 20;
  maxDistance = 80;
};

datablock SFXDescription( Tree01Looping3d : AudioEffect )
{
  volume   = 1.0;
  isLooping= true;

  is3D     = true;
  ReferenceDistance = 20;
  maxDistance = 60;
};

datablock SFXDescription( Fire01Looping3d : AudioEffect )
{
  volume   = 1.0;
  isLooping= true;

  is3D     = true;
  ReferenceDistance = 3;
  maxDistance = 10;
};