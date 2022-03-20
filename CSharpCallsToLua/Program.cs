using System;
using System.IO;
using System.Threading;
using NLua;

namespace CSharpCallsToLua {
    public class Program {
        private static Lua luaState;

        public static void Main(string[] args) {
            Console.WriteLine("Welcome to a demo program that calls Lua code from C#!");

            Directory.CreateDirectory("docker-shared");
            File.WriteAllText("docker-shared/test.json", "{\n  \"testValue\": 2147\n}\n");

            luaState = new Lua();
            luaState.DoString(@"print(""Hey from Lua!!!"")");

            Thread.Sleep(5000);
        }
    }
}
