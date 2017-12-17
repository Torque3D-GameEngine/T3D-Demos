
singleton Material(hanginglights_cord_mat)
{
   mapTo = "hanginglights_cord";
   diffuseMap[0] = "./hanginglights_diffuse.dds";
};

singleton Material(hanginglights_lights02_DAE_mat_hanginglights_lights)
{
   mapTo = "mat_hanginglights_lights";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   translucent = "1";
   diffuseMap[0] = ".hanginglights_diffuse.dds";
   normalMap[0] = "./hanginglights_normal.dds";
   specularMap[0] = "./hanginglights_specular.dds";
};

singleton Material(hanginglightspost_ColorEffectR6G135B58_material)
{
   mapTo = "ColorEffectR6G135B58-material";
   diffuseColor[0] = "0.0235294 0.529412 0.227451 1";
   specular[0] = "White";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(DefaultMaterial)
{
   mapTo = "hanginglights_diffuse";
   diffuseMap[0] = "./hanginglights_diffuse.dds";
};

singleton Material(DefaultMaterial2)
{
   mapTo = "hanginglightsbulb_diffuse";
   diffuseMap[0] = "./hanginglightsbulb_diffuse.dds";
};
