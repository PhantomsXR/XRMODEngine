// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using LitJson;

namespace FoundationTest.Runtime
{
    [System.Serializable]
    public class SpawnTargetType
    {
        public string TypeName;
        public int TargetTypeId;
        public string[] TargetMeshesName;
    }

    [System.Serializable]
    public class SpawnTargetData:IService,IService2
    {
        private List<SpawnTargetType> spawnTargetTypes = new();

        public int TargetTypeSize => spawnTargetTypes.Count;

        public SpawnTargetType GetSpawnTargetType(int _idx)
        {
            return spawnTargetTypes.Find(_type => _type.TargetTypeId == _idx);
        }

        public void Register(SpawnTargetType _spawnTargetType)
        {
            if (spawnTargetTypes.Exists(_type => _type.TargetTypeId == _spawnTargetType.TargetTypeId)) return;
            spawnTargetTypes.Add(_spawnTargetType);
        }

        public void ExecuteService()
        {
            
        }

        public void ExecuteService2()
        {
            
        }
    }

    public static class SpawnTargetDataExtension
    {
        public static SpawnTargetData CreateFromJson(this SpawnTargetData _data, string _json)
        {
            return JsonMapper.ToObject<SpawnTargetData>(_json);
        }
    }
}