
singleton Material(DECAL_leavesdebris)
{

//   pixelSpecular = true;
//   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
//   specularPower = 12;

   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 30;
   mapTo = "leavesdebris_diffuse_transparency.png";
   diffuseMap[0] = "./leaves_debris/leavesdebris_diffuse_transparency.png";
   normalMap[0] = "./leaves_debris/leavesdebris_normal_specular.png";
   materialTag0 = "decal";
   vertColor[0] = "1";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
};


singleton Material(DECAL_moss)
{
   baseTex[0] = "";
   bumpTex[0] = "";

//   pixelSpecular = true;
//   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
//   specularPower = 12;

   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
   alphaTest = 0;
   alphaRef = 84;
   mapTo = "moss_diffuse_transparency.png";
   diffuseMap[0] = "./moss/moss_diffuse_transparency.dds";
   normalMap[0] = "./moss/moss_normal.dds";
   materialTag0 = "decal";
   castShadows = "0";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   specularPower[0] = "1";
   specularMap[0] = "./moss/moss_specular.dds";
   vertColor[0] = "1";
};

singleton Material(DECAL_wornearth)
{
   baseTex[0] = "";
//   bumpTex[0] = "./shore_debris/shoredebris_normal_specular.png";

//   pixelSpecular = true;
//   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
//   specularPower = 12;

   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "wornearth_diffuse_transparency";
   diffuseMap[0] = "./worn_earth/wornearth_diffuse_transparency.dds";
   materialTag0 = "decal";
   normalMap[0] = "./worn_earth/wornearth_normal_specularity.dds";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";

   useAnisotropic[0] = true;
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   vertColor[0] = "1";
};

singleton Material(DECAL_exposedrock)
{
   diffuseMap[0] = "./exposed_rock/exposedrock_diffuse_transparency.dds";
   normalMap[0] = "./exposed_rock/exposedrock_normals_specularity.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "exposedrock_diffuse_transparency";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "0";

   useAnisotropic[0] = true;
   specularMap[0] = "./exposed_rock/exposedrock_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   vertColor[0] = "1";
};

singleton Material(DECAL_beachdebris01)
{
   diffuseMap[0] = "./beach_debris/beachdebris_01_diffuse_transparency.dds";
   normalMap[0] = "./beach_debris/beachdebris01_normals.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "beachdebris_01_diffuse_transparency";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "1";

   useAnisotropic[0] = true;
   vertColor[0] = "1";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
};



singleton Material(DECAL_shorerock01)
{
   diffuseMap[0] = "./shore_rock/seaweed_rock_dif.dds";
   normalMap[0] = "./shore_rock/seaweed_rock_nrm.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "seaweed_rock_dif";

   materialTag0 = "decal";
   specularPower[0] = "71";
   pixelSpecular[0] = "0";

   useAnisotropic[0] = true;
   specularMap[0] = "./shore_rock/seaweed_rock_spc.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   vertColor[0] = "1";
};

singleton Material(DECAL_seaweed01)
{
   diffuseMap[0] = "./seaweed/seaweed_01_dif.dds";
   normalMap[0] = "./seaweed/seaweed_01_nrm.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "seaweed_01_dif";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "1";

   useAnisotropic[0] = true;
   vertColor[0] = "1";
};

singleton Material(DECAL_cliffcover01)
{
   diffuseMap[0] = "./cliffcover/cliff_cover_dif.dds";
   normalMap[0] = "./cliffcover/cliff_cover_nrm.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "cliff_cover_dif";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "0";

   useAnisotropic[0] = true;
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   vertColor[0] = "1";
};

singleton Material(DECAL_volcanowall01)
{
   diffuseMap[0] = "./volcano_wall/volcano_wall_dif.dds";
   normalMap[0] = "./volcano_wall/volcano_wall_nrm.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "volcano_wall_dif";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "0";

   useAnisotropic[0] = true;
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   vertColor[0] = "1";
};

singleton Material(DECAL_rockface_one_transparency)
{
   mapTo = "rockface_one_diffuse_transparency";
   diffuseMap[0] = "../red.png";
   normalMap[0] = "../red.png";
   translucent = "1";
   materialTag0 = "decal";
};


singleton Material(DecalDirtTrail)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "./dirt_trail_end/dirt_trail_end_dif.dds";
   castShadows = "0";
   translucent = "1";
   translucentZWrite = "1";
   materialTag0 = "decal";
};

singleton Material(DECAL_sandroadend_material)
{
   mapTo = "sandroadend_diffuse_transparency";
   diffuseMap[0] = "./sandroad_end/sandroadend_diffuse_transparency.dds";
   castShadows = "0";
   translucent = "1";
   translucentZWrite = "1";
   materialTag0 = "decal";
};


