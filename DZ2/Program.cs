string A = Console.ReadLine();
string B = Console.ReadLine();
string С = Console.ReadLine();

int numA = Convert.ToInt32(A);
int numB = Convert.ToInt32(B);
int numС = Convert.ToInt32(С);

if (numA > numB)
{
    if (numA > numC){
        Console.WriteLine(numA);
     }
    else Console.WriteLine(numC);

}
else if (numB > numC)
{
    Console.WriteLine(numB);
}
else{
    Console.WriteLine(numC);
}
