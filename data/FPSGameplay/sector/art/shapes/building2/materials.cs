//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(building_02_orig_orig_orig_orig_orig_orig_orig_02___Default)
{
	mapTo = "orig_orig_orig_orig_orig_orig_orig_02_-_Default";

	diffuseMap[0] = "./building_02_df_var2.tga";
	normalMap[0] = "./building_02_nm.tga";
	specularMap[0] = "./building_02_spec.tga";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building_02_b__7___Default)
{
	mapTo = "_7_-_Default";

	diffuseMap[0] = "./building_02_df_var2";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   castShadows = "0";
   materialTag0 = "RoadAndPath";
};

singleton Material(building_02_GlassMat02)
{
	mapTo = "GlassMat02";

	diffuseMap[0] = "./building_02_df.tga";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 0.721569 0 1";
	specular[0] = "0.901961 0.901961 0.901961 1";
	specularPower[0] = "128";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "RoadAndPath";
   pixelSpecular[0] = "0";
   glow[0] = "0";
   cubemap = "GoldenHourCloudySkyCubeMap";
   emissive[0] = "1";
};



