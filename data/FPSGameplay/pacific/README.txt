
Copy this level files inside of folder FPSGamplay/levels

pacific/levels/Pacific.mis
pacific/levels/Pacific.postfxpreset.cs
pacific/levels/Pacific_preview.png
pacific/levels/Pacific.forest
pacific/levels/Pacific.mis.decals

Remember to put this lines of code at the top of the [Level_Name].mis file in this order.

// LOAD PACIFIC DATABLOCKS
exec("data/FPSGameplay/pacific/scripts/datablocks/managedDecalData.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/managedItemData.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/brushes.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/audioData.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/audioProfiles.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/audioAmbience.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/particles.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/environment.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/triggers.cs");

// LOAD PACIFIC FX DATABLOCKS
exec("data/FPSGameplay/pacific/scripts/datablocks/fxpack1/bulletImpact_building.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/fxpack1/bulletImpact_dirt.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/fxpack1/explosion_groundminor.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/fxpack1/explosion_waterminor.cs");
exec("data/FPSGameplay/pacific/scripts/datablocks/fxpack1/explosion_woodCrate.cs");


// LOAD PACIFIC PHYSICS LEVEL DATABLOCKS
exec("data/FPSGameplay/pacific/scripts/datablocks/physicsShape.cs");
exec("data/FPSGameplay/pacific/scripts/multiactors.cs");

// LOAD SERVER SCRIPTS
exec("data/FPSGameplay/pacific/scripts/server/triggers.cs");

