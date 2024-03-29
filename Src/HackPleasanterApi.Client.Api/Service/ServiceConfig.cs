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
using HackPleasanterApi.Client.Api.Definition;

namespace HackPleasanterApi.Client.Api.Service
{
    public class ServiceConfig
    {
        /// <summary>
        /// 対象となるAPI
        /// </summary>
        public Uri uri;

        /// <summary>
        /// APIバージョン
        /// </summary>
        public string ApiVersion = "1.1";
        /// <summary>
        /// アクセス用APIキー
        /// </summary>
        public string ApiKey;

        /// <summary>
        /// API実行時のリトライカウント
        /// </summary>
        public  int RetryCount = DefaultConfiguration.RetryCount;

        /// <summary>
        /// URLのパスを修飾する場合
        /// </summary>
        public URLPathPrefixSetting URLPathPrefixSetting = new URLPathPrefixSetting();

    }
}
