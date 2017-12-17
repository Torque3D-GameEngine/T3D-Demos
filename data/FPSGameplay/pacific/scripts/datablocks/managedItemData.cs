
echo("*** LOAD PACICIF DATABLOCK - managedItemData.cs ***");

datablock TSForestItemData(BananaMature)
{
   internalName = "BananaMature";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/banana/bananatree_mature.DAE";
   radius = "1";
   trunkBendScale = "0.001";
   branchAmp = "0.04";
   detailAmp = "0.04";
   detailFreq = "0.05";
   windScale = "1";
};

datablock TSForestItemData(CanopyTree_01_wVines)
{
   internalName = "CanopyTree_01_wVines";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/canopy_test/canopytreeY_vines.DAE";
   trunkBendScale = "0.002";
   branchAmp = "0.1";
   detailAmp = "0.05";
   detailFreq = "0.3";
   windScale = "1";
};

datablock TSForestItemData(CanopyTree_01_noVines)
{
   internalName = "CanopyTree_01_noVines";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/canopy_test/canopytreeY_novines.DAE";
   windScale = "1";
};

datablock TSForestItemData(CanopyTree_02)
{
   internalName = "CanopyTree_02";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/canopy_test/canopytree2.DAE";
   trunkBendScale = "0.005";
   branchAmp = "5";
   detailAmp = "1";
   detailFreq = "0.05";
   windScale = "1";
   radius = "0.1";
};

datablock TSForestItemData(CanopyTree_03)
{
   internalName = "CanopyTree_03";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/canopytree_three.DAE";
   trunkBendScale = "0.002";
   branchAmp = "0.01";
   detailAmp = "0.01";
   detailFreq = "0.01";
   rigidity = "30";
   windScale = "1";
};

datablock TSForestItemData(Shrub_Large)
{
   internalName = "Shrub_Large";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/shrub_one.DAE";
   trunkBendScale = "0.001";
   branchAmp = "0.4";
   detailAmp = "0.05";
   detailFreq = "0.02";
   rigidity = "10";
   mass = "0.4";
   dampingCoefficient = "0.7";
   tightnessCoefficient = "0.9";
   windScale = "1";
   radius = "1";
};

datablock TSForestItemData(BigLeaf_Plant)
{
   internalName = "BigLeaf_Plant";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/smallplants/bigleaf/bigleaf.DAE";
   trunkBendScale = "0.003";
   branchAmp = "10";
   detailAmp = "30";
   detailFreq = "0.003";
   radius = "1";
   mass = "0.5";
   rigidity = "2";
   tightnessCoefficient = "2";
   windScale = "1";
   dampingCoefficient = "10";
};

datablock TSForestItemData(BroadLeaf)
{
   internalName = "BroadLeaf";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/smallplants/broadleaf/broadleaf_wskirt.DAE";
   trunkBendScale = "0.006";
   branchAmp = "0";
   detailAmp = "0.04";
   detailFreq = "0.03";
   rigidity = "1";
   tightnessCoefficient = "2";
   mass = "0.1";
   windScale = "1";
};

datablock TSForestItemData(DarkLeaf_Plant)
{
   internalName = "DarkLeaf_Plant";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/smallplants/darkleafbush/darkleafbush.DAE";
   windScale = "1";
   trunkBendScale = "0.03";
   branchAmp = "0.02";
   detailAmp = "0.03";
   detailFreq = "0.05";
   mass = "1";
   rigidity = "5";
};

datablock TSForestItemData(Fern_Plant)
{
   internalName = "Fern_Plant";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/smallplants/fern/fern.DAE";
   trunkBendScale = "0.002";
   branchAmp = "0.1";
   detailAmp = "0.2";
   detailFreq = "0.02";
   radius = "0.5";
   mass = "0.5";
   rigidity = "5";
   tightnessCoefficient = "0.5";
   windScale = "1";
   dampingCoefficient = "5";
};

datablock TSForestItemData(GrassyPlant__Plant)
{
   internalName = "GrassyPlant__Plant";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/smallplants/grassyplant/grassyplant.DAE";
   trunkBendScale = "0.003";
   branchAmp = "0.02";
   detailAmp = "0.12";
   detailFreq = "0.05";
   rigidity = "5";
   tightnessCoefficient = "0.15";
   dampingCoefficient = "1";
   mass = "0.2";
   radius = "0.25";
   windScale = "1";
};

