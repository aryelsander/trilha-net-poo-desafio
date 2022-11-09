using DesafioPOO.Models;

Nokia nokia = new Nokia("1","Lumia","1243213",1024);
Iphone iphone = new Iphone("2","Iphone 6","414124214",1024);


System.Console.WriteLine("Teste Nokia");
System.Console.WriteLine(nokia.ToString());
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
System.Console.WriteLine();

System.Console.WriteLine("Teste Iphone");
System.Console.WriteLine(iphone.ToString());
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");