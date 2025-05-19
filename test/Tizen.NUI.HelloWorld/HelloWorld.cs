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
        View view1;

        public App(string styleSheet) : base(styleSheet)
        {
        }

        protected override void OnCreate()
        {
            base.OnCreate();

            NUIApplication.IsUsingXaml = false;

            NUIApplication.GetDefaultWindow().KeyEvent += OnKeyEvent;

            NUIApplication.GetDefaultWindow().Add(view1 = new View()
            {
                SizeWidth = 200f,
                SizeHeight = 200f,
                BackgroundColor = Color.White,
                OffScreenRendering = View.OffScreenRenderingType.RefreshAlways
            });
            view1.Add(new View()
            {
                SizeWidth = 100f,
                SizeHeight = 100f,
                BackgroundColor = Color.Red
            });
            view1.Add(new View()
            {
                SizeWidth = 100f,
                SizeHeight = 100f,
                PositionX = 100f,
                PositionY = 100f,
                BackgroundColor = Color.Blue
            });
        }

        static void FullGC()
        {
            global::System.GC.Collect();
            global::System.GC.WaitForPendingFinalizers();
            global::System.GC.Collect();
        }

        static void Main(string[] args)
        {
            new App("").Run(args);
        }

        private void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Up && e.Key.KeyPressedName == "0")
            {
                view1.SizeWidth = 100;
            }
        }
    }
}

