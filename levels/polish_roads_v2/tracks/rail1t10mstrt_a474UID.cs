
singleton TSShapeConstructor(rail1t10mstrt_a474UID_Dae)
{
   baseShape = "./rail1t10mstrt_a474UID.dae";
   adjustCenter = "0";
   adjustFloor = "0";
   loadLights = "0";
};

function rail1t10mstrt_a474UID_Dae::onLoad(%this)
{
   %this.addImposter("399", "6", "0", "0", "128", "0", "0");
   %this.setDetailLevelSize("2", "400");
}
