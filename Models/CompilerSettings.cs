using System;

namespace MiniCompiler.Models
{
    /// <summary>
    /// Compiler settings and configuration
    /// </summary>
    public class CompilerSettings
    {
        public bool EnableOptimization { get; set; }
        public bool ShowDetailedOutput { get; set; }
        public bool EnableErrorRecovery { get; set; }
        public int MaxErrorCount { get; set; }

        public CompilerSettings()
        {
            EnableOptimization = true;
            ShowDetailedOutput = true;
            EnableErrorRecovery = true;
            MaxErrorCount = 50;
        }
    }
}
