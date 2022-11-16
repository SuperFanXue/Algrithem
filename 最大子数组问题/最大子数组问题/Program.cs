// See https://aka.ms/new-console-template for more inform

using System;

int[] priceArray = { 100, 113, 110, 85, 105, 102, 86, 63, 82, 101, 94, 106, 101, 79, 94, 90, 97 };
int[] priceFluctuationArray = new int[priceArray.Length];

for(int i = 1; i<priceArray.Length; i++)
{
    priceFluctuationArray[i - 1] = priceArray[i] - priceArray[i - 1];
}

int total = priceFluctuationArray[0];
int startIndex = 0;
int endIndex = 0;

for(int i = 0; i<priceFluctuationArray.Length; i++)
{
    for(int j = i; j<priceFluctuationArray.Length; j++)
    {
        int temptotal = 0;
        for(int index = i; index<=j; index++)
        {
            temptotal += priceFluctuationArray[index];
        }
        if(temptotal > total)
        {
            total = temptotal;
            startIndex = i;
            endIndex = j;
        }
    }
}
Console.WriteLine($" start: {startIndex}  end: {endIndex}");
