
// Declare an array of integer type
int[] data = { 3, 4, 3, 6, 2, 3, 4, 5, 7, 3 };
Console.WriteLine("Array before removing duplicate values: ");
Array.ForEach(data, i => Console.WriteLine(i));

//remove duplicate integers
int[] unique = data.Distinct().ToArray();

// Display the final result
Console.WriteLine("Array after removing duplicate values: ");
Array.ForEach(unique, j => Console.WriteLine(j));








