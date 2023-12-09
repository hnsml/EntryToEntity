using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO.Pipes;
using System.Text;
using Data;
using Model;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        using (DataContex dc = new DataContex())
        {
            Standing realMadrid = new Standing("Реал Мадрид", "Мадрид", 4, 0, 1);
            Standing girona = new Standing("Жірона", "Жірона", 4, 0, 1);
            Standing barcelona = new Standing("Барселона", "Барселона", 3, 1, 1);
            Standing atleticoMadrid = new Standing("Атлетіко Мадрид", "Мадрид", 3, 2, 0);
            Standing atleticoBilbao = new Standing("Атлетік Більбао", "Більбао", 3, 0, 2);
            Standing realіsociedad = new Standing("Реал Сосьєдад", "Сан-Себастьян", 2, 2, 1);
            Standing betis = new Standing("Бетіс", "Севілья", 2, 0, 3);
            Standing laspalmas = new Standing("Лас-Пальмас", "Лас-Пальмас", 3, 1, 2);
            Standing getafe = new Standing("Хетафе", "Мадрид", 3, 1, 2);
            Standing valencia = new Standing("Валенсія", "Валенсія", 1, 3, 1);
            dc.Standings.Add(realMadrid);
            dc.Standings.Add(girona);
            dc.Standings.Add(barcelona);
            dc.Standings.Add(atleticoMadrid);
            dc.Standings.Add(atleticoBilbao);
            dc.Standings.Add(realіsociedad);
            dc.Standings.Add(betis);
            dc.Standings.Add(laspalmas);
            dc.Standings.Add(getafe);
            dc.Standings.Add(valencia);
            dc.SaveChanges();
            var standings = dc.Standings.ToList();
            Console.WriteLine("Турнірна талиця: ");
            Console.WriteLine();
            Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-10} {4,-10}","Назва команди","Назва міста","W","L","D");
            Console.WriteLine();
            foreach (var standing in standings)
            {
                Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-10} {4,-10}", standing.name, standing.city, standing.wins, standing.defeats, standing.draws);
            }
        }



    }
}