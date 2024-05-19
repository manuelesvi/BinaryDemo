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
Console.WriteLine("Press any key to continue...");
Console.Read();


string Imprime(Digitos digitos) => string.Format("decimal: {1}, binario: {0}, octal: {2}, hexadecimal: {3}",
    Convert.ToString((int)digitos, toBase: 2), (int)digitos,
    Convert.ToString((int)digitos, toBase: 8),
    Convert.ToString((int)digitos, toBase: 16));
