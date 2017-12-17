//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------



singleton Material(pier_detail_target)
{

   mapTo = "pier_wood";  
   baseTex[0] = "";
   overlayTex[0] = "";
   bumpTex[0] = "";

   pixelSpecular = "1";
   specular = "1 1 1 0";
   specularPower = "49";
   diffuseMap[0] = "./pier_diffuse_transparency.dds";
   overlayMap[0] = "./target_diffuse.png";
   normalMap[0] = "./pier_normal_specular.dds";
   materialTag0 = "Structure";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";

//   detailTex[0] = "pier_detail.dds";
//   detailScale[0] = "4 10";

};


/*
singleton Material(wooden_beams_target)
{

   mapTo = "beam";  
   baseTex[0] = "post_diffuse.png";
   bumpTex[0] = "post_normal_specular.png";

   pixelSpecular = true;
   specular = "1 1 1 0";
   specularPower = 12;
};
*/

//--- watertower.dae MATERIALS BEGIN ---
singleton Material(watertower_Standard_1)
{
	baseTex[0] = "";
	mapTo = "Standard_1";

	diffuseColor[0] = "1.000000 1.000000 1.000000 1.000000";
	specular[0] = "0.000000 0.000000 0.000000 1.000000";
	specularPower[0] = 2.000000;
	pixelSpecular[0] = true;
	emissive[0] = false;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   diffuseMap[0] = "pier_diffuse_transparency";
   materialTag0 = "Structure";
};


//--- watertower.dae MATERIALS END ---

//--- pier.dae MATERIALS BEGIN ---

//--- pier.dae MATERIALS END ---


singleton Material(pier_ColorEffectR8G61B138_material)
{
   mapTo = "ColorEffectR8G61B138-material";
   diffuseColor[0] = "0.0313726 0.239216 0.541176 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(watertowertank_material)
{
   mapTo = "watertowertank_material";
   specular[0] = "0 0 0 1";
   specularPower[0] = "2";
   translucentBlendOp = "None";
};
