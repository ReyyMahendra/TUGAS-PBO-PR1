using System.Runtime;
using System.Runtime.CompilerServices;

namespace PBOTugasPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ban ban1 = new Ban("Ban Michelin");
            Ban ban2 = new Ban("Ban Bridgestone");

            mobil mobil1 = new Agya("Toyota", "Agya", ban1);
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();
            Console.WriteLine(mobil1.ban.merk);
            Console.WriteLine();

            mobil mobil2 = new Avanza("Toyota", "Avanza", ban2);
            mobil2.NyalakanMesin();
            mobil2.MatikanMesin();
            Console.WriteLine(mobil2.ban.merk);
            Console.WriteLine();

            mobil innova1 = new Innova("Toyota", "Innova", ban1);
            innova1.NyalakanMesin();
            innova1.MatikanMesin();
            Console.WriteLine();

            mobil ayla1 = new Ayla("Daihatsu", "Ayla", ban1);
            ayla1.NyalakanMesin();
            ayla1.MatikanMesin();
            Console.WriteLine();

            mobil xenia1 = new Xenia("Daihatsu", "Xenia", ban2);
            xenia1.NyalakanMesin();
            xenia1.MatikanMesin();
            Console.WriteLine();

            mobil brio1 = new Brio("Honda", "Brio", ban1);
            brio1.NyalakanMesin();
            brio1.MatikanMesin();
            Console.WriteLine();

            mobil civic1 = new Civic("Honda", "Civic", ban2);
            civic1.NyalakanMesin();
            civic1.MatikanMesin();
            ((Civic)civic1).VtecKickedIn();
            Console.WriteLine();
        }
    }
}

class mobil
{
    public string merk;
    public string tipe;
    public Ban ban;

    public mobil(string merk, string tipe, Ban ban)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.ban = ban;
    }

    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} menyala");
    }

    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} mati");
    }
}

class honda : mobil
{
    public honda(string merk, string tipe, Ban ban) : base("Honda", tipe, ban)
    {
    }
}

class Brio : honda
{
    public Brio(string merk, string tipe, Ban ban) : base(merk, "Brio", ban)
    {
    }
}

class Civic : honda
{
    public Civic(string merk, string tipe, Ban ban) : base(merk, "Civic", ban)
    {
    }
    public void VtecKickedIn()
    {
        Console.WriteLine($"Ngeeeng Wooosh!!!");
    }
}
class daihatsu : mobil
{
    public daihatsu(string merk, string tipe, Ban ban) : base("Daihatsu", tipe, ban)
    {
    }
}

class Xenia : daihatsu
{
    public Xenia(string merk, string tipe, Ban ban) : base(merk, "Xenia", ban)
    {
    }
}

class Ayla : daihatsu
{
    public Ayla(string merk, string tipe, Ban ban) : base(merk, "Ayla", ban)
    {
    }
}

class toyota : mobil
{
    public toyota(string merk, string tipe, Ban ban) : base("Toyota", tipe, ban)
    {
    }
}

class Avanza : toyota
{
    public Avanza(string merk, string tipe, Ban ban) : base(merk, "Avanza", ban)
    {
    }
    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {this.merk} bertipe {this.tipe} menyala");
    }
}

class Innova : toyota
{
    public Innova(string merk, string tipe, Ban ban) : base("Toyota", tipe, ban)
    {
    }
}

class Agya : toyota
{
    public Agya(string merk, string tipe, Ban ban) : base(merk, "Agya", ban)
    {
    }
}

class Ban
{
    public string merk;
    public Ban(string merk)
    {
        this.merk = merk;
    }
}

class michelin : Ban
{
    public michelin(string merk) : base(merk)
    {
        merk = "Michelin";
    }
}

class bridgestone : Ban
{
    public bridgestone(string merk) : base(merk)
    {
        merk = "Bridgestone";
    }
}
