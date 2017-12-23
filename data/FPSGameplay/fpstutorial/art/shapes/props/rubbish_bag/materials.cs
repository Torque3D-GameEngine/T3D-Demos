
//--- rub_bag.dae MATERIALS BEGIN ---
singleton Material(rub_bag_rubbishBag)
{
	mapTo = "rubbishBag";

	diffuseMap[0] = "./rubbish_bag_diff_GM.dds";
	normalMap[0] = "./rubbish_bag_norm_GM.dds";
	specularMap[0] = "./rubbish_bag_spec_GM.dds";

	diffuseColor[0] = "0.8 0.8 0.8 0";
	specularPower[0] = 31;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
	materialTag0 = "Untagged";
};

//--- rub_bag.dae MATERIALS END ---

