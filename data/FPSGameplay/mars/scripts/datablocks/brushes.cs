
echo("*** LOAD MARS DATABLOCK - brushes.cs ***");

new SimGroup(ForestBrushGroup02)
{
    canSave = 1;
    canSaveDynamicFields = 1;

    new ForestBrushElement(){
        internalName = "deserttree";
        canSave = 1;
        canSaveDynamicFields = 1;
        ForestItemData = "deserttree";
        probability = 1;
        rotationRange = 360;
        scaleMin = 0.5;
        scaleMax = 1.4;
        scaleExponent = 1;
        sinkMin = 0;
        sinkMax = 0;
        sinkRadius = 1;
        slopeMin = 0;
        slopeMax = 90;
        elevationMin = -10000;
        elevationMax = 10000;
    };
    new ForestBrushElement(){
        internalName = "deadbush2";
        canSave = 1;
        canSaveDynamicFields = 1;
        ForestItemData = "deadbush2";
        probability = 1;
        rotationRange = 360;
        scaleMin = 0.8;
        scaleMax = 1.3;
        scaleExponent = 1;
        sinkMin = 0;
        sinkMax = 0;
        sinkRadius = 1;
        slopeMin = 0;
        slopeMax = 90;
        elevationMin = -10000;
        elevationMax = 10000;
    };
    new ForestBrush(){
        internalName = "Rocks";
        canSave = 1;
        canSaveDynamicFields = 1;
        new ForestBrushElement("")
        {
            internalName = "half_rock_1";
            canSave = 1;
            canSaveDynamicFields = 1;
            ForestItemData = "smallrock_01";
            probability = 0.2;
            rotationRange = 360;
            scaleMin = 0.04;
            scaleMax = 0.2;
            scaleExponent = 1;
            sinkMin = 1;
            sinkMax = 2;
            sinkRadius = 1;
            slopeMin = 0;
            slopeMax = 90;
            elevationMin = -10000;
            elevationMax = 10000;
        };
        new ForestBrushElement(){
            internalName = "quarter_rock_1";
            canSave = 1;
            canSaveDynamicFields = 1;
            ForestItemData = "smallrock_02";
            probability = 0.2;
            rotationRange = 360;
            scaleMin = 0.05;
            scaleMax = 0.4;
            scaleExponent = 1;
            sinkMin = 1;
            sinkMax = 2;
            sinkRadius = 1;
            slopeMin = 0;
            slopeMax = 90;
            elevationMin = -10000;
            elevationMax = 10000;
        };
    };
    new ForestBrushElement(){
        internalName = "longleaf_plant";
        canSave = 1;
        canSaveDynamicFields = 1;
        ForestItemData = "longleaf_plant";
        probability = 1;
        rotationRange = 360;
        scaleMin = 0.9;
        scaleMax = 1.4;
        scaleExponent = 1;
        sinkMin = 0;
        sinkMax = 0;
        sinkRadius = 1;
        slopeMin = 0;
        slopeMax = 90;
        elevationMin = -10000;
        elevationMax = 10000;
    };
    new ForestBrushElement(){
        internalName = "agaveplant";
        canSave = 1;
        canSaveDynamicFields = 1;
        ForestItemData = "agaveplant";
        probability = 1;
        rotationRange = 360;
        scaleMin = 0.9;
        scaleMax = 1.7;
        scaleExponent = 2;
        sinkMin = 0;
        sinkMax = 0.1;
        sinkRadius = 1;
        slopeMin = 0;
        slopeMax = 90;
        elevationMin = -10000;
        elevationMax = 10000;
    };
    new ForestBrushElement(){
        internalName = "fallentree";
        canSave = 1;
        canSaveDynamicFields = 1;
        ForestItemData = "fallentree";
        probability = 1;
        rotationRange = 360;
        scaleMin = 0.1;
        scaleMax = 0.4;
        scaleExponent = 2;
        sinkMin = 0;
        sinkMax = 0;
        sinkRadius = 1;
        slopeMin = 0;
        slopeMax = 90;
        elevationMin = -10000;
        elevationMax = 10000;
    };
};

