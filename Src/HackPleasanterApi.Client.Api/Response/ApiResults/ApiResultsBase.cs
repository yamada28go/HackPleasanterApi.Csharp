﻿/**
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 * */

using System;
using System.Collections.Generic;
using System.Text;

namespace HackPleasanterApi.Client.Api.Response.ApiResults
{
    /// <summary>
    /// API戻り値の基底クラス
    ///
    /// APIの戻り値は
    /// ApiResults型が基本の型形式となる。
    /// 
    /// この型に含まれる形で
    /// ResponseData.Item名前空間の型が入ってくる
    /// データが帰ってくることとなる。
    /// このめた、双方は別の存在となる
    /// 
    /// </summary>
    public class ApiResultsBase
    {
        /// <summary>
        /// 戻り値ステータスコード
        /// </summary>
        public int StatusCode { get; set; }

    }
}
