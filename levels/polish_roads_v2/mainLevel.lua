local M = {}

--If you reload Lua with CTRL+L use thise in the GE console ` extensions["/levels/polish_roads_V2/mainLevel"].onClientStartMission() `

local speedLimit = 57 /3.6 --50kph converted to ms
local light = nil
local isOn = false
local timer = 0.2
local lastValue = nil

local function onClientStartMission()
  light = scenetree.findObject('fotolamp')
end

local function setAllLightsEnabled(group, value)
    for i = 0, group.obj:getCount(), 1 do
        local id = group.obj:idAt(i)
        local obj = scenetree.findObjectById(id)
        if obj and obj.obj:isSubClassOf('LightBase') then
            obj.obj:setLightEnabled( value )
        end
    end
end

local function onUpdate(dt)
  if isOn then
    timer = timer - dt
  end
  if timer < 0 then
    timer = 0.2
    isOn = false
    if light then
      light.isEnabled = false
    end
  end
    local tod = scenetree.tod
    if not tod then return end

    local value = false
    if tod.time > 0.24 and tod.time < 0.76 then
        value = true
    end

    if lastValue == value then return end
    lastValue = value

    if scenetree.DynamicLights then
      setAllLightsEnabled(scenetree.DynamicLights, value )
    end
    if scenetree.MissionLights then
      setAllLightsEnabled(scenetree.MissionLights, value )
    end
end

local function onBeamNGTrigger(data)
  -- dump(data)
  if data.triggerName == "fototrig" and data.event == "enter" then
    local veh = be:getObjectByID(data.subjectID)
    if light and veh then
      local speedVec = vec3(veh:getVelocity(veh:getRefNodeId()) )
      -- local dir = vec3(veh:getDirectionVector())
      local radarDir = vec3(0,1,0)
      -- log("E", "levels.polish_roads", "speedVec = "..dumps(speedVec))
      -- log("E", "levels.polish_roads", "dir = "..dumps(dir))
      local speed = radarDir:dot(speedVec) -- we use the speed on the axis of the camera only
      if speed > speedLimit * 1.05 then --added a few kph so the limit is not too strict
        light.isEnabled = true
        isOn = true
        local unit = tostring( settings.getValue("uiUnitLength") )
        local msgRadar = "speeding!!!"
        if ( unit or 'metric') == "metric" then
          msgRadar = string.format("📸You drive at speed: %0.1f KPH❌ instead of %0.1f KPH✅ Slow Down!", speed*3.6, speedLimit*3.6)
        else
          msgRadar = string.format("📸You drive at speed: %0.1f MPH❌ instead of %0.1f MPH✅ Slow Down!", speed*2.23694, speedLimit*2.23694)
        end
        guihooks.trigger('Message', {ttl = 10, msg = msgRadar, category = "test", icon = "photo_camera"})
      end
    end
  end
end

local lastValue = nil

M.onClientStartMission = onClientStartMission
M.onUpdate = onUpdate
M.onBeamNGTrigger = onBeamNGTrigger



return M

