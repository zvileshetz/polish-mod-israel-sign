
singleton TSShapeConstructor(Tree_douglasfir_large_bDae)
{
   baseShape = "./tree_douglasfir_large_b.dae";
   loadLights = "0";
};

function Tree_douglasfir_large_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
   %this.setDetailLevelSize("1300", "1900");
   %this.setDetailLevelSize("800", "1400");
   %this.setDetailLevelSize("400", "700");
}
