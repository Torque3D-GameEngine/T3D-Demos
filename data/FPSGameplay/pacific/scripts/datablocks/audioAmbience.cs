
echo("*** LOAD PACICIF DATABLOCK - audioAmbience.cs ***");

singleton SFXAmbience( UnderwaterAmbiance )
{
   environment = AudioEnvUnderwater;
   states[ 0 ] = AudioLocationUnderwater;
   soundTrack = "UnderwaterBubblesSound";
   states[0] = "AudioLocationUnderwater";
};
