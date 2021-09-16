using System;
using System.Threading;
using NLua;

namespace CSharpCallsToLua {
    public class Program {
        private static Lua luaState;

        public static void Main(string[] args) {
            Console.WriteLine("Welcome to a demo program that calls Lua code from C#!");

            luaState = new Lua();
            luaState.DoString(@"print(""Hey from Lua!!!"")");

            Thread.Sleep(5000);
        }
    }
}
