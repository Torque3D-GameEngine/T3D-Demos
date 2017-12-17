
singleton Material(grassyplant_material)
{
   mapTo = "grassyplant";

//   pixelSpecular = true;
//   specular = "1 1 0.75 0.25";
//   specularPower = 50;
      
   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 75;
   
   forestWindEnabled = 1;   
   diffuseMap[0] = "./grassyplant_diffuse_transparency.dds";
   normalMap[0] = "./grassyplant_normals.dds";
   specularPower[0] = "26";
   pixelSpecular[0] = "0";
   materialTag0 = "Vegetation";
   specularMap[0] = "./grassyplant_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";

};

