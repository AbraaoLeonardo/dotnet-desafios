double pi, raio, volume;
raio = double.Parse(Console.ReadLine());
pi = 3.14159;
volume = (4 / 3.0) * pi * raio * raio * raio;
Console.WriteLine($"VOLUME = " + volume.ToString("F3"));
