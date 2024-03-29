using System;
using System.Threading;

namespace TAFL
{
    public class Lexeme
    {
        public readonly LexemeType Type;
        public readonly int Line;
        public readonly int Start;
        public readonly int End;
        public readonly string Word;
        public readonly double Value;

        public Lexeme(LexemeType type, int line, int start, int end, string word = null, double value = 0)
        {
            this.Type = type;
            this.Line = line;
            this.Start = start;
            this.End = end;
            this.Word = word;
            this.Value = value;
        }
        public static implicit operator int(Lexeme lexeme) => (int) lexeme.Type;
    }

    public enum LexemeType
    {
        Identifier,
        Const,
        Summation,
        Subtraction,
        Multiplication,
        Division,
        Assignment,
        LeftRoundBracket,
        RightRoundBracket,
        Semicolon,
        LeftSquareBracket,
        RightSquareBracket,
        Comma,
        EqualTo,
        NotEqualTo,
        GreaterThan,
        LessThan,
        GreaterThanOrEqualTo,
        LessThanOrEqualTo,
        Or,
        And,
        Not,
        LeftCurlyBracket,
        RightCurlyBracket,
        Read,
        Write,
        While,
        If,
        Else,
        Var,
        Fn,
        Return,
        EoF,
        Error
    }
}