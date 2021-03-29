using System;
using Richargh.Sandbox.DockerDep.Common;

namespace Richargh.Sandbox.DockerDep.Store
{

    public class Store
    {
        public void PrintState()
        {
            var config = new Config();
            Console.WriteLine($"Will create store with ${config.DbName}");
        }
    }
}
