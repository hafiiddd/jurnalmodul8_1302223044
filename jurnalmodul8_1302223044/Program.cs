using System.Collections.Generic;
using System.Numerics;
using static banktransferConfig;

internal class Program
{
    private static void Main(string[] args)
    {
        banktransferConfig config = new banktransferConfig();
        uibankconfig uiConfig = new uibankconfig();
        uiConfig.ReadJSON();
        
        uiConfig.config.lang = Convert.ToString(Console.ReadLine());

        if(uiConfig.config.lang == "en")
        {
            
            Console.WriteLine("Please insert the amount of money to transfer");
            
            int transferUang = Convert.ToInt32(Console.ReadLine());
            if (transferUang <= uiConfig.config.Transfer)
            {
                 int transferfee = low_fee;
                 Console.WriteLine($"Transfer fee = {low_fee}");
                 int totalBiaya = transferUang + low_fee;
                 Console.WriteLine($"Total amount = {totalBiaya} ");
             }
            else
            {
                int transferfee = high_fee;
                Console.WriteLine($"Transfer fee = {low_fee}");
                int totalBiaya = transferUang + low_fee;
                Console.WriteLine($"Total amount = {totalBiaya} ");

            }
            Console.WriteLine("select transfer method");
            Console.WriteLine(uiConfig.config.method);
            Console.WriteLine($"Please type {uiConfig.config.Confirmation.en} to confirm the transaction");
            Console.WriteLine("The transfer is completed");

        }else if  (uiConfig.config.lang == "id")
        {

                Console.WriteLine("Masukkan jumlah uang yang ingin di tranfer");
                int transferUang = Convert.ToInt32(Console.ReadLine());
                if (transferUang <= uiConfig.config.Transfer)
                {
                int transferfee = low_fee;
                Console.WriteLine($"Transfer fee = {low_fee}");
                int totalBiaya = transferUang + low_fee;
                Console.WriteLine($"Total amount = {totalBiaya} ");
                    }
                else
                {
                int transferfee = high_fee;
                Console.WriteLine($"Transfer fee = {low_fee}");
                int totalBiaya = transferUang + low_fee;
                Console.WriteLine($"Total amount = {totalBiaya} ");
                 }
                Console.WriteLine($"biaya tranfer = {}");
                int totalBiaya = transferUang + ;
                Console.WriteLine($"Total biaya = {totalBiaya} ");
            Console.WriteLine("Pilih metode transfer");
            Console.WriteLine(uiConfig.config.method);
            Console.WriteLine($"Please type {uiConfig.config.Confirmation.id} untuk mengkonfirmasi transaks");
            Console.WriteLine("The transfer is completed");
         }

    }
}