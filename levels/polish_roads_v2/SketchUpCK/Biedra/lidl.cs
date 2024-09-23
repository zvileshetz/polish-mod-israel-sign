
singleton TSShapeConstructor(BiedraDae)
{
   baseShape = "./biedra.dae";
   loadLights = "0";
};

function LidlDae::onLoad(%this)
{
   %this.addImposter("25", "6", "0", "0", "128", "0", "0");
   %this.setDetailLevelSize("2", "1000");
}
