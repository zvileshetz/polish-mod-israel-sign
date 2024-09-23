
singleton TSShapeConstructor(KontrolaDae)
{
   baseShape = "./kontrola.dae";
};

function KontrolaDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "0", "0");
   %this.setDetailLevelSize("2", "200");
}
