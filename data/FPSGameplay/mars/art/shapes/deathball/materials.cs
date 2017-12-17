//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

new Material(ballofdeath_dif)
{
   mapTo = "ballofdeath_dif";
   baseTex[0] = "./ballofdeath_dif.jpg";
   bumpTex[0] = "./ballofdeath_nrm.png";
   pixelSpecular[0] = true;
   specular[0] = "0.5 0.5 0.5 0.5";
   specularPower[0] = 0.3;
};

new Material(ballofdeath_glw1)
{
   mapTo = "ballofdeath_glw1";
   baseTex[0] = "./ballofdeath_glw1.png";
   translucent[0] = true;
   emissive[0] = true;
   glow[0] = true;
};

new Material(ballofdeath_glw2)
{
   mapTo = "ballofdeath_glw2";
   baseTex[0] = "./ballofdeath_glw2.png";
   translucent[0] = true;
   emissive[0] = true;
   glow[0] = true;
};

