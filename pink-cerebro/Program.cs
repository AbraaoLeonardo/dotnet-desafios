string[] number = Console.ReadLine().Split(' ');

int multiplo2 = 0;
int multiplo3 = 0;
int multiplo4 = 0;
int multiplo5 = 0;
for (int index = 0; index < number.Length; index++)
{
    if ((int.Parse(number[index]) % 2) == 0) multiplo2 += 1;
    if ((int.Parse(number[index]) % 3) == 0) multiplo3 += 1;
    if ((int.Parse(number[index]) % 4) == 0) multiplo4 += 1;
    if ((int.Parse(number[index]) % 5) == 0) multiplo5 += 1;
}

Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);