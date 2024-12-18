/*
* Copyright (c) 2019 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System;
using System.Collections.Generic;

namespace Tizen.NUI
{
    internal static class DisposablePool
    {
        private static readonly Dictionary<Type, Stack<Disposable>> pools = new Dictionary<Type, Stack<Disposable>>();

        public static int MaximumPoolSize { get; set; } = 50;

        public static T Get<T>() where T : Disposable
        {
            if (pools.TryGetValue(typeof(T), out var typePool) && typePool.Count > 0)
            {
                Log.Debug("JYJY", $"Get {typeof(T)} pool: {typePool.Count}");
                return typePool.Pop() as T;
            }
            return null;
        }

        // public static T GetOrCreate<T>() where T : Disposable
        // {
        //     // NOTE Remove reflextion later
        //     return Get<T>() ?? (T)Activator.CreateInstance(typeof(T));
        // }

        public static bool Push<T>(T item) where T : Disposable
        {
            if (!pools.TryGetValue(typeof(T), out var typePool))
            {
                pools[typeof(T)] = typePool = new Stack<Disposable>();
            }

            if (typePool.Count == MaximumPoolSize)
            {
                Log.Debug("JYJY", $"{typeof(T)} maximum pool size reached");
                return false;
            }

            typePool.Push(item);

            return true;
        }
    }
}
