using DesafioPOO.Models;

Console.WriteLine("IPHONE\n");

Iphone iphone = new Iphone("99-999999999","Iphone-13","888998-898559-9988asv",8);
iphone.InstalarAplicativo("Itaú Cartões");
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine();

Console.WriteLine("NOKIA\n");
Nokia nokia = new Nokia("99-999999999", "Nokia-G21", "88568-558889-9998asv", 8);
nokia.InstalarAplicativo("Bradesco Cartões");
nokia.Ligar();
nokia.ReceberLigacao();
