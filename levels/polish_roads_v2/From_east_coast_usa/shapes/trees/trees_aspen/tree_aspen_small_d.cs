
singleton TSShapeConstructor(Tree_aspen_small_dDae)
{
   baseShape = "./tree_aspen_small_d.dae";
   loadLights = "0";
};

function Tree_aspen_small_dDae::onLoad(%this)
{
   %this.setDetailLevelSize("600", "900");
   %this.setDetailLevelSize("300", "450");
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
