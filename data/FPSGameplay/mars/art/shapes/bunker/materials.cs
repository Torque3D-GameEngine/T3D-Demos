
singleton Material(Bunker_Concrete)
{
	mapTo = "Concrete";

	diffuseMap[0] = "./Concrete_D";
	specularMap[0] = "./Concrete_S";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = "16";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   useAnisotropic[0] = "1";
   lightMap[0] = "./Bunker_LightMap";
   materialTag0 = "RoadAndPath";
};

singleton Material(Bunker_Panels)
{
	mapTo = "Panels";

	diffuseMap[0] = "./Panels01_D";
	normalMap[0] = "./Panels01_N";
	specularMap[0] = "./Panels01_S";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = "16";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   lightMap[0] = "./Bunker_LightMap";
   materialTag0 = "RoadAndPath";
};

singleton Material(Bunker_GDoorFrame)
{
	mapTo = "GDoorFrame";

	diffuseMap[0] = "./GDoorFrame_D";
	normalMap[0] = "./GDoorFrame_N";
	specularMap[0] = "./GDoorFrame_S";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = "16";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   lightMap[0] = "./Bunker_LightMap";
   materialTag0 = "RoadAndPath";
};

singleton Material(Bunker_Interior01_MainScreen)
{
	mapTo = "Interior01_MainScreen";

	diffuseMap[0] = "./Interior01_D";

	diffuseColor[0] = "0.411765 0.890196 0.988235 1";
	specular[0] = "0.00392157 0.00392157 0.00392157 1";
	specularPower[0] = "16";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   useAnisotropic[0] = "0";
   glow[0] = "0";
   emissive[0] = "1";
   materialTag0 = "RoadAndPath";
};

singleton Material(Bunker_Pavement)
{
	mapTo = "Pavement";

	diffuseMap[0] = "./Pavement_D";

	//diffuseColor[0] = "4 6 12 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = "2";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   specularMap[0] = "./Pavement_S";
   useAnisotropic[0] = "1";
   materialTag0 = "RoadAndPath";
   diffuseColor[0] = "0.992157 0.992157 0.992157 1";
   lightMap[0] = "./Bunker_LightMap.tga";
};

singleton Material(Bunker_Wall)
{
	mapTo = "Wall";

	diffuseMap[0] = "./Wall_D";
	normalMap[0] = "./Wall_N";
	specularMap[0] = "./Wall_S";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = "16";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   toneMap[0] = "./Bunker_LightMap";
};


singleton Material(Bunker_Interior02_Lights)
{
	mapTo = "Interior02_Lights";

	//diffuseMap[0] = "./Interior02_D";
	//normalMap[0] = "Interior02_N";
	//specularMap[0] = "Interior02_S";

	diffuseColor[0] = "8 12 24 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   //diffuseColor[0] = "0.219608 0.227451 0.227451 1";
   glow[0] = "0";
   emissive[0] = "1";
   materialTag0 = "RoadAndPath";
};

singleton Material(Bunker_Interior02)
{
	mapTo = "Interior02";

	diffuseMap[0] = "./Interior02_D";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = "16";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   lightMap[0] = "./Bunker_LightMap";
   materialTag0 = "RoadAndPath";
};

singleton Material(Bunker_Interior01)
{
	mapTo = "Interior01";

	diffuseMap[0] = "./Interior01_D";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = "2";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   lightMap[0] = "./Bunker_LightMap";
   materialTag0 = "RoadAndPath";
   //useAnisotropic[0] = "1";
};

singleton Material(Bunker_Extras)
{
	mapTo = "Extras";

	diffuseMap[0] = "./Extras_D";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = "16";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   lightMap[0] = "./Bunker_LightMap";
   normalMap[0] = "./Extras_N";
   pixelSpecular[0] = "1";
   specularMap[0] = "./Extras_S";
   materialTag0 = "RoadAndPath";
};

singleton Material(Bunker_Interior03)
{
	mapTo = "Interior03";

	diffuseMap[0] = "./Interior03_D";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = "8";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   lightMap[0] = "./Bunker_LightMap";
   materialTag0 = "RoadAndPath";
};


singleton Material(Bunker_Interior03)
{
	mapTo = "Interior03";

	diffuseMap[0] = "./Interior03_D";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
};

singleton Material(Bunker_Interior02_Screens)
{
   mapTo = "Interior02_Screens";
   diffuseColor[0] = "0.666667 0.898039 0.890196 1";
   diffuseMap[0] = "./Interior02_D";
   //normalMap[0] = "Interior02_N";
   specular[0] = "0 0 0 1";
   specularPower[0] = "2";
   //specularMap[0] = "Interior02_S";
   glow[0] = "0";
   emissive[0] = "1";
   translucentBlendOp = "None";
   materialTag0 = "RoadAndPath";
};

singleton Material(Bunker_ColorEffectR213G154B229_material)
{
   mapTo = "ColorEffectR213G154B229-material";
   diffuseColor[0] = "0.835294 0.603922 0.898039 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
singleton Material(newMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "./Panels01_D";
   materialTag0 = "RoadAndPath";
};
singleton Material(Parts01_mat)
{
   mapTo = "Parts01";
   diffuseMap[0] = "./Parts01_D";
   lightMap[0] = "./Bunker_LightMap";
   normalMap[0] = "./Parts01_N";
   specularMap[0] = "./Parts01_S";
};
