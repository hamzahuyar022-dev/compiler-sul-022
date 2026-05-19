# 🔧 Mini Compiler Application

```
████████████████████████████████████████████████████████████████
█                                                              █
█   A Comprehensive C# .NET Compiler with All 6 Phases        █
█   Lexical → Syntax → Semantic → IR → Optimization → Code   █
█                                                              █
████████████████████████████████████████████████████████████████
```

---

## 📋 Project Overview

**Mini Compiler** is a full-featured compiler application built with **C# .NET Framework 4.7.2** and **Windows Forms**. It implements a complete compiler pipeline with all 6 phases, featuring a professional animated dark theme UI inspired by Visual Studio Code and JetBrains IDEs.

This project demonstrates compiler theory in action with real-time visualization, comprehensive error handling, and production-quality code architecture.

---

## 🎯 Features

### ✅ Complete 6-Phase Compiler Implementation

| Phase | Description | Status |
|-------|-------------|--------|
| **Phase 1: Lexical Analysis** | Tokenization, classification, symbol table creation | ✨ Enhanced |
| **Phase 2: Syntax Analysis** | Parse tree generation, grammar validation, derivations | ✨ Enhanced |
| **Phase 3: Semantic Analysis** | Type checking, scope analysis, attribute evaluation | 🆕 New |
| **Phase 4: Intermediate Code Generation** | Three-address code (TAC), IR visualization | 🆕 New |
| **Phase 5: Optimization** | Constant folding, dead code elimination, CSE | 🆕 New |
| **Phase 6: Code Generation** | Target code generation, register allocation | 🆕 New |

### 🎨 Professional UI/UX
- **Animated Dark Theme** with 12-color professional palette
- **Tabbed Interface** for all 6 compiler phases
- **Real-time Code Editor** with syntax highlighting
- **Color-coded Output Panels** - each phase has unique accent colors
- **Visual Tree Representations** with expandable nodes
- **Smooth Phase Transitions** with progress indicators
- **Error Highlighting** with line numbers and detailed messages
- **Side Statistics Panel** showing compilation metrics

### 🔍 Advanced Features
- Symbol table management and visualization
- Left-most & Right-most derivations (LMD/RMD)
- Three-address code (TAC) generation and display
- Optimization impact metrics
- Before/After optimization comparison
- Real-time error tracking and reporting
- Comprehensive compilation reports
- Independent phase testing capabilities

---

## 🛠️ Technology Stack

