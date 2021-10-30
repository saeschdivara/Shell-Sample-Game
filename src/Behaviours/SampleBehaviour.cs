using System;
using Shell.Core.Behaviours;

namespace App
{
    public class SampleBehaviour : ShellBehaviour
    {
        public override void OnUpdate()
        {
            Console.Out.WriteLine("OnUpdate");
        }
    }
}