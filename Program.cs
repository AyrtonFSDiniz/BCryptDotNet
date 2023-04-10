using static BCrypt.Net.BCrypt;
using System.Diagnostics;

Stopwatch stopWatch = new Stopwatch();
Console.WriteLine("Digite a senha para criptografar: ");
var cleanPassword = Console.ReadLine();
int WorkFactor = 15;
stopWatch.Start();
var hashedPassword = HashPassword(cleanPassword, WorkFactor);
stopWatch.Stop();
Console.WriteLine($"O hash para sua senha é: {hashedPassword}");
var seconds = stopWatch.ElapsedMilliseconds / 1000;
Console.WriteLine($"O tempo para gerar o hash foi de {seconds} segundos");


Console.WriteLine("Confirme sua senha original: ");
stopWatch.Start();
var passwordsMatch = Verify(Console.ReadLine(), hashedPassword);
stopWatch.Stop();
Console.WriteLine($"A verificação foi da senha {(passwordsMatch ? "positiva" : "negativa")}");
seconds = stopWatch.ElapsedMilliseconds / 1000;
Console.WriteLine($"O tempo para verificar a senha foi de {seconds} segundos");