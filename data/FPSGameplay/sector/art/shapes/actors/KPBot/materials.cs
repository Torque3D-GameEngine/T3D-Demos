//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(KPBot_KPbot_Player_mat)
{
	mapTo = "KPbot_Player_mat";

	diffuseMap[0] = "./KPBot_D";
	normalMap[0] = "";
	specularMap[0] = "./KPBot_S";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 24;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   materialTag0 = "KPbot";
   castDynamicShadows = true;
};

singleton Material(KPBot_KPbot_Glow)
{
	mapTo = "KPbot_Glow";

	diffuseMap[0] = "./KPBot_D";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "Add";
   glow[0] = "1";
   emissive[0] = "1";
   materialTag0 = "KPbot";
   castDynamicShadows = true;
};

singleton Material(KpBot_Sentry_KPbot_Sentry_mat)
{
	mapTo = "KPbot_Sentry_mat";

	diffuseMap[0] = "./KPBot_v2_D";
	specularMap[0] = "./KPBot_S";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 36;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   materialTag0 = "KPbot";
   castDynamicShadows = "1";
};

singleton Material(KpBot_Sentry_KPbot_Sentry_Glow)
{
	mapTo = "KPbot_Sentry_Glow";

	diffuseMap[0] = "./KPBot_v2_D.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "Add";
   glow[0] = "1";
   emissive[0] = "1";
   materialTag0 = "KPbot";
   castDynamicShadows = "1";
};

singleton Material(KpBot_Sentry_KpBot_Sentry_Gun)
{
	mapTo = "KpBot_Sentry_Gun";

	diffuseMap[0] = "./Gun_D";
	normalMap[0] = "./Gun_N.png";
	specularMap[0] = "./Gun_S.png";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 11;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   materialTag0 = "KPbot";
   castDynamicShadows = true;
};

