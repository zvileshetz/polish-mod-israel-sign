
singleton TSShapeConstructor(PomnikDae)
{
   baseShape = "./pomnik.dae";
   loadLights = "0";
};

function PomnikDae::onLoad(%this)
{
   %this.addImposter("25", "6", "0", "0", "128", "0", "0");
   %this.setDetailLevelSize("2", "50");
}
