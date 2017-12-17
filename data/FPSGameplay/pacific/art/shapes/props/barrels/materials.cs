//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------

singleton Material(barrel_black)
{
   mapTo = "barrel_black";  
   baseTex[0] = "";
   bumpTex[0] = "";

   detailTex[0] = "";
   detailScale[0] = "11 16";
// detail scale = horizrepeat vertrepeat
//   detailBumpMap[0] = true;

   pixelSpecular = 0;
   specular = "1 1 1 0";
   specularPower = 6;
   diffuseMap[0] = "./barreblack_diffuse_transparency.dds";
   detailMap[0] = "";
   normalMap[0] = "./barreblack_normal_specular.dds";
   materialTag0 = "props";
   detailNormalMap[0] = "./barrel_detailnormal.dds";
   specularMap[0] = "./barreblack_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";

};
