using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(numero: "12345678", modelo: "Ultra 9", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Iphone iphone = new Iphone(numero: "222222222", modelo: "Pro Max", imei: "2121121212", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");