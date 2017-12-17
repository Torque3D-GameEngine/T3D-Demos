//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(deserttree_deserttree_frond_lod1)
{
	mapTo = "deserttree_frond_lod1";

	diffuseMap[0] = "./fronds_diffuse_transparencyLOD1.dds";
	normalMap[0] = "./fronds_normal_LOD1.dds";
	specularMap[0] = "./fronds_specularLOD1.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "60";
   materialTag0 = "Vegetation";
};

singleton Material(deserttree_deserttree_bark_lod1)
{
	mapTo = "deserttree_bark_lod1";

	diffuseMap[0] = "./bark_diffuseLOD1.dds";
	normalMap[0] = "./bark_normals_LOD1.dds";
	specularMap[0] = "./bark_specularLOD1.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Vegetation";
};

singleton Material(deserttree_deserttree_lod2)
{
	mapTo = "deserttree_lod2";

	diffuseMap[0] = "./deserttree_diffuse_transparencyLOD2.dds";
	normalMap[0] = "./deserttree_normal_LOD2.dds";
	specularMap[0] = "./deserttree_specularLOD2.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Vegetation";
   alphaTest = "1";
   alphaRef = "60";
};


//--- deserttree.DAE MATERIALS BEGIN ---
singleton Material(deserttree_ColorEffectR198G225B87)
{
	mapTo = "ColorEffectR198G225B87";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.776471 0.882353 0.341177 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(deserttree_ColorEffectR61G135B6)
{
	mapTo = "ColorEffectR61G135B6";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.239216 0.529412 0.0235294 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- deserttree.DAE MATERIALS END ---

