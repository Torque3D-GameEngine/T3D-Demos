//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(groundcover_grass)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "./tex_grass_01_dif.dds";
   normalMap[0] = "./tex_grass_01_nrm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   materialTag0 = "Vegetation";
   translucent = "1";
   translucentZWrite = "0";
   castShadows = "0";
   translucentBlendOp = "None";
};
