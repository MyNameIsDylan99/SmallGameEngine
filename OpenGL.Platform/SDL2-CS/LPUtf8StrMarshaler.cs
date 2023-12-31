/* SDL2# - C# Wrapper for SDL2
 *
 * Copyright (c) 2013-2015 Ethan Lee.
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. If you use this software in a
 * product, an acknowledgment in the product documentation would be
 * appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 * misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 *
 * Ethan "flibitijibibo" Lee <flibitijibibo@flibitijibibo.com>
 *
 */

// Copyright (c) 2017 Giawa
//
// This source file has been modified by Giawa to make all methods 'safe'.
// This source file has also been modified to remove ICustomMarshaler, which
//   is not yet part of the .NET Standard < 2.0
// This modified source file is part of the OpenGL.Platform package:
//    https://www.github.com/giawa/opengl4csharp

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL2
{
#if NETSTANDARD1_4
    interface ICustomMarshaler
    {
        object MarshalNativeToManaged(IntPtr pNativeData);
        IntPtr MarshalManagedToNative(object ManagedObj);
    }
#endif

    internal class LPUtf8StrMarshaler : ICustomMarshaler
    {
        public const string LeaveAllocated = "LeaveAllocated";

        private static ICustomMarshaler
            _leaveAllocatedInstance = new LPUtf8StrMarshaler(true),
            _defaultInstance = new LPUtf8StrMarshaler(false);

        public static ICustomMarshaler GetInstance(string cookie)
        {
            switch (cookie)
            {
                case "LeaveAllocated":
                    return _leaveAllocatedInstance;

                default:
                    return _defaultInstance;
            }
        }

        private bool _leaveAllocated;

        public LPUtf8StrMarshaler(bool leaveAllocated)
        {
            _leaveAllocated = leaveAllocated;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return null;

            int length = 0;
            while (Marshal.ReadByte((IntPtr)(pNativeData + length)) != 0) length++;

            byte[] bytes = new byte[length];
            Marshal.Copy(pNativeData, bytes, 0, bytes.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (ManagedObj == null)
                return IntPtr.Zero;

            var str = ManagedObj as string;
            if (str == null)
            {
                throw new ArgumentException("ManagedObj must be a string.", "ManagedObj");
            }

            byte[] utfBytes = Encoding.UTF8.GetBytes(str);
            byte[] bytes = new byte[utfBytes.Length + 1];
            Array.Copy(utfBytes, bytes, utfBytes.Length);

            var mem = SDL.SDL_malloc((IntPtr)bytes.Length);
            Marshal.Copy(bytes, 0, mem, bytes.Length);

            return mem;
        }

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            if (!_leaveAllocated)
            {
                SDL.SDL_free(pNativeData);
            }
        }

        public int GetNativeDataSize()
        {
            return -1;
        }
    }
}