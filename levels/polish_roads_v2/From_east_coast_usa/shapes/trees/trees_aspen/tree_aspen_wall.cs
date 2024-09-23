
singleton TSShapeConstructor(Tree_aspen_wallDae)
{
   baseShape = "./tree_aspen_wall.dae";
   loadLights = "0";
};

function Tree_aspen_wallDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
   %this.setDetailLevelSize("1900", "1800");
}
