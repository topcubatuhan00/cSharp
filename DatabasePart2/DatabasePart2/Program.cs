using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConnectDb connectDb = new ConnectDb();
            /*connectDb.getData();

            if (connectDb.updateClassData(10,20))
                Console.WriteLine("güncelleme başarılı");

            if (connectDb.insertClassData("testData", 300))
                Console.WriteLine("ekleme başarılı");

            if (connectDb.deleteClassData(50))
                Console.WriteLine("silme başarılı");

            connectDb.getData();*/

            connectDb.runProcedure();

        }
    }
}
