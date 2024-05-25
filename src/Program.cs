using System.Diagnostics;

Console.WriteLine(Imprime(Digitos.Zero));
Console.WriteLine(Imprime(Digitos.One));
Console.WriteLine(Imprime(Digitos.Two));
Console.WriteLine(Imprime(Digitos.Three));
Console.WriteLine(Imprime(Digitos.Four));
Console.WriteLine(Imprime(Digitos.Five));
Console.WriteLine(Imprime(Digitos.Six));
Console.WriteLine(Imprime(Digitos.Seven));
Console.WriteLine(Imprime(Digitos.Eight));
Console.WriteLine(Imprime(Digitos.Nine));
Console.WriteLine(Imprime(Digitos.Ten));
Console.WriteLine(Imprime(Digitos.Eleven));
Pause();

var digits = Digitos.One
    | Digitos.Two
    | Digitos.Five; // 10011 - dec: 19, octal: 23, hex = 13

Console.WriteLine(Imprime(digits));
Trace.Assert((int)digits == 19,
    "unexpected quantity for digits, expected = 19");

Pause();

string Imprime(Digitos digitos) => string.Format(
    "decimal: {1}, binario: {0}, octal: {2}, hexadecimal: {3}",
    Convert.ToString((int)digitos, toBase: 2), // binary
        (int)digitos,                          // decimal
    Convert.ToString((int)digitos, toBase: 8), // octal
    Convert.ToString((int)digitos, toBase: 16)); // hexadecimal
