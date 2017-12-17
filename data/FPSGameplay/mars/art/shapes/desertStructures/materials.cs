//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(Grid)
{
   mapTo = "grid";
   diffuseMap[0] = "./grid";
   normalMap[0] = "./grid_nrm.png";
   cellSize[2] = "0 1060505600";
   specularMap[0] = "./grid.png";
   specular[0] = "0.823529 0.713726 0.352941 1";
   specularPower[0] = "1";
};

singleton Material(Plate)
{
   mapTo = "plate";
   diffuseMap[0] = "./plate";
   normalMap[0] = "./plate_nrm.png";
   cellSize[2] = "0 -1132441856";
   specular[0] = "0.447059 0.698039 0.894118 1";
   specularPower[0] = "9";
   pixelSpecular[0] = "1";
   translucentBlendOp = "None";
   alphaRef = "0";
};

singleton Material(Building01Walls)
{
   mapTo = "building01walls";
   diffuseMap[0] = "./building01walls";
   detailMap[0] = "./detail_concrete.png";
   detailScale[0] = "8 8";
   normalMap[0] = "./building01wallsnorm.jpg";
   detailNormalMap[0] = "./detail_concrete_nm.png";
   detailNormalMapStrength[0] = "1.5";
   cellSize[2] = "0 -1119081216";
   specularPower[0] = "39";
   pixelSpecular[0] = "0";
   specularMap[0] = "./building02walls_s.png";
};

singleton Material(Station02_Building02Walls)
{
   mapTo = "Building02Walls";
   diffuseMap[0] = "./building02walls.png";
   specular[0] = "0.2 0.2 0.2 1";
   specularPower[0] = "43.2193";
   translucentBlendOp = "None";
   detailMap[0] = "./detail_concrete.png";
   normalMap[0] = "./building01wallsnorm.jpg";
   detailNormalMap[0] = "./detail_concrete_nm.png";
   specularMap[0] = "./building02walls_s.png";
   materialTag0 = "RockStructures";
};

