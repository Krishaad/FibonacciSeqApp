using System.Numerics;


BigInteger[] fibseq = new BigInteger[150];
fibseq[0] = 0;
fibseq[1] = 1;

//Console.WriteLine("This is the 1st number in the fibonacci sequence 0");
//Console.WriteLine("This is the 2nd number in the fibonacci sequence 1");
for (int i = 2; i <= 100; i++)
{
    fibseq[i] = fibseq[i - 1] + fibseq[i - 2];
    //Console.WriteLine($"This is the {i+1}th number in the fibonacci sequence {fibseq[i]}");

}

Console.WriteLine($"The 100th iteration of the fibonacci sequence is {fibseq[100]}");

