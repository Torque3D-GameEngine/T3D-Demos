
singleton CubemapData( GoldenHourCloudySkyCubeMap )
{
   cubeFace[0] = "./GoldenHourCloudySky_1";
   cubeFace[1] = "./GoldenHourCloudySky_2";
   cubeFace[2] = "./GoldenHourCloudySky_3";
   cubeFace[3] = "./GoldenHourCloudySky_4";
   cubeFace[4] = "./GoldenHourCloudySky_5";
   cubeFace[5] = "./GoldenHourCloudySky_6";
};

singleton Material( GoldenHourCloudySkyMat )
{
   cubemap = GoldenHourCloudySkyCubeMap;
};
