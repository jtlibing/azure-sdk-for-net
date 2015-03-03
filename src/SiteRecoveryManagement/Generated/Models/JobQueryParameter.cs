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

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a JobQueryParameter object.
    /// </summary>
    public partial class JobQueryParameter
    {
        private string _endTime;
        
        /// <summary>
        /// Optional. End range of start time in UTC.
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _objectId;
        
        /// <summary>
        /// Optional. Id of afftected object.
        /// </summary>
        public string ObjectId
        {
            get { return this._objectId; }
            set { this._objectId = value; }
        }
        
        private string _startTime;
        
        /// <summary>
        /// Optional. Start time  in UTC.
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. State of job.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobQueryParameter class.
        /// </summary>
        public JobQueryParameter()
        {
        }
    }
}
