//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(sign01__8___Default)
{
	mapTo = "_8_-_Default";

	diffuseMap[0] = "sign01";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(sign02_orig_10___Default)
{
	mapTo = "orig_10_-_Default";

	diffuseMap[0] = "./sign02";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 128;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   diffuseMap[1] = "./sign02_l2";
   glow[1] = "1";
};

