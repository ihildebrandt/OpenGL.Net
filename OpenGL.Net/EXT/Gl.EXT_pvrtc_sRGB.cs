
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
		/// [GL] Value of GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pvrtc_sRGB", Api = "gles2")]
		public const int COMPRESSED_SRGB_PVRTC_2BPPV1_EXT = 0x8A54;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pvrtc_sRGB", Api = "gles2")]
		public const int COMPRESSED_SRGB_PVRTC_4BPPV1_EXT = 0x8A55;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pvrtc_sRGB", Api = "gles2")]
		public const int COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT = 0x8A56;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pvrtc_sRGB", Api = "gles2")]
		public const int COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT = 0x8A57;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pvrtc_sRGB", Api = "gles2")]
		public const int COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG = 0x93F0;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pvrtc_sRGB", Api = "gles2")]
		public const int COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG = 0x93F1;

	}

}
