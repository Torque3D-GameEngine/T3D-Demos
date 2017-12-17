
echo("*** LOAD PACICIF DATABLOCK - managedDecalData.cs ***");

datablock DecalData(LeavesDebris)
{
   Material = "DECAL_leavesdebris";
   textureCoordCount = "0";
   fadeStartPixelSize = "800";
};

datablock DecalData(MossPatch)
{
   Material = "DECAL_moss";
   fadeStartPixelSize = "800";
   textureCoordCount = "0";
};

datablock DecalData(DECAL_sandroadend)
{
   Material = "DECAL_sandroadend_material";
   textureCoordCount = "0";
   renderPriority = "1";
   fadeStartPixelSize = "800";
};

datablock DecalData(WornEarth)
{
   textureCoordCount = "0";
   Material = "DECAL_wornearth";
   fadeStartPixelSize = "800";
};

datablock DecalData(ExposedRock)
{
   textureCoordCount = "0";
   Material = "DECAL_exposedrock";
   fadeStartPixelSize = "800";
};

datablock DecalData(BeachDebris_01)
{
   textureCoordCount = "0";
   Material = "DECAL_beachdebris01";
   fadeStartPixelSize = "800";
};


datablock DecalData(shorerock)
{
   textureCoordCount = "0";
   Material = "DECAL_shorerock01";
   fadeStartPixelSize = "800";
};

datablock DecalData(seaweed)
{
   textureCoordCount = "0";
   Material = "DECAL_seaweed01";
   fadeStartPixelSize = "400";
   fadeEndPixelSize = "50";
   renderPriority = "9";
};

datablock DecalData(cliffcover)
{
   textureCoordCount = "0";
   Material = "DECAL_cliffcover01";
   fadeStartPixelSize = "1000";
   clippingAngle = "90";
};


datablock DecalData(volcanowall)
{
   textureCoordCount = "0";
   Material = "DECAL_volcanowall01";
   fadeStartPixelSize = "1000";
   clippingAngle = "90";
};


datablock DecalData(DirtTrailEnd)
{
   Material = "DecalDirtTrail";
   textureCoordCount = "0";
};
