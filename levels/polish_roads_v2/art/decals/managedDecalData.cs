// This is the default save location for any Decal datablocks created in the
// Decal Editor (this script is executed from onServerCreated())


datablock DecalData(Road_01_d)
{
    Material = "Road_01_decal";
    randomize = "1";
    texCols = "1";
    textureCoords[0] = "0 0 1 1";
    textureCoords[1] = "0 0.5 1 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    textureCoordCount = "0";
    fadeStartPixelSize = "80";
    fadeEndPixelSize = "90";
    renderPriority = "120";
};

datablock DecalData(Asphalt_road_01)
{
    Material = "BNG_Asphalt_decal";
    randomize = "1";
    texCols = "1";
    textureCoords[0] = "0 0 1 1";
    textureCoords[1] = "0.5 0.5 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    textureCoordCount = "0";
    fadeStartPixelSize = "70";
    fadeEndPixelSize = "80";
    size = "5.5";
    renderPriority = "160";
};

datablock DecalData(Asphalt_road_01)
{
    Material = "BNG_Asphalt_decal";
    texRows = "1";
    textureCoords[0] = "0 0 1 1";
    textureCoords[1] = "0.5 0.5 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    randomize = "1";
    textureCoordCount = "0";
    size = "5.5";
};

datablock DecalData(Road_02_d)
{
    Material = "BNG_Road_02_decal";
    textureCoordCount = "0";
    size = "10";
    randomize = "0";
    texRows = "1";
    texCols = "1";
    textureCoords[0] = "0 0 1 1";
    textureCoords[1] = "0 0 1 1";
    textureCoords[2] = "0 0 1 1";
    textureCoords[3] = "0 0 1 1";
    textureCoords[5] = "0 0 1 1";
    fadeStartPixelSize = "70";
    fadeEndPixelSize = "80";
    renderPriority = "130";
};

datablock DecalData(Road_03_coast_decal)
{
    Material = "Road_Dirt_Coastal_Decal";
    textureCoordCount = "0";
    texRows = "1";
    texCols = "1";
    textureCoords[1] = "0 0 1 1";
    textureCoords[2] = "0 0 1 1";
    textureCoords[3] = "0 0 1 1";
    textureCoords[0] = "0 0 1 1";
    frame = "0";
    randomize = "0";
    fadeStartPixelSize = "70";
    fadeEndPixelSize = "80";
    renderPriority = "140";
};

datablock DecalData(AsphaltRoad_lanes_d)
{
    Material = "AsphaltRoad_lanes_decal";
    textureCoordCount = "0";
    renderPriority = "170";
    fadeStartPixelSize = "80";
    fadeEndPixelSize = "90";
    size = "8.5";
};

datablock DecalData(AsphaltRoad_track_d)
{
    Material = "AsphaltRoad_track_decal";
    textureCoordCount = "0";
    size = "12";
    fadeStartPixelSize = "80";
    fadeEndPixelSize = "90";
    renderPriority = "180";
};

datablock DecalData(AsphaltRoad_track_d)
{
    size = "12";
    Material = "AsphaltRoad_track_decal";
    textureCoordCount = "0";
    fadeStartPixelSize = "50";
    fadeEndPixelSize = "60";
};

datablock DecalData(ind_stuff_02)
{
    size = "10";
    Material = "ind_decal_stuff_02";
    textureCoordCount = "0";
    renderPriority = "30";
    fadeStartPixelSize = "60";
    fadeEndPixelSize = "70";
};

datablock DecalData(ind_stuff_02b)
{
    Material = "ind_decal_stuff_02b";
    textureCoordCount = "0";
    size = "11";
    textureCoords[1] = "0.5 0.5 0.5 0.5";
    textureCoords[2] = "0.666667 0.666667 0.333333 0.333333";
    textureCoords[3] = "0 0.5 0.333333 0.5";
    textureCoords[4] = "0.333333 0.5 0.333333 0.5";
    textureCoords[5] = "0.666667 0.5 0.333333 0.5";
    textureCoords[6] = "0 0.666667 0.333333 0.333333";
    textureCoords[7] = "0.333333 0.666667 0.333333 0.333333";
    textureCoords[8] = "0.666667 0.666667 0.333333 0.333333";
    textureCoords[13] = "0.333333 0.8 0.333333 0.2";
    textureCoords[14] = "0.666667 0.8 0.333333 0.2";
    fadeStartPixelSize = "60.0999985";
    fadeEndPixelSize = "70";
    renderPriority = "29";
   clippingAngle = "333";
   order_simset = "745829744";
};

datablock DecalData(ind_stuff_01)
{
    Material = "ind_decal_stuff_01";
    textureCoordCount = "3";
    size = "1";
    randomize = "1";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    textureCoords[5] = "0 0 1 15";
    fadeStartPixelSize = "60";
    fadeEndPixelSize = "70";
    renderPriority = "32";
};

