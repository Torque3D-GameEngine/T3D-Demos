

Copy this level files inside of folder FPSGamplay/levels

fpstutorial/levels/ChinaTown_Day.mis
fpstutorial/levels/ChinaTown_Day.postfxpreset.cs
fpstutorial/levels/ChinaTown_Day_preview.png

fpstutorial/levels/ChinaTown_Dusk.mis
fpstutorial/levels/ChinaTown_Dusk.postfxpreset.cs
fpstutorial/levels/ChinaTown_Dusk_preview.png

fpstutorial/levels/ChinaTown_Eerie.mis
fpstutorial/levels/ChinaTown_Eerie.postfxpreset.cs
fpstutorial/levels/ChinaTown_Eerie_preview.png

fpstutorial/levels/ChinaTown_Mist.mis
fpstutorial/levels/ChinaTown_Mist.postfxpreset.cs
fpstutorial/levels/ChinaTown_Mist_preview.png


Remember to put this lines of code at the top of the [Level_Name].mis file in this order.

// LOAD FPSTUTORIAL DATABLOCKS
exec("data/FPSGameplay/fpstutorial/scripts/datablocks/ambientSounds.cs");
exec("data/FPSGameplay/fpstutorial/scripts/datablocks/managedDecalData.cs");
exec("data/FPSGameplay/fpstutorial/scripts/datablocks/managedParticleData.cs");
exec("data/FPSGameplay/fpstutorial/scripts/datablocks/managedParticleEmitterData.cs");
exec("data/FPSGameplay/fpstutorial/scripts/datablocks/weapons/rocketLauncher.cs");
exec("data/FPSGameplay/fpstutorial/scripts/datablocks/weapons/grenadeLauncher.cs");
exec("data/FPSGameplay/fpstutorial/scripts/datablocks/player.cs");



