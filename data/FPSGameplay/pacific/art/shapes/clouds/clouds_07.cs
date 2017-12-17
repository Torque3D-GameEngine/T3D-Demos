//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton TSShapeConstructor(Clouds_07DAE)
{
   baseShape = "./clouds_07.DAE";
   loadLights = "0";
};

function Clouds_07DAE::onLoad(%this)
{
   %this.setMeshType("grouptwo 400", "billboard");
   %this.setObjectNode("grouptwo", "grouptwo400");
   %this.setMeshType("groupthree 400", "billboard");
   %this.setObjectNode("groupthree", "groupthree400");
   %this.setMeshType("groupsix 400", "billboard");
   %this.setObjectNode("groupsix", "groupsix400");
   %this.setMeshType("groupone 400", "billboard");
   %this.setObjectNode("groupone", "groupone400");
   %this.setMeshType("groupfour 400", "billboard");
   %this.setObjectNode("groupfour", "groupfour400");
   %this.setMeshType("groupfive 400", "billboard");
   %this.setObjectNode("groupfive", "groupfive400");
}