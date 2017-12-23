
Copy this level files inside of folder FPSGamplay/levels

mars/levels/Mars.mis
mars/levels/Mars.postfxpreset.cs
mars/levels/Mars_preview.png

mars/levels/Deathball Desert.mis
mars/levels/Deathball Desert.forest
mars/levels/Deathball Desert.mis.decals
mars/levels/Deathball Desert.postfxpreset.cs
mars/levels/Deathball Desert_preview.png

mars/levels/Burg.mis
mars/levels/Burg.postfxpreset.cs
mars/levels/Burg_preview.png

mars/levels/Convex Land.mis
mars/levels/Convex Land_preview.png

Remember to put this lines of code at the top of the [Level_Name].mis file in this order.

// LOAD MARS BURG DEATHBALL DATABLOCKS
exec("data/FPSGameplay/mars/scripts/datablocks/managedDecalData.cs");
exec("data/FPSGameplay/mars/scripts/datablocks/managedItemData.cs");
exec("data/FPSGameplay/mars/scripts/datablocks/brushes.cs");
exec("data/FPSGameplay/mars/scripts/datablocks/audioData.cs");
exec("data/FPSGameplay/mars/scripts/datablocks/audioProfiles.cs");
exec("data/FPSGameplay/mars/scripts/datablocks/particles.cs");
exec("data/FPSGameplay/mars/scripts/datablocks/environment.cs");
exec("data/FPSGameplay/mars/scripts/datablocks/weapons/grenadeLauncher.cs");
exec("data/FPSGameplay/mars/scripts/datablocks/player.cs");

// LOAD MARS BURG DEATHBALL SERVER SCRIPTS
exec("data/FPSGameplay/mars/scripts/server/deathMatchGame.cs");

If you want to play as Gideon in Burg level and use his weapon, type preparePlayer(); in the console. After the level finished loading.
