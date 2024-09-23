
singleton TSShapeConstructor(Rail1t100mstrt_a474UIDae)
{
   baseShape = "./rail1t100mstrt_a474UI.dae";
   adjustCenter = "0";
   adjustFloor = "0";
   loadLights = "0";
};

function Rail1t100mstrt_a474UIDae::onLoad(%this)
{
   %this.addImposter("399", "8", "0", "0", "128", "0", "0");
   %this.setDetailLevelSize("2", "400");
}
