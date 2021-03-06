﻿//*********************************************************//
//    Copyright (c) Microsoft. All rights reserved.
//    
//    Apache 2.0 License
//    
//    You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//    
//    Unless required by applicable law or agreed to in writing, software 
//    distributed under the License is distributed on an "AS IS" BASIS, 
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or 
//    implied. See the License for the specific language governing 
//    permissions and limitations under the License.
//
//*********************************************************

using System;
using System.Collections.Generic;

using Orleans;
using Orleans.Concurrency;

namespace AdventureGrainInterfaces
{
    [Immutable]
    public class Thing
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public long FoundIn { get; set; }
        public List<String> Commands { get; set; }
    }

    [Immutable]
    public class MapInfo
    {
        public string Name { get; set; }
        public List<RoomInfo> Rooms { get; set; }
        public List<CategoryInfo> Categories { get; set; }
        public List<Thing> Things { get; set; }
        public List<MonsterInfo> Monsters { get; set; }
    }

    [Immutable]
    public class RoomInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, long> Directions { get; set; }
    }

    [Immutable]
    public class CategoryInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<String> Commands { get; set; }
    }
}
