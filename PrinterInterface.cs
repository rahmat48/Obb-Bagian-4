using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;

namespace PrinterInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer prt = new Printer();
            Dimen dm = new Dimen();
            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Lasetjet");
            Console.WriteLine("");
            Console.WriteLine("Nomor Printer [1..3] : ");
            int nomor = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            IConvertObject convert;
            if (nomor == 1)
            {
                prt.nama = "Epson Display Dimension : 10*11";
                dm.dimen = "Epson Printer Printing ....";
                convert = new ConvertToJson();
            }
            else if (nomor == 2)
            {
                prt.nama = "Canon Display Dimension : 9.5*12";
                dm.dimen = "Canon Printer Printing ....";
                convert = new ConvertToJson2();
            }
            else
            {
                prt.nama = "Lasetjat Display Dimension : 12*12";
                dm.dimen = "Lasetjat Printer Printing ....";
                convert = new ConvertToJson3();
            }

            convert.Convert(prt);
            convert.Convert(dm);

            Console.ReadKey();
        }
    }

    public class Printer
    {
        public string nama { get; set; }
    }
    public class Dimen
    {
        public string dimen { get; set; }
    }

    public interface IConvertObject
    {
        void Convert(Printer prt);
        void Convert(Dimen dm);
    }

    
    public class ConvertToJson : IConvertObject
    {
        public void Convert(Printer prt)
        {
            string json = JsonConvert.SerializeObject(prt);
            
            Console.WriteLine(json);
        }
        public void Convert(Dimen dm)
        {
            string json2 = JsonConvert.SerializeObject(dm);

            Console.WriteLine(json2);
        }
    }
    public class ConvertToJson2 : IConvertObject
    {
        public void Convert(Printer prt)
        {
            string json = JsonConvert.SerializeObject(prt);

            Console.WriteLine(json);
        }
        public void Convert(Dimen dm)
        {
            string json2 = JsonConvert.SerializeObject(dm);

            Console.WriteLine(json2);
        }
    }
    public class ConvertToJson3 : IConvertObject
    {
        public void Convert(Printer prt)
        {
            string json = JsonConvert.SerializeObject(prt);

            Console.WriteLine(json);
        }
        public void Convert(Dimen dm)
        {
            string json2 = JsonConvert.SerializeObject(dm);

            Console.WriteLine(json2);
        }
    }

}


