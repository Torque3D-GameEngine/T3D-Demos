//--- lavafall.DAE MATERIALS BEGIN ---
singleton Material(lavafall)
{
	mapTo = "lavafall";

	diffuseMap[0] = "./lava.png";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.588235 0.588235 0.588235 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "0 -0.14";
   scrollSpeed[0] = "1.882";
   emissive[0] = "1";
   glow[0] = "1";
   vertColor[0] = "1";
   materialTag0 = "lavafall";
};

//--- lavafall.DAE MATERIALS END ---


