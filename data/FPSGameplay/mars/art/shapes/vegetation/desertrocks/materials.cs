//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- small_rock_02.DAE MATERIALS BEGIN ---
singleton Material(small_rock_02_tex_smallrock_02)
{
	mapTo = "tex_smallrock_02";

	diffuseMap[0] = "./tex_smallrock_02_dif.dds";
	normalMap[0] = "./tex_smallrock_02_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "RockStructures";
   detailScale[0] = "5 5";
   detailNormalMap[0] = "data/FPSGameplay/mars/art/shapes/rocks/tex_tileable_noise_nrm.dds";
   detailNormalMapStrength[0] = "0.8";
};

//--- small_rock_02.DAE MATERIALS END ---

//--- small_rock_01.DAE MATERIALS BEGIN ---
singleton Material(small_rock_01_tex_smallrock_01)
{
	mapTo = "tex_smallrock_01";

	diffuseMap[0] = "./tex_smallrock_01_dif.dds";
	normalMap[0] = "./tex_smallrock_01_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "RockStructures";
   detailScale[0] = "8 8";
   detailNormalMap[0] = "data/FPSGameplay/mars/art/shapes/rocks/tex_tileable_noise_nrm.dds";
   detailNormalMapStrength[0] = "0.8";
};

//--- small_rock_01.DAE MATERIALS END ---

