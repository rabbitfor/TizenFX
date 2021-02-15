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
using System.ComponentModel;
using System.Reflection;
using System.Xml;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using Tizen.NUI.Xaml;

namespace Tizen.NUI.Components
{
    /// <summary>
    /// <para>
    /// Basically, the Theme is a dictionary of <seealso cref="ViewStyle"/>s that can decorate NUI <seealso cref="View"/>s.
    /// Each ViewStyle item is identified by a string key that can be matched the <seealso cref="View.StyleName"/>.
    /// </para>
    /// <para>
    /// The main purpose of providing Theme is to separate style details from the structure.
    /// Managing style separately makes it easier to customize the look of application by user context.
    /// Also since a Theme can be created from xaml file, it can be treated as a resource.
    /// This enables sharing styles with other applications.
    /// </para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class TestTheme : Theme
    {
        public TestTheme()
        {
            InitializeComponent();
        }

        public void Reload(ResourceDictionary newRes)
        {
            XamlResources = newRes;
            XamlLoader.Load(this, typeof(TestTheme));
        }
    }
}
