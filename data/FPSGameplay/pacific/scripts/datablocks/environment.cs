
echo("*** LOAD PACICIF DATABLOCK - environment.cs ***");

//-JR
//Pacific Assets
// Electro-Tiki

datablock StaticShapeData( TikiData )
{
   category = "Misc";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/props/electrotiki/electrotiki.DAE";
   isInvincible = true;
};

datablock LightFlareData( TikiLightFlare )
{
   overallScale = 2.0;
   flareEnabled = true;
   flareTexture = "data/FPSGameplay/art/lights/lensFlareSheet1";
   
   elementRect[0] = "0 512 512 512";
   elementDist[0] = 0.0;
   elementScale[0] = 0.5;
   elementTint[0] = "0.5 0.5 0.5 1";
   elementRotate[0] = false;
   elementUseLightColor[0] = false;
   
   elementRect[1] = "512 0 512 512";
   elementDist[1] = 0.0;
   elementScale[1] = 1;
   elementTint[1] = "1 1 1 1";
   elementRotate[1] = false;
   elementUseLightColor[1] = false;
   occlusionRadius = "0.2";
};

function TikiData::onAdd( %this, %obj )
{
   echo( "TikiData::onadd" );
   
   %obj.playThread(0,"ambient");
   
   // This code was causing a crash when exiting from the editor
   // I removed it so we can ship. This will be addressed after
   // 1.1 final - MP
   /*
   %light = new PointLight()
   { 
      radius = 5;
      castShadows = false;
      flareScale = 0.6;
      flareType = "TikiLightFlare";
      isEnabled = false;
   };   

   %obj.mountObject( %light, 0 ); 
   if ( !isObject( DynamicLights ) )
      new SimSet( DynamicLights );     
   DynamicLights.add( %light );*/
}

// String-of-Lights

datablock StaticShapeData( StringOfLightsData )
{
   category = "Misc";
   shapeFile = "data/FPSGameplay/pacific/art/shapes/structures/hanginglights/hanginglights_animatedlights.dts";
   isInvincible = true;
};

datablock LightFlareData( StringOfLightsLightFlare )
{
   overallScale = 2.0;
   flareEnabled = true;
   flareTexture = "data/FPSGameplay/art/lights/lensFlareSheet1";
   
   elementRect[0] = "0 512 512 512";
   elementDist[0] = 0.0;
   elementScale[0] = 0.5;
   elementTint[0] = "0.5 0.5 0.5 1";
   elementRotate[0] = false;
   elementUseLightColor[0] = false;
   
   elementRect[1] = "512 0 512 512";
   elementDist[1] = 0.0;
   elementScale[1] = 1;
   elementTint[1] = "0.4 0.4 0.4 1";
   elementRotate[1] = true;
   elementUseLightColor[1] = true;
   occlusionRadius = "0.2";
};

$hangingLightColors[0] = "0.996078 0.972549 0.662745 1";
$hangingLightColors[1] = "0.996078 0.972549 0.662745 1";
$hangingLightColors[2] = "0.996078 0.972549 0.662745 1";
$hangingLightColors[3] = "0.996078 0.972549 0.662745 1";
$hangingLightColors[4] = "0.996078 0.972549 0.662745 1";

$hangingLightShadows[0] = false;
$hangingLightShadows[1] = false;
$hangingLightShadows[2] = false;
$hangingLightShadows[3] = false;
$hangingLightShadows[4] = false;

function StringOfLightsData::onAdd( %this, %obj )
{
   echo( "StringOfLightsData::onadd" );
   
   %obj.playThread(0,"ambient");
   
   // This code was causing a crash when exiting from the editor
   // I removed it so we can ship. This will be addressed after
   // 1.1 final - MP
   /* This was causing a crash
   for ( %i = 0; %i < 5; %i++ )
   {
      %light = new PointLight()
      { 
         radius = 7;
         brightness = 0.5;
         castShadows = $hangingLightShadows[%i];
         shadowType = "DualParaboloid";
         texSize = 256;
         shadowSoftness = 2;
         priority = 2;
         flareScale = 0.6;
         flareType = "StringOfLightsLightFlare";
         color = $hangingLightColors[%i];   
         isEnabled = false;      
      };   

      %obj.mountObject( %light, %i ); 
      if ( !isObject( DynamicLights ) )
         new SimSet( DynamicLights );     
      DynamicLights.add( %light );
   }*/
}

function Prefab::onLoad( %this, %grp )
{      
   echo( "Prefab::onLoad" );
   
   // Look for any lights in the SimGroup and add them to DynamicLights.
   
   if ( !isObject( DynamicLights ) )
      new SimSet( DynamicLights );     
      
   for ( %i = 0; %i < %grp.getCount(); %i++ )
   {
      %obj = %grp.getObject( %i );  
      if ( %obj.getClassName() $= "PointLight" )
         DynamicLights.add( %obj );  
   }   
}
//-JR
