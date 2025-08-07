using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia("491234", "Modelo 01", "487364378", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Nokia: ");
Smartphone iphone = new Iphone("12345", "Modelo 02", "111111111", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");