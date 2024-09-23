
singleton TSShapeConstructor(RoadworkDae)
{
   baseShape = "./roadwork.dae";
};

function RoadworkDae::onLoad(%this)
{
   %this.addImposter("25", "6", "0", "0", "128", "0", "0");
   %this.setDetailLevelSize("2", "200");
}
