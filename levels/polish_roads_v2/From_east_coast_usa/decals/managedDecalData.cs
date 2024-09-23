// This is the default save location for any Decal datablocks created in the
// Decal Editor (this script is executed from onServerCreated())







datablock DecalData(ind_stuff_02)
{
    size = "6";
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
    size = "5";
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
    fadeStartPixelSize = "60";
    fadeEndPixelSize = "70";
    renderPriority = "31";
};

datablock DecalData(ind_stuff_01)
{
    Material = "ind_decal_stuff_01";
    textureCoordCount = "3";
    size = "2";
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
    frame = "2";
    randomize = "1";
    fadeStartPixelSize = "60";
    fadeEndPixelSize = "70";
    renderPriority = "2";
   size = "2";
};

datablock DecalData(eca_decals_concrete_damage_decal)
{
    size = "2";
    Material = "eca_decals_concrete_damage";
    textureCoordCount = "0";
    fadeStartPixelSize = "80";
    fadeEndPixelSize = "90";
    renderPriority = "1";
};

datablock DecalData(Road_01_damage01)
{
    Material = "road_01_damage_sml_decal_01";
    textureCoordCount = "3";
    size = "2";
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
    renderPriority = "2";
};

datablock DecalData(eca_road_variation_and_damage_decal)
{
    size = "20";
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
    size = "2";
    Material = "nat_decals_rocks_01";
    textureCoordCount = "0";
    fadeStartPixelSize = "50";
    fadeEndPixelSize = "60";
    renderPriority = "1";
};

datablock DecalData(decal_graffiti)
{
    Material = "graffiti";
    textureCoordCount = "15";
    size = "3";
    textureCoords[0] = "0 0 0.25 0.25";
    textureCoords[1] = "0.25 0 0.25 0.25";
    fadeStartPixelSize = "50";
    fadeEndPixelSize = "60";
   frame = "1";
   texRows = "4";
   texCols = "4";
   textureCoords[2] = "0.5 0 0.25 0.25";
   textureCoords[3] = "0.75 0 0.25 0.25";
   textureCoords[4] = "0 0.25 0.25 0.25";
   textureCoords[5] = "0.25 0.25 0.25 0.25";
   textureCoords[6] = "0.5 0.25 0.25 0.25";
   textureCoords[7] = "0.75 0.25 0.25 0.25";
   textureCoords[8] = "0 0.5 0.25 0.25";
   textureCoords[9] = "0.25 0.5 0.25 0.25";
   textureCoords[10] = "0.5 0.5 0.25 0.25";
   textureCoords[11] = "0.75 0.5 0.25 0.25";
   textureCoords[12] = "0 0.75 0.25 0.25";
   textureCoords[13] = "0.25 0.75 0.25 0.25";
   textureCoords[14] = "0.5 0.75 0.25 0.25";
   textureCoords[15] = "0.75 0.75 0.25 0.25";
   renderPriority = "9";
   randomize = "1";
};

datablock DecalData(decal_graffiti_nekkit)
{
    Material = "graffiti_nekkit";
    textureCoordCount = "15";
    size = "3";
    textureCoords[0] = "0 0 0.25 0.25";
    textureCoords[1] = "0.25 0 0.25 0.25";
    fadeStartPixelSize = "50";
    fadeEndPixelSize = "60";
   frame = "1";
   texRows = "4";
   texCols = "4";
   textureCoords[2] = "0.5 0 0.25 0.25";
   textureCoords[3] = "0.75 0 0.25 0.25";
   textureCoords[4] = "0 0.25 0.25 0.25";
   textureCoords[5] = "0.25 0.25 0.25 0.25";
   textureCoords[6] = "0.5 0.25 0.25 0.25";
   textureCoords[7] = "0.75 0.25 0.25 0.25";
   textureCoords[8] = "0 0.5 0.25 0.25";
   textureCoords[9] = "0.25 0.5 0.25 0.25";
   textureCoords[10] = "0.5 0.5 0.25 0.25";
   textureCoords[11] = "0.75 0.5 0.25 0.25";
   textureCoords[12] = "0 0.75 0.25 0.25";
   textureCoords[13] = "0.25 0.75 0.25 0.25";
   textureCoords[14] = "0.5 0.75 0.25 0.25";
   textureCoords[15] = "0.75 0.75 0.25 0.25";
   renderPriority = "9";
   randomize = "1";
};

datablock DecalData(decal_damage)
{
   size = "7";
   Material = "damage";
   fadeStartPixelSize = "2";
   fadeEndPixelSize = "60";
   renderPriority = "11";
   frame = "15";
   randomize = "1";
   textureCoordCount = "15";
   texRows = "4";
   texCols = "4";
   textureCoords[1] = "0.25 0 0.25 0.25";
   textureCoords[2] = "0.5 0 0.25 0.25";
   textureCoords[3] = "0.75 0 0.25 0.25";
   textureCoords[4] = "0 0.25 0.25 0.25";
   textureCoords[5] = "0.25 0.25 0.25 0.25";
   textureCoords[6] = "0.5 0.25 0.25 0.25";
   textureCoords[7] = "0.75 0.25 0.25 0.25";
   textureCoords[8] = "0 0.5 0.25 0.25";
   textureCoords[9] = "0.25 0.5 0.25 0.25";
   textureCoords[10] = "0.5 0.5 0.25 0.25";
   textureCoords[11] = "0.75 0.5 0.25 0.25";
   textureCoords[12] = "0 0.75 0.25 0.25";
   textureCoords[13] = "0.25 0.75 0.25 0.25";
   textureCoords[14] = "0.5 0.75 0.25 0.25";
   textureCoords[15] = "0.75 0.75 0.25 0.25";
   textureCoords[0] = "0 0 0.25 0.25";
};
