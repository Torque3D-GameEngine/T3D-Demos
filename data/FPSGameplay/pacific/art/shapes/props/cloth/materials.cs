singleton Material(clothframe_clothframe)
{
	mapTo = "clothframe";

	diffuseMap[0] = "./tex_clothframe_dif.dds";
	normalMap[0] = "./tex_clothframe_nrm.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 29;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   materialTag0 = "props";
};

singleton Material(Cloth)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "./sheerfabric_diffuse.dds";
   normalMap[0] = "./sheerfabric_normal.png";
   doubleSided = "1";
   materialTag0 = "RoadAndPath";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "161";
};


singleton Material(clothframe_ColorEffectR225G87B143_material)
{
	mapTo = "ColorEffectR225G87B143-material";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.882353 0.341177 0.560784 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(clothframe_ColorEffectR154G154B229_material)
{
   mapTo = "ColorEffectR154G154B229-material";
   diffuseColor[0] = "0.603922 0.603922 0.898039 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
