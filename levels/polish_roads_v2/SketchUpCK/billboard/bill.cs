
singleton TSShapeConstructor(BillDae)
{
   baseShape = "./bill.dae";
   loadLights = "0";
};

function BillDae::onLoad(%this)
{
   %this.setMeshSize("Colmesh 2", "-1");
   %this.setDetailLevelSize("2", "200");
   %this.addImposter("25", "6", "0", "0", "128", "0", "0");
}
