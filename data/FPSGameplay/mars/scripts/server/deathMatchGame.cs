
echo("*** LOAD mars server scripts - deathMatchGame.cs ***");

function preparePlayer()
{
   if(ClientGroup.getCount() > 0)
   {
      for(%i = 0; %i < ClientGroup.getCount(); %i++)
      {
         %client = ClientGroup.getObject(%i);
   
         if(%client.player.getDatablock().getName() $= "GideonData")
         {
            loadOut(%client.player);
         }
      }
   }
}

function loadOut(%player)
{
   %player.clearWeaponCycle();
   
   %player.setInventory(GrenadeLauncher, 1);
   %player.setInventory(GrenadeLauncherAmmo, %player.maxInventory(GrenadeLauncherAmmo)); // Start the gun loaded
   %player.addToWeaponCycle(GrenadeLauncher);
   
   if (%player.getDatablock().mainWeapon.image !$= "")
   {
      %player.mountImage(%player.getDatablock().mainWeapon.image, 0);
   }
   else
   {
      %player.mountImage(Ryder, 0);
   }
}

preparePlayer();