
echo("*** LOAD PACICIF DATABLOCK - brushes.cs ***");

//--- OBJECT WRITE BEGIN ---
new SimGroup(ForestBrushGroup03) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new ForestBrush() {
      internalName = "Individual Plants";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "seaweed";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "seaweed_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "2";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0.2";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "FernAllSizes";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Fern_Plant";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.3";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "20";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Thintree_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Thintree_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1.2";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "BananaMature";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "BananaMature";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.8";
         scaleMax = "1.1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "rivergrass";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "rivergrass0";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.1";
         scaleMax = "0.9";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "15";
            clumpCountMin = "10";
            clumpRadius = "0.05";
      };
      new ForestBrushElement() {
         internalName = "Big_Leaf";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "BigLeaf_Plant";
         probability = "0.1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1.2";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "30";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "BroadLeaf";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "BroadLeaf";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1.25";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "canopytree_three";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "CanopyTree_03";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "DeadBush_Plant";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "DeadBush_Plant";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "3";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "GRassy_Plant";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "GrassyPlant__Plant";
         probability = "10";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1.7";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "6";
            clumpCountMin = "1";
            clumpRadius = "0";
      };
      new ForestBrushElement() {
         internalName = "LongLeaf_Bush";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "LongLeaf_Bush";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Palm_Bush";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Palm_Bush";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Palm_Tall";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "PalmTree_Tall_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1.25";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Palm_Tall_Leaning";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "TallPalmLeaning";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "PalmTree_Short";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "PalmTree_Short_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Shrub_Small";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Shrub_Large";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.3";
         scaleMax = "0.5";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Shrub_Large";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Shrub_Large_NoCollision";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.8";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "25";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
   };
   new ForestBrush() {
      internalName = "Multi_GeneralGroundCover";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "BroadLeaf";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "BroadLeaf";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Fern_Plant";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Fern_Plant";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "LongLeaf_Bush";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "LongLeaf_Bush";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "ThinTree";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Thintree_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
   new ForestBrush() {
      internalName = "Multi_BeachTrees";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "TallPalmLeaning";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "TallPalmLeaning";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "PalmTree_Tall_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "PalmTree_Tall_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "BananaMature";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "BananaMature";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.7";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "DeadBush_Plant";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "DeadBush_Plant";
         probability = "0.1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "BigLeaf_Plant";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "BigLeaf_Plant";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
   };
   new ForestBrush() {
      internalName = "Multi_CanopyTrees";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "canopytree_one";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "canopytree_one_novines";
         probability = "0.5";
         rotationRange = "360";
         scaleMin = "0.7";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "canopytree_two";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "canopytree_two";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.7";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "canopytree_two_dark";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "canopytree_two_dark";
         probability = "0.5";
         rotationRange = "360";
         scaleMin = "0.7";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "canopytree_two_light";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "canopytree_two_light";
         probability = "0.5";
         rotationRange = "360";
         scaleMin = "0.7";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "canopytree_three";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "canopytree_three";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.7";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
   };
   new ForestBrush() {
      internalName = "Multi_SmallRocks";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "SmallRock_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "30";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "SmallRock_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_02";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "30";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "SmallRock_03";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_03";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.1";
         scaleMax = "0.5";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "30";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "SmallRock_04";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_04";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "30";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "SmallRock_05";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_05";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.1";
         scaleMax = "0.7";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "30";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
   };
   new ForestBrush() {
      internalName = "Multi_SmallRocks2";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "Element";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1";
         scaleExponent = "0.5";
         sinkMin = "0";
         sinkMax = "0.2";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "20";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Element0";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_03";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "2";
         scaleExponent = "0.5";
         sinkMin = "0";
         sinkMax = "0.2";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "20";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Element1";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_05";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.4";
         scaleMax = "1";
         scaleExponent = "0.5";
         sinkMin = "0";
         sinkMax = "0.2";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "20";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
   };
   new ForestBrush() {
      internalName = "Multi_Distant_Mix";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "CanopyTree_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "canopytree_two";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "PalmTree_Tall_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "PalmTree_Tall_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1.25";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "Shrub_Large";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Shrub_Large";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1.5";
         scaleMax = "2";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
   };
   new ForestBrush() {
      internalName = "Multi_Distant_LightDark";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "CanopyTree_02_Light";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "canopytree_two_light";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "CanopyTree_02_Dark";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "canopytree_two_dark";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
   };
   new ForestBrush() {
      internalName = "Multi_SmallRocksUnderwater";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "SmallRock_06";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_06";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "2";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0.2";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "SmallRock_07";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SmallRock_07";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.2";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0.1";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
      new ForestBrushElement() {
         internalName = "SmallRock_08";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.2";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
            clumpCountExponent = "1";
            clumpCountMax = "1";
            clumpCountMin = "1";
            clumpRadius = "10";
      };
   };
};
//--- OBJECT WRITE END ---
