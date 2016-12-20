using System;
using System.Runtime.InteropServices;

namespace CSharpCode
{
	class MainClass
	{
		[DllImport("libcsharp_interop_test.dylib", EntryPoint = "add", CallingConvention = CallingConvention.Cdecl)]
		public static extern UInt32 AddInRust(UInt32 v1, UInt32 v2);

		public static void Main(string[] args)
		{
			Console.WriteLine("C#: Getting result from Rust");
			var result = AddInRust(3, 7);
			Console.WriteLine("C#: The result is: {0}", result);
		}
	}
}
