//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(building03_SignTwo)
{
	mapTo = "SignTwo";

	diffuseMap[0] = "./LargeSigns_D";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = 1;
	translucentBlendOp = "AddAlpha";
   emissive[0] = "1";
   materialTag0 = "RoadAndPath";
};

singleton Material(Grid512_ForestGreenLines_Mat)
{
   mapTo = "Material__53";
   diffuseMap[0] = "./interior01_df.tga";
   normalMap[0] = "./interior01_nm.tga";
   specularMap[0] = "./interior01_spec.tga";
};


singleton Material(newMaterial)
{
   mapTo = "orig_orig_orig_05_-_Default";
   diffuseMap[0] = "./building03_df.tga";
   detailMap[0] = "";
   detailScale[0] = "11 11";
   normalMap[0] = "./building03_nm.tga";
   detailNormalMap[0] = "./detail_concrete_N.tga";
   specularMap[0] = "./building03_spec.tga";
   pixelSpecular[0] = "1";
   cubemap = "DefaultSkyMatCubemap";
   materialTag0 = "RoadAndPath";
};

singleton Material(balcony_glass)
{
   mapTo = "Material__188";
   diffuseMap[0] = "./glass_df.tga";
   translucent = "1";
   translucentZWrite = "1";
   alphaRef = "248";
};

singleton Material(lightPoles)
{
   mapTo = "orig_11_-_Default";
   diffuseColor[0] = "1 1 1 0";
   diffuseMap[0] = "./lightpost01.tga";
};

singleton Material(building03_RailsGlass)
{
mapTo = "RailsGlass";
diffuseColor[0] = "0.74902 0.92549 0.996078 1";
diffuseMap[0] = "./RailingT.png";
specular[0] = "0.9 0.9 0.9 1";
specularPower[0] = "1";
pixelSpecular[0] = "0";
emissive[0] = "0";
translucent = "1";
translucentBlendOp = "AddAlpha";
materialTag0 = "RoadAndPath";
diffuseMap[1] = "./RailingT_ScanLine.png";
emissive[1] = "1";
animFlags[0] = "0x00000001";
animFlags[1] = "0x00000001";
scrollDir[1] = "1 -0.07";
scrollSpeed[1] = "4.235";
alphaRef = "0";
scrollDir[0] = "0 -0.1";
scrollSpeed[0] = "1";
   castShadows = "0";
};

singleton Material(building03_Kiosk)
{
   mapTo = "Kiosk";
   diffuseColor[0] = "0.588 0.588 0.588 1";
   diffuseMap[0] = "./Kiosk_D.png";
   normalMap[0] = "./Kiosk_N.png";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   materialTag0 = "RoadAndPath";
   specularMap[0] = "./Kiosk_S.png";
};

singleton Material(building03_SignThree)
{
   mapTo = "SignThree";
   diffuseMap[0] = "./LargeSignsTwo_D";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   emissive[0] = "1";
   translucent = "1";
   translucentBlendOp = "AddAlpha";
   materialTag0 = "RoadAndPath";
};

singleton Material(building03_GlowLightBlue)
{
   mapTo = "GlowLightBlue";
   diffuseColor[0] = "0.239216 0.290196 0.294118 1";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   glow[0] = "1";
   emissive[0] = "1";
   translucentBlendOp = "None";
   materialTag0 = "RoadAndPath";
};

singleton Material(building03_BridgeFloor)
{
	mapTo = "BridgeFloor";

	diffuseMap[0] = "./BridgeFloor_D";
	normalMap[0] = "./BridgeFloor_N.png";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 19;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   materialTag0 = "RoadAndPath";
};

singleton Material(building03_InsideFloor)
{
	mapTo = "InsideFloor";

	diffuseMap[0] = "ground tile";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_SignMic)
{
	mapTo = "SignMic";

	diffuseMap[0] = "./LargeSignsMic_D";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = 1;
	translucentBlendOp = "AddAlpha";
   emissive[0] = "1";
  
};

singleton Material(building03_GlowLightYellow)
{
	mapTo = "GlowLightYellow";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.215686 0.223529 0.227451 1";
	specular[0] = "0.729412 0.901961 0.929412 1";
	specularPower[0] = "36";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   glow[0] = "1";
   emissive[0] = "1";
   materialTag0 = "RoadAndPath";
   
};


singleton Material(building03_HiTextDoor)
{
	mapTo = "HiTextDoor";

	diffuseMap[0] = "./Hi-TexDoor_D";
	normalMap[0] = "./Hi-TexDoor_N.png";
	specularMap[0] = "./Hi-TexDoor_S.png";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "RoadAndPath";
};

//--- building03.DAE MATERIALS BEGIN ---
singleton Material(building03_orig_orig_orig_05___Default_ncl1_2)
{
	mapTo = "orig_orig_orig_05___Default_ncl1_2";

	diffuseMap[0] = "building03_df";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_BridgeFloor_ncl1_2)
{
	mapTo = "BridgeFloor_ncl1_2";

	diffuseMap[0] = "BridgeFloor_D";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_GlowLightBlue_ncl1_2)
{
	mapTo = "GlowLightBlue_ncl1_2";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.129412 0.172549 0.211765 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "RoadAndPath";
};

singleton Material(building03_SignThree_ncl1_1)
{
	mapTo = "SignThree_ncl1_1";

	diffuseMap[0] = "LargeSignsTwo_D";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_orig_orig_orig_05___Default)
{
	mapTo = "orig_orig_orig_05___Default";

	diffuseMap[0] = "building03_df";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_orig_orig_orig_05___Default_ncl1_1)
{
	mapTo = "orig_orig_orig_05___Default_ncl1_1";

	diffuseMap[0] = "building03_df";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_Material__53_ncl1_1)
{
	mapTo = "Material__53_ncl1_1";

	diffuseMap[0] = "interior01_df";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_BridgeFloor_ncl1_1)
{
	mapTo = "BridgeFloor_ncl1_1";

	diffuseMap[0] = "BridgeFloor_D";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_InsideFloor_ncl1_1)
{
	mapTo = "InsideFloor_ncl1_1";

	diffuseMap[0] = "ground tile";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(building03_GradantGlow)
{
	mapTo = "GradantGlow";

	diffuseMap[0] = "./GlowGrad.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.215686 0.215686 0.215686 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = "1";
	translucentBlendOp = "AddAlpha";
   glow[0] = "1";
   emissive[0] = "1";
   materialTag0 = "RoadAndPath";
   castShadows = "0";
   translucentZWrite = "1";
   alphaTest = "1";
   alphaRef = "60";
   showFootprints = "0";
};

//--- building03.DAE MATERIALS END ---

