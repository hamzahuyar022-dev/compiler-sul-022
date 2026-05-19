using System;
using System.Collections.Generic;

namespace MiniCompiler.CompilerPhases
{
    /// <summary>
    /// Code Generator - Phase 6
    /// Generates target code (Assembly-like pseudo-code) from optimized intermediate code
    /// </summary>
    public class CodeGenerator
    {
        private List<string> generatedCode;

        public CodeGenerator()
        {
            generatedCode = new List<string>();
        }

        public List<string> Generate(List<string> optimizedTAC)
        {
            generatedCode = new List<string>();

            generatedCode.Add("; ===== GENERATED TARGET CODE =====");
            generatedCode.Add("; Assembly-like pseudo code");
            generatedCode.Add("");

            foreach (var instruction in optimizedTAC)
            {
                string targetInstruction = TranslateToTarget(instruction);
                generatedCode.Add(targetInstruction);
            }

            generatedCode.Add("");
            generatedCode.Add("; ===== END OF GENERATED CODE =====");

            return generatedCode;
        }

        private string TranslateToTarget(string tacInstruction)
        {
            // Simple translation from TAC to pseudo-assembly

            if (tacInstruction.Contains(":="))
            {
                var parts = tacInstruction.Split(new[] { ":=" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    string target = parts[0].Trim();
                    string source = parts[1].Trim();

                    return $"  MOV {target}, {source}  ; {tacInstruction}";
                }
            }

            if (tacInstruction.Contains("+"))
            {
                var parts = tacInstruction.Split('+');
                if (parts.Length == 2)
                {
                    return $"  ADD {parts[0].Trim()}, {parts[1].Trim()}  ; {tacInstruction}";
                }
            }

            if (tacInstruction.Contains("-"))
            {
                var parts = tacInstruction.Split('-');
                if (parts.Length == 2)
                {
                    return $"  SUB {parts[0].Trim()}, {parts[1].Trim()}  ; {tacInstruction}";
                }
            }

            if (tacInstruction.Contains("*"))
            {
                var parts = tacInstruction.Split('*');
                if (parts.Length == 2)
                {
                    return $"  IMUL {parts[0].Trim()}, {parts[1].Trim()}  ; {tacInstruction}";
                }
            }

            if (tacInstruction.Contains("/"))
            {
                var parts = tacInstruction.Split('/');
                if (parts.Length == 2)
                {
                    return $"  DIV {parts[0].Trim()}, {parts[1].Trim()}  ; {tacInstruction}";
                }
            }

            return $"  ; {tacInstruction}";
        }

        public Dictionary<string, int> AllocateRegisters(List<string> variables)
        {
            var registerMap = new Dictionary<string, int>();
            int registerCount = 0;

            foreach (var variable in variables)
            {
                if (registerCount < 8) // Assume 8 available registers
                {
                    registerMap[variable] = registerCount++;
                }
            }

            return registerMap;
        }
    }
}
