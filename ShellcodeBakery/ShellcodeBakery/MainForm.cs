using System;
using System.Windows.Forms;
using Binarysharp.Assemblers.Fasm;
using System.Linq;

namespace ShellcodeBakery
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LanguageSelection.SelectedIndex = 0;
        }

        private void AssembleInternal(string bitness)
        {
            OutputTextBox.Clear();

            int lineCount = 0;
            int currentOffset = 0;

            string output = LanguageSelection.SelectedIndex == 0 ? CSyntax : CSharpSyntax;
            if (BeautifyCb.Checked) output += "\n";

            foreach(var line in InputTextBox.Lines)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        ++lineCount;
                        continue;
                    }

                    var instruction = AssembleSingleInstruction(line, bitness, lineCount == InputTextBox.Lines.Length - 1, out int length);
                    output += (BeautifyCb.Checked ? "\t": "") + instruction;

                    if (BeautifyCb.Checked)
                    {
                        if (AnnotateOffsetsCb.Checked)
                        {
                            output += GenerateTabs(length) + $" // 0x{currentOffset:X}";
                        }

                        if (AnnotateInstructionsCb.Checked)
                        {
                            output += $"{(AnnotateOffsetsCb.Checked ? ": " : GenerateTabs(length) + " // ")}" + line;
                        }
                        output += "\n";
                    }

                    currentOffset += length;
                    ++lineCount;
                }
                catch (FasmAssemblerException ex)
                {
                    MessageBox.Show($"Error: {ex.ErrorCode}\nLine: {lineCount}");
                    string[] lines = InputTextBox.Lines;

                    if (lines[lineCount].Contains(" ; <-- Error:"))
                        lines[lineCount] = lines[lineCount].Remove(lines[lineCount].IndexOf(" ; <-- Error:"));

                    lines[lineCount] = lines[lineCount] + " ; <-- Error: " + ex.ErrorCode;
                    InputTextBox.Lines = lines;
                    return;
                }
            }

            output += BeautifyCb.Checked ? "};" : " };";

            OutputTextBox.Text = output;
        }

        private string GenerateTabs(int instructionLength)
        {
            int[] lengths = { 8, 6, 5, 4, 3, 2, 1, 1 };
            string output = "";
            for (int i = 0; i < lengths[instructionLength - 1]; i++)
                output += "\t";

            return output;
        }

        private string AssembleSingleInstruction(string instruction, string bitness, bool final, out int length)
        {
            string[] mnemonics = { bitness, instruction };
            var asm = FasmNet.Assemble(mnemonics);
            string output = "";

            foreach(var b in asm)
            {
                output += "0x" + b.ToString("X2") + ", ";
            }
            if (final) output = output.Remove(output.Length - 2);
            length = asm.Length;
            return output;
        }

        private void Assemble32Btn_Click(object sender, EventArgs e)
        {
            AssembleInternal("use32");
        }

        private void Assemble64Btn_Click(object sender, EventArgs e)
        {
            AssembleInternal("use64");
        }

        string CSharpSyntax = "byte[] shellcode = { ";
        string CSyntax = "char shellcode[] = { ";
    }
}
