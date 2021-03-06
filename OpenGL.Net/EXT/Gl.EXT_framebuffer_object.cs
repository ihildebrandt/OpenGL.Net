
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
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;

		/// <summary>
		/// Binding for glBindRenderbufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void BindRenderbufferEXT(RenderbufferTarget target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbufferEXT != null, "pglBindRenderbufferEXT not implemented");
			Delegates.pglBindRenderbufferEXT((Int32)target, renderbuffer);
			LogCommand("glBindRenderbufferEXT", null, target, renderbuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBindFramebufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void BindFramebufferEXT(FramebufferTarget target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebufferEXT != null, "pglBindFramebufferEXT not implemented");
			Delegates.pglBindFramebufferEXT((Int32)target, framebuffer);
			LogCommand("glBindFramebufferEXT", null, target, framebuffer			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glBindRenderbufferEXT(Int32 target, UInt32 renderbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindFramebufferEXT", ExactSpelling = true)]
			internal extern static void glBindFramebufferEXT(Int32 target, UInt32 framebuffer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_framebuffer_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindRenderbufferEXT(Int32 target, UInt32 renderbuffer);

			[RequiredByFeature("GL_EXT_framebuffer_object")]
			[ThreadStatic]
			internal static glBindRenderbufferEXT pglBindRenderbufferEXT;

			[RequiredByFeature("GL_EXT_framebuffer_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFramebufferEXT(Int32 target, UInt32 framebuffer);

			[RequiredByFeature("GL_EXT_framebuffer_object")]
			[ThreadStatic]
			internal static glBindFramebufferEXT pglBindFramebufferEXT;

		}
	}

}
