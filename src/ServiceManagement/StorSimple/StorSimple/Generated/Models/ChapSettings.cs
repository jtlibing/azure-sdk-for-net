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

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Device Chap settings
    /// </summary>
    public partial class ChapSettings
    {
        private string _initiatorSecret;
        
        /// <summary>
        /// Required. Gets or sets the Initiator Secret
        /// </summary>
        public string InitiatorSecret
        {
            get { return this._initiatorSecret; }
            set { this._initiatorSecret = value; }
        }
        
        private string _initiatorUser;
        
        /// <summary>
        /// Required. Gets or sets the Initiator User
        /// </summary>
        public string InitiatorUser
        {
            get { return this._initiatorUser; }
            set { this._initiatorUser = value; }
        }
        
        private string _targetSecret;
        
        /// <summary>
        /// Required. Gets or sets the Target Secret
        /// </summary>
        public string TargetSecret
        {
            get { return this._targetSecret; }
            set { this._targetSecret = value; }
        }
        
        private string _targetUser;
        
        /// <summary>
        /// Required. Gets or sets the Target User
        /// </summary>
        public string TargetUser
        {
            get { return this._targetUser; }
            set { this._targetUser = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ChapSettings class.
        /// </summary>
        public ChapSettings()
        {
        }
    }
}
