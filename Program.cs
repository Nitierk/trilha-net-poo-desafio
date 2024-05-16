using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia =  new Nokia("998039669", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone =  new Iphone("998039669", "Modelo 2", "11111111", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

