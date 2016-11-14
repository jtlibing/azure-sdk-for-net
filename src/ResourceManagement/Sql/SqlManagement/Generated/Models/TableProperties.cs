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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Database table.
    /// </summary>
    public partial class TableProperties
    {
        private IList<Column> _columns;
        
        /// <summary>
        /// Optional. Gets the columns from this table.
        /// </summary>
        public IList<Column> Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }
        
        private IList<RecommendedIndex> _recommendedIndexes;
        
        /// <summary>
        /// Optional. Gets the recommended indices for this table.
        /// </summary>
        public IList<RecommendedIndex> RecommendedIndexes
        {
            get { return this._recommendedIndexes; }
            set { this._recommendedIndexes = value; }
        }
        
        private string _tableType;
        
        /// <summary>
        /// Optional. Gets the type of Azure SQL Database table.
        /// </summary>
        public string TableType
        {
            get { return this._tableType; }
            set { this._tableType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TableProperties class.
        /// </summary>
        public TableProperties()
        {
            this.Columns = new LazyList<Column>();
            this.RecommendedIndexes = new LazyList<RecommendedIndex>();
        }
    }
}
