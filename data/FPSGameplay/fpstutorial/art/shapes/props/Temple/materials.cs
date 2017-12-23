
//--- Temple.dae MATERIALS BEGIN ---
singleton Material(Temple_Default_Material)
{
	mapTo = "Default_Material";

	diffuseMap[0] = "./Temple_Diff.dds";
	normalMap[0] = "./Temple_Norm.jpg";
	specularMap[0] = "./Temple_Spec.dds";

	diffuseColor[0] = "0.7 0.7 0.7 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;
	pixelSpecular[0] = false;
	emissive[0] = 0;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
	materialTag0 = "Untagged";
};

//--- Temple.dae MATERIALS END ---

singleton Material(Temple_MaterialLibrary_Temple)
{
   mapTo = "temple";
   diffuseColor[0] = "0.7 0.7 0.7 0";
   diffuseMap[0] = "./Temple_Diff.dds";
   detailMap[0] = "detail.dds";
   detailScale[0] = "5 5";
   normalMap[0] = "./Temple_Norm.jpg";
   specular[0] = "0 0.509804 1 0";
   specularPower[0] = "1";
   pixelSpecular[0] = "0";
   translucentBlendOp = "None";
   specularMap[0] = "./Temple_Spec.dds";
   materialTag0 = "Untagged";
};
