﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Areas.Containers
{

    public class Area
    {

        public string name { get; set; }
        public string cfg { get; set; }
        public int layer { get; set; }
        public Vector3 centre { get; set; }
        public Vector3 radius { get; set; }

    }

    public class CTMods
    {

        public class ByDay
        {
            public int days { get; set; }
            public float value { get; set; }
        }

        // Custom Variables
        public int? level_min { get; set; }
        public int? level_max { get; set; }
        public float? level_chance { get; set; }
        public int? level_fixed { get; set; }

        public float? health_multi { get; set; }
        public float? damage_multi { get; set; }

        public float? size { get; set; }
        public string color { get; set; }

        public Dictionary<int, string> evolutions { get; set; }

        public Dictionary<string, ByDay> scale_by_day { get; set; }
        public Dictionary<string, Dictionary<string, float>> scale_by_boss { get; set; }

        // Weird Character Stuff
        // public string name = ""{ get; set; }
        // public Faction faction = Faction.AnimalsVeg{ get; set; }
        // public bool boss{ get; set; }
        // public string bossEvent = ""{ get; set; }
        // public string defeatSetGlobalKey = ""{ get; set; }

        public float? crouch_speed { get; set; }
        public float? walk_speed { get; set; }
        public float? speed { get; set; }
        public float? turn_speed { get; set; }
        public float? run_speed { get; set; }
        public float? run_turn_speed { get; set; }
        public float? fly_slow_speed { get; set; }
        public float? fly_fast_speed { get; set; }
        public float? fly_turn_speed { get; set; }
        public float? acceleration { get; set; }
        public float? jump_force { get; set; }
        public float? jump_force_forward { get; set; }
        public float? jump_force_tired_factor { get; set; }
        public float? air_control { get; set; }
        public bool? can_swim { get; set; }
        public float? swim_depth { get; set; }
        public float? swim_speed { get; set; }
        public float? swim_turn_speed { get; set; }
        public float? swim_acceleration { get; set; }
        // public GroundTiltType m_groundTilt{ get; set; }
        public bool? flying { get; set; }
        public float? jump_stamina_usage { get; set; }

        public bool? tolerate_water { get; set; }
        public bool? tolerate_fire { get; set; }
        public bool? tolerate_smoke { get; set; }
        public float? health { get; set; }
        public bool? stagger_when_blocked { get; set; }
        public float? stagger_damage_factor { get; set; }

        // Base AI stuff
        public string path_agent_type { get; set; }
        public float? view_range { get; set; }
        public float? view_angle { get; set; }
        public float? hear_range { get; set; }
        // public EffectList alertedEffects = new EffectList(){ get; set; }
        // public EffectList idleSound = new EffectList(){ get; set; }
        public float? idle_sound_interval { get; set; }
        public float? idle_sound_chance { get; set; }
        public float? move_min_angle { get; set; }
        public bool? smooth_movement { get; set; }
        public bool? serpent_movement { get; set; }
        public float? serpent_turn_radius { get; set; }
        public float? jump_interval { get; set; }

        public float? random_circle_interval { get; set; }

        public float? random_move_interval { get; set; }
        public float? random_move_range { get; set; }

        public bool? random_fly { get; set; }
        public float? chance_to_takeoff { get; set; }
        public float? chance_to_land { get; set; }
        public float? ground_duration { get; set; }
        public float? air_duration { get; set; }
        public float? max_land_altitude { get; set; }
        public float? fly_altitude_min { get; set; }
        public float? fly_altitude_max { get; set; }
        public float? takeoff_time { get; set; }

        public bool? avoid_fire { get; set; }
        public bool? afraid_of_fire { get; set; }
        public bool? avoid_water { get; set; }
        public string spawn_message { get; set; }
        public string death_message { get; set; }

        // Monster AI stuff
        public float? alert_range { get; set; }
        public bool? flee_if_hurt_when_target_cant_be_reached { get; set; }
        public bool? flee_if_not_alerted { get; set; }
        public float? flee_if_low_health { get; set; }
        public bool? circulate_while_charging { get; set; }
        public bool? circulate_while_charging_flying { get; set; }
        public bool? enable_hunt_player { get; set; }
        public bool? attack_player_objects { get; set; }
        public bool? attack_player_objects_when_alerted { get; set; }
        public float? intercept_time_max { get; set; }
        public float? intercept_time_min { get; set; }
        public float? max_chase_distance { get; set; }
        public float? min_attack_interval { get; set; }

        public float? circle_target_interval { get; set; }
        public float? circle_target_duration { get; set; }
        public float? circle_target_distance { get; set; }

        public bool? sleeping { get; set; }
        public bool? noise_wakeup { get; set; }
        public float? noise_range_scale { get; set; }
        public float? wakeup_range { get; set; }
        // public EffectList wakeupEffects = new EffectList(){ get; set; }

        public bool? avoid_land { get; set; }

        // public List<ItemDrop> consumeItems{ get; set; }
        public float? consume_range { get; set; }
        public float? consume_search_range { get; set; }
        public float? consume_search_interval { get; set; }
        public float? consume_heal { get; set; }

    }

    public class SSMods
    {

        public bool? enabled { get; set; }
        // public Heightmap.Biome? biome{ get; set; }
        // public Heightmap.BiomeArea? biome_area{ get; set; }

        public int? max_spawned { get; set; }
        public float? spawn_interval { get; set; } // How often do it spawn
        public float? spawn_chance { get; set; } // Chanse to spawn each spawn interval
        public float? spawn_distance { get; set; } // Minimum distance to another instance

        public float? spawn_radius_min { get; set; } // 0 for global settings
        public float? spawn_radius_max { get; set; }

        public string required_global_key { get; set; } // only spawn if this key is set

        // public List<string> requiredEnvironments = new List<string>(){ get; set; } // only spawn if this environment is active

        public int? group_size_min { get; set; }
        public int? group_size_max { get; set; }
        public int? group_radius { get; set; }

        public bool? spawn_at_day { get; set; }
        public bool? spawn_at_night { get; set; }

        public int? min_altitude { get; set; }
        public int? max_altitude { get; set; }

        public float? min_tilt { get; set; }
        public float? max_tilt { get; set; }

        public bool? in_forest { get; set; }
        public bool? outside_forest { get; set; }

        public float? min_ocean_depth { get; set; }
        public float? max_ocean_depth { get; set; }

        public bool? hunt_player { get; set; }
        public float? ground_offset { get; set; }

    }

    public class CSMods
    {

        public float? respawn_time_minutes { get; set; }

        public float? trigger_distance { get; set; }
        public float? trigger_noise { get; set; }

        public bool? spawn_at_day { get; set; }
        public bool? spawn_at_night { get; set; }
        public bool? require_spawn_area { get; set; }
        public bool? spawn_in_player_base { get; set; }
        public bool? set_patrol_spawn_point { get; set; }

    }

    public class SAMods
    {

        public float? spawn_interval_sec { get; set; }
        public float? trigger_distance { get; set; }
        public bool? set_patrol_spawn_point { get; set; }
        public float? spawn_radius { get; set; }
        public float? near_radius { get; set; }
        public float? far_radius { get; set; }
        public int? max_near { get; set; }
        public int? max_total { get; set; }
        public bool? on_ground_only { get; set; }

    }

}
