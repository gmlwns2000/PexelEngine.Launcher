using System;

namespace PexelEngine.Launcher
{
    public abstract class Core
    {
        public static Core Current { get; private set; }

        public static void Init(Core core)
        {
            Current = core;
        }
    }
}
