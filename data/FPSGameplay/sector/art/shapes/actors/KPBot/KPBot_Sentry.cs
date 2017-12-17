//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton TSShapeConstructor(KPBot_Sentry_Dae)
{
   baseShape = "./KPBot_Sentry.dae";
   loadLights = "0";
   unit = "1.36";
};



function KPBot_Sentry_Dae::onLoad(%this)
{
   %this.renameSequence("ambient", "all");
   %this.addSequence("all", "ambient", "1450", "2050"); // sentry idle
}
