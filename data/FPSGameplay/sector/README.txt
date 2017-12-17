
Copy this level files inside of folder FPSGamplay/levels
sector/levels/Sector_T3D.mis
sector/levels/Sector_T3D.postfxpreset.cs
sector/levels/Sector_T3D_preview.png

Remember to put this lines of code at the top of the [Level_Name].mis file in this order.

// LOAD SECTOR DATABLOCKS 
exec("data/FPSGameplay/sector/scripts/datablocks/sounds.cs");
exec("data/FPSGameplay/sector/scripts/datablocks/triggers.cs");
exec("data/FPSGameplay/sector/scripts/datablocks/player.cs");
