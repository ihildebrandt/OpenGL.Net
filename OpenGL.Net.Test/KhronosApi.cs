﻿
// Copyright (C) 2017 Luca Piccioni
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

using System;
using System.Diagnostics;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
	class KhronosApiTest : TestBaseGL
	{
		[Test]
		public void TestBindAPIPerformance()
		{
			// Ensure cached attributes
			Gl.BindAPI();

			Stopwatch sw = Stopwatch.StartNew();
			for (int i = 0; i < 10; i++)
				Gl.BindAPI();
			sw.Stop();

			Console.WriteLine("BindAPI(): {0} ms", sw.ElapsedMilliseconds / 10.0f);
		}
	}
}
