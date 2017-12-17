
//exec("./data/FPSGameplay/sector/scripts/datablocks/triggers.cs");

echo("*** LOAD SECTOR DATABLOCK - triggers.cs ***");

datablock TriggerData(AudioMuffleTrigger)
{
   tickPeriodMS = 100;
   clientSide = true;
};

function AudioMuffleTrigger::onEnterTrigger(%this, %trigger, %obj)
{
   // Only player objects can trigger this
   if ( !%obj.isMemberOfClass( "Player" ) )
      return;
      
   // Make sure we the wind object
   if ( !isObject( ambientWind ) )   
      return;
   else
   {
      ambientWind.pitch = 1.15;
      ambientWind.volume = 0.3;
   }
}

function AudioMuffleTrigger::onLeaveTrigger(%this, %trigger, %obj)
{
   // Only player objects can trigger this
   if ( !%obj.isMemberOfClass( "Player" ) )
      return;
      
   // Make sure we the wind object
   if ( !isObject( ambientWind ) )   
      return;
   else
   {
      ambientWind.pitch = 1;
      ambientWind.volume = 0.5;
   }
}