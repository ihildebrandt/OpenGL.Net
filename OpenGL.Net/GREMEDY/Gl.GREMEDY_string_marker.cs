
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Binding for glStringMarkerGREMEDY.
		/// </summary>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_GREMEDY_string_marker")]
		public static void StringMarkerGREMEDY(Int32 len, IntPtr @string)
		{
			Debug.Assert(Delegates.pglStringMarkerGREMEDY != null, "pglStringMarkerGREMEDY not implemented");
			Delegates.pglStringMarkerGREMEDY(len, @string);
			LogCommand("glStringMarkerGREMEDY", null, len, @string			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStringMarkerGREMEDY.
		/// </summary>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_GREMEDY_string_marker")]
		public static void StringMarkerGREMEDY(Int32 len, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				StringMarkerGREMEDY(len, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStringMarkerGREMEDY", ExactSpelling = true)]
			internal extern static unsafe void glStringMarkerGREMEDY(Int32 len, IntPtr @string);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_GREMEDY_string_marker")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glStringMarkerGREMEDY(Int32 len, IntPtr @string);

			[RequiredByFeature("GL_GREMEDY_string_marker")]
			[ThreadStatic]
			internal static glStringMarkerGREMEDY pglStringMarkerGREMEDY;

		}
	}

}
