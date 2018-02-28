
Copy this level files inside of folder FPSGamplay/levels

pacific/levels/Pacific.mis
pacific/levels/Pacific.postfxpreset.cs
pacific/levels/Pacific_preview.png
pacific/levels/Pacific.forest
pacific/levels/Pacific.mis.decals

Remember to put one of this line at the top of the [Level_Name].mis file, or just execute when the level finished loading.

// LOAD PACIFIC SCRIPTS
exec("data/FPSGameplay/pacific/pacific_noPhysics.cs");

// LOAD PACIFIC PHYSICS SCRIPTS
exec("data/FPSGameplay/pacific/pacific.cs");
