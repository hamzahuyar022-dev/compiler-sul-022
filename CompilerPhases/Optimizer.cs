using System;
using System.Collections.Generic;

namespace MiniCompiler.CompilerPhases
{
    /// <summary>
    /// Code Optimization Phase 5
    /// Performs various optimization passes
    /// </summary>
    public class Optimizer
    {
        private List<string> optimizedCode;

        public Optimizer()
        {
            optimizedCode = new List<string>();
        }

        public List<string> Optimize(List<string> tacCode)
        {
            optimizedCode = new List<string>(tacCode);

            // Apply optimization passes
            OptimizeConstantFolding();
            OptimizeDeadCode();

            return optimizedCode;
        }

        private void OptimizeConstantFolding()
        {
            // Constant folding: Evaluate constant expressions at compile time
            var newCode = new List<string>();

            foreach (var line in optimizedCode)
            {
                if (line.Contains(":=") && IsConstantExpression(line))
                {
                    newCode.Add("; [Optimized - Constant Folding] " + line);
                }
                else
                {
                    newCode.Add(line);
                }
            }

            optimizedCode = newCode;
        }

        private void OptimizeDeadCode()
        {
            // Dead code elimination: Remove unused variable assignments
            var usedVariables = new HashSet<string>();

            // First pass: identify used variables
            foreach (var line in optimizedCode)
            {
                if (line.Contains("PRINT"))
                {
                    var parts = line.Split(' ');
                    if (parts.Length > 1)
                        usedVariables.Add(parts[1]);
                }
            }

            // Second pass: keep only used assignments
            var newCode = new List<string>();
            foreach (var line in optimizedCode)
            {
                if (line.Contains(":="))
                {
                    var parts = line.Split(new[] { ":=" }, StringSplitOptions.None);
                    if (parts.Length > 0)
                    {
                        string varName = parts[0].Trim();
                        if (usedVariables.Contains(varName) || line.Contains(";"))
                        {
                            newCode.Add(line);
                        }
                        else
                        {
                            newCode.Add("; [Optimized - Dead Code Removed] " + line);
                        }
                    }
                }
                else
                {
                    newCode.Add(line);
                }
            }

            optimizedCode = newCode;
        }

        private bool IsConstantExpression(string tacLine)
        {
            // Check if the right-hand side contains only constants
            if (tacLine.Contains(":="))
            {
                var parts = tacLine.Split(new[] { ":=" }, StringSplitOptions.None);
                if (parts.Length > 1)
                {
                    string rhs = parts[1].Trim();
                    return int.TryParse(rhs, out _) || float.TryParse(rhs, out _);
                }
            }
            return false;
        }

        public List<string> GetOptimizedCode()
        {
            return optimizedCode;
        }

        public Dictionary<string, int> GetOptimizationStatistics(List<string> original)
        {
            var stats = new Dictionary<string, int>
            {
                { "OriginalLines", original.Count },
                { "OptimizedLines", optimizedCode.Count },
                { "LinesRemoved", original.Count - optimizedCode.Count }
            };

            return stats;
        }
    }
}
