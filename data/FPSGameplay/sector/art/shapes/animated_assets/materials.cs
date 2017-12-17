
singleton Material(FlyingCars_Full_BlackBus_Mat)
{
	mapTo = "Future_Cars";

	diffuseMap[0] = "./Future_Cars";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 54;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
	castShadows = "0";
};



singleton Material(FlyingCars_Full_glow_mat_02)
{
	mapTo = "Car_Glow";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.294118 0.847059 0.984314 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   glow[0] = "1";
   emissive[0] = "1";
   materialTag0 = "RoadAndPath";
   castShadows = "0";
};