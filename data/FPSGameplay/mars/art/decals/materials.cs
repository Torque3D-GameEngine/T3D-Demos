
singleton Material(DECAL_sediment_01)
{
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   mapTo = "rBlast.png";
   diffuseMap[0] = "./sediment_decal_01/sediment_decal_01_dif.dds";
   vertColor[ 0 ] = true;
   castShadows = "0";
   normalMap[0] = "./sediment_decal_01/sediment_decal_01_nrm.dds";
   vertColor[0] = "0";
   alphaRef = "127";
   materialTag0 = "Decals";
};

singleton Material(DECAL_leaves_01)
{
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   diffuseMap[0] = "./leaves_twigs_decal/tex_leaves_twigs_dif.dds";
   vertColor[ 0 ] = true;
   castShadows = "0";
   normalMap[0] = "./leaves_twigs_decal/tex_leaves_twigs_nrm.dds";
   vertColor[0] = "0";
   alphaRef = "127";
   materialTag0 = "Decals";
};

singleton Material(DECAL_cliff_rocks_01)
{
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   diffuseMap[0] = "./cliff_decal_01/tex_cliff_decal_dif.dds";
   vertColor[ 0 ] = true;
   castShadows = "0";
   normalMap[0] = "./cliff_decal_01/tex_cliff_decal_nrm.dds";
   vertColor[0] = "0";
   alphaRef = "127";
   materialTag0 = "Decals";
};
