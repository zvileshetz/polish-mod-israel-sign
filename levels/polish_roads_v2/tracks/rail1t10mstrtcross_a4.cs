
singleton TSShapeConstructor(Rail1t10mstrtcross_a4Dae)
{
   baseShape = "./rail1t10mstrtcross_a4.dae";
   loadLights = "0";
};

function Rail1t10mstrtcross_a4Dae::onLoad(%this)
{
   %this.addImposter("399", "6", "0", "0", "128", "0", "0");
   %this.setDetailLevelSize("2", "400");
}
