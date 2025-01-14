using System;
public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // Creamos una lista para los resultados
        var results = new System.Collections.Generic.List<int>();

        // Indices para recorrer list1 y list2
        int index1 = 0, index2 = 0;

        // Recorrer el arreglo select
        foreach (var sel in select)
        {
            if (sel == 1) // seleccionar de list1
            {
             if (index1 < list1.Length) // Asegurarse de que no exceda el límite
                {
                    results.Add(list1[index1]);
                    index1++; // Avanzar el índice de list1
                }
            }
            else if (sel == 2) // Seleccionar de list2
            {
                if (index2 < list2.Length) // Asegurarse de que no exceda el límite
                {
                    results.Add(list2[index2]);
                    index2++; // Avanzar el índice de list2
                }
            }
        }

        // Convertir la lista a un arreglo y devolverla
        return results.ToArray();
    }
}