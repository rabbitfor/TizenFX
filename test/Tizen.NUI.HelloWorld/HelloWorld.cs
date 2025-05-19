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
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;
using Tizen.NUI.Extension;

namespace Tizen.NUI.HelloWorld
{
    public class App : NUIApplication
    {
        const int testVolumn = 1000;
        View view;

        public App(string styleSheet) : base(styleSheet)
        {
        }

        protected override void OnCreate()
        {
            base.OnCreate();

            NUIApplication.IsUsingXaml = false;

            NUIApplication.GetDefaultWindow().Add(new TextLabel()
            {
                Text = "Hello World",
                TextColor = Color.White,
            });
        }

        static void FullGC()
        {
            // Tizen.Log.Info("NUI", $"GC!");
            global::System.GC.Collect();
            global::System.GC.WaitForPendingFinalizers();
            global::System.GC.Collect();
        }

        static void Main(string[] args)
        {
            new App("").Run(args);
        }
    }
}

