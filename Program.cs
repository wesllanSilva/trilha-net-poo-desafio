using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia!");
Smartphone novoNokia = new Nokia(numero: "5578965", modelo: "Z10", imei: "555855", memoria: 240);
novoNokia.Ligar();
novoNokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone!");
Smartphone iphone20 = new Iphone(numero: "5578965", modelo: "Z10", imei: "555855", memoria: 240);
iphone20.ReceberLigacao();
iphone20.InstalarAplicativo("YouTube");