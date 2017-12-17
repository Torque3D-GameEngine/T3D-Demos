//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------

singleton Material(Grasses)
{
   diffuseMap[0] = "./groundcover_diffuse_transparency.png";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "130";
   materialTag0 = "Vegetation";
   translucent = "1";
   translucentZWrite = "1";
   normalMap[0] = "./groundcover_normals.dds";
   specularMap[0] = "./groundcover_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};
