//сложный 19
Console.Write("Введите текст: ");
char[] s1 = Console.ReadLine().ToCharArray();
string s2 = "";
int i, L;
L = s1.Length;
for (i = 0; i < L; i++)
{
    s2 = s2 + s1[L - i - 1];
}
Console.WriteLine("s1={0}, s2={1}", s1, s2);
Console.ReadKey();