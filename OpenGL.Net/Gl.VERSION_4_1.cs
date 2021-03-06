
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
		/// [GL] Value of GL_FIXED symbol.
		/// </summary>
		[AliasOf("GL_FIXED_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public const int FIXED = 0x140C;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single GLenum value indicating the implementation's preferred pixel data type. See 
		/// Gl.ReadPixels.
		/// </para>
		/// <para>
		/// [GL4] Gl.GetFramebufferParameter: param returns a GLenum value indicating the implementation's preferred pixel data type 
		/// for the framebuffer object. See Gl.ReadPixels.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the type chosen by the implementation with which pixels may be read from the 
		/// color buffer of the currently bound framebuffer in conjunction with Gl.IMPLEMENTATION_COLOR_READ_FORMAT. See 
		/// Gl.ReadPixels.
		/// </para>
		/// </summary>
		[AliasOf("GL_IMPLEMENTATION_COLOR_READ_TYPE_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_read_format", Api = "gl|gles1")]
		public const int IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single GLenum value indicating the implementation's preferred pixel data format. See 
		/// Gl.ReadPixels.
		/// </para>
		/// <para>
		/// [GL4] Gl.GetFramebufferParameter: param returns a GLenum value indicating the preferred pixel data format for the 
		/// framebuffer object. See Gl.ReadPixels.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the format chosen by the implementation in which pixels may be read from the 
		/// color buffer of the currently bound framebuffer in conjunction with Gl.IMPLEMENTATION_COLOR_READ_TYPE. See 
		/// Gl.ReadPixels.
		/// </para>
		/// </summary>
		[AliasOf("GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_read_format", Api = "gl|gles1")]
		public const int IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

		/// <summary>
		/// [GL] Value of GL_LOW_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int LOW_FLOAT = 0x8DF0;

		/// <summary>
		/// [GL] Value of GL_MEDIUM_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MEDIUM_FLOAT = 0x8DF1;

		/// <summary>
		/// [GL] Value of GL_HIGH_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int HIGH_FLOAT = 0x8DF2;

		/// <summary>
		/// [GL] Value of GL_LOW_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int LOW_INT = 0x8DF3;

		/// <summary>
		/// [GL] Value of GL_MEDIUM_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MEDIUM_INT = 0x8DF4;

		/// <summary>
		/// [GL] Value of GL_HIGH_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int HIGH_INT = 0x8DF5;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single boolean value indicating whether an online shader compiler is present in the 
		/// implementation. All desktop OpenGL implementations must support online shader compilations, and therefore the value of 
		/// Gl.SHADER_COMPILER will always be Gl.TRUE.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single boolean value indicating whether a shader compiler is supported. This value is 
		/// always Gl.TRUE. See Gl.CompileShader.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int SHADER_COMPILER = 0x8DFA;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns a list of symbolic constants of length Gl.NUM_SHADER_BINARY_FORMATS indicating which 
		/// shader binary formats are available. See Gl.ShaderBinary.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int SHADER_BINARY_FORMATS = 0x8DF8;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the number of binary shader formats supported by the implementation. If this value 
		/// is greater than zero, then the implementation supports loading binary shaders. If it is zero, then the loading of binary 
		/// shaders by the implementation is not supported.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single integer value indicating the number of available shader binary formats. The 
		/// minimum value is 0. See Gl.ShaderBinary.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int NUM_SHADER_BINARY_FORMATS = 0x8DF9;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the maximum number of 4-vectors that may be held in uniform variable storage for 
		/// the vertex shader. The value of Gl.MAX_VERTEX_UNIFORM_VECTORS is equal to the value of Gl.MAX_VERTEX_UNIFORM_COMPONENTS 
		/// and must be at least 256.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum number of vector floating-point, integer, or boolean values that 
		/// can be held in uniform variable storage for a vertex shader. The value must be at least 256. See Gl.Uniform.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the number 4-vectors for varying variables, which is equal to the value of 
		/// Gl.MAX_VARYING_COMPONENTS and must be at least 15.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum number of interpolators available for processing varying variables 
		/// used by vertex and fragment shaders. This value represents the number of vector values that can be interpolated; varying 
		/// variables declared as matrices and arrays will consume multiple interpolators. The value must be at least 15.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MAX_VARYING_VECTORS = 0x8DFC;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the maximum number of individual 4-vectors of floating-point, integer, or boolean 
		/// values that can be held in uniform variable storage for a fragment shader. The value is equal to the value of 
		/// Gl.MAX_FRAGMENT_UNIFORM_COMPONENTS divided by 4 and must be at least 256. See Gl.Uniform.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum number of vector floating-point, integer, or boolean values that 
		/// can be held in uniform variable storage for a fragment shader. The value must be at least 224. See Gl.Uniform.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;

		/// <summary>
		/// [GL] Value of GL_RGB565 symbol.
		/// </summary>
		[AliasOf("GL_RGB565_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		public const int RGB565 = 0x8D62;

		/// <summary>
		/// [GLES3.2] Gl.GetProgram: params returns the current value of whether the binary retrieval hint is enabled for program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		public const int PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;

		/// <summary>
		/// [GL4] Gl.GetProgram: params returns the length of the program binary, in bytes that will be returned by a call to 
		/// Gl.GetProgramBinary. When a progam's Gl.LINK_STATUS is Gl.FALSE, its program binary length is zero.
		/// </summary>
		[AliasOf("GL_PROGRAM_BINARY_LENGTH_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public const int PROGRAM_BINARY_LENGTH = 0x8741;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the number of program binary formats supported by the implementation.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single integer value indicating the number of available program binary formats. The 
		/// minimum value is 0. See Gl.ProgramBinary.
		/// </para>
		/// </summary>
		[AliasOf("GL_NUM_PROGRAM_BINARY_FORMATS_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public const int NUM_PROGRAM_BINARY_FORMATS = 0x87FE;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data an array of Gl.NUM_PROGRAM_BINARY_FORMATS values, indicating the proram binary formats supported by 
		/// the implementation.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a list of symbolic constants of length Gl.NUM_PROGRAM_BINARY_FORMATS indicating which 
		/// program binary formats are available. See Gl.ProgramBinary.
		/// </para>
		/// </summary>
		[AliasOf("GL_PROGRAM_BINARY_FORMATS_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public const int PROGRAM_BINARY_FORMATS = 0x87FF;

		/// <summary>
		/// [GL] Value of GL_VERTEX_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_SHADER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint VERTEX_SHADER_BIT = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_FRAGMENT_SHADER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FRAGMENT_SHADER_BIT = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_GEOMETRY_SHADER_BIT_EXT")]
		[AliasOf("GL_GEOMETRY_SHADER_BIT_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint GEOMETRY_SHADER_BIT = 0x00000004;

		/// <summary>
		/// [GL] Value of GL_TESS_CONTROL_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TESS_CONTROL_SHADER_BIT_EXT")]
		[AliasOf("GL_TESS_CONTROL_SHADER_BIT_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;

		/// <summary>
		/// [GL] Value of GL_TESS_EVALUATION_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TESS_EVALUATION_SHADER_BIT_EXT")]
		[AliasOf("GL_TESS_EVALUATION_SHADER_BIT_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;

		/// <summary>
		/// [GL] Value of GL_ALL_SHADER_BITS symbol.
		/// </summary>
		[AliasOf("GL_ALL_SHADER_BITS_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint ALL_SHADER_BITS = 0xFFFFFFFF;

		/// <summary>
		/// [GLES3.2] Gl.GetProgram: params returns Gl.TRUE if the program has been flagged for use as a separable program object 
		/// that can be found to individual shader stages with Gl.UseProgramStages.
		/// </summary>
		[AliasOf("GL_PROGRAM_SEPARABLE_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		public const int PROGRAM_SEPARABLE = 0x8258;

		/// <summary>
		/// [GL] Value of GL_ACTIVE_PROGRAM symbol.
		/// </summary>
		[AliasOf("GL_ACTIVE_PROGRAM_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		public const int ACTIVE_PROGRAM = 0x8259;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data a single value, the name of the currently bound program pipeline object, or zero if no 
		/// program pipeline object is bound. See Gl.BindProgramPipeline.
		/// </summary>
		[AliasOf("GL_PROGRAM_PIPELINE_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		public const int PROGRAM_PIPELINE_BINDING = 0x825A;

		/// <summary>
		/// [GL4] Gl.Get: data returns one value, the maximum number of simultaneous viewports that are supported. The value must be 
		/// at least 16. See Gl.ViewportIndexed.
		/// </summary>
		[AliasOf("GL_MAX_VIEWPORTS_NV")]
		[AliasOf("GL_MAX_VIEWPORTS_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public const int MAX_VIEWPORTS = 0x825B;

		/// <summary>
		/// [GL4] Gl.Get: data returns a single value, the number of bits of sub-pixel precision which the GL uses to interpret the 
		/// floating point viewport bounds. The minimum value is 0.
		/// </summary>
		[AliasOf("GL_VIEWPORT_SUBPIXEL_BITS_NV")]
		[AliasOf("GL_VIEWPORT_SUBPIXEL_BITS_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public const int VIEWPORT_SUBPIXEL_BITS = 0x825C;

		/// <summary>
		/// [GL4] Gl.Get: data returns two values, the minimum and maximum viewport bounds range. The minimum range should be at 
		/// least [-32768, 32767].
		/// </summary>
		[AliasOf("GL_VIEWPORT_BOUNDS_RANGE_NV")]
		[AliasOf("GL_VIEWPORT_BOUNDS_RANGE_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public const int VIEWPORT_BOUNDS_RANGE = 0x825D;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the implementation dependent specifc vertex of a primitive that is used to select 
		/// the rendering layer. If the value returned is equivalent to Gl.PROVOKING_VERTEX, then the vertex selection follows the 
		/// convention specified by Gl.ProvokingVertex. If the value returned is equivalent to Gl.FIRST_VERTEX_CONVENTION, then the 
		/// selection is always taken from the first vertex in the primitive. If the value returned is equivalent to 
		/// Gl.LAST_VERTEX_CONVENTION, then the selection is always taken from the last vertex in the primitive. If the value 
		/// returned is equivalent to Gl.UNDEFINED_VERTEX, then the selection is not guaranteed to be taken from any specific vertex 
		/// in the primitive.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the implementation dependent specifc vertex of a primitive that is used to 
		/// select the rendering layer. If the value returned is Gl.FIRST_VERTEX_CONVENTION, then the selection is always taken from 
		/// the first vertex in the primitive. If the value returned is Gl.LAST_VERTEX_CONVENTION, then the selection is always 
		/// taken from the last vertex in the primitive. If the value returned is Gl.UNDEFINED_VERTEX, then the selection is not 
		/// guaranteed to be taken from any specific vertex in the primitive. Portable applications will therefore assign the same 
		/// layer for all vertices in a primitive.
		/// </para>
		/// </summary>
		[AliasOf("GL_LAYER_PROVOKING_VERTEX_EXT")]
		[AliasOf("GL_LAYER_PROVOKING_VERTEX_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int LAYER_PROVOKING_VERTEX = 0x825E;

		/// <summary>
		/// [GL4] Gl.Get: data returns one value, the implementation dependent specifc vertex of a primitive that is used to select 
		/// the viewport index. If the value returned is equivalent to Gl.PROVOKING_VERTEX, then the vertex selection follows the 
		/// convention specified by Gl.ProvokingVertex. If the value returned is equivalent to Gl.FIRST_VERTEX_CONVENTION, then the 
		/// selection is always taken from the first vertex in the primitive. If the value returned is equivalent to 
		/// Gl.LAST_VERTEX_CONVENTION, then the selection is always taken from the last vertex in the primitive. If the value 
		/// returned is equivalent to Gl.UNDEFINED_VERTEX, then the selection is not guaranteed to be taken from any specific vertex 
		/// in the primitive.
		/// </summary>
		[AliasOf("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV")]
		[AliasOf("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public const int VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;

		/// <summary>
		/// [GL] Value of GL_UNDEFINED_VERTEX symbol.
		/// </summary>
		[AliasOf("GL_UNDEFINED_VERTEX_EXT")]
		[AliasOf("GL_UNDEFINED_VERTEX_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int UNDEFINED_VERTEX = 0x8260;

		/// <summary>
		/// release resources consumed by the implementation's shader compiler
		/// </summary>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void ReleaseShaderCompiler()
		{
			Debug.Assert(Delegates.pglReleaseShaderCompiler != null, "pglReleaseShaderCompiler not implemented");
			Delegates.pglReleaseShaderCompiler();
			LogCommand("glReleaseShaderCompiler", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// load pre-compiled shader binaries
		/// </summary>
		/// <param name="count">
		/// Specifies the number of shader object handles contained in <paramref name="shaders"/>.
		/// </param>
		/// <param name="shaders">
		/// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
		/// </param>
		/// <param name="binaryformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="binary">
		/// Specifies the address of an array of bytes containing pre-compiled binary shader code.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the array whose address is given in <paramref name="binary"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if more than one of the handles in <paramref name="shaders"/> refers to the same 
		/// shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="binaryFormat"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the data pointed to by <paramref name="binary"/> does not match the format specified by 
		/// <paramref name="binaryFormat"/>.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void ShaderBinary(Int32 count, UInt32[] shaders, Int32 binaryformat, Object binary, Int32 length)
		{
			GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
			try {
				ShaderBinary(count, shaders, binaryformat, pin_binary.AddrOfPinnedObject(), length);
			} finally {
				pin_binary.Free();
			}
		}

		/// <summary>
		/// load pre-compiled shader binaries
		/// </summary>
		/// <param name="shaders">
		/// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
		/// </param>
		/// <param name="binaryformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="binary">
		/// Specifies the address of an array of bytes containing pre-compiled binary shader code.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the array whose address is given in <paramref name="binary"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if more than one of the handles in <paramref name="shaders"/> refers to the same 
		/// shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="binaryFormat"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the data pointed to by <paramref name="binary"/> does not match the format specified by 
		/// <paramref name="binaryFormat"/>.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void ShaderBinary(UInt32[] shaders, Int32 binaryformat, IntPtr binary, Int32 length)
		{
			unsafe {
				fixed (UInt32* p_shaders = shaders)
				{
					Debug.Assert(Delegates.pglShaderBinary != null, "pglShaderBinary not implemented");
					Delegates.pglShaderBinary((Int32)shaders.Length, p_shaders, binaryformat, binary, length);
					LogCommand("glShaderBinary", null, shaders.Length, shaders, binaryformat, binary, length					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the range and precision for numeric formats supported by the shader compiler
		/// </summary>
		/// <param name="shadertype">
		/// A <see cref="T:ShaderType"/>.
		/// </param>
		/// <param name="precisiontype">
		/// A <see cref="T:PrecisionType"/>.
		/// </param>
		/// <param name="range">
		/// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
		/// </param>
		/// <param name="precision">
		/// Specifies the address of an integer into which the numeric precision of the implementation is written.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shaderType"/> or <paramref name="precisionType"/> is not an accepted 
		/// value.
		/// </exception>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, [Out] Int32[] range, [Out] Int32[] precision)
		{
			unsafe {
				fixed (Int32* p_range = range)
				fixed (Int32* p_precision = precision)
				{
					Debug.Assert(Delegates.pglGetShaderPrecisionFormat != null, "pglGetShaderPrecisionFormat not implemented");
					Delegates.pglGetShaderPrecisionFormat((Int32)shadertype, (Int32)precisiontype, p_range, p_precision);
					LogCommand("glGetShaderPrecisionFormat", null, shadertype, precisiontype, range, precision					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the range and precision for numeric formats supported by the shader compiler
		/// </summary>
		/// <param name="shadertype">
		/// A <see cref="T:ShaderType"/>.
		/// </param>
		/// <param name="precisiontype">
		/// A <see cref="T:PrecisionType"/>.
		/// </param>
		/// <param name="range">
		/// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
		/// </param>
		/// <param name="precision">
		/// Specifies the address of an integer into which the numeric precision of the implementation is written.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shaderType"/> or <paramref name="precisionType"/> is not an accepted 
		/// value.
		/// </exception>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, out Int32 range, out Int32 precision)
		{
			unsafe {
				fixed (Int32* p_range = &range)
				fixed (Int32* p_precision = &precision)
				{
					Debug.Assert(Delegates.pglGetShaderPrecisionFormat != null, "pglGetShaderPrecisionFormat not implemented");
					Delegates.pglGetShaderPrecisionFormat((Int32)shadertype, (Int32)precisiontype, p_range, p_precision);
					LogCommand("glGetShaderPrecisionFormat", null, shadertype, precisiontype, range, precision					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		[AliasOf("glDepthRangefOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
		public static void DepthRange(float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangef != null, "pglDepthRangef not implemented");
			Delegates.pglDepthRangef(n, f);
			LogCommand("glDepthRangef", null, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the clear value for the depth buffer
		/// </summary>
		/// <param name="d">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.removedTypes"/>
		[AliasOf("glClearDepthfOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
		public static void ClearDepth(float d)
		{
			Debug.Assert(Delegates.pglClearDepthf != null, "pglClearDepthf not implemented");
			Delegates.pglClearDepthf(d);
			LogCommand("glClearDepthf", null, d			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object whose binary representation to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer whose address is given by <paramref name="binary"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable to receive the number of bytes written into <paramref name="binary"/>.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array into which the GL will return <paramref name="program"/>'s binary representation.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="bufSize"/> is less than the size of Gl.PROGRAM_BINARY_LENGTH for 
		/// <paramref name="program"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LINK_STATUS for the program object is false.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[AliasOf("glGetProgramBinaryOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public static void GetProgramBinary(UInt32 program, Int32 bufSize, out Int32 length, out Int32 binaryFormat, IntPtr binary)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_binaryFormat = &binaryFormat)
				{
					Debug.Assert(Delegates.pglGetProgramBinary != null, "pglGetProgramBinary not implemented");
					Delegates.pglGetProgramBinary(program, bufSize, p_length, p_binaryFormat, binary);
					LogCommand("glGetProgramBinary", null, program, bufSize, length, binaryFormat, binary					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object whose binary representation to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer whose address is given by <paramref name="binary"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable to receive the number of bytes written into <paramref name="binary"/>.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array into which the GL will return <paramref name="program"/>'s binary representation.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="bufSize"/> is less than the size of Gl.PROGRAM_BINARY_LENGTH for 
		/// <paramref name="program"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LINK_STATUS for the program object is false.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[AliasOf("glGetProgramBinaryOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public static void GetProgramBinary(UInt32 program, Int32 bufSize, out Int32 length, out Int32 binaryFormat, Object binary)
		{
			GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
			try {
				GetProgramBinary(program, bufSize, out length, out binaryFormat, pin_binary.AddrOfPinnedObject());
			} finally {
				pin_binary.Free();
			}
		}

		/// <summary>
		/// load a program object with a program binary
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object into which to load a program binary.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the format of the binary data in binary.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array containing the binary to be loaded into <paramref name="program"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the number of bytes contained in <paramref name="binary"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="binaryFormat"/> is not a value recognized by the implementation.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		[AliasOf("glProgramBinaryOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public static void ProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length)
		{
			Debug.Assert(Delegates.pglProgramBinary != null, "pglProgramBinary not implemented");
			Delegates.pglProgramBinary(program, binaryFormat, binary, length);
			LogCommand("glProgramBinary", null, program, binaryFormat, binary, length			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// load a program object with a program binary
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object into which to load a program binary.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the format of the binary data in binary.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array containing the binary to be loaded into <paramref name="program"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the number of bytes contained in <paramref name="binary"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="binaryFormat"/> is not a value recognized by the implementation.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		[AliasOf("glProgramBinaryOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public static void ProgramBinary(UInt32 program, Int32 binaryFormat, Object binary, Int32 length)
		{
			GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
			try {
				ProgramBinary(program, binaryFormat, pin_binary.AddrOfPinnedObject(), length);
			} finally {
				pin_binary.Free();
			}
		}

		/// <summary>
		/// specify a parameter for a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object whose parameter to modify.
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the parameter to modify.
		/// </param>
		/// <param name="value">
		/// Specifies the new value of the parameter specified by <paramref name="pname"/> for <paramref name="program"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="value"/> is not a valid value for the parameter named by <paramref 
		/// name="pname"/>.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[AliasOf("glProgramParameteriARB")]
		[AliasOf("glProgramParameteriEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramParameter(UInt32 program, ProgramParameterPName pname, Int32 value)
		{
			Debug.Assert(Delegates.pglProgramParameteri != null, "pglProgramParameteri not implemented");
			Delegates.pglProgramParameteri(program, (Int32)pname, value);
			LogCommand("glProgramParameteri", null, program, pname, value			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind stages of a program object to a program pipeline
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the program pipeline object to which to bind stages from <paramref name="program"/>.
		/// </param>
		/// <param name="stages">
		/// Specifies a set of program stages to bind to the program pipeline object.
		/// </param>
		/// <param name="program">
		/// Specifies the program object containing the shader executables to use in <paramref name="pipeline"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shaders"/> contains set bits that are not recognized, and is not the 
		/// reserved value Gl.ALL_SHADER_BITS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> refers to a program object that was not linked with its 
		/// Gl.PROGRAM_SEPARABLE status set.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> refers to a program object that has not been 
		/// successfully linked.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not a name previously returned from a call to 
		/// glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void UseProgramStage(UInt32 pipeline, UInt32 stages, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgramStages != null, "pglUseProgramStages not implemented");
			Delegates.pglUseProgramStages(pipeline, stages, program);
			LogCommand("glUseProgramStages", null, pipeline, stages, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the active program object for a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the program pipeline object to set the active program object for.
		/// </param>
		/// <param name="program">
		/// Specifies the program object to set as the active program pipeline object <paramref name="pipeline"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not a name previously returned from a call to 
		/// glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> refers to a program object that has not been 
		/// successfully linked.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ActiveShaderProgram(UInt32 pipeline, UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveShaderProgram != null, "pglActiveShaderProgram not implemented");
			Delegates.pglActiveShaderProgram(pipeline, program);
			LogCommand("glActiveShaderProgram", null, pipeline, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create a stand-alone program from an array of null-terminated source code strings
		/// </summary>
		/// <param name="type">
		/// Specifies the type of shader to create.
		/// </param>
		/// <param name="count">
		/// Specifies the number of source code strings in the array <paramref name="strings"/>.
		/// </param>
		/// <param name="strings">
		/// Specifies the address of an array of pointers to source code strings from which to create the program object.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted shader type.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Other errors are generated if the supplied shader code fails to compile and link, as described for the commands in the 
		/// pseudocode sequence above, but all such errors are generated without any side effects of executing those commands.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static UInt32 CreateShaderProgram(ShaderType type, Int32 count, params String[] strings)
		{
			Debug.Assert(strings.Length >= count);
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramv != null, "pglCreateShaderProgramv not implemented");
			retValue = Delegates.pglCreateShaderProgramv((Int32)type, count, strings);
			LogCommand("glCreateShaderProgramv", retValue, type, count, strings			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// create a stand-alone program from an array of null-terminated source code strings
		/// </summary>
		/// <param name="type">
		/// Specifies the type of shader to create.
		/// </param>
		/// <param name="strings">
		/// Specifies the address of an array of pointers to source code strings from which to create the program object.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted shader type.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Other errors are generated if the supplied shader code fails to compile and link, as described for the commands in the 
		/// pseudocode sequence above, but all such errors are generated without any side effects of executing those commands.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static UInt32 CreateShaderProgram(ShaderType type, params String[] strings)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramv != null, "pglCreateShaderProgramv not implemented");
			retValue = Delegates.pglCreateShaderProgramv((Int32)type, (Int32)strings.Length, strings);
			LogCommand("glCreateShaderProgramv", retValue, type, strings.Length, strings			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// bind a program pipeline to the current context
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of the pipeline object to bind to the context.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not zero or a name previously returned from a call 
		/// to glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void BindProgramPipeline(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglBindProgramPipeline != null, "pglBindProgramPipeline not implemented");
			Delegates.pglBindProgramPipeline(pipeline);
			LogCommand("glBindProgramPipeline", null, pipeline			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delete program pipeline objects
		/// </summary>
		/// <param name="pipelines">
		/// Specifies an array of names of program pipeline objects to delete.
		/// </param>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		/// <seealso cref="Gl.UseProgramStages"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void DeleteProgramPipelines(params UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglDeleteProgramPipelines != null, "pglDeleteProgramPipelines not implemented");
					Delegates.pglDeleteProgramPipelines((Int32)pipelines.Length, p_pipelines);
					LogCommand("glDeleteProgramPipelines", null, pipelines.Length, pipelines					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// reserve program pipeline object names
		/// </summary>
		/// <param name="pipelines">
		/// Specifies an array of into which the reserved names will be written.
		/// </param>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		/// <seealso cref="Gl.UseProgramStages"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void GenProgramPipelines(UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglGenProgramPipelines != null, "pglGenProgramPipelines not implemented");
					Delegates.pglGenProgramPipelines((Int32)pipelines.Length, p_pipelines);
					LogCommand("glGenProgramPipelines", null, pipelines.Length, pipelines					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// reserve program pipeline object names
		/// </summary>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		/// <seealso cref="Gl.UseProgramStages"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static UInt32 GenProgramPipeline()
		{
			UInt32[] retValue = new UInt32[1];
			GenProgramPipelines(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies a value that may be the name of a program pipeline object.
		/// </param>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static bool IsProgramPipeline(UInt32 pipeline)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgramPipeline != null, "pglIsProgramPipeline not implemented");
			retValue = Delegates.pglIsProgramPipeline(pipeline);
			LogCommand("glIsProgramPipeline", retValue, pipeline			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// retrieve properties of a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of a program pipeline object whose parameter retrieve.
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the parameter to retrieve.
		/// </param>
		/// <param name="params">
		/// Specifies the address of a variable into which will be written the value or values of <paramref name="pname"/> for 
		/// <paramref name="pipeline"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not zero or a name previously returned from a call 
		/// to glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted values.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void GetProgramPipeline(UInt32 pipeline, PipelineParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineiv != null, "pglGetProgramPipelineiv not implemented");
					Delegates.pglGetProgramPipelineiv(pipeline, (Int32)pname, p_params);
					LogCommand("glGetProgramPipelineiv", null, pipeline, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1iEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1i != null, "pglProgramUniform1i not implemented");
			Delegates.pglProgramUniform1i(program, location, v0);
			LogCommand("glProgramUniform1i", null, program, location, v0			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1iv != null, "pglProgramUniform1iv not implemented");
					Delegates.pglProgramUniform1iv(program, location, (Int32)value.Length, p_value);
					LogCommand("glProgramUniform1iv", null, program, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform1(UInt32 program, Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglProgramUniform1iv != null, "pglProgramUniform1iv not implemented");
			Delegates.pglProgramUniform1iv(program, location, count, value);
			LogCommand("glProgramUniform1iv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1fEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, float v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1f != null, "pglProgramUniform1f not implemented");
			Delegates.pglProgramUniform1f(program, location, v0);
			LogCommand("glProgramUniform1f", null, program, location, v0			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1fv != null, "pglProgramUniform1fv not implemented");
					Delegates.pglProgramUniform1fv(program, location, (Int32)value.Length, p_value);
					LogCommand("glProgramUniform1fv", null, program, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform1(UInt32 program, Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniform1fv != null, "pglProgramUniform1fv not implemented");
			Delegates.pglProgramUniform1fv(program, location, count, value);
			LogCommand("glProgramUniform1fv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1d.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform1(UInt32 program, Int32 location, double v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1d != null, "pglProgramUniform1d not implemented");
			Delegates.pglProgramUniform1d(program, location, v0);
			LogCommand("glProgramUniform1d", null, program, location, v0			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform1(UInt32 program, Int32 location, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1dv != null, "pglProgramUniform1dv not implemented");
					Delegates.pglProgramUniform1dv(program, location, (Int32)value.Length, p_value);
					LogCommand("glProgramUniform1dv", null, program, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniform1(UInt32 program, Int32 location, Int32 count, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniform1dv != null, "pglProgramUniform1dv not implemented");
			Delegates.pglProgramUniform1dv(program, location, count, value);
			LogCommand("glProgramUniform1dv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1uiEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, UInt32 v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1ui != null, "pglProgramUniform1ui not implemented");
			Delegates.pglProgramUniform1ui(program, location, v0);
			LogCommand("glProgramUniform1ui", null, program, location, v0			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1uiv != null, "pglProgramUniform1uiv not implemented");
					Delegates.pglProgramUniform1uiv(program, location, (Int32)value.Length, p_value);
					LogCommand("glProgramUniform1uiv", null, program, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform1(UInt32 program, Int32 location, Int32 count, UInt32* value)
		{
			Debug.Assert(Delegates.pglProgramUniform1uiv != null, "pglProgramUniform1uiv not implemented");
			Delegates.pglProgramUniform1uiv(program, location, count, value);
			LogCommand("glProgramUniform1uiv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2iEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 v0, Int32 v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2i != null, "pglProgramUniform2i not implemented");
			Delegates.pglProgramUniform2i(program, location, v0, v1);
			LogCommand("glProgramUniform2i", null, program, location, v0, v1			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2iv != null, "pglProgramUniform2iv not implemented");
					Delegates.pglProgramUniform2iv(program, location, count, p_value);
					LogCommand("glProgramUniform2iv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform2(UInt32 program, Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglProgramUniform2iv != null, "pglProgramUniform2iv not implemented");
			Delegates.pglProgramUniform2iv(program, location, count, value);
			LogCommand("glProgramUniform2iv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2fEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, float v0, float v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2f != null, "pglProgramUniform2f not implemented");
			Delegates.pglProgramUniform2f(program, location, v0, v1);
			LogCommand("glProgramUniform2f", null, program, location, v0, v1			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2fv != null, "pglProgramUniform2fv not implemented");
					Delegates.pglProgramUniform2fv(program, location, count, p_value);
					LogCommand("glProgramUniform2fv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform2(UInt32 program, Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniform2fv != null, "pglProgramUniform2fv not implemented");
			Delegates.pglProgramUniform2fv(program, location, count, value);
			LogCommand("glProgramUniform2fv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2d.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform2(UInt32 program, Int32 location, double v0, double v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2d != null, "pglProgramUniform2d not implemented");
			Delegates.pglProgramUniform2d(program, location, v0, v1);
			LogCommand("glProgramUniform2d", null, program, location, v0, v1			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2dv != null, "pglProgramUniform2dv not implemented");
					Delegates.pglProgramUniform2dv(program, location, count, p_value);
					LogCommand("glProgramUniform2dv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniform2(UInt32 program, Int32 location, Int32 count, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniform2dv != null, "pglProgramUniform2dv not implemented");
			Delegates.pglProgramUniform2dv(program, location, count, value);
			LogCommand("glProgramUniform2dv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2uiEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, UInt32 v0, UInt32 v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2ui != null, "pglProgramUniform2ui not implemented");
			Delegates.pglProgramUniform2ui(program, location, v0, v1);
			LogCommand("glProgramUniform2ui", null, program, location, v0, v1			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2uiv != null, "pglProgramUniform2uiv not implemented");
					Delegates.pglProgramUniform2uiv(program, location, count, p_value);
					LogCommand("glProgramUniform2uiv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform2(UInt32 program, Int32 location, Int32 count, UInt32* value)
		{
			Debug.Assert(Delegates.pglProgramUniform2uiv != null, "pglProgramUniform2uiv not implemented");
			Delegates.pglProgramUniform2uiv(program, location, count, value);
			LogCommand("glProgramUniform2uiv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3iEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3i != null, "pglProgramUniform3i not implemented");
			Delegates.pglProgramUniform3i(program, location, v0, v1, v2);
			LogCommand("glProgramUniform3i", null, program, location, v0, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3iv != null, "pglProgramUniform3iv not implemented");
					Delegates.pglProgramUniform3iv(program, location, count, p_value);
					LogCommand("glProgramUniform3iv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform3(UInt32 program, Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglProgramUniform3iv != null, "pglProgramUniform3iv not implemented");
			Delegates.pglProgramUniform3iv(program, location, count, value);
			LogCommand("glProgramUniform3iv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3fEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, float v0, float v1, float v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3f != null, "pglProgramUniform3f not implemented");
			Delegates.pglProgramUniform3f(program, location, v0, v1, v2);
			LogCommand("glProgramUniform3f", null, program, location, v0, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3fv != null, "pglProgramUniform3fv not implemented");
					Delegates.pglProgramUniform3fv(program, location, count, p_value);
					LogCommand("glProgramUniform3fv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform3(UInt32 program, Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniform3fv != null, "pglProgramUniform3fv not implemented");
			Delegates.pglProgramUniform3fv(program, location, count, value);
			LogCommand("glProgramUniform3fv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3d.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform3(UInt32 program, Int32 location, double v0, double v1, double v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3d != null, "pglProgramUniform3d not implemented");
			Delegates.pglProgramUniform3d(program, location, v0, v1, v2);
			LogCommand("glProgramUniform3d", null, program, location, v0, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3dv != null, "pglProgramUniform3dv not implemented");
					Delegates.pglProgramUniform3dv(program, location, count, p_value);
					LogCommand("glProgramUniform3dv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniform3(UInt32 program, Int32 location, Int32 count, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniform3dv != null, "pglProgramUniform3dv not implemented");
			Delegates.pglProgramUniform3dv(program, location, count, value);
			LogCommand("glProgramUniform3dv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3uiEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3ui != null, "pglProgramUniform3ui not implemented");
			Delegates.pglProgramUniform3ui(program, location, v0, v1, v2);
			LogCommand("glProgramUniform3ui", null, program, location, v0, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3uiv != null, "pglProgramUniform3uiv not implemented");
					Delegates.pglProgramUniform3uiv(program, location, count, p_value);
					LogCommand("glProgramUniform3uiv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform3(UInt32 program, Int32 location, Int32 count, UInt32* value)
		{
			Debug.Assert(Delegates.pglProgramUniform3uiv != null, "pglProgramUniform3uiv not implemented");
			Delegates.pglProgramUniform3uiv(program, location, count, value);
			LogCommand("glProgramUniform3uiv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4iEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4i != null, "pglProgramUniform4i not implemented");
			Delegates.pglProgramUniform4i(program, location, v0, v1, v2, v3);
			LogCommand("glProgramUniform4i", null, program, location, v0, v1, v2, v3			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4iv != null, "pglProgramUniform4iv not implemented");
					Delegates.pglProgramUniform4iv(program, location, count, p_value);
					LogCommand("glProgramUniform4iv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform4(UInt32 program, Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglProgramUniform4iv != null, "pglProgramUniform4iv not implemented");
			Delegates.pglProgramUniform4iv(program, location, count, value);
			LogCommand("glProgramUniform4iv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4fEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, float v0, float v1, float v2, float v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4f != null, "pglProgramUniform4f not implemented");
			Delegates.pglProgramUniform4f(program, location, v0, v1, v2, v3);
			LogCommand("glProgramUniform4f", null, program, location, v0, v1, v2, v3			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4fv != null, "pglProgramUniform4fv not implemented");
					Delegates.pglProgramUniform4fv(program, location, count, p_value);
					LogCommand("glProgramUniform4fv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform4(UInt32 program, Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniform4fv != null, "pglProgramUniform4fv not implemented");
			Delegates.pglProgramUniform4fv(program, location, count, value);
			LogCommand("glProgramUniform4fv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4d.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v3">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform4(UInt32 program, Int32 location, double v0, double v1, double v2, double v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4d != null, "pglProgramUniform4d not implemented");
			Delegates.pglProgramUniform4d(program, location, v0, v1, v2, v3);
			LogCommand("glProgramUniform4d", null, program, location, v0, v1, v2, v3			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4dv != null, "pglProgramUniform4dv not implemented");
					Delegates.pglProgramUniform4dv(program, location, count, p_value);
					LogCommand("glProgramUniform4dv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniform4(UInt32 program, Int32 location, Int32 count, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniform4dv != null, "pglProgramUniform4dv not implemented");
			Delegates.pglProgramUniform4dv(program, location, count, value);
			LogCommand("glProgramUniform4dv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4uiEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4ui != null, "pglProgramUniform4ui not implemented");
			Delegates.pglProgramUniform4ui(program, location, v0, v1, v2, v3);
			LogCommand("glProgramUniform4ui", null, program, location, v0, v1, v2, v3			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4uiv != null, "pglProgramUniform4uiv not implemented");
					Delegates.pglProgramUniform4uiv(program, location, count, p_value);
					LogCommand("glProgramUniform4uiv", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniform4(UInt32 program, Int32 location, Int32 count, UInt32* value)
		{
			Debug.Assert(Delegates.pglProgramUniform4uiv != null, "pglProgramUniform4uiv not implemented");
			Delegates.pglProgramUniform4uiv(program, location, count, value);
			LogCommand("glProgramUniform4uiv", null, program, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix2(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2fv != null, "pglProgramUniformMatrix2fv not implemented");
					Delegates.pglProgramUniformMatrix2fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix2fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix2(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix2fv != null, "pglProgramUniformMatrix2fv not implemented");
			Delegates.pglProgramUniformMatrix2fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix2fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix3(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3fv != null, "pglProgramUniformMatrix3fv not implemented");
					Delegates.pglProgramUniformMatrix3fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix3fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix3(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix3fv != null, "pglProgramUniformMatrix3fv not implemented");
			Delegates.pglProgramUniformMatrix3fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix3fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix4(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4fv != null, "pglProgramUniformMatrix4fv not implemented");
					Delegates.pglProgramUniformMatrix4fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix4fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix4(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix4fv != null, "pglProgramUniformMatrix4fv not implemented");
			Delegates.pglProgramUniformMatrix4fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix4fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2dv != null, "pglProgramUniformMatrix2dv not implemented");
					Delegates.pglProgramUniformMatrix2dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix2dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix2(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix2dv != null, "pglProgramUniformMatrix2dv not implemented");
			Delegates.pglProgramUniformMatrix2dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix2dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3dv != null, "pglProgramUniformMatrix3dv not implemented");
					Delegates.pglProgramUniformMatrix3dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix3dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix3(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix3dv != null, "pglProgramUniformMatrix3dv not implemented");
			Delegates.pglProgramUniformMatrix3dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix3dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4dv != null, "pglProgramUniformMatrix4dv not implemented");
					Delegates.pglProgramUniformMatrix4dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix4dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix4(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix4dv != null, "pglProgramUniformMatrix4dv not implemented");
			Delegates.pglProgramUniformMatrix4dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix4dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2x3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix2x3(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x3fv != null, "pglProgramUniformMatrix2x3fv not implemented");
					Delegates.pglProgramUniformMatrix2x3fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix2x3fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2x3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix2x3(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix2x3fv != null, "pglProgramUniformMatrix2x3fv not implemented");
			Delegates.pglProgramUniformMatrix2x3fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix2x3fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3x2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix3x2(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x2fv != null, "pglProgramUniformMatrix3x2fv not implemented");
					Delegates.pglProgramUniformMatrix3x2fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix3x2fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3x2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix3x2(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix3x2fv != null, "pglProgramUniformMatrix3x2fv not implemented");
			Delegates.pglProgramUniformMatrix3x2fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix3x2fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2x4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix2x4(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x4fv != null, "pglProgramUniformMatrix2x4fv not implemented");
					Delegates.pglProgramUniformMatrix2x4fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix2x4fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2x4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix2x4(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix2x4fv != null, "pglProgramUniformMatrix2x4fv not implemented");
			Delegates.pglProgramUniformMatrix2x4fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix2x4fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4x2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix4x2(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x2fv != null, "pglProgramUniformMatrix4x2fv not implemented");
					Delegates.pglProgramUniformMatrix4x2fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix4x2fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4x2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix4x2(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix4x2fv != null, "pglProgramUniformMatrix4x2fv not implemented");
			Delegates.pglProgramUniformMatrix4x2fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix4x2fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3x4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix3x4(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x4fv != null, "pglProgramUniformMatrix3x4fv not implemented");
					Delegates.pglProgramUniformMatrix3x4fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix3x4fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3x4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix3x4(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix3x4fv != null, "pglProgramUniformMatrix3x4fv not implemented");
			Delegates.pglProgramUniformMatrix3x4fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix3x4fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4x3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ProgramUniformMatrix4x3(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x3fv != null, "pglProgramUniformMatrix4x3fv not implemented");
					Delegates.pglProgramUniformMatrix4x3fv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix4x3fv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4x3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static unsafe void ProgramUniformMatrix4x3(UInt32 program, Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix4x3fv != null, "pglProgramUniformMatrix4x3fv not implemented");
			Delegates.pglProgramUniformMatrix4x3fv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix4x3fv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2x3dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2x3(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x3dv != null, "pglProgramUniformMatrix2x3dv not implemented");
					Delegates.pglProgramUniformMatrix2x3dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix2x3dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2x3dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix2x3(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix2x3dv != null, "pglProgramUniformMatrix2x3dv not implemented");
			Delegates.pglProgramUniformMatrix2x3dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix2x3dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3x2dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3x2(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x2dv != null, "pglProgramUniformMatrix3x2dv not implemented");
					Delegates.pglProgramUniformMatrix3x2dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix3x2dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3x2dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix3x2(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix3x2dv != null, "pglProgramUniformMatrix3x2dv not implemented");
			Delegates.pglProgramUniformMatrix3x2dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix3x2dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2x4dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2x4(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x4dv != null, "pglProgramUniformMatrix2x4dv not implemented");
					Delegates.pglProgramUniformMatrix2x4dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix2x4dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2x4dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix2x4(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix2x4dv != null, "pglProgramUniformMatrix2x4dv not implemented");
			Delegates.pglProgramUniformMatrix2x4dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix2x4dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4x2dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4x2(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x2dv != null, "pglProgramUniformMatrix4x2dv not implemented");
					Delegates.pglProgramUniformMatrix4x2dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix4x2dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4x2dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix4x2(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix4x2dv != null, "pglProgramUniformMatrix4x2dv not implemented");
			Delegates.pglProgramUniformMatrix4x2dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix4x2dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3x4dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3x4(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x4dv != null, "pglProgramUniformMatrix3x4dv not implemented");
					Delegates.pglProgramUniformMatrix3x4dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix3x4dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3x4dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix3x4(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix3x4dv != null, "pglProgramUniformMatrix3x4dv not implemented");
			Delegates.pglProgramUniformMatrix3x4dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix3x4dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4x3dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4x3(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x3dv != null, "pglProgramUniformMatrix4x3dv not implemented");
					Delegates.pglProgramUniformMatrix4x3dv(program, location, count, transpose, p_value);
					LogCommand("glProgramUniformMatrix4x3dv", null, program, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4x3dv.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double*"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static unsafe void ProgramUniformMatrix4x3(UInt32 program, Int32 location, Int32 count, bool transpose, double* value)
		{
			Debug.Assert(Delegates.pglProgramUniformMatrix4x3dv != null, "pglProgramUniformMatrix4x3dv not implemented");
			Delegates.pglProgramUniformMatrix4x3dv(program, location, count, transpose, value);
			LogCommand("glProgramUniformMatrix4x3dv", null, program, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// validate a program pipeline object against current GL state
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of a program pipeline object to validate.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not a name previously returned from a call to 
		/// glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ValidateProgramPipeline(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglValidateProgramPipeline != null, "pglValidateProgramPipeline not implemented");
			Delegates.pglValidateProgramPipeline(pipeline);
			LogCommand("glValidateProgramPipeline", null, pipeline			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the info log string from a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of a program pipeline object from which to retrieve the info log.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the maximum number of characters, including the null terminator, that may be written into <paramref 
		/// name="infoLog"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable into which will be written the number of characters written into <paramref 
		/// name="infoLog"/>.
		/// </param>
		/// <param name="infoLog">
		/// Specifies the address of an array of characters into which will be written the info log for <paramref name="pipeline"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not a name previously returned from a call to 
		/// glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.GetProgramPipeline"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineInfoLog != null, "pglGetProgramPipelineInfoLog not implemented");
					Delegates.pglGetProgramPipelineInfoLog(pipeline, bufSize, p_length, infoLog);
					LogCommand("glGetProgramPipelineInfoLog", null, pipeline, bufSize, length, infoLog					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL1dEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL1(UInt32 index, double x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1d != null, "pglVertexAttribL1d not implemented");
			Delegates.pglVertexAttribL1d(index, x);
			LogCommand("glVertexAttribL1d", null, index, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL2dEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL2(UInt32 index, double x, double y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2d != null, "pglVertexAttribL2d not implemented");
			Delegates.pglVertexAttribL2d(index, x, y);
			LogCommand("glVertexAttribL2d", null, index, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL3dEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL3(UInt32 index, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3d != null, "pglVertexAttribL3d not implemented");
			Delegates.pglVertexAttribL3d(index, x, y, z);
			LogCommand("glVertexAttribL3d", null, index, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL4dEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL4(UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4d != null, "pglVertexAttribL4d not implemented");
			Delegates.pglVertexAttribL4d(index, x, y, z, w);
			LogCommand("glVertexAttribL4d", null, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL1dvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL1(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1dv != null, "pglVertexAttribL1dv not implemented");
					Delegates.pglVertexAttribL1dv(index, p_v);
					LogCommand("glVertexAttribL1dv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL2dvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL2(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2dv != null, "pglVertexAttribL2dv not implemented");
					Delegates.pglVertexAttribL2dv(index, p_v);
					LogCommand("glVertexAttribL2dv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL3dvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL3(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3dv != null, "pglVertexAttribL3dv not implemented");
					Delegates.pglVertexAttribL3dv(index, p_v);
					LogCommand("glVertexAttribL3dv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL4dvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL4(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4dv != null, "pglVertexAttribL4dv not implemented");
					Delegates.pglVertexAttribL4dv(index, p_v);
					LogCommand("glVertexAttribL4dv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribLPointerEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribLPointer(UInt32 index, Int32 size, VertexAttribType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribLPointer != null, "pglVertexAttribLPointer not implemented");
			Delegates.pglVertexAttribLPointer(index, size, (Int32)type, stride, pointer);
			LogCommand("glVertexAttribLPointer", null, index, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribLPointerEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribLPointer(UInt32 index, Int32 size, VertexAttribType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribLPointer(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribLdvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void GetVertexAttribL(UInt32 index, VertexAttribPName pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLdv != null, "pglGetVertexAttribLdv not implemented");
					Delegates.pglGetVertexAttribLdv(index, (Int32)pname, p_params);
					LogCommand("glGetVertexAttribLdv", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glViewportArrayv.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[AliasOf("glViewportArrayvNV")]
		[AliasOf("glViewportArrayvOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void ViewportArray(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglViewportArrayv != null, "pglViewportArrayv not implemented");
					Delegates.pglViewportArrayv(first, count, p_v);
					LogCommand("glViewportArrayv", null, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glViewportIndexedf.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="h">
		/// A <see cref="T:float"/>.
		/// </param>
		[AliasOf("glViewportIndexedfOES")]
		[AliasOf("glViewportIndexedfNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void ViewportIndexed(UInt32 index, float x, float y, float w, float h)
		{
			Debug.Assert(Delegates.pglViewportIndexedf != null, "pglViewportIndexedf not implemented");
			Delegates.pglViewportIndexedf(index, x, y, w, h);
			LogCommand("glViewportIndexedf", null, index, x, y, w, h			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glViewportIndexedfv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[AliasOf("glViewportIndexedfvOES")]
		[AliasOf("glViewportIndexedfvNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void ViewportIndexed(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglViewportIndexedfv != null, "pglViewportIndexedfv not implemented");
					Delegates.pglViewportIndexedfv(index, p_v);
					LogCommand("glViewportIndexedfv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define the scissor box for multiple viewports
		/// </summary>
		/// <param name="first">
		/// Specifies the index of the first viewport whose scissor box to modify.
		/// </param>
		/// <param name="count">
		/// Specifies the number of scissor boxes to modify.
		/// </param>
		/// <param name="v">
		/// Specifies the address of an array containing the left, bottom, width and height of each scissor box, in that order.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> + <paramref name="count"/> is greater than or equal to the 
		/// value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if any width or height specified in the array <paramref name="v"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.ViewportIndexed"/>
		/// <seealso cref="Gl.ViewportArray"/>
		[AliasOf("glScissorArrayvNV")]
		[AliasOf("glScissorArrayvOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void ScissorArray(UInt32 first, Int32 count, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglScissorArrayv != null, "pglScissorArrayv not implemented");
					Delegates.pglScissorArrayv(first, count, p_v);
					LogCommand("glScissorArrayv", null, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define the scissor box for a specific viewport
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the viewport whose scissor box to modify.
		/// </param>
		/// <param name="left">
		/// Specify the coordinate of the bottom left corner of the scissor box, in pixels.
		/// </param>
		/// <param name="bottom">
		/// Specify the coordinate of the bottom left corner of the scissor box, in pixels.
		/// </param>
		/// <param name="width">
		/// Specify ths dimensions of the scissor box, in pixels.
		/// </param>
		/// <param name="height">
		/// Specify ths dimensions of the scissor box, in pixels.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if any width or height specified in the array <paramref name="v"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.ScissorArray"/>
		[AliasOf("glScissorIndexedNV")]
		[AliasOf("glScissorIndexedOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglScissorIndexed != null, "pglScissorIndexed not implemented");
			Delegates.pglScissorIndexed(index, left, bottom, width, height);
			LogCommand("glScissorIndexed", null, index, left, bottom, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define the scissor box for a specific viewport
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the viewport whose scissor box to modify.
		/// </param>
		/// <param name="v">
		/// For Gl.ScissorIndexedv, specifies the address of an array containing the left, bottom, width and height of each scissor 
		/// box, in that order.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if any width or height specified in the array <paramref name="v"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.ScissorArray"/>
		[AliasOf("glScissorIndexedvNV")]
		[AliasOf("glScissorIndexedvOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void ScissorIndexed(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglScissorIndexedv != null, "pglScissorIndexedv not implemented");
					Delegates.pglScissorIndexedv(index, p_v);
					LogCommand("glScissorIndexedv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates for a specified set of 
		/// viewports
		/// </summary>
		/// <param name="first">
		/// Specifies the index of the first viewport whose depth range to update.
		/// </param>
		/// <param name="count">
		/// Specifies the number of viewports whose depth range to update.
		/// </param>
		/// <param name="v">
		/// Specifies the address of an array containing the near and far values for the depth range of each modified viewport.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> + <paramref name="count"/> is greater than or equal to the 
		/// value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.DepthRangeIndexed"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.ViewportArray"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		public static void DepthRangeArray(UInt32 first, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayv != null, "pglDepthRangeArrayv not implemented");
					Delegates.pglDepthRangeArrayv(first, count, p_v);
					LogCommand("glDepthRangeArrayv", null, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates for a specified viewport
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the viewport whose depth range to update.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.DepthRangeArray"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.ViewportArray"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		public static void DepthRangeIndexed(UInt32 index, double n, double f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexed != null, "pglDepthRangeIndexed not implemented");
			Delegates.pglDepthRangeIndexed(index, n, f);
			LogCommand("glDepthRangeIndexed", null, index, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[AliasOf("glGetFloatIndexedvEXT")]
		[AliasOf("glGetFloati_vEXT")]
		[AliasOf("glGetFloati_vNV")]
		[AliasOf("glGetFloati_vOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void Get(Int32 target, UInt32 index, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
					Delegates.pglGetFloati_v(target, index, p_data);
					LogCommand("glGetFloati_v", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[AliasOf("glGetFloatIndexedvEXT")]
		[AliasOf("glGetFloati_vEXT")]
		[AliasOf("glGetFloati_vNV")]
		[AliasOf("glGetFloati_vOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void Get(Int32 target, UInt32 index, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
					Delegates.pglGetFloati_v(target, index, p_data);
					LogCommand("glGetFloati_v", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[AliasOf("glGetDoubleIndexedvEXT")]
		[AliasOf("glGetDoublei_vEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void Get(Int32 target, UInt32 index, [Out] double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
					Delegates.pglGetDoublei_v(target, index, p_data);
					LogCommand("glGetDoublei_v", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[AliasOf("glGetDoubleIndexedvEXT")]
		[AliasOf("glGetDoublei_vEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void Get(Int32 target, UInt32 index, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
					Delegates.pglGetDoublei_v(target, index, p_data);
					LogCommand("glGetDoublei_v", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReleaseShaderCompiler", ExactSpelling = true)]
			internal extern static void glReleaseShaderCompiler();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
			internal extern static unsafe void glShaderBinary(Int32 count, UInt32* shaders, Int32 binaryformat, IntPtr binary, Int32 length);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderPrecisionFormat(Int32 shadertype, Int32 precisiontype, Int32* range, Int32* precision);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
			internal extern static void glDepthRangef(float n, float f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
			internal extern static void glClearDepthf(float d);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramBinary", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramBinary(UInt32 program, Int32 bufSize, Int32* length, Int32* binaryFormat, IntPtr binary);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramBinary", ExactSpelling = true)]
			internal extern static unsafe void glProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramParameteri", ExactSpelling = true)]
			internal extern static void glProgramParameteri(UInt32 program, Int32 pname, Int32 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUseProgramStages", ExactSpelling = true)]
			internal extern static void glUseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glActiveShaderProgram", ExactSpelling = true)]
			internal extern static void glActiveShaderProgram(UInt32 pipeline, UInt32 program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateShaderProgramv", ExactSpelling = true)]
			internal extern static UInt32 glCreateShaderProgramv(Int32 type, Int32 count, String[] strings);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindProgramPipeline", ExactSpelling = true)]
			internal extern static void glBindProgramPipeline(UInt32 pipeline);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteProgramPipelines", ExactSpelling = true)]
			internal extern static unsafe void glDeleteProgramPipelines(Int32 n, UInt32* pipelines);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenProgramPipelines", ExactSpelling = true)]
			internal extern static unsafe void glGenProgramPipelines(Int32 n, UInt32* pipelines);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsProgramPipeline", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsProgramPipeline(UInt32 pipeline);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramPipelineiv", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramPipelineiv(UInt32 pipeline, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1i", ExactSpelling = true)]
			internal extern static void glProgramUniform1i(UInt32 program, Int32 location, Int32 v0);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1iv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1f", ExactSpelling = true)]
			internal extern static void glProgramUniform1f(UInt32 program, Int32 location, float v0);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1fv(UInt32 program, Int32 location, Int32 count, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1d", ExactSpelling = true)]
			internal extern static void glProgramUniform1d(UInt32 program, Int32 location, double v0);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1dv(UInt32 program, Int32 location, Int32 count, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1ui", ExactSpelling = true)]
			internal extern static void glProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1uiv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2i", ExactSpelling = true)]
			internal extern static void glProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2iv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2f", ExactSpelling = true)]
			internal extern static void glProgramUniform2f(UInt32 program, Int32 location, float v0, float v1);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2fv(UInt32 program, Int32 location, Int32 count, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2d", ExactSpelling = true)]
			internal extern static void glProgramUniform2d(UInt32 program, Int32 location, double v0, double v1);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2dv(UInt32 program, Int32 location, Int32 count, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2ui", ExactSpelling = true)]
			internal extern static void glProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2uiv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3i", ExactSpelling = true)]
			internal extern static void glProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3iv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3f", ExactSpelling = true)]
			internal extern static void glProgramUniform3f(UInt32 program, Int32 location, float v0, float v1, float v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3fv(UInt32 program, Int32 location, Int32 count, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3d", ExactSpelling = true)]
			internal extern static void glProgramUniform3d(UInt32 program, Int32 location, double v0, double v1, double v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3dv(UInt32 program, Int32 location, Int32 count, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3ui", ExactSpelling = true)]
			internal extern static void glProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3uiv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4i", ExactSpelling = true)]
			internal extern static void glProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4iv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4f", ExactSpelling = true)]
			internal extern static void glProgramUniform4f(UInt32 program, Int32 location, float v0, float v1, float v2, float v3);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4fv(UInt32 program, Int32 location, Int32 count, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4d", ExactSpelling = true)]
			internal extern static void glProgramUniform4d(UInt32 program, Int32 location, double v0, double v1, double v2, double v3);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4dv(UInt32 program, Int32 location, Int32 count, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4ui", ExactSpelling = true)]
			internal extern static void glProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4uiv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x3fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x2fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x4fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x2fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x4fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x3fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x3dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x2dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x4dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x2dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x4dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x3dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glValidateProgramPipeline", ExactSpelling = true)]
			internal extern static void glValidateProgramPipeline(UInt32 pipeline);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramPipelineInfoLog", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, Int32* length, String infoLog);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL1d", ExactSpelling = true)]
			internal extern static void glVertexAttribL1d(UInt32 index, double x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL2d", ExactSpelling = true)]
			internal extern static void glVertexAttribL2d(UInt32 index, double x, double y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL3d", ExactSpelling = true)]
			internal extern static void glVertexAttribL3d(UInt32 index, double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL4d", ExactSpelling = true)]
			internal extern static void glVertexAttribL4d(UInt32 index, double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL1dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1dv(UInt32 index, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL2dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL2dv(UInt32 index, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL3dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL3dv(UInt32 index, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL4dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL4dv(UInt32 index, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribLPointer", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribLPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexAttribLdv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLdv(UInt32 index, Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glViewportArrayv", ExactSpelling = true)]
			internal extern static unsafe void glViewportArrayv(UInt32 first, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glViewportIndexedf", ExactSpelling = true)]
			internal extern static void glViewportIndexedf(UInt32 index, float x, float y, float w, float h);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glViewportIndexedfv", ExactSpelling = true)]
			internal extern static unsafe void glViewportIndexedfv(UInt32 index, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScissorArrayv", ExactSpelling = true)]
			internal extern static unsafe void glScissorArrayv(UInt32 first, Int32 count, Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScissorIndexed", ExactSpelling = true)]
			internal extern static void glScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScissorIndexedv", ExactSpelling = true)]
			internal extern static unsafe void glScissorIndexedv(UInt32 index, Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRangeArrayv", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangeArrayv(UInt32 first, Int32 count, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRangeIndexed", ExactSpelling = true)]
			internal extern static void glDepthRangeIndexed(UInt32 index, double n, double f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFloati_v", ExactSpelling = true)]
			internal extern static unsafe void glGetFloati_v(Int32 target, UInt32 index, float* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetDoublei_v", ExactSpelling = true)]
			internal extern static unsafe void glGetDoublei_v(Int32 target, UInt32 index, double* data);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReleaseShaderCompiler();

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glReleaseShaderCompiler pglReleaseShaderCompiler;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glShaderBinary(Int32 count, UInt32* shaders, Int32 binaryformat, IntPtr binary, Int32 length);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glShaderBinary pglShaderBinary;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetShaderPrecisionFormat(Int32 shadertype, Int32 precisiontype, Int32* range, Int32* precision);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetShaderPrecisionFormat pglGetShaderPrecisionFormat;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRangef(float n, float f);

			[AliasOf("glDepthRangef")]
			[AliasOf("glDepthRangefOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glDepthRangef pglDepthRangef;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearDepthf(float d);

			[AliasOf("glClearDepthf")]
			[AliasOf("glClearDepthfOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glClearDepthf pglClearDepthf;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramBinary(UInt32 program, Int32 bufSize, Int32* length, Int32* binaryFormat, IntPtr binary);

			[AliasOf("glGetProgramBinary")]
			[AliasOf("glGetProgramBinaryOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
			[ThreadStatic]
			internal static glGetProgramBinary pglGetProgramBinary;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);

			[AliasOf("glProgramBinary")]
			[AliasOf("glProgramBinaryOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramBinary pglProgramBinary;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramParameteri(UInt32 program, Int32 pname, Int32 value);

			[AliasOf("glProgramParameteri")]
			[AliasOf("glProgramParameteriARB")]
			[AliasOf("glProgramParameteriEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramParameteri pglProgramParameteri;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUseProgramStages pglUseProgramStages;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveShaderProgram(UInt32 pipeline, UInt32 program);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glActiveShaderProgram pglActiveShaderProgram;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateShaderProgramv(Int32 type, Int32 count, String[] strings);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateShaderProgramv pglCreateShaderProgramv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindProgramPipeline(UInt32 pipeline);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glBindProgramPipeline pglBindProgramPipeline;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteProgramPipelines(Int32 n, UInt32* pipelines);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDeleteProgramPipelines pglDeleteProgramPipelines;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenProgramPipelines(Int32 n, UInt32* pipelines);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGenProgramPipelines pglGenProgramPipelines;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsProgramPipeline(UInt32 pipeline);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glIsProgramPipeline pglIsProgramPipeline;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramPipelineiv(UInt32 pipeline, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetProgramPipelineiv pglGetProgramPipelineiv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1i(UInt32 program, Int32 location, Int32 v0);

			[AliasOf("glProgramUniform1i")]
			[AliasOf("glProgramUniform1iEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform1i pglProgramUniform1i;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[AliasOf("glProgramUniform1iv")]
			[AliasOf("glProgramUniform1ivEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform1iv pglProgramUniform1iv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1f(UInt32 program, Int32 location, float v0);

			[AliasOf("glProgramUniform1f")]
			[AliasOf("glProgramUniform1fEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform1f pglProgramUniform1f;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1fv(UInt32 program, Int32 location, Int32 count, float* value);

			[AliasOf("glProgramUniform1fv")]
			[AliasOf("glProgramUniform1fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform1fv pglProgramUniform1fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1d(UInt32 program, Int32 location, double v0);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform1d pglProgramUniform1d;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1dv(UInt32 program, Int32 location, Int32 count, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform1dv pglProgramUniform1dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);

			[AliasOf("glProgramUniform1ui")]
			[AliasOf("glProgramUniform1uiEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform1ui pglProgramUniform1ui;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[AliasOf("glProgramUniform1uiv")]
			[AliasOf("glProgramUniform1uivEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform1uiv pglProgramUniform1uiv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);

			[AliasOf("glProgramUniform2i")]
			[AliasOf("glProgramUniform2iEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform2i pglProgramUniform2i;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[AliasOf("glProgramUniform2iv")]
			[AliasOf("glProgramUniform2ivEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform2iv pglProgramUniform2iv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2f(UInt32 program, Int32 location, float v0, float v1);

			[AliasOf("glProgramUniform2f")]
			[AliasOf("glProgramUniform2fEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform2f pglProgramUniform2f;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2fv(UInt32 program, Int32 location, Int32 count, float* value);

			[AliasOf("glProgramUniform2fv")]
			[AliasOf("glProgramUniform2fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform2fv pglProgramUniform2fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2d(UInt32 program, Int32 location, double v0, double v1);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform2d pglProgramUniform2d;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2dv(UInt32 program, Int32 location, Int32 count, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform2dv pglProgramUniform2dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);

			[AliasOf("glProgramUniform2ui")]
			[AliasOf("glProgramUniform2uiEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform2ui pglProgramUniform2ui;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[AliasOf("glProgramUniform2uiv")]
			[AliasOf("glProgramUniform2uivEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform2uiv pglProgramUniform2uiv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[AliasOf("glProgramUniform3i")]
			[AliasOf("glProgramUniform3iEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform3i pglProgramUniform3i;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[AliasOf("glProgramUniform3iv")]
			[AliasOf("glProgramUniform3ivEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform3iv pglProgramUniform3iv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3f(UInt32 program, Int32 location, float v0, float v1, float v2);

			[AliasOf("glProgramUniform3f")]
			[AliasOf("glProgramUniform3fEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform3f pglProgramUniform3f;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3fv(UInt32 program, Int32 location, Int32 count, float* value);

			[AliasOf("glProgramUniform3fv")]
			[AliasOf("glProgramUniform3fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform3fv pglProgramUniform3fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3d(UInt32 program, Int32 location, double v0, double v1, double v2);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform3d pglProgramUniform3d;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3dv(UInt32 program, Int32 location, Int32 count, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform3dv pglProgramUniform3dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

			[AliasOf("glProgramUniform3ui")]
			[AliasOf("glProgramUniform3uiEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform3ui pglProgramUniform3ui;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[AliasOf("glProgramUniform3uiv")]
			[AliasOf("glProgramUniform3uivEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform3uiv pglProgramUniform3uiv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[AliasOf("glProgramUniform4i")]
			[AliasOf("glProgramUniform4iEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform4i pglProgramUniform4i;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[AliasOf("glProgramUniform4iv")]
			[AliasOf("glProgramUniform4ivEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform4iv pglProgramUniform4iv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4f(UInt32 program, Int32 location, float v0, float v1, float v2, float v3);

			[AliasOf("glProgramUniform4f")]
			[AliasOf("glProgramUniform4fEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform4f pglProgramUniform4f;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4fv(UInt32 program, Int32 location, Int32 count, float* value);

			[AliasOf("glProgramUniform4fv")]
			[AliasOf("glProgramUniform4fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform4fv pglProgramUniform4fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4d(UInt32 program, Int32 location, double v0, double v1, double v2, double v3);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform4d pglProgramUniform4d;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4dv(UInt32 program, Int32 location, Int32 count, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform4dv pglProgramUniform4dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

			[AliasOf("glProgramUniform4ui")]
			[AliasOf("glProgramUniform4uiEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform4ui pglProgramUniform4ui;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[AliasOf("glProgramUniform4uiv")]
			[AliasOf("glProgramUniform4uivEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniform4uiv pglProgramUniform4uiv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix2fv")]
			[AliasOf("glProgramUniformMatrix2fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2fv pglProgramUniformMatrix2fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix3fv")]
			[AliasOf("glProgramUniformMatrix3fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3fv pglProgramUniformMatrix3fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix4fv")]
			[AliasOf("glProgramUniformMatrix4fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4fv pglProgramUniformMatrix4fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2dv pglProgramUniformMatrix2dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3dv pglProgramUniformMatrix3dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4dv pglProgramUniformMatrix4dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix2x3fv")]
			[AliasOf("glProgramUniformMatrix2x3fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2x3fv pglProgramUniformMatrix2x3fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix3x2fv")]
			[AliasOf("glProgramUniformMatrix3x2fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3x2fv pglProgramUniformMatrix3x2fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix2x4fv")]
			[AliasOf("glProgramUniformMatrix2x4fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2x4fv pglProgramUniformMatrix2x4fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix4x2fv")]
			[AliasOf("glProgramUniformMatrix4x2fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4x2fv pglProgramUniformMatrix4x2fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix3x4fv")]
			[AliasOf("glProgramUniformMatrix3x4fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3x4fv pglProgramUniformMatrix3x4fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix4x3fv")]
			[AliasOf("glProgramUniformMatrix4x3fvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4x3fv pglProgramUniformMatrix4x3fv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2x3dv pglProgramUniformMatrix2x3dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3x2dv pglProgramUniformMatrix3x2dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2x4dv pglProgramUniformMatrix2x4dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4x2dv pglProgramUniformMatrix4x2dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3x4dv pglProgramUniformMatrix3x4dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4x3dv pglProgramUniformMatrix4x3dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glValidateProgramPipeline(UInt32 pipeline);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glValidateProgramPipeline pglValidateProgramPipeline;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetProgramPipelineInfoLog pglGetProgramPipelineInfoLog;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1d(UInt32 index, double x);

			[AliasOf("glVertexAttribL1d")]
			[AliasOf("glVertexAttribL1dEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribL1d pglVertexAttribL1d;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2d(UInt32 index, double x, double y);

			[AliasOf("glVertexAttribL2d")]
			[AliasOf("glVertexAttribL2dEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribL2d pglVertexAttribL2d;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3d(UInt32 index, double x, double y, double z);

			[AliasOf("glVertexAttribL3d")]
			[AliasOf("glVertexAttribL3dEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribL3d pglVertexAttribL3d;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4d(UInt32 index, double x, double y, double z, double w);

			[AliasOf("glVertexAttribL4d")]
			[AliasOf("glVertexAttribL4dEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribL4d pglVertexAttribL4d;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1dv(UInt32 index, double* v);

			[AliasOf("glVertexAttribL1dv")]
			[AliasOf("glVertexAttribL1dvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribL1dv pglVertexAttribL1dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2dv(UInt32 index, double* v);

			[AliasOf("glVertexAttribL2dv")]
			[AliasOf("glVertexAttribL2dvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribL2dv pglVertexAttribL2dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3dv(UInt32 index, double* v);

			[AliasOf("glVertexAttribL3dv")]
			[AliasOf("glVertexAttribL3dvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribL3dv pglVertexAttribL3dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4dv(UInt32 index, double* v);

			[AliasOf("glVertexAttribL4dv")]
			[AliasOf("glVertexAttribL4dvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribL4dv pglVertexAttribL4dv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribLPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[AliasOf("glVertexAttribLPointer")]
			[AliasOf("glVertexAttribLPointerEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glVertexAttribLPointer pglVertexAttribLPointer;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLdv(UInt32 index, Int32 pname, double* @params);

			[AliasOf("glGetVertexAttribLdv")]
			[AliasOf("glGetVertexAttribLdvEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
			[ThreadStatic]
			internal static glGetVertexAttribLdv pglGetVertexAttribLdv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glViewportArrayv(UInt32 first, Int32 count, float* v);

			[AliasOf("glViewportArrayv")]
			[AliasOf("glViewportArrayvNV")]
			[AliasOf("glViewportArrayvOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glViewportArrayv pglViewportArrayv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glViewportIndexedf(UInt32 index, float x, float y, float w, float h);

			[AliasOf("glViewportIndexedf")]
			[AliasOf("glViewportIndexedfOES")]
			[AliasOf("glViewportIndexedfNV")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glViewportIndexedf pglViewportIndexedf;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glViewportIndexedfv(UInt32 index, float* v);

			[AliasOf("glViewportIndexedfv")]
			[AliasOf("glViewportIndexedfvOES")]
			[AliasOf("glViewportIndexedfvNV")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glViewportIndexedfv pglViewportIndexedfv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glScissorArrayv(UInt32 first, Int32 count, Int32* v);

			[AliasOf("glScissorArrayv")]
			[AliasOf("glScissorArrayvNV")]
			[AliasOf("glScissorArrayvOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glScissorArrayv pglScissorArrayv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);

			[AliasOf("glScissorIndexed")]
			[AliasOf("glScissorIndexedNV")]
			[AliasOf("glScissorIndexedOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glScissorIndexed pglScissorIndexed;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glScissorIndexedv(UInt32 index, Int32* v);

			[AliasOf("glScissorIndexedv")]
			[AliasOf("glScissorIndexedvNV")]
			[AliasOf("glScissorIndexedvOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glScissorIndexedv pglScissorIndexedv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDepthRangeArrayv(UInt32 first, Int32 count, double* v);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDepthRangeArrayv pglDepthRangeArrayv;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRangeIndexed(UInt32 index, double n, double f);

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDepthRangeIndexed pglDepthRangeIndexed;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFloati_v(Int32 target, UInt32 index, float* data);

			[AliasOf("glGetFloati_v")]
			[AliasOf("glGetFloatIndexedvEXT")]
			[AliasOf("glGetFloati_vEXT")]
			[AliasOf("glGetFloati_vNV")]
			[AliasOf("glGetFloati_vOES")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glGetFloati_v pglGetFloati_v;

			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetDoublei_v(Int32 target, UInt32 index, double* data);

			[AliasOf("glGetDoublei_v")]
			[AliasOf("glGetDoubleIndexedvEXT")]
			[AliasOf("glGetDoublei_vEXT")]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetDoublei_v pglGetDoublei_v;

		}
	}

}
