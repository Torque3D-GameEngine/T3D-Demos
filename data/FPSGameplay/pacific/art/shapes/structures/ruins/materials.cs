
singleton Material(shrine_bridge_tex_shrine)
{
   mapTo = "tex_shrine";
   diffuseMap[0] = "./tex_temple_ruins_dif.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "LerpAlpha";
   alphaTest = "1";
   alphaRef = "170";
};

singleton Material(shrine_stage_tex_shrine_detail)
{
   mapTo = "tex_shrine_detail";
   diffuseMap[0] = "./tex_temple_ruins_detail_dif.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
