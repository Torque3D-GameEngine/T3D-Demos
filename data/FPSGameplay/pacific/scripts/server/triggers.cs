
echo("*** LOAD PACICIF SERVER SCRIPT - triggers.cs ***");

function SimSet::setAllLightsEnabled(%this, %enabled)
{
    %i = 0;
    while (%i < %this.getCount())
    {
        %light = %this.getObject(%i);
        %light.setLightEnabled(%enabled);
        %i = %i + 1;
    }
}

function TimeJumpTrigger::onAdd(%this, %trigger)
{
    if (%trigger.todObject $= "")
    {
        %trigger.todObject = "theTod";
    }
    if (%trigger.targetTime $= "")
    {
        %trigger.targetTime = 90;
    }
    if (%trigger.speed $= "")
    {
        %trigger.speed = 10;
    }
}

function TimeJumpTrigger::onEnterTrigger(%this, %trigger, %obj)
{
   if(%obj.isMemberOfClass("Player")){
   
      %tod = %trigger.todObject;
   
      if(isObject(%tod)){
         
         %tod.animate(%trigger.targetTime, %trigger.speed);
         
         switch(%trigger.musicID)
         {
         case 0:
            BGsound.play();
            CaveAmbient.stop();
         case 1:
            BGsound.stop();
            CaveAmbient.play();
         case 2:
            BGsound.stop();
            CaveAmbient.stop();
         default:
            BGsound.play();
            CaveAmbient.stop();
         }
      }
   }
}