### **Framework & Language**
- ![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white) **C# .NET Framework 4.7.2**
- ![Windows](https://img.shields.io/badge/Windows%20Forms-0078D4?style=flat-square&logo=windows&logoColor=white) **Windows Forms (WinExe)**

### **Core Components**
- `Token.cs` - Token definition and classification
- `Parser.cs` - Syntax analysis and parse tree generation
- `ParseTreeNode.cs` - Tree node representation
- `SemanticAnalyzer.cs` - Type checking and scope analysis
- `IntermediateCodeGen.cs` - Three-address code generation
- `Optimizer.cs` - Code optimization passes
- `CodeGenerator.cs` - Target code generation
- `ModernUIHelper.cs` - Professional theming and animations

---

## 🎨 Design & Theming

### Color Palette (12-Color Professional Theme)
```
Primary Colors:
├─ Cyan        #64c8ff  (Primary highlights)
├─ Purple      #9664ff  (Secondary highlights)
└─ Orange      #ff8c00  (Tertiary highlights)

Status Colors:
├─ Green       #4caf50  (Success/Valid)
├─ Red         #f44336  (Error/Invalid)
└─ Yellow      #ff9800  (Warning/Info)

Base Colors:
├─ Dark Navy   #1a1e28  (Background)
├─ Dark Gray   #262b38  (Secondary background)
└─ Light Gray  #e6e6e6  (Text/Foreground)
```

### Typography
- **Code Display:** Consolas, 10pt
- **UI Elements:** Segoe UI, 9-11pt
- **Headers:** Segoe UI, 12-14pt

---

## 📊 Project Structure

```
compiler-sul-022/
├── 📄 README.md
├── 📄 LICENSE
├── 🔧 Source/
│   ├── Token.cs                 # Token definitions
│   ├── Parser.cs                # Syntax analysis
│   ├── ParseTreeNode.cs         # Tree structures
│   ├── SemanticAnalyzer.cs      # Semantic analysis
│   ├── IntermediateCodeGen.cs   # IR generation
│   ├── Optimizer.cs             # Optimization passes
│   ├── CodeGenerator.cs         # Code generation
│   ├── ModernUIHelper.cs        # UI theming
│   ├── Form1.cs                 # Main compiler UI
│   ├── Form2.cs                 # Phase visualization
│   ├── Form3.cs                 # Complete pipeline view
│   └── Program.cs               # Entry point
├── 📝 Docs/
│   ├── ARCHITECTURE.md          # System design
│   ├── PHASES.md                # Phase documentation
│   ├── ALGORITHMS.md            # Algorithm descriptions
│   └── API.md                   # API reference
├── 🧪 Tests/
│   ├── SamplePrograms.txt       # Test cases
│   ├── CompilerTests.cs         # Unit tests
│   └── IntegrationTests.cs      # Integration tests
└── 📦 Build/
    └── compiler-sul-022.exe     # Compiled executable
```

---

## 🚀 Getting Started

### Prerequisites
- Windows OS (7, 8, 10, 11)
- .NET Framework 4.7.2 or higher
- Visual Studio 2015 or later (recommended)

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/hamzahuyar022-dev/compiler-sul-022.git
   cd compiler-sul-022
   ```

2. **Open in Visual Studio**
   - Open `compiler-sul-022.sln` in Visual Studio
   - Restore NuGet packages
   - Build the solution (Ctrl + Shift + B)

3. **Run the Application**
   - Press F5 or click "Start" to run
   - The Mini Compiler UI will launch

### Quick Test

1. Paste sample code in the input editor:
   ```c
   int x = 5;
   int y = 10;
   int z = x + y;
   print(z);
   ```

2. Click "Compile" or press Ctrl + Enter

3. Watch all 6 phases execute in real-time with animations

---

## 📖 Usage Guide

### Phase 1: Lexical Analysis
- **Input:** Raw source code
- **Output:** Token stream with classifications
- **Features:** 
  - Token highlighting by type
  - Symbol table display
  - Error detection (invalid tokens)

### Phase 2: Syntax Analysis
- **Input:** Token stream
- **Output:** Parse tree (AST)
- **Features:**
  - Tree visualization with expansion
  - Left-most and right-most derivations
  - Production rules display
  - Syntax error recovery

### Phase 3: Semantic Analysis
- **Input:** Parse tree
- **Output:** Annotated AST with type info
- **Features:**
  - Type checking
  - Scope analysis
  - Function declaration verification
  - Semantic error detection

### Phase 4: Intermediate Code Generation
- **Input:** Annotated AST
- **Output:** Three-address code (TAC)
- **Features:**
  - TAC visualization
  - Quadruple/Triple representations
  - Control flow graph display
  - IR step-by-step animation

### Phase 5: Optimization
- **Input:** Intermediate code
- **Output:** Optimized IR
- **Features:**
  - Before/After comparison
  - Optimization metrics
  - Code reduction statistics
  - Visual highlighting of optimizations

### Phase 6: Code Generation
- **Input:** Optimized IR
- **Output:** Target code (Assembly-like)
- **Features:**
  - Register allocation visualization
  - Instruction selection display
  - Final symbol table
  - Execution simulation (optional)

---

## 🔧 Key Components

### Token.cs
Defines token types and classification:
```csharp
public enum TokenType
{
    Keyword, Identifier, Number, Operator, 
    Delimiter, String, Comment, EOF
}
```

### Parser.cs
Implements recursive descent parser and parse tree generation.

### SemanticAnalyzer.cs
Performs type checking, scope analysis, and semantic validation.

### IntermediateCodeGen.cs
Generates three-address code and intermediate representations.

### Optimizer.cs
Implements optimization passes:
- Constant folding and propagation
- Dead code elimination
- Common subexpression elimination
- Loop optimizations

### CodeGenerator.cs
Generates target code with register allocation and instruction selection.

### ModernUIHelper.cs
Provides professional theming, colors, and animation utilities.

---

## 🎯 Supported Language Features

The Mini Compiler currently supports:

- **Data Types:** int, float, string, bool
- **Operators:** Arithmetic (+, -, *, /), Logical (&&, ||, !), Comparison (==, !=, <, >)
- **Control Flow:** if-else, while, for loops
- **Functions:** Function declaration and calls
- **Variables:** Declaration, assignment, scope handling

### Sample Program
```c
int factorial(int n) {
    if (n <= 1)
        return 1;
    else
        return n * factorial(n - 1);
}

int main() {
    int result = factorial(5);
    print(result);
    return 0;
}
```

---

## 📊 Compilation Statistics

After compilation, view detailed statistics:
- **Tokens Generated:** Total count and breakdown by type
- **Parse Tree Nodes:** Total nodes and tree depth
- **Semantic Errors:** Count and severity levels
- **TAC Instructions:** Total three-address code instructions
- **Optimizations Applied:** Count and types
- **Code Size:** Before and after optimization
- **Compilation Time:** Total and per-phase breakdown

---

## 🧪 Testing

### Run Tests
```bash
# Unit tests for individual components
dotnet test Tests/CompilerTests.cs

# Integration tests for complete pipeline
dotnet test Tests/IntegrationTests.cs
```

### Test Cases
See `Tests/SamplePrograms.txt` for comprehensive test cases covering:
- Simple expressions and assignments
- Control flow structures
- Function declarations and calls
- Semantic type checking
- Error recovery and reporting

---

## 📝 Documentation

- **[ARCHITECTURE.md](Docs/ARCHITECTURE.md)** - System design and architecture
- **[PHASES.md](Docs/PHASES.md)** - Detailed phase documentation
- **[ALGORITHMS.md](Docs/ALGORITHMS.md)** - Algorithm descriptions and complexity
- **[API.md](Docs/API.md)** - API reference and examples

---

## 🎨 UI Showcase

### Main Compiler Window
- **Top:** Source code editor with real-time input
- **Middle:** Tabbed interface for all 6 phases
- **Right Side:** Statistics panel and metrics
- **Bottom:** Error console and detailed messages

### Phase-Specific Views
- **Phase 1:** Token list with color coding by type
- **Phase 2:** Expandable parse tree visualization
- **Phase 3:** Type information and scope highlighting
- **Phase 4:** Three-address code with control flow
- **Phase 5:** Before/After optimization comparison
- **Phase 6:** Generated target code display

---

## 🚧 Roadmap

- [ ] Support for more complex language features
- [ ] Multi-pass optimization strategies
- [ ] JIT compilation support
- [ ] AST-based debugging features
- [ ] Export compilation reports (PDF/HTML)
- [ ] Plugin system for custom phases
- [ ] Command-line interface (CLI)

---

## 🤝 Contributing

Contributions are welcome! Here's how:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit changes (`git commit -m 'Add amazing feature'`)
4. Push to branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### Contribution Guidelines
- Follow existing code style and conventions
- Add tests for new features
- Update documentation accordingly
- Keep commits atomic and descriptive

---

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

---

## 👨‍💻 Author

**Hamza Huyar**
- GitHub: [@hamzahuyar022-dev](https://github.com/hamzahuyar022-dev)
- Email: hamzahuyar022@example.com

---

## 🙏 Acknowledgments

- Compiler design principles from classic literature
- Inspiration from professional IDEs (VS Code, JetBrains)
- Community feedback and contributions

---

## 📚 Resources & References

### Books
- *Compilers: Principles, Techniques, and Tools* - Aho, Sethi, Ullman
- *Engineering a Compiler* - Cooper & Torczon

### Online Resources
- [Compiler Design Tutorial](https://www.tutorialspoint.com/compiler_design/)
- [Dragon Book (Online)](https://en.wikipedia.org/wiki/Compilers:_Principles,_Techniques,_and_Tools)

### Related Projects
- LLVM - Low Level Virtual Machine
- GCC - GNU Compiler Collection
- Roslyn - .NET Compiler Platform

---

## 💬 Support

If you have questions or need assistance:
- 📧 Open an issue on GitHub
- 💬 Check existing documentation
- 🔍 Review test cases for usage examples

---

## 🌟 Show Your Support

If you found this project helpful, please consider:
- ⭐ Starring the repository
- 🔄 Sharing with others
- 💡 Contributing improvements
- 📢 Providing feedback

---

<div align="center">

```
████████████████████████████████████████████████████████████████
█  Made with ❤️  for compiler enthusiasts and developers      █
████████████████████████████████████████████████████████████████
```

**[⬆ Back to Top](#-mini-compiler-application)**

</div>

---

*Last Updated: May 19, 2026 | Version: 1.0.0*
