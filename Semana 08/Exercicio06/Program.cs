using factoryPatternexample;

string PhoneType = "Sumsung";

Imobile mobile = MobileFactory.GetPhoneObj(PhoneType);

Console.WriteLine("CPU: " + mobile.GetCPU());
Console.WriteLine("RAM: " + mobile.GetRAM());

Console.ReadLine();