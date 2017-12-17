
echo("*** LOAD SECTOR DATABLOCK - player.cs ***");

datablock PlayerData(BoomBotData : DefaultPlayerData)
{
   
   maxForwardSpeed = 10;
   
   cameraDefaultFov = 75;
   cameraMinFov = 5.0;
   cameraMaxFov = 75;

   shapeFile = "data/FPSGameplay/sector/art/shapes/actors/KPBot/KPBot.dae";
   boundingBox = "1.1 1.2 2.5";
};