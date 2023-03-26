string A = Console.ReadLine();
string B = Console.ReadLine();
string X = Console.ReadLine();

int numA = Convert.ToInt32(A);
int numB = Convert.ToInt32(B);
int numX = Convert.ToInt32(X);

if (numA > numB)
{
    if (numA > numX){
        Console.WriteLine(numA);
     }
    else Console.WriteLine(numX);

}
else if (numB > numX)
{
    Console.WriteLine(numB);
}
else{
    Console.WriteLine(numX);
}
