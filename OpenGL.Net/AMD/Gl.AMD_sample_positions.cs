
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
		/// [GL] Value of GL_SUBSAMPLE_DISTANCE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		[RequiredByFeature("GL_AMD_sample_positions")]
		public const int SUBSAMPLE_DISTANCE_AMD = 0x883F;

		/// <summary>
		/// Binding for glSetMultisamplefvAMD.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="val">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_sample_positions")]
		public static void SetMultisampleAMD(Int32 pname, UInt32 index, float[] val)
		{
			unsafe {
				fixed (float* p_val = val)
				{
					Debug.Assert(Delegates.pglSetMultisamplefvAMD != null, "pglSetMultisamplefvAMD not implemented");
					Delegates.pglSetMultisamplefvAMD(pname, index, p_val);
					LogCommand("glSetMultisamplefvAMD", null, pname, index, val					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSetMultisamplefvAMD", ExactSpelling = true)]
			internal extern static unsafe void glSetMultisamplefvAMD(Int32 pname, UInt32 index, float* val);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_sample_positions")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSetMultisamplefvAMD(Int32 pname, UInt32 index, float* val);

			[RequiredByFeature("GL_AMD_sample_positions")]
			[ThreadStatic]
			internal static glSetMultisamplefvAMD pglSetMultisamplefvAMD;

		}
	}

}
