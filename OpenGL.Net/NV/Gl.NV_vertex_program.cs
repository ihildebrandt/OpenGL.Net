
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
		/// [GL] Value of GL_VERTEX_STATE_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_STATE_PROGRAM_NV = 0x8621;

		/// <summary>
		/// [GL] Value of GL_ATTRIB_ARRAY_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int ATTRIB_ARRAY_SIZE_NV = 0x8623;

		/// <summary>
		/// [GL] Value of GL_ATTRIB_ARRAY_STRIDE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int ATTRIB_ARRAY_STRIDE_NV = 0x8624;

		/// <summary>
		/// [GL] Value of GL_ATTRIB_ARRAY_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int ATTRIB_ARRAY_TYPE_NV = 0x8625;

		/// <summary>
		/// [GL] Value of GL_CURRENT_ATTRIB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int CURRENT_ATTRIB_NV = 0x8626;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW_PROJECTION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MODELVIEW_PROJECTION_NV = 0x8629;

		/// <summary>
		/// [GL] Value of GL_IDENTITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int IDENTITY_NV = 0x862A;

		/// <summary>
		/// [GL] Value of GL_INVERSE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int INVERSE_NV = 0x862B;

		/// <summary>
		/// [GL] Value of GL_TRANSPOSE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int TRANSPOSE_NV = 0x862C;

		/// <summary>
		/// [GL] Value of GL_INVERSE_TRANSPOSE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int INVERSE_TRANSPOSE_NV = 0x862D;

		/// <summary>
		/// [GL] Value of GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;

		/// <summary>
		/// [GL] Value of GL_MAX_TRACK_MATRICES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAX_TRACK_MATRICES_NV = 0x862F;

		/// <summary>
		/// [GL] Value of GL_MATRIX0_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX0_NV = 0x8630;

		/// <summary>
		/// [GL] Value of GL_MATRIX1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX1_NV = 0x8631;

		/// <summary>
		/// [GL] Value of GL_MATRIX2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX2_NV = 0x8632;

		/// <summary>
		/// [GL] Value of GL_MATRIX3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX3_NV = 0x8633;

		/// <summary>
		/// [GL] Value of GL_MATRIX4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX4_NV = 0x8634;

		/// <summary>
		/// [GL] Value of GL_MATRIX5_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX5_NV = 0x8635;

		/// <summary>
		/// [GL] Value of GL_MATRIX6_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX6_NV = 0x8636;

		/// <summary>
		/// [GL] Value of GL_MATRIX7_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX7_NV = 0x8637;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_PARAMETER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_PARAMETER_NV = 0x8644;

		/// <summary>
		/// [GL] Value of GL_ATTRIB_ARRAY_POINTER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int ATTRIB_ARRAY_POINTER_NV = 0x8645;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_TARGET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_TARGET_NV = 0x8646;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_RESIDENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_RESIDENT_NV = 0x8647;

		/// <summary>
		/// [GL] Value of GL_TRACK_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int TRACK_MATRIX_NV = 0x8648;

		/// <summary>
		/// [GL] Value of GL_TRACK_MATRIX_TRANSFORM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int TRACK_MATRIX_TRANSFORM_NV = 0x8649;

		/// <summary>
		/// [GL] Value of GL_VERTEX_PROGRAM_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_PROGRAM_BINDING_NV = 0x864A;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY0_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY0_NV = 0x8650;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY1_NV = 0x8651;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY2_NV = 0x8652;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY3_NV = 0x8653;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY4_NV = 0x8654;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY5_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY5_NV = 0x8655;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY6_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY6_NV = 0x8656;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY7_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY7_NV = 0x8657;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY8_NV = 0x8658;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY9_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY9_NV = 0x8659;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY10_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY10_NV = 0x865A;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY11_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY11_NV = 0x865B;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY12_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY12_NV = 0x865C;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY13_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY13_NV = 0x865D;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY14_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY14_NV = 0x865E;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY15_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY15_NV = 0x865F;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB0_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB0_4_NV = 0x8660;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB1_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB1_4_NV = 0x8661;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB2_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB2_4_NV = 0x8662;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB3_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB3_4_NV = 0x8663;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB4_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB4_4_NV = 0x8664;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB5_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB5_4_NV = 0x8665;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB6_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB6_4_NV = 0x8666;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB7_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB7_4_NV = 0x8667;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB8_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB8_4_NV = 0x8668;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB9_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB9_4_NV = 0x8669;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB10_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB10_4_NV = 0x866A;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB11_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB11_4_NV = 0x866B;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB12_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB12_4_NV = 0x866C;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB13_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB13_4_NV = 0x866D;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB14_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB14_4_NV = 0x866E;

		/// <summary>
		/// [GL] Value of GL_MAP1_VERTEX_ATTRIB15_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB15_4_NV = 0x866F;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB0_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB0_4_NV = 0x8670;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB1_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB1_4_NV = 0x8671;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB2_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB2_4_NV = 0x8672;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB3_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB3_4_NV = 0x8673;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB4_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB4_4_NV = 0x8674;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB5_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB5_4_NV = 0x8675;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB6_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB6_4_NV = 0x8676;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB7_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB7_4_NV = 0x8677;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB8_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB8_4_NV = 0x8678;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB9_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB9_4_NV = 0x8679;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB10_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB10_4_NV = 0x867A;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB11_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB11_4_NV = 0x867B;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB12_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB12_4_NV = 0x867C;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB13_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB13_4_NV = 0x867D;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB14_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB14_4_NV = 0x867E;

		/// <summary>
		/// [GL] Value of GL_MAP2_VERTEX_ATTRIB15_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB15_4_NV = 0x867F;

		/// <summary>
		/// Binding for glAreProgramsResidentNV.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="residences">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static bool AreProgramsResidentNV(UInt32[] programs, [Out] bool[] residences)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_programs = programs)
				fixed (bool* p_residences = residences)
				{
					Debug.Assert(Delegates.pglAreProgramsResidentNV != null, "pglAreProgramsResidentNV not implemented");
					retValue = Delegates.pglAreProgramsResidentNV((Int32)programs.Length, p_programs, p_residences);
					LogCommand("glAreProgramsResidentNV", retValue, programs.Length, programs, residences					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glExecuteProgramNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ExecuteProgramNV(Int32 target, UInt32 id, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglExecuteProgramNV != null, "pglExecuteProgramNV not implemented");
					Delegates.pglExecuteProgramNV(target, id, p_params);
					LogCommand("glExecuteProgramNV", null, target, id, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramParameterdvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetProgramParameterNV(Int32 target, UInt32 index, Int32 pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramParameterdvNV != null, "pglGetProgramParameterdvNV not implemented");
					Delegates.pglGetProgramParameterdvNV(target, index, pname, p_params);
					LogCommand("glGetProgramParameterdvNV", null, target, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramParameterfvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetProgramParameterNV(Int32 target, UInt32 index, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramParameterfvNV != null, "pglGetProgramParameterfvNV not implemented");
					Delegates.pglGetProgramParameterfvNV(target, index, pname, p_params);
					LogCommand("glGetProgramParameterfvNV", null, target, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramivNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetProgramNV(UInt32 id, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramivNV != null, "pglGetProgramivNV not implemented");
					Delegates.pglGetProgramivNV(id, pname, p_params);
					LogCommand("glGetProgramivNV", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramStringNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetProgramStringNV(UInt32 id, Int32 pname, [Out] byte[] program)
		{
			unsafe {
				fixed (byte* p_program = program)
				{
					Debug.Assert(Delegates.pglGetProgramStringNV != null, "pglGetProgramStringNV not implemented");
					Delegates.pglGetProgramStringNV(id, pname, p_program);
					LogCommand("glGetProgramStringNV", null, id, pname, program					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTrackMatrixivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="address">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetTrackMatrixNV(Int32 target, UInt32 address, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetTrackMatrixivNV != null, "pglGetTrackMatrixivNV not implemented");
					Delegates.pglGetTrackMatrixivNV(target, address, pname, p_params);
					LogCommand("glGetTrackMatrixivNV", null, target, address, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLoadProgramNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void LoadProgramNV(Int32 target, UInt32 id, byte[] program)
		{
			unsafe {
				fixed (byte* p_program = program)
				{
					Debug.Assert(Delegates.pglLoadProgramNV != null, "pglLoadProgramNV not implemented");
					Delegates.pglLoadProgramNV(target, id, (Int32)program.Length, p_program);
					LogCommand("glLoadProgramNV", null, target, id, program.Length, program					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameter4dNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
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
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameter4NV(Int32 target, UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglProgramParameter4dNV != null, "pglProgramParameter4dNV not implemented");
			Delegates.pglProgramParameter4dNV(target, index, x, y, z, w);
			LogCommand("glProgramParameter4dNV", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameter4dvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameter4NV(Int32 target, UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramParameter4dvNV != null, "pglProgramParameter4dvNV not implemented");
					Delegates.pglProgramParameter4dvNV(target, index, p_v);
					LogCommand("glProgramParameter4dvNV", null, target, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameter4fNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameter4NV(Int32 target, UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglProgramParameter4fNV != null, "pglProgramParameter4fNV not implemented");
			Delegates.pglProgramParameter4fNV(target, index, x, y, z, w);
			LogCommand("glProgramParameter4fNV", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameter4fvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameter4NV(Int32 target, UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramParameter4fvNV != null, "pglProgramParameter4fvNV not implemented");
					Delegates.pglProgramParameter4fvNV(target, index, p_v);
					LogCommand("glProgramParameter4fvNV", null, target, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameters4dvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameters4NV(Int32 target, UInt32 index, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramParameters4dvNV != null, "pglProgramParameters4dvNV not implemented");
					Delegates.pglProgramParameters4dvNV(target, index, count, p_v);
					LogCommand("glProgramParameters4dvNV", null, target, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameters4fvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameters4NV(Int32 target, UInt32 index, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramParameters4fvNV != null, "pglProgramParameters4fvNV not implemented");
					Delegates.pglProgramParameters4fvNV(target, index, count, p_v);
					LogCommand("glProgramParameters4fvNV", null, target, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRequestResidentProgramsNV.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void RequestResidentProgramsNV(UInt32[] programs)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				{
					Debug.Assert(Delegates.pglRequestResidentProgramsNV != null, "pglRequestResidentProgramsNV not implemented");
					Delegates.pglRequestResidentProgramsNV((Int32)programs.Length, p_programs);
					LogCommand("glRequestResidentProgramsNV", null, programs.Length, programs					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTrackMatrixNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="address">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="matrix">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transform">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void TrackMatrixNV(Int32 target, UInt32 address, Int32 matrix, Int32 transform)
		{
			Debug.Assert(Delegates.pglTrackMatrixNV != null, "pglTrackMatrixNV not implemented");
			Delegates.pglTrackMatrixNV(target, address, matrix, transform);
			LogCommand("glTrackMatrixNV", null, target, address, matrix, transform			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribPointerNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribPointerNV(UInt32 index, Int32 fsize, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribPointerNV != null, "pglVertexAttribPointerNV not implemented");
			Delegates.pglVertexAttribPointerNV(index, fsize, type, stride, pointer);
			LogCommand("glVertexAttribPointerNV", null, index, fsize, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribPointerNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribPointerNV(UInt32 index, Int32 fsize, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribPointerNV(index, fsize, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glVertexAttribs1dvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs1NV(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs1dvNV != null, "pglVertexAttribs1dvNV not implemented");
					Delegates.pglVertexAttribs1dvNV(index, (Int32)v.Length, p_v);
					LogCommand("glVertexAttribs1dvNV", null, index, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs1fvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs1NV(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs1fvNV != null, "pglVertexAttribs1fvNV not implemented");
					Delegates.pglVertexAttribs1fvNV(index, (Int32)v.Length, p_v);
					LogCommand("glVertexAttribs1fvNV", null, index, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs1svNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs1NV(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs1svNV != null, "pglVertexAttribs1svNV not implemented");
					Delegates.pglVertexAttribs1svNV(index, (Int32)v.Length, p_v);
					LogCommand("glVertexAttribs1svNV", null, index, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs2dvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs2NV(UInt32 index, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs2dvNV != null, "pglVertexAttribs2dvNV not implemented");
					Delegates.pglVertexAttribs2dvNV(index, count, p_v);
					LogCommand("glVertexAttribs2dvNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs2fvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs2NV(UInt32 index, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs2fvNV != null, "pglVertexAttribs2fvNV not implemented");
					Delegates.pglVertexAttribs2fvNV(index, count, p_v);
					LogCommand("glVertexAttribs2fvNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs2svNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs2NV(UInt32 index, Int32 count, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs2svNV != null, "pglVertexAttribs2svNV not implemented");
					Delegates.pglVertexAttribs2svNV(index, count, p_v);
					LogCommand("glVertexAttribs2svNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs3dvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs3NV(UInt32 index, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs3dvNV != null, "pglVertexAttribs3dvNV not implemented");
					Delegates.pglVertexAttribs3dvNV(index, count, p_v);
					LogCommand("glVertexAttribs3dvNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs3fvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs3NV(UInt32 index, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs3fvNV != null, "pglVertexAttribs3fvNV not implemented");
					Delegates.pglVertexAttribs3fvNV(index, count, p_v);
					LogCommand("glVertexAttribs3fvNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs3svNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs3NV(UInt32 index, Int32 count, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs3svNV != null, "pglVertexAttribs3svNV not implemented");
					Delegates.pglVertexAttribs3svNV(index, count, p_v);
					LogCommand("glVertexAttribs3svNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs4dvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs4NV(UInt32 index, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4dvNV != null, "pglVertexAttribs4dvNV not implemented");
					Delegates.pglVertexAttribs4dvNV(index, count, p_v);
					LogCommand("glVertexAttribs4dvNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs4fvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs4NV(UInt32 index, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4fvNV != null, "pglVertexAttribs4fvNV not implemented");
					Delegates.pglVertexAttribs4fvNV(index, count, p_v);
					LogCommand("glVertexAttribs4fvNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs4svNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs4NV(UInt32 index, Int32 count, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4svNV != null, "pglVertexAttribs4svNV not implemented");
					Delegates.pglVertexAttribs4svNV(index, count, p_v);
					LogCommand("glVertexAttribs4svNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs4ubvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs4NV(UInt32 index, Int32 count, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4ubvNV != null, "pglVertexAttribs4ubvNV not implemented");
					Delegates.pglVertexAttribs4ubvNV(index, count, p_v);
					LogCommand("glVertexAttribs4ubvNV", null, index, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAreProgramsResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static unsafe bool glAreProgramsResidentNV(Int32 n, UInt32* programs, bool* residences);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glExecuteProgramNV", ExactSpelling = true)]
			internal extern static unsafe void glExecuteProgramNV(Int32 target, UInt32 id, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramParameterdvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramParameterdvNV(Int32 target, UInt32 index, Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramParameterfvNV(Int32 target, UInt32 index, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramivNV(UInt32 id, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramStringNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramStringNV(UInt32 id, Int32 pname, byte* program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTrackMatrixivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetTrackMatrixivNV(Int32 target, UInt32 address, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadProgramNV", ExactSpelling = true)]
			internal extern static unsafe void glLoadProgramNV(Int32 target, UInt32 id, Int32 len, byte* program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramParameter4dNV", ExactSpelling = true)]
			internal extern static void glProgramParameter4dNV(Int32 target, UInt32 index, double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramParameter4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramParameter4dvNV(Int32 target, UInt32 index, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramParameter4fNV", ExactSpelling = true)]
			internal extern static void glProgramParameter4fNV(Int32 target, UInt32 index, float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramParameter4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramParameter4fvNV(Int32 target, UInt32 index, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramParameters4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramParameters4dvNV(Int32 target, UInt32 index, Int32 count, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramParameters4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramParameters4fvNV(Int32 target, UInt32 index, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRequestResidentProgramsNV", ExactSpelling = true)]
			internal extern static unsafe void glRequestResidentProgramsNV(Int32 n, UInt32* programs);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTrackMatrixNV", ExactSpelling = true)]
			internal extern static void glTrackMatrixNV(Int32 target, UInt32 address, Int32 matrix, Int32 transform);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribPointerNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribPointerNV(UInt32 index, Int32 fsize, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs1dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs1dvNV(UInt32 index, Int32 count, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs1fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs1fvNV(UInt32 index, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs1svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs2dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs2dvNV(UInt32 index, Int32 count, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs2fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs2fvNV(UInt32 index, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs2svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs3dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs3dvNV(UInt32 index, Int32 count, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs3fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs3fvNV(UInt32 index, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs3svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4dvNV(UInt32 index, Int32 count, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4fvNV(UInt32 index, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs4svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs4ubvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4ubvNV(UInt32 index, Int32 count, byte* v);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glAreProgramsResidentNV(Int32 n, UInt32* programs, bool* residences);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glAreProgramsResidentNV pglAreProgramsResidentNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glExecuteProgramNV(Int32 target, UInt32 id, float* @params);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glExecuteProgramNV pglExecuteProgramNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramParameterdvNV(Int32 target, UInt32 index, Int32 pname, double* @params);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramParameterdvNV pglGetProgramParameterdvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramParameterfvNV(Int32 target, UInt32 index, Int32 pname, float* @params);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramParameterfvNV pglGetProgramParameterfvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramivNV(UInt32 id, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramivNV pglGetProgramivNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramStringNV(UInt32 id, Int32 pname, byte* program);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramStringNV pglGetProgramStringNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTrackMatrixivNV(Int32 target, UInt32 address, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetTrackMatrixivNV pglGetTrackMatrixivNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadProgramNV(Int32 target, UInt32 id, Int32 len, byte* program);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glLoadProgramNV pglLoadProgramNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramParameter4dNV(Int32 target, UInt32 index, double x, double y, double z, double w);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glProgramParameter4dNV pglProgramParameter4dNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramParameter4dvNV(Int32 target, UInt32 index, double* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glProgramParameter4dvNV pglProgramParameter4dvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramParameter4fNV(Int32 target, UInt32 index, float x, float y, float z, float w);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glProgramParameter4fNV pglProgramParameter4fNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramParameter4fvNV(Int32 target, UInt32 index, float* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glProgramParameter4fvNV pglProgramParameter4fvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramParameters4dvNV(Int32 target, UInt32 index, Int32 count, double* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glProgramParameters4dvNV pglProgramParameters4dvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramParameters4fvNV(Int32 target, UInt32 index, Int32 count, float* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glProgramParameters4fvNV pglProgramParameters4fvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRequestResidentProgramsNV(Int32 n, UInt32* programs);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glRequestResidentProgramsNV pglRequestResidentProgramsNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTrackMatrixNV(Int32 target, UInt32 address, Int32 matrix, Int32 transform);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glTrackMatrixNV pglTrackMatrixNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribPointerNV(UInt32 index, Int32 fsize, Int32 type, Int32 stride, IntPtr pointer);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribPointerNV pglVertexAttribPointerNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs1dvNV(UInt32 index, Int32 count, double* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs1dvNV pglVertexAttribs1dvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs1fvNV(UInt32 index, Int32 count, float* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs1fvNV pglVertexAttribs1fvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs1svNV pglVertexAttribs1svNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs2dvNV(UInt32 index, Int32 count, double* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs2dvNV pglVertexAttribs2dvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs2fvNV(UInt32 index, Int32 count, float* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs2fvNV pglVertexAttribs2fvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs2svNV pglVertexAttribs2svNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs3dvNV(UInt32 index, Int32 count, double* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs3dvNV pglVertexAttribs3dvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs3fvNV(UInt32 index, Int32 count, float* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs3fvNV pglVertexAttribs3fvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs3svNV pglVertexAttribs3svNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4dvNV(UInt32 index, Int32 count, double* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs4dvNV pglVertexAttribs4dvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4fvNV(UInt32 index, Int32 count, float* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs4fvNV pglVertexAttribs4fvNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs4svNV pglVertexAttribs4svNV;

			[RequiredByFeature("GL_NV_vertex_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4ubvNV(UInt32 index, Int32 count, byte* v);

			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttribs4ubvNV pglVertexAttribs4ubvNV;

		}
	}

}
