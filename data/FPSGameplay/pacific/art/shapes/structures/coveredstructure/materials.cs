
singleton Material(coveredstructure_bluetinroof)
{
	mapTo = "bluetinroof";

	diffuseMap[0] = "./roof_diffuse.dds";
	normalMap[0] = "./roof_normal_parallax.dds";
	specularMap[0] = "./roof_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 9;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   parallaxScale[0] = "0";
   pixelSpecular[0] = "1";
   materialTag0 = "Structure";
};



//--- coveredstructure.dae MATERIALS BEGIN ---

//--- coveredstructure.dae MATERIALS END ---


singleton Material(coveredstructure_beam)
{
   mapTo = "beam";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   backLightFactor = "0.9 1.0 0.2";
   materialTag0 = "Structure";
   forestWindEnabled = "1";
   backlight = "1";
};

singleton Material(coveredstructure_ColorEffectR28G28B177_material)
{
   mapTo = "ColorEffectR28G28B177-material";
   diffuseColor[0] = "0.109804 0.109804 0.694118 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(coveredstructure01_DAE_concreteStr)
{
   mapTo = "concreteStr";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "9 9 9 1";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   diffuseMap[0] = "data/FPSGameplay/pacific/art/shapes/structures/coveredstructure/concretepier_diffuse.dds";
   normalMap[0] = "data/FPSGameplay/pacific/art/shapes/structures/coveredstructure/concretepier_normal.dds";
};