datablock DecalData(sawdust_d)
{
    Material = "sawdust";
    size = "4";
    textureCoordCount = "0";
    fadeStartPixelSize = "80";
    fadeEndPixelSize = "90";
    renderPriority = "60";
};

datablock DecalData(AsphaltRoad_damage_large_decal_01d)
{
    Material = "AsphaltRoad_damage_large_decal_01";
    textureCoordCount = "3";
    texRows = "2";
    texCols = "2";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    textureCoords[0] = "0 0 0.5 0.5";
    frame = "5";
    randomize = "1";
    fadeStartPixelSize = "60";
    fadeEndPixelSize = "70";
    renderPriority = "71";
};

datablock DecalData(AsphaltRoad_damage_large_decal_02d)
{
    Material = "AsphaltRoad_damage_large_decal_02";
    textureCoordCount = "3";
    size = "4.7";
    randomize = "1";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    textureCoords[5] = "0 0 1 15";
    fadeStartPixelSize = "70";
    fadeEndPixelSize = "80";
    renderPriority = "70";
};

datablock DecalData(AsphaltRoad_damage_large_decal_03d)
{
    Material = "AsphaltRoad_damage_large_decal_03";
    textureCoordCount = "3";
    size = "4.8";
    randomize = "1";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    textureCoords[5] = "0 0 1 15";
    fadeStartPixelSize = "35";
    fadeEndPixelSize = "40";
    renderPriority = "72";
};

datablock DecalData(eca_decals_concrete_damage_decal)
{
    size = "8.5";
    Material = "eca_decals_concrete_damage";
    textureCoordCount = "0";
    fadeStartPixelSize = "80";
    fadeEndPixelSize = "90";
    renderPriority = "60";
};

datablock DecalData(Asphalt_road_02_Cracks)
{
    Material = "Asphalt_road_01_decal2";
    textureCoordCount = "0";
    size = "5";
    fadeStartPixelSize = "50";
    fadeEndPixelSize = "60";
    renderPriority = "150";
};

datablock DecalData(Road_01_damage01)
{
    Material = "road_01_damage_sml_decal_01";
    textureCoordCount = "3";
    size = "2.2";
    fadeStartPixelSize = "50";
    fadeEndPixelSize = "60";
    frame = "1";
    randomize = "1";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    renderPriority = "110";
};

datablock DecalData(AsphaltRoad_damage_sml_decal_01d)
{
    Material = "AsphaltRoad_damage_sml_decal_01";
    textureCoordCount = "3";
    size = "2";
    randomize = "1";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    fadeStartPixelSize = "45";
    fadeEndPixelSize = "50";
};

datablock DecalData(AsphaltRoad_TireTracks_01d)
{
    Material = "AsphaltRoad_TireTracks_decal";
    textureCoordCount = "3";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    size = "20";
    frame = "3";
    fadeStartPixelSize = "120";
    fadeEndPixelSize = "130";
    renderPriority = "80";
};

datablock DecalData(road_01_tracks_large_decal_01d)
{
    Material = "Road_01_tracks_large_decal_01";
    textureCoordCount = "3";
    randomize = "0";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    size = "15";
    frame = "3";
    fadeStartPixelSize = "150";
    fadeEndPixelSize = "160";
    renderPriority = "40";
};

datablock DecalData(eca_road_variation_and_damage_decal)
{
    size = "38";
    Material = "eca_road_variation_and_damage";
    textureCoordCount = "0";
    fadeStartPixelSize = "220";
    fadeEndPixelSize = "230";
    renderPriority = "50";
};

datablock DecalData(nat_decals_fallen_leaves_01_decal)
{
    size = "4";
    Material = "nat_decals_fallen_leaves";
    textureCoordCount = "0";
    fadeStartPixelSize = "70";
    fadeEndPixelSize = "80";
    renderPriority = "20";
};

datablock DecalData(nat_decals_rocks_01_decal)
{
    size = "8";
    Material = "nat_decals_rocks_01";
    textureCoordCount = "0";
    fadeStartPixelSize = "50";
    fadeEndPixelSize = "60";
    renderPriority = "10";
};

singleton DecalData(NewTemplate)
{
   material = "WarningMaterial";
   order_simset = "808209999";
};

singleton DecalData(test_QA)
{
   material = "WarningMaterial";
   order_simset = "808209999";
   textureCoordCount = "0";
};

singleton DecalData(NewTemplate3)
{
   material = "WarningMaterial";
   order_simset = "745829744";
};

singleton DecalData(NewTemplate4)
{
   material = "WarningMaterial";
   order_simset = "745829744";
};

singleton DecalData(NewTemplate5)
{
   material = "WarningMaterial";
   order_simset = "745829744";
};

singleton DecalData(NewTemplate6)
{
   material = "WarningMaterial";
   order_simset = "745829744";
};

singleton DecalData(NewTemplate7)
{
   material = "WarningMaterial";
};

singleton DecalData(NewTemplate8)
{
   material = "WarningMaterial";
   order_simset = "0";
};
