//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton TSShapeConstructor(KPBotDae)
{
   baseShape = "./KPBot.dae";
   loadLights = "0";
   unit = "1.20";
};



function KPBotDae::onLoad(%this)
{
   %this.renameSequence("ambient", "all");
   %this.addSequence("all", "root", "115", "715");
   %this.addSequence("all", "run", "2", "28");
   %this.addSequence("all", "back", "40", "65");
   %this.addSequence("all", "side", "80", "95");
   //%this.addSequence("all", "back", "0", "26"); // Run Back
   //%this.addSequence("all", "side", "0", "26"); // Strafe right (plays in reverse for left)
   %this.addSequence("all", "jump", "2100", "2110"); // Jump
   %this.setSequenceCyclic("jump", "0");
   %this.addSequence("all", "fall", "2130", "2140"); // Fall
   %this.addSequence("all", "land", "2170", "2180"); // Land
   %this.setSequenceCyclic("land", "0");
   //%this.addSequence("all", "standjump", "0", "26"); // Strafe
   //%this.addSequence("all", "look", "0", "26"); // aiming & looking from up to down
   //%this.setSequenceBlend("look", "1", "root", "0"); // 'look' sequence must be set to blend
   %this.addSequence("all", "SentryIdle", "1450", "2050"); // custom
   %this.addSequence("all", "RobotDance", "2300", "2814"); //custom
   %this.addsequence("RobotDance", "ambient");
}
