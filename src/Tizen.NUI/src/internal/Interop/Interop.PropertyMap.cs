/*
 * Copyright(c) 2021 Samsung Electronics Co., Ltd.
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
using global::System.Runtime.InteropServices;

namespace Tizen.NUI
{
    internal static partial class Interop
    {
        internal static partial class PropertyMap
        {
            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property_Map__SWIG_0")]
            public static extern global::System.IntPtr NewPropertyMap();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property_Map__SWIG_1")]
            public static extern global::System.IntPtr NewPropertyMap(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Property_Map")]
            public static extern void DeletePropertyMap(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Count")]
            public static extern uint Count(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Empty")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static extern bool Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Insert__SWIG_0")]
            public static extern void Insert(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Insert__SWIG_2")]
            public static extern void Insert(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add__SWIG_0")]
            public static extern global::System.IntPtr Add(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add__SWIG_2")]
            public static extern global::System.IntPtr Add(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Remove__SWIG_0")]
            public static extern bool Remove(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Remove__SWIG_1")]
            public static extern bool Remove(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_GetValue")]
            public static extern global::System.IntPtr GetValue(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_GetKeyAt")]
            public static extern global::System.IntPtr GetKeyAt(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Find__SWIG_0")]
            public static extern global::System.IntPtr Find(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Find__SWIG_2")]
            public static extern global::System.IntPtr Find(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Find__SWIG_3")]
            public static extern global::System.IntPtr Find(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Clear")]
            public static extern void Clear(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Merge")]
            public static extern void Merge(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_ValueOfIndex__SWIG_0")]
            public static extern global::System.IntPtr ValueOfIndex(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_ValueOfIndex__SWIG_2")]
            public static extern global::System.IntPtr ValueOfIndex(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_SetValue_StringKey")]
            public static extern void SetValueStringKey(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_SetValue_IntKey")]
            public static extern void SetValueIntKey(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_None")]
            public static extern IntPtr AddNone(HandleRef jarg1, string jarg2);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_None")]
            public static extern IntPtr AddNone(HandleRef jarg1, int jarg2);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Bool")]
            public static extern IntPtr AddBool(HandleRef jarg1, string jarg2, bool jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Bool")]
            public static extern IntPtr AddBool(HandleRef jarg1, int jarg2, bool jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Int")]
            public static extern IntPtr AddInt(HandleRef jarg1, string jarg2, int jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Int")]
            public static extern IntPtr AddInt(HandleRef jarg1, int jarg2, int jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Str")]
            public static extern IntPtr AddString(HandleRef jarg1, string jarg2, string jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Str")]
            public static extern IntPtr AddString(HandleRef jarg1, int jarg2, string jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Float")]
            public static extern IntPtr AddFloat(HandleRef jarg1, string jarg2, float jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Float")]
            public static extern IntPtr AddFloat(HandleRef jarg1, int jarg2, float jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_NVector2")]
            public static extern IntPtr AddVector2(HandleRef jarg1, string jarg2, float jarg3, float jarg4);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_NVector2")]
            public static extern IntPtr AddVector2(HandleRef jarg1, int jarg2, float jarg3, float jarg4);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Vector2")]
            public static extern IntPtr AddVector2(HandleRef jarg1, string jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Vector2")]
            public static extern IntPtr AddVector2(HandleRef jarg1, int jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Vector3")]
            public static extern IntPtr AddVector3(HandleRef jarg1, string jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Vector3")]
            public static extern IntPtr AddVector3(HandleRef jarg1, int jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_NVector4")]
            public static extern IntPtr AddVector4(HandleRef jarg1, string jarg2, float jarg3, float jarg4, float jarg5, float jarg6);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_NVector4")]
            public static extern IntPtr AddVector4(HandleRef jarg1, int jarg2, float jarg3, float jarg4, float jarg5, float jarg6);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Vector4")]
            public static extern IntPtr AddVector4(HandleRef jarg1, string jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Vector4")]
            public static extern IntPtr AddVector4(HandleRef jarg1, int jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Rectangle")]
            public static extern IntPtr AddRectangle(HandleRef jarg1, string jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Rectangle")]
            public static extern IntPtr AddRectangle(HandleRef jarg1, int jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Map")]
            public static extern IntPtr AddMap(HandleRef jarg1, string jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Map")]
            public static extern IntPtr AddMap(HandleRef jarg1, int jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_None")]
            public static extern void SetNone(HandleRef jarg1, string jarg2);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_None")]
            public static extern void SetNone(HandleRef jarg1, int jarg2);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Bool")]
            public static extern void SetBool(HandleRef jarg1, string jarg2, bool jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Bool")]
            public static extern void SetBool(HandleRef jarg1, int jarg2, bool jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Int")]
            public static extern void SetInt(HandleRef jarg1, string jarg2, int jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Int")]
            public static extern void SetInt(HandleRef jarg1, int jarg2, int jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Float")]
            public static extern void SetFloat(HandleRef jarg1, string jarg2, float jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Float")]
            public static extern void SetFloat(HandleRef jarg1, int jarg2, float jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Str")]
            public static extern void SetString(HandleRef jarg1, string jarg2, string jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Str")]
            public static extern void SetString(HandleRef jarg1, int jarg2, string jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Rectangle")]
            public static extern void SetRectangle(HandleRef jarg1, string jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Rectangle")]
            public static extern void SetRectangle(HandleRef jarg1, int jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_NVector2")]
            public static extern void SetVector2(HandleRef jarg1, string jarg2, float jarg3, float jarg4);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_NVector2")]
            public static extern void SetVector2(HandleRef jarg1, int jarg2, float jarg3, float jarg4);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Vector2")]
            public static extern void SetVector2(HandleRef jarg1, string jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Vector2")]
            public static extern void SetVector2(HandleRef jarg1, int jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Vector4")]
            public static extern void SetVector4(HandleRef jarg1, string jarg2, HandleRef jarg3);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Vector4")]
            public static extern void SetVector4(HandleRef jarg1, int jarg2, HandleRef jarg3);
        }
    }
}
