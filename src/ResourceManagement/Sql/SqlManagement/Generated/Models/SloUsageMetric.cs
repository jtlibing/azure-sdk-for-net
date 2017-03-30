// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents a Slo Usage Metric.
    /// </summary>
    public partial class SloUsageMetric : ResourceBaseExtended
    {
        private double _inRangeTimeRatio;
        
        /// <summary>
        /// Optional. Gets or sets inRangeTimeRatio for SLO usage metric.
        /// </summary>
        public double InRangeTimeRatio
        {
            get { return this._inRangeTimeRatio; }
            set { this._inRangeTimeRatio = value; }
        }
        
        private string _serviceLevelObjective;
        
        /// <summary>
        /// Optional. Gets or sets serviceLevelObjective for SLO usage metric.
        /// </summary>
        public string ServiceLevelObjective
        {
            get { return this._serviceLevelObjective; }
            set { this._serviceLevelObjective = value; }
        }
        
        private Guid _serviceLevelObjectiveId;
        
        /// <summary>
        /// Optional. Gets or sets serviceLevelObjectiveId for SLO usage metric.
        /// </summary>
        public Guid ServiceLevelObjectiveId
        {
            get { return this._serviceLevelObjectiveId; }
            set { this._serviceLevelObjectiveId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SloUsageMetric class.
        /// </summary>
        public SloUsageMetric()
        {
        }
    }
}
