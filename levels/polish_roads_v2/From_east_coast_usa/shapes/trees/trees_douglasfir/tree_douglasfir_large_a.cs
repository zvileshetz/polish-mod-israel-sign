
singleton TSShapeConstructor(Tree_douglasfir_large_aDae)
{
   baseShape = "./tree_douglasfir_large_a.dae";
   loadLights = "0";
};

function Tree_douglasfir_large_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
   %this.setDetailLevelSize("2000", "2500");
   %this.setDetailLevelSize("1500", "1700");
}
