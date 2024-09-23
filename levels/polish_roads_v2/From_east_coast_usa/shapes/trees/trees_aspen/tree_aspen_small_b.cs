
singleton TSShapeConstructor(Tree_aspen_small_bDae)
{
   baseShape = "./tree_aspen_small_b.dae";
   loadLights = "0";
};

function Tree_aspen_small_bDae::onLoad(%this)
{
   %this.setDetailLevelSize("600", "700");
   %this.setDetailLevelSize("300", "400");
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
