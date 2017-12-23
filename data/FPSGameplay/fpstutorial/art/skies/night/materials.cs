

singleton CubemapData( CTNightSkyCubemap )
{
   cubeFace[0] = "./ct_night_skybox_3.dds";
   cubeFace[1] = "./ct_night_skybox_4.dds";
   cubeFace[2] = "./ct_night_skybox_2.dds";
   cubeFace[3] = "./ct_night_skybox_1.dds";
   cubeFace[4] = "./ct_night_skybox_5.dds";
   cubeFace[5] = "./ct_night_skybox_6.dds";
};

singleton Material( CTnightTime )
{
   cubemap = CTNightSkyCubemap;
   materialTag0 = "skies";
   constantCubemapGloss = "0.2";
};
