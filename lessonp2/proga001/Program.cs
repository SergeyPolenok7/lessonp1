﻿//int a1 = 10, b1 = 12, c1 = 4,
   // a2 = 14, b2 = 16, c2 = 8,
    //a3 = 9, b3 = 24, c3 = 1;

//int max = a1;
//if (b1>max) max = b1;
//if (c1>max) max = c1;

//if (a2>max) max = a2;
//if (b2>max) max = b2;
//if (c2>max) max = c2;

//if (a3>max) max = a3;
//if (b3>max) max = b3;
//if (c3>max) max = c3;

//Console.WriteLine(max);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} 

int a1 = 10, b1 = 12, c1 = 4,
    a2 = 14, b2 = 16, c2 = 8,
    a3 = 9, b3 = 24, c3 = 1;

int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);

Console.WriteLine(max);