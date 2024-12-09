/*
 * Copyright(c) 2020 Samsung Electronics Co., Ltd.
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

namespace Tizen.NUI.BaseComponents
{
    /// <summary>
    /// The class storing Layout properties.
    /// </summary>
    internal sealed class LayoutExtraData : IDisposable
    {
        private bool disposed;

        // Indicates whether the layout has been set by user or not.
        public bool LayoutSet { get; set; }

        // Exclusive layout assigned to this View.
        public LayoutItem Layout { get; set; }

        public Dictionary<TransitionCondition, TransitionList> LayoutTransitions { get; set; }

        public LayoutTransition LayoutTransition { get; set; }

        public TransitionOptions TransitionOptions { get; set; }

        public int WidthPolicy { get; set; }

        public int HeightPolicy { get; set; }

        public float Weight { get; set; }

        public bool ExcludeLayouting { get; set; }

        ~LayoutExtraData() => Dispose(false);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                TransitionOptions?.Dispose();
            }
            disposed = true;
        }
    }
}


