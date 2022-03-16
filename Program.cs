//I need to create a two dimensional array for the size of plateau's.
Console.WriteLine("Please enter the size of x dimension of plateau's : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the size of y dimension of plateau's : ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] plateau = new int[x, y];

// a two-dimensional array is created.
//But how can ı access this array's elements later?
//If ı create a collections list, ı need to check every element of this collection-list

Operations.ShowMenu();

/* ı am checking whether my plato is created or not.
int counter=1;
for (int i = 0; i <= plateauDimensions.GetUpperBound(0); i++)
{
 for (int j = 0; j <= plateauDimensions.GetUpperBound(1); j++)
 {
     plateauDimensions[i,j]+=counter;
     counter+=1;
     Console.Write(plateauDimensions[i,j].ToString()+" ");
 }   
 Console.WriteLine();
}
*/
