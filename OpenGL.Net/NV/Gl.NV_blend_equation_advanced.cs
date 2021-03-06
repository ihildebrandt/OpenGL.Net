
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
		/// [GL] Value of GL_BLEND_OVERLAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int BLEND_OVERLAP_NV = 0x9281;

		/// <summary>
		/// [GL] Value of GL_BLEND_PREMULTIPLIED_SRC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int BLEND_PREMULTIPLIED_SRC_NV = 0x9280;

		/// <summary>
		/// [GL] Value of GL_CONJOINT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int CONJOINT_NV = 0x9284;

		/// <summary>
		/// [GL] Value of GL_CONTRAST_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int CONTRAST_NV = 0x92A1;

		/// <summary>
		/// [GL] Value of GL_DISJOINT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int DISJOINT_NV = 0x9283;

		/// <summary>
		/// [GL] Value of GL_DST_ATOP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int DST_ATOP_NV = 0x928F;

		/// <summary>
		/// [GL] Value of GL_DST_IN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int DST_IN_NV = 0x928B;

		/// <summary>
		/// [GL] Value of GL_DST_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int DST_NV = 0x9287;

		/// <summary>
		/// [GL] Value of GL_DST_OUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int DST_OUT_NV = 0x928D;

		/// <summary>
		/// [GL] Value of GL_DST_OVER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int DST_OVER_NV = 0x9289;

		/// <summary>
		/// [GL] Value of GL_HARDMIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int HARDMIX_NV = 0x92A9;

		/// <summary>
		/// [GL] Value of GL_INVERT_OVG_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int INVERT_OVG_NV = 0x92B4;

		/// <summary>
		/// [GL] Value of GL_INVERT_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int INVERT_RGB_NV = 0x92A3;

		/// <summary>
		/// [GL] Value of GL_LINEARBURN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int LINEARBURN_NV = 0x92A5;

		/// <summary>
		/// [GL] Value of GL_LINEARDODGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int LINEARDODGE_NV = 0x92A4;

		/// <summary>
		/// [GL] Value of GL_LINEARLIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int LINEARLIGHT_NV = 0x92A7;

		/// <summary>
		/// [GL] Value of GL_MINUS_CLAMPED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int MINUS_CLAMPED_NV = 0x92B3;

		/// <summary>
		/// [GL] Value of GL_MINUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int MINUS_NV = 0x929F;

		/// <summary>
		/// [GL] Value of GL_PINLIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int PINLIGHT_NV = 0x92A8;

		/// <summary>
		/// [GL] Value of GL_PLUS_CLAMPED_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int PLUS_CLAMPED_ALPHA_NV = 0x92B2;

		/// <summary>
		/// [GL] Value of GL_PLUS_CLAMPED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int PLUS_CLAMPED_NV = 0x92B1;

		/// <summary>
		/// [GL] Value of GL_PLUS_DARKER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int PLUS_DARKER_NV = 0x9292;

		/// <summary>
		/// [GL] Value of GL_PLUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int PLUS_NV = 0x9291;

		/// <summary>
		/// [GL] Value of GL_SRC_ATOP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int SRC_ATOP_NV = 0x928E;

		/// <summary>
		/// [GL] Value of GL_SRC_IN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int SRC_IN_NV = 0x928A;

		/// <summary>
		/// [GL] Value of GL_SRC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int SRC_NV = 0x9286;

		/// <summary>
		/// [GL] Value of GL_SRC_OUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int SRC_OUT_NV = 0x928C;

		/// <summary>
		/// [GL] Value of GL_SRC_OVER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int SRC_OVER_NV = 0x9288;

		/// <summary>
		/// [GL] Value of GL_UNCORRELATED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int UNCORRELATED_NV = 0x9282;

		/// <summary>
		/// [GL] Value of GL_VIVIDLIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int VIVIDLIGHT_NV = 0x92A6;

		/// <summary>
		/// Binding for glBlendParameteriNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public static void BlendParameterNV(Int32 pname, Int32 value)
		{
			Debug.Assert(Delegates.pglBlendParameteriNV != null, "pglBlendParameteriNV not implemented");
			Delegates.pglBlendParameteriNV(pname, value);
			LogCommand("glBlendParameteriNV", null, pname, value			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlendParameteriNV", ExactSpelling = true)]
			internal extern static void glBlendParameteriNV(Int32 pname, Int32 value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendParameteriNV(Int32 pname, Int32 value);

			[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glBlendParameteriNV pglBlendParameteriNV;

		}
	}

}
