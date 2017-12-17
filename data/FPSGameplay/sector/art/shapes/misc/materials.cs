//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Buildings_Tile.DAE MATERIALS BEGIN ---
singleton Material(Buildings_Tile_CityNormalLayerMat)
{
	mapTo = "CityNormalLayerMat";

	diffuseMap[0] = "./TargetCityColorMap";
	normalMap[0] = "./TargetCityNormalsMap.png";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- Buildings_Tile.DAE MATERIALS END ---

