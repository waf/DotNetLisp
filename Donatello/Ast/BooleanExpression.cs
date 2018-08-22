﻿
using Donatello.TypeInference;

namespace Donatello.Ast
{
	class BooleanExpression : ITypedExpression, ILiteralExpression
    {
        public BooleanExpression(string value) =>
            Value = bool.Parse(value);

        public bool Value { get; }
        public IType Type { get; set; } = new ConcreteType(typeof(bool));
        object ILiteralExpression.Value => Value;

        public void Accept(IVisitor visitor) => visitor.Visit(this);
        public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
    }
}
