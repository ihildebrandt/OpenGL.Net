
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
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG = 0x913C;

		/// <summary>
		/// [GL] Value of GL_NUM_DOWNSAMPLE_SCALES_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
		public const int NUM_DOWNSAMPLE_SCALES_IMG = 0x913D;

		/// <summary>
		/// [GL] Value of GL_DOWNSAMPLE_SCALES_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
		public const int DOWNSAMPLE_SCALES_IMG = 0x913E;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG = 0x913F;

		/// <summary>
		/// Binding for glFramebufferTexture2DDownsampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xscale">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yscale">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
		public static void FramebufferTexture2DIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 xscale, Int32 yscale)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DDownsampleIMG != null, "pglFramebufferTexture2DDownsampleIMG not implemented");
			Delegates.pglFramebufferTexture2DDownsampleIMG((Int32)target, (Int32)attachment, (Int32)textarget, texture, level, xscale, yscale);
			LogCommand("glFramebufferTexture2DDownsampleIMG", null, target, attachment, textarget, texture, level, xscale, yscale			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFramebufferTextureLayerDownsampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xscale">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yscale">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
		public static void FramebufferTextureLayerIMG(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer, Int32 xscale, Int32 yscale)
		{
			Debug.Assert(Delegates.pglFramebufferTextureLayerDownsampleIMG != null, "pglFramebufferTextureLayerDownsampleIMG not implemented");
			Delegates.pglFramebufferTextureLayerDownsampleIMG((Int32)target, (Int32)attachment, texture, level, layer, xscale, yscale);
			LogCommand("glFramebufferTextureLayerDownsampleIMG", null, target, attachment, texture, level, layer, xscale, yscale			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferTexture2DDownsampleIMG", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2DDownsampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 xscale, Int32 yscale);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferTextureLayerDownsampleIMG", ExactSpelling = true)]
			internal extern static void glFramebufferTextureLayerDownsampleIMG(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer, Int32 xscale, Int32 yscale);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture2DDownsampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 xscale, Int32 yscale);

			[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
			[ThreadStatic]
			internal static glFramebufferTexture2DDownsampleIMG pglFramebufferTexture2DDownsampleIMG;

			[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureLayerDownsampleIMG(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer, Int32 xscale, Int32 yscale);

			[RequiredByFeature("GL_IMG_framebuffer_downsample", Api = "gles2")]
			[ThreadStatic]
			internal static glFramebufferTextureLayerDownsampleIMG pglFramebufferTextureLayerDownsampleIMG;

		}
	}

}
