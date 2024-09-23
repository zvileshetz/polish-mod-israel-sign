
singleton TSShapeConstructor(Tree_aspen_small_aDae)
{
   baseShape = "./tree_aspen_small_a.dae";
   loadLights = "0";
};

function Tree_aspen_small_aDae::onLoad(%this)
{
   %this.setDetailLevelSize("700", "800");
   %this.setDetailLevelSize("300", "450");
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
