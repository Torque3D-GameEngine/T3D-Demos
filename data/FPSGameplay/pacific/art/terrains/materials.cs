//WetSand Terrain

new TerrainMaterial()
{
   internalName = "WetSand";
   diffuseMap = "./wet sand/wetsand_base";
   normalMap = "./wet sand/wetsand_normal";
   detailMap = "./wet sand/wetsand_detail";
   detailScale = "512";
   detailSize = "2";
   detailDistance = "100";
};

singleton Material( Terrain_SFX_Sand_Mat )
{
   mapTo = "wetsand_base";
   customFootstepSound = Sand_Step_Sound;
};

//DirtySand Terrain

new TerrainMaterial()
{
   diffuseMap = "./dirty sand/dirtysand_base";
   diffuseSize = "900";
   normalMap = "./dirty sand/dirtysand_2_nrm";
   detailMap = "./dirty sand/dirtysand_detail";
   detailSize = "2";
   detailStrength = "0.8";
   detailDistance = "100";
   parallaxScale = "0.02";
   internalName = "DirtySand";
   detailScale = "512";
};

singleton Material( Terrain_SFX_DirtySand_Mat )
{
   mapTo = "dirtysand_base";
   customFootstepSound = Sand_Step_Sound;
};


//DirtySand Terrain 2

new TerrainMaterial()
{
   diffuseMap = "./dirty sand/dirtysand_base";
   normalMap = "./dirty sand/dirtysand_2_nrm";
   detailMap = "./dirty sand/dirtysand_2_detail";
   detailSize = "2";
   detailStrength = "0.7";
   detailDistance = "100";
   parallaxScale = "0.02";
   internalName = "DirtySand2";
   detailScale = "512";
   diffuseSize = "900";
};

/*
singleton Material( Terrain_SFX_DirtySand_Mat )
{
   mapTo = "dirtysand_base";
   customFootstepSound = Sand_Step_Sound;
};
*/

//DirtSandMix Terrain

new TerrainMaterial()
{
   diffuseMap = "./dirty sand/dirtyandmix_base";
   diffuseSize = "500";
   normalMap = "./dirty sand/dirtsandmix_nrm";
   detailMap = "./dirty sand/dirtsandmix_detail";
   detailSize = "2";
   detailStrength = "0.7";
   detailDistance = "100";
   parallaxScale = "0.02";
   internalName = "DirtSandMix";
   detailScale = "512";
};

/*
singleton Material( Terrain_SFX_DirtySand_Mat )
{
   mapTo = "dirtsandmix_base";
   customFootstepSound = Sand_Step_Sound;
};
*/

//RockyDirt Terrain

new TerrainMaterial()
{
   internalName = "RockyDirt";
   diffuseMap = "./rocky dirt/rockydirt_base";
   normalMap = "./rocky dirt/rockydirt_normal";
   detailMap = "./rocky dirt/rockydirt_detail";
   detailScale = "512";
   detailSize = "4.4";
   parallaxScale = "0";
   detailDistance = "500";
   detailStrength = "1";
};
singleton Material( Terrain_SFX_RockyDirt_Mat )
{
   mapTo = "rockydirt_base";
   customFootstepSound = Dirt_Step_Sound;
};

//RockyDirtDark Terrain

new TerrainMaterial()
{
   diffuseMap = "./rocky dirt/rockydirt_base";
   normalMap = "./rocky dirt/rockydirt_normal";
   detailMap = "./rocky dirt/rockydirt_detail";
   internalName = "RockyDirtDark";
   detailSize = "3.5";
   detailDistance = "1000";
   detailStrength = "0.5";
};

//Grass Terrain

new TerrainMaterial()
{
   internalName = "Grass";
   diffuseMap = "./base grass/grass_base";
   normalMap = "./base grass/grass_normal";
   detailMap = "./base grass/grass_detail";
   detailScale = "512";
   detailSize = "2";
   detailDistance = "200";
   detailStrength = "1";
};


singleton Material( Terrain_SFX_Grass_Mat )
{
   mapTo = "grass_base2";
   customFootstepSound = Grass_Step_Sound;
};

//RiverRock Terrain

new TerrainMaterial()
{
   internalName = "RiverRock";
   diffuseMap = "./ocean rocks/oceanrocks_dif";
   normalMap = "./ocean rocks/oceanrocks_normal";
   detailMap = "./grayrock/grayrock_detail";
   detailScale = "256";
   detailStrength = "0.5";
   parallaxScale = "0.03";
   detailSize = "4";
};

singleton Material( Terrain_SFX_RiverRock_Mat )
{
   mapTo = "grayrock_base";
   customFootstepSound = Dirt_Step_Sound;
};

//RockGroundWithGrassTerrain

new TerrainMaterial()
{
   internalName = "RockGroundWithGrass";
   diffuseMap = "./rocky ground with grass/rockygroundwithgrass_base";
   normalMap = "./rocky ground with grass/rockygroundwithgrass_normal_displacement";
   detailMap = "./rocky ground with grass/rockygroundwithgrass_detail";
   detailScale = "256";
   detailDistance = "1000";
   parallaxScale = "0";
};

singleton Material( Terrain_SFX_RockGroundWithGrass_Mat )
{
   mapTo = "rockygroundwithgrass_base";
   customFootstepSound = Dirt_Step_Sound;
};

