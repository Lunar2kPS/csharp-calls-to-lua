using System;

namespace CSharpCallsToLua {
	public class Program {
		private static dynamic dLua;

		public static void Main(string[] args) {
			Console.WriteLine("Welcome to a demo program that calls Lua code from C#!");

			dLua = new DynamicLua.DynamicLua();
			dLua.print = (Action<string>) Console.WriteLine;
			dLua(@"print(""Hey from Lua!"")");
		}
	}
}
