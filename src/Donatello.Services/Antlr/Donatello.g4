grammar Donatello;

file: form*;

form: literal
    | list
    | lambda
    | vector
    | set
    | dictionary
    ;

list: '(' form* ')' ;

// collection types
dictionary: '{' form* '}';
set: '|' form* '|';
vector: '[' form* ']' ;

LAMBDA_PARAMETER: '\\' [0-9]+;
lambdaParameter: LAMBDA_PARAMETER;
lambda: '\\(' form* ')';

literal
    : string
    | number
    | methodAccess
    | fieldAccess
    | symbol
    | lambdaParameter
    | type
    ;

string: STRING;
number: LONG;
methodAccess: METHOD_ACCESS;
fieldAccess: FIELD_ACCESS;
symbol: SYMBOL;
type: TYPE;

// Lexers
//--------------------------------------------------------------------

STRING: '"' ( ~'"' | '\\' '"' )* '"' ;
LONG: '-'? [0-9]+[lL]?;
METHOD_ACCESS: '.' SYMBOL;
FIELD_ACCESS: '-' SYMBOL;
SYMBOL: ('A'..'Z' | 'a'..'z' | '0'..'9' | '_' | '.' | '=' | '<' | ',' | ', ' | '>' | '*')+ | MATH_OPERATION;
TYPE: ':' ('A'..'Z' | 'a'..'z' | '<' | ',' | ', ' | '>')+; //TODO: need to tighten this up.
MATH_OPERATION: '+' | '-' | '/' | '*' | '%';

// Discard
//--------------------------------------------------------------------

fragment
WS : [ \n\r\t,] ;

fragment
COMMENT: '//' ~[\r\n]* ;

TRASH
    : ( WS | COMMENT ) -> channel(HIDDEN)
    ;
