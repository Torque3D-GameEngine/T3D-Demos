
singleton Material(chinese_lantern_Misc_rope)
{
	mapTo = "Misc.rope";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.7 0.7 0.7 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;
	pixelSpecular[0] = false;
	emissive[0] = true;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
	materialTag0 = "Untagged";
};

//--- chinese_lantern.dae MATERIALS END ---

singleton Material(CT_paperLantern)
{
   mapTo = "Misc.Paper_lantern";
   diffuseMap[0] = "./lamp_diff_GM.dds";
   normalMap[0] = "./lamp_normals.dds";
   alphaTest = "1";
   alphaRef = "73";
   specularPower[0] = "66";
   pixelSpecular[0] = "1";
   glow[0] = "1";
   doubleSided = "1";
   diffuseMap[1] = "./lamp_glow.dds";
   glow[1] = "1";
   specular[0] = "1 0.396078 0 1";
   materialTag0 = "Untagged";
};

