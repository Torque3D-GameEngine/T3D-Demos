singleton Material(target_static_ColorEffectR28G149B177_material)
{
   mapTo = "ColorEffectR28G149B177-material";
   diffuseColor[0] = "0.109804 0.584314 0.694118 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_static_concrete_pillars)
{
   mapTo = "concrete_pillars";
   diffuseMap[0] = "./concretepier_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./concretepier_normal.dds";
   forestWindEnabled = "1";
   materialTag0 = "props";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
};
