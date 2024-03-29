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
using HackPleasanterApi.Client.Api.Helper.Mix;
using HackPleasanterApi.Client.Api.Logging;
using HackPleasanterApi.Client.Api.Response.ApiResults;
using HackPleasanterApi.Client.Api.Response.ResponseData.Item;

namespace HackPleasanterApi.Client.Api.Exceptions
{
    /// <summary>
    /// 生成失敗例外
    /// </summary>
    public class CreateItemException : Exception
    {
        public CreateItemResults CreateItemResponse { get; private set; }

        public CreateItemException(CreateItemResults CreateItemResponse)
        {
            this.CreateItemResponse = CreateItemResponse;

            // エラーログを残す
            var L = LoggerManager.GetInstance().Logger;
            L.Error(() => $"Error CreateItemException Msg : {this.CreateItemResponse?.DumpAsJsonString()} ");

        }
    }
}