// GrayRockNear Terrain


new TerrainMaterial()
{
   internalName = "GrayRockNear";
   diffuseMap = "./grayrock/rockfromabovebrown";
   detailMap = "./grayrock/grayrock_detail";   
   detailSize = "5";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "128";
   normalMap = "./grayrock/grayrock_normal_specular";
   detailDistance = "1000";
   parallaxScale = "0.05";
   useSideProjection = "1";
};


//Grayrockfar Terrain


new TerrainMaterial()
{
   diffuseMap = "./grayrock/rockfromabovebrown";
   diffuseSize = "400";
   normalMap = "./grayrock/grayrock_normal_specular";
   detailMap = "./grayrock/grayrock_detail";
   detailSize = "20";
   detailDistance = "2000";
   useSideProjection = "1";
   internalName = "GrayRockFar";
};

singleton Material( Terrain_SFX_GrayRockFar_Mat )
{
   mapTo = "rockfromabovebrown";
   customFootstepSound = Dirt_Step_Sound;
};

//VolcanoRock Terrain

new TerrainMaterial()
{
   diffuseMap = "./volcanic_mix/tex_volcanic_rock_base";
   normalMap = "./volcanic_mix/tex_volcanic_rock_nrm";
   detailMap = "./volcanic_mix/tex_volcanic_rock_dif";
   detailStrength = "1.4";
   detailDistance = "1000";
   internalName = "VolcanoRock";
   enabled = "1";
   isManaged = "1";
   detailBrightness = "1";
   diffuseSize = "80";
};


// VolcanicSplash Terrain

new TerrainMaterial()
{
   diffuseMap = "./volcanic_mix/tex_volcanic_rock_base";
   normalMap = "./volcanic_mix/tex_volcanic_rock_nrm";
   detailMap = "./volcanic_mix/tex_volcanic_rock_burn_dif";
   detailSize = "10";
   detailStrength = "1.2";
   detailDistance = "500";
   internalName = "VolcanicSplash";
   diffuseSize = "40";
};

// VolcanicCliffRockTop Terrain

new TerrainMaterial()
{
   diffuseMap = "./volcanic_mix/tex_volcanic_cliffrock_base";
   diffuseSize = "200";
   normalMap = "./volcanic_mix/tex_volcanic_cliffrock_nrm";
   detailMap = "./volcanic_mix/tex_volcanic_cliffrock_dif";
   detailSize = "8";
   detailStrength = "0.4";
   detailDistance = "1000";
   internalName = "VolcanicCliffRockTop";
};

// VolcanicCliffSide Terrain

new TerrainMaterial()
{
   diffuseMap = "./volcanic_mix/tex_volcanic_cliffrock_base";
   normalMap = "./volcanic_mix/tex_volcanic_cliffrock_nrm";
   detailMap = "./volcanic_mix/tex_volcanic_cliffrock_dif";
   detailSize = "14";
   detailDistance = "1000";
   useSideProjection = "1";
   internalName = "VolcanicCliffSide";
   diffuseSize = "500";
   detailStrength = "0.5";
};

//SeaweedMain Terrain

new TerrainMaterial()
{
   diffuseMap = "./seaweed/Seaweed_base";
   normalMap = "./seaweed/Seaweed_nrm_displacement";
   detailMap = "./seaweed/Seaweed_detail";
   detailSize = "5.5";
   detailStrength = "0.4";
   detailDistance = "1000";
   parallaxScale = "0.03";
   internalName = "SeaweedMain";
};

//SeaweedRiverRock Terrain

new TerrainMaterial()
{
   diffuseMap = "./seaweed/Seaweed_base";
   normalMap = "./ocean rocks/oceanrocks_normal";
   detailMap = "./ocean rocks/oceanrocks_dif";
   parallaxScale = "0.03";
   internalName = "SeaweedRiverRock";
   detailSize = "4";
   detailDistance = "50";
   detailStrength = "0.5";
};

// RockySeaweed Terrain

new TerrainMaterial()
{
   diffuseMap = "./rocky_seaweed/rocky_seaweed_base";
   normalMap = "./rocky_seaweed/rocky_seaweed_nrm";
   detailMap = "./rocky_seaweed/rocky_seaweed_dif";
   internalName = "RockySeaweed";
   detailSize = "9";
   detailStrength = "0.2";
   detailDistance = "1000";
   parallaxScale = "0.03";
};

// RockyGroundSmall

new TerrainMaterial()
{
   diffuseMap = "./rocky ground with grass/rockygroundwithgrass_base";
   normalMap = "./rocky ground with grass/rockygroundwithgrass_normal_displacement";
   detailMap = "./rocky ground with grass/rockygroundwithgrass_detail";
   detailSize = "2.8";
   detailStrength = "1";
   parallaxScale = "0";
   internalName = "RockGroundSmall";
   detailScale = "256";
   diffuseSize = "50";
};

new TerrainMaterial()
{
   diffuseMap = "./forest mix/forestmix_base";
   normalMap = "./forest mix/forestmix_normal_displacement";
   detailMap = "./forest mix/forestmix_detail";
   internalName = "ForestFloor";
   detailScale = "128";
   parallaxScale = "0.05";
};





