
// This is the default save location for any ForestBrush(s) created in
// the Forest Editor.
// This script is executed from ForestEditorPlugin::onWorldEditorStartup().

//--- OBJECT WRITE BEGIN ---
new SimGroup(ForestBrushGroup) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new ForestBrush() {
      internalName = "Brush";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "Element2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "tree_oak_sml_b";
         probability = "1";
         rotationRange = "1";
         scaleMin = "0.7";
         scaleMax = "1";
         scaleExponent = "1.5";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "5326";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
   new ForestBrush() {
      internalName = "Brush0";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "Element";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "17";
         rotationRange = "360";
         scaleMin = "0.8";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Element0";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Element1";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
   new ForestBrush() {
      internalName = "Brush1";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "Element3";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "350";
         scaleMin = "1";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
};
//--- OBJECT WRITE END ---
