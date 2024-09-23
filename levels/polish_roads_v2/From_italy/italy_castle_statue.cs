
singleton TSShapeConstructor(Italy_castle_statueDae)
{
   baseShape = "./italy_castle_statue.dae";
};

function Italy_castle_statueDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "32", "1", "0");
}
