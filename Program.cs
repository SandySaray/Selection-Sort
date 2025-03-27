using System;
class Program{
    static void Main()
    {
        // Erstelle ein Array mit zufälligen Zahlen
        int[] array = new int[10];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
        }

        // Gib das unsortierte Array aus
        Console.WriteLine("Unsortiertes Array:");
        foreach (int zahl in array)
        {
            Console.Write(zahl + " ");
        }
        Console.WriteLine();

        // Sortiere das Array mit Selection Sort
        SelectionSort(array);

        // Gib das sortierte Array aus
        Console.WriteLine("Sortiertes Array:");
        foreach (int zahl in array)
        {
            Console.Write(zahl + " ");
        }


    }
    static void SelectionSort(int [] array)
    {
        // Durchlaufe jeden Index außer den letzten
        for(int i=0; i < array.Length- 1; i++)
        {
            //wir nehmen an : das aktuelle Element ist das kleinste
            // und suchen das kleinste Element im Rest des Arrays
            
            
            int minIndex = i;
            //vergliche array[minIndex] mit den anderen Elementen
            for(int j = i + 1; j < array.Length; j++)
            {
                // Wenn das aktuelle Element kleiner ist als das kleinste Element,
                if(array[j] < array[minIndex])
                {
                    // aktualisiere den Index des kleinsten Elements
                    // und setze den Index des kleinsten Elements auf j
                    minIndex = j;
                }
            }
        
            if(minIndex != i)
            {
                // Tausche das aktuelle Element mit dem kleinsten Element
                // wenn sie unterschiedlich sind
                  int temp = array[minIndex];
                   array[minIndex] = array[i];
                   array[i] = temp;
            }
        }
    
    }
}