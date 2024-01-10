using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo1", imei: "22222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone Iphone = new Iphone(numero: "987654", modelo: "Modelo5", imei: "66666666", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Facebook");

