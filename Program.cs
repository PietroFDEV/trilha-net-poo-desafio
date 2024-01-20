using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia("12", "22","4",260);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone("X", "2","8",1000);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");