using System.Collections;
using System.Linq;

/*
//Array
char[] arrChar = new char[3];
Console.WriteLine(arrChar.Length);
var arrChar2 = new char[3];
var arrChar3 = new char[3] { 'b', 't', 'k' };
var arrInt = Array.CreateInstance(typeof(int), 5);
arrInt.SetValue(10, 0); // arrInt[0] = 10
arrInt.SetValue(20, 1); // 10
arrInt.GetValue(0);



//ArrayList - Not Type-Safe
// 10 -> boxing -> object
// b -> boxing -> object
// object -> unboxing -> int 
var arrObj = new ArrayList();
arrObj.Add(10);
arrObj.Add('b');
var c = ((int)arrObj[0] + 10);

//List<T> - Type-Safe
var arrIntG = new List<int>();
arrIntG.Add(10);
arrIntG.AddRange(new int[] {1, 2, 3 });
arrIntG.RemoveAt(0);
Console.WriteLine(arrIntG.Count);
foreach (var i in arrIntG)
{
    Console.WriteLine(i);
}
//arrIntG.Add(false); error   



var arr = new Array<int>();
for (int i = 0; i < 5; i++)
{
    arr.Add(i);
}
arr.Remove();
Console.WriteLine(arr.InnerList[4]);

foreach (var item in arr)
{
    Console.WriteLine(item);
}
Console.WriteLine("------EVEN NUMBERS IN ARR------");
arr.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine("-------------");
Console.WriteLine($"{"Count"}:{arr.Count} - {"Capacity"}:{arr.Capacity}");


Console.WriteLine("-----ARR2-----");
var arr2 = new Array<int>(10, 20, 30, 40, 50, 60);
foreach (var item in arr2)
{
    Console.WriteLine(item);
}


Console.WriteLine("-----TEST-----");
var arr3 = new Array<int>(1, 2, 3, 4);
var arr4 = new int[] { 8, 9, 10, 11 };
var arr5 = new List<int> { 5, 15, 20, 25 };
var arr6 = new ArrayList() { 12, 13, 14 }; 

var test = new Array<int>(arr5); // arr6 gives error - conversion error (boxing-unboxing)  
foreach (var item in test)
{
    Console.WriteLine(item);
}


var arr = new Array<int>();
for (int i = 0; i < 10; i++)
{
    arr.Add(i + 1);
    Console.WriteLine($"{i + 1} has been added to array");
    Console.WriteLine($"{"Count"}:{arr.Count} - {"Capacity"}:{arr.Capacity}");
}

for (int i = arr.Count; i > 1; i--)
{
    Console.WriteLine($"{arr.Remove()} has been removed from the array");
    Console.WriteLine($"{"Count"}:{arr.Count} - {"Capacity"}:{arr.Capacity}");
}

Console.WriteLine();

foreach (var item in arr)
{
    Console.WriteLine(item);
}


var arr = new Array<int>(1,3,5,7);
var carr = (Array<int>)arr.Clone();
arr.Add(99);
foreach (var item in arr)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine($"{arr.Count}/{arr.Capacity}");

foreach (var item in carr)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine($"{carr.Count}/{carr.Capacity}");
*/

var arr = new Array<int>(1,2,4,5);
arr.Remove(1);
foreach (var item in arr)
{
    Console.WriteLine(item);
}