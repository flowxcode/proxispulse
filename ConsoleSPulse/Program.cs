// See https://aka.ms/new-console-template for more information
using ConsoleSPulse;
using ProxiLABLib;

Console.WriteLine("init keolabs!");

//var keo = new KeoService();

var proxilab = (IProxiLAB)Activator.CreateInstance(Type.GetTypeFromProgID("KEOLABS.ProxiLAB"));
var x = KeoService.InitProtocol(proxilab);

//int cycles 500;

byte[] cmd = { 0x00, 0xA4, 0x04, 0x00, 0x08, 0xA0, 0x00, 0x00, 0x01, 0x51, 0x00, 0x00, 0x00, 0x00 };

long time = 0;

for (uint i = 500; i < 50000; i += 100)
{
    KeoService.SendTclTearing(proxilab, cmd, i, out time);
}

Console.WriteLine("end");