datablock TSForestItemData(DeadBush_Plant)
{
   internalName = "DeadBush_Plant";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/bushes/deadbush/deadbush.dae";
   trunkBendScale = "0.002";
   branchAmp = "0.3";
   detailAmp = "0.8";
   detailFreq = "0.3";
   mass = "0.2";
   rigidity = "5";
   windScale = "1";
   tightnessCoefficient = "0.15";
   dampingCoefficient = "1";
};

datablock TSForestItemData(LongLeaf_Bush)
{
   internalName = "LongLeaf_Bush";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/longleaf/longleaf_plant.DAE";
   branchAmp = "0.02";
   detailAmp = "1";
   detailFreq = "0.015";
   mass = "0.1";
   rigidity = "3";
   trunkBendScale = "0.0005";
   windScale = "1";
   tightnessCoefficient = "1.5";
   dampingCoefficient = "5";
};

datablock TSForestItemData(PalmTree_Tall_01)
{
   internalName = "PalmTree_Tall_01";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/palm/palmtree_tall.DAE";
   trunkBendScale = "0.005";
   branchAmp = "0.2";
   detailAmp = "0.3";
   detailFreq = "0.02";
   radius = "1.5";
   mass = "2";
   rigidity = "10";
   tightnessCoefficient = "2";
   dampingCoefficient = "1";
   windScale = "1";
};

datablock TSForestItemData(PalmTree_Short_01)
{
   internalName = "PalmTree_Short_01";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/palm/palmtree_short.DAE";
   branchAmp = "0.1";
   detailAmp = "0.15";
   detailFreq = "0.04";
   trunkBendScale = "0.001";
   mass = "0.5";
   rigidity = "10";
   tightnessCoefficient = "0.2";
   dampingCoefficient = "4";
   windScale = "1";
};

datablock TSForestItemData(Palm_Bush)
{
   internalName = "Palm_Bush";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/palm/palm_bush.DAE";
   trunkBendScale = "0.01";
   branchAmp = "0.05";
   detailAmp = "0.08";
   detailFreq = "0.03";
   mass = "0.3";
   rigidity = "2";
   tightnessCoefficient = "1";
   windScale = "1";
};

datablock TSForestItemData(Thintree_01)
{
   internalName = "Thintree_01";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/thin/thintree_one.DAE";
   trunkBendScale = "0.001";
   branchAmp = "0.06";
   detailAmp = "0.15";
   detailFreq = "0.05";
   mass = "0.2";
   tightnessCoefficient = "2";
   rigidity = "5";
   dampingCoefficient = "1";
   windScale = "1";
   radius = "0.6";
};

datablock TSForestItemData(SmallRock_01)
{
   internalName = "SmallRock_01";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/rocks/15_smallrockone.DAE";
};

datablock TSForestItemData(SmallRock_02)
{
   internalName = "SmallRock_02";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/rocks/16_smallrocktwo.DAE";
};

datablock TSForestItemData(SmallRock_03)
{
   internalName = "SmallRock_03";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/rocks/17_smallrockthree.DAE";
};

datablock TSForestItemData(SmallRock_04)
{
   internalName = "SmallRock_04";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/rocks/18_smallrockfour.DAE";
};

datablock TSForestItemData(SmallRock_05)
{
   internalName = "SmallRock_05";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/rocks/19_smallrockfive.DAE";
};

datablock TSForestItemData(SmallRock_06)
{
   internalName = "SmallRock_06";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/rocks/20_smallrocksix.DAE";
};

datablock TSForestItemData(SmallRock_07)
{
   internalName = "SmallRock_07";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/rocks/21_smallrockseven.DAE";
};

datablock TSForestItemData(SmallRock_08)
{
   internalName = "SmallRock_08";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/rocks/22_smallrockeight.DAE";
};


datablock TSForestItemData(Grass_01)
{
   internalName = "Grass_01";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/grass_mesh/grassmesh01.dts";
   collidable = "0";
};

datablock TSForestItemData(GrassClump_Dry2m)
{
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/grass_mesh/drygrass_2m.DAE";
   internalName = "GrassClump_Dry2m";
   collidable = "0";
};


datablock TSForestItemData(TallPalmLeaning)
{
   internalName = "TallPalmLeaning";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/palm/palmtree_tall_leaning.DAE";
   trunkBendScale = "0.005";
   branchAmp = "0.02";
   detailAmp = "0.08";
   detailFreq = "0.15";
   mass = "2";
   tightnessCoefficient = "2";
   dampingCoefficient = "1";
   windScale = "1";
};

datablock TSForestItemData(defaulttree)
{
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/defaulttree/defaulttree.DAE";
   internalName = "defaulttree";
   trunkBendScale = "0.02";
   branchAmp = "0.05";
   detailAmp = "0.1";
   detailFreq = "0.2";
   mass = "5";
   rigidity = "20";
   dampingCoefficient = "0.2";
   tightnessCoefficient = "4";
   windScale = "1";
};

datablock TSForestItemData(rivergrass0)
{
   internalName = "rivergrass0";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/smallplants/rivergrass/rivergrass.DAE";
   collidable = "0";
   rigidity = "1";
   windScale = "0.1";
   branchAmp = "1";
   detailAmp = "3";
   detailFreq = "0.05";
   radius = "0.1";
};

datablock TSForestItemData(canopytree_one_novines)
{
   internalName = "canopytree_one_novines";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/canopytree_one_novines.DAE";
   windScale = "1";
   branchAmp = "0.03";
   detailAmp = "0.05";
   detailFreq = "0.1";
   rigidity = "20";
   trunkBendScale = "0.005";
   radius = "1";
};

datablock TSForestItemData(canopytree_two_dark)
{
   internalName = "canopytree_two_dark";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/canopytree_two_dark.DAE";
   windScale = "1";
   trunkBendScale = "0.005";
   branchAmp = "0.03";
   detailAmp = "0.04";
   detailFreq = "0.04";
   radius = "1";
};

datablock TSForestItemData(canopytree_two_light)
{
   internalName = "canopytree_two_light";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/canopytree_two_light.DAE";
   windScale = "1";
   trunkBendScale = "0.005";
   branchAmp = "0.03";
   detailAmp = "0.04";
   detailFreq = "0.04";
   radius = "1";
};

datablock TSForestItemData(canopytree_two)
{
   internalName = "canopytree_two";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/canopytree_two.DAE";
   windScale = "1";
   trunkBendScale = "0.005";
   branchAmp = "0.03";
   detailAmp = "0.07";
   detailFreq = "0.02";
   radius = "1";
};

datablock TSForestItemData(canopytree_one_wvines)
{
   internalName = "canopytree_one_wvines";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/canopytree_one_wvines.DAE";
   windScale = "0.2";
   trunkBendScale = "0.01";
   branchAmp = "0.2";
   detailAmp = "0.5";
   detailFreq = "0.05";
   rigidity = "20";
};

datablock TSForestItemData(canopytree_three)
{
   internalName = "canopytree_three";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/canopytree_three.DAE";
   windScale = "1";
   trunkBendScale = "0.005";
   branchAmp = "0.03";
   detailAmp = "0.01";
   detailFreq = "0.01";
   radius = "1";
};

datablock TSForestItemData(palm_bush2)
{
   internalName = "palm_bush2";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/palm/palm_bush.DAE";
   windScale = "1";
   trunkBendScale = "0.01";
   branchAmp = "0.06";
   detailAmp = "0.1";
   detailFreq = "0.2";
};

datablock TSForestItemData(Shrub_Large_NoCollision)
{
   internalName = "Shrub_Large_NoCollision";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/trees/canopy/shrub_one.DAE";
   collidable = "0";
   radius = "0.5";
   mass = "0.5";
   rigidity = "20";
   tightnessCoefficient = "0.9";
   dampingCoefficient = "0.7";
   windScale = "1";
   trunkBendScale = "0.001";
   branchAmp = "0.4";
   detailAmp = "0.5";
   detailFreq = "0.01";
};

datablock TSForestItemData(seaweed_01)
{
   internalName = "seaweed_01";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/vegetation/smallplants/seaweed/seaweed_01.DAE";
   windScale = "1";
   trunkBendScale = "0.01";
   branchAmp = "0.1";
   detailAmp = "0.8";
   detailFreq = "0.007";
};
