
singleton TSShapeConstructor(Tree_douglasfir_dead_02Dae)
{
   baseShape = "./tree_douglasfir_dead_02.dae";
   loadLights = "0";
};

function Tree_douglasfir_dead_02Dae::onLoad(%this)
{
   %this.setDetailLevelSize("700", "800");
   %this.setDetailLevelSize("400", "500");
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
