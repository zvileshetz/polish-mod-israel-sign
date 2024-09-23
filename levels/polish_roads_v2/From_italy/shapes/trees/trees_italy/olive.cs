
singleton TSShapeConstructor(OliveDae)
{
   baseShape = "./olive.dae";
};

function OliveDae::onLoad(%this)
{
   %this.addImposter("25", "16", "0", "0", "128", "1", "0");
}
