using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LatihanOverloadingMethod
{
public class Numbers
{
public int FindMinimum(int number1, int number2)
{
int min;
if (number1 < number2)
min = number1;
else
min = number2;
return min;
}
public int FindMinimum(int number1, int number2, int number3)
{
int min;
if (number1 < number2)
min = number1;
else
min = number2;
if (min < number3)
min = min;
else
min = number3;
return min;
}
public int FindMaximum(int number1, int number2)
{
@April 9, 2022 11:59 PM
Method 2
int max;
if (number1 > number2)
max = number1;
else
max = number2;
return max;
}
public int FindMaximum(int number1, int number2, float number3)
{
int max;
if (number1 > number2)
max = number1;
else
max = number2;
if (max > number3)
max = max;
else
max = (int)number3;
return max;
}
}
}
