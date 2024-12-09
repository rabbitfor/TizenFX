/*
 * Copyright(c) 2024 Samsung Electronics Co., Ltd.
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
using System.ComponentModel;

namespace Tizen.NUI
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IImmutable
    {
        /// <summary>
        /// Gets a value indicating whether it is read-only.
        /// </summary>
        bool IsImmutable { get; set; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ImmutableExtensions
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void ThrowWhenImmutable(this IImmutable immutable)
        {
            if (immutable.IsImmutable)
            {
                throw new InvalidOperationException($"Modifying immutable {immutable.GetType()} is forbidden");
            }
        }
    }
}
