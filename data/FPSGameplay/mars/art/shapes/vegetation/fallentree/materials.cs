//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- fallentree.DAE MATERIALS BEGIN ---
singleton Material(fallentree_tex_fallen_tree)
{
	mapTo = "tex_fallen_tree";

	diffuseMap[0] = "./tex_fallen_tree_dif.dds";
	normalMap[0] = "./tex_fallen_tree_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "vegetation";
};

//--- fallentree.DAE MATERIALS END ---

