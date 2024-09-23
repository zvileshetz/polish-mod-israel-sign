
singleton TSShapeConstructor(Tree_douglasfir_large_dDae)
{
   baseShape = "./tree_douglasfir_large_d.dae";
   loadLights = "0";
};

function Tree_douglasfir_large_dDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
   %this.setDetailLevelSize("1200", "1500");
   %this.setDetailLevelSize("800", "600");
   %this.setDetailLevelSize("1600", "2500");
}
