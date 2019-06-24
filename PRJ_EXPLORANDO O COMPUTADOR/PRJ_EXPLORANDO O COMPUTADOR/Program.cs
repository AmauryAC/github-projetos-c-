using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace PRJ_EXPLORANDO_O_COMPUTADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string significado;

            //Dados da dupla do trabalho.
            Console.WriteLine("************************************************");
            Console.WriteLine("*           Explorando o Computador            *");
            Console.WriteLine("* Trabalho 2: Arquitetura de Computadores      *");
            Console.WriteLine("* Alunos: Amaury Alexandrino da Costa (499960) *\n" +
                              "*         Felipe Henrique Rocha (495779)       *");
            Console.WriteLine("* Sistemas de Informação - 2º Período (Noite)  *");
            Console.WriteLine("************************************************");

            //--------------------------------------I-M-P-O-R-T-A-N-T-E-------------------------------------------------------
            //Obs: Os nomes dos dados foram mantidos em inglês, por motivo de padronização e para não se perderem na tradução.

            //----INÍCIO DO PROGRAMA
            //Declaração de objeto do tipo ManagementObject que contém dados sobre o processador.
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            ManagementObjectCollection results = searcher.Get();

            Console.WriteLine("\nDados da CPU: \n");

            //Foreach para percorrer todo o objeto do tipo ManagementObject e capaturar algumas informações sobre a CPU.
            foreach (ManagementObject result in results)
            {
                Console.WriteLine("Name: {0}", result["Name"]);
                Console.WriteLine("Description: {0}", result["Description"]);
                Console.WriteLine("NumberOfCores : {0}", result["NumberOfCores"]);
                Console.WriteLine("NumberOfLogicalProcessors : {0}", result["NumberOfLogicalProcessors"]);

                //Código para verificar se a tecnologia Hypertreading está ativada ou não. 
                if ((Convert.ToUInt16(result["NumberOfCores"]) < Convert.ToUInt16(result["NumberOfLogicalProcessors"])) && (Convert.ToUInt16(result["NumberOfLogicalProcessors"]) / Convert.ToUInt16(result["NumberOfCores"]) == 2))
                    Console.WriteLine("Tecnology: Hypertreading is enabled");
                else
                    Console.WriteLine("Tecnology: Hypertreading is disabled");

                Console.WriteLine("CurrentClockSpeed : {0} MHz", result["CurrentClockSpeed"]);
                Console.WriteLine("MaxClockSpeed : {0} MHz", result["MaxClockSpeed"]);
                Console.WriteLine("ExtClock : {0} MHz", result["ExtClock"]);
                Console.WriteLine("Level: {0}", result["Level"]);
                Console.WriteLine("L2CacheSize: {0} KB", result["L2CacheSize"]);
                Console.WriteLine("L2CacheSpeed: {0} MHz", result["L2CacheSpeed"]);
                Console.WriteLine("L3CacheSize: {0} KB", result["L3CacheSize"]);
                Console.WriteLine("L3CacheSpeed: {0} MHz", result["L3CacheSpeed"]);

                //Código para comparar os valores com os significados da tabela.
                if (Convert.ToUInt16(result["Architecture"]) == 0)
                    significado = "x86";
                else if (Convert.ToUInt16(result["Architecture"]) == 1)
                    significado = "MIPS";
                else if (Convert.ToUInt16(result["Architecture"]) == 2)
                    significado = "Alpha";
                else if (Convert.ToUInt16(result["Architecture"]) == 3)
                    significado = "PowerPC";
                else if (Convert.ToUInt16(result["Architecture"]) == 5)
                    significado = "ARM";
                else if (Convert.ToUInt16(result["Architecture"]) == 6)
                    significado = "Itanium-based systems";
                else if (Convert.ToUInt16(result["Architecture"]) == 9)
                    significado = "x64";
                else
                    significado = "Not Found!";

                Console.WriteLine("Architecture : {0}", significado);
                break;
            }

            //Declaração de objeto do tipo ManagementObject que contém dados sobre a memória física.
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
            ManagementObjectCollection results1 = searcher1.Get();

            Console.WriteLine("\nDados das Memórias: \n");

            //Foreach para percorrer todo o objeto do tipo ManagementObject e capaturar algumas informações sobre a memória física.
            foreach (ManagementObject result in results1)
            {
                Console.WriteLine("Name: {0}", result["Name"]);
                Console.WriteLine("Description: {0}", result["Description"]);
                Console.WriteLine("Capacity : {0} Bytes", result["Capacity"]);
                Console.WriteLine("DataWidth : {0} Bits", result["DataWidth"]);

                //Código para comparar os valores com os significados da tabela.
                if (Convert.ToUInt16(result["MemoryType"]) == 0)
                    significado = "Unknown";
                else if (Convert.ToUInt16(result["MemoryType"]) == 1)
                    significado = "Other";
                else if (Convert.ToUInt16(result["MemoryType"]) == 2)
                    significado = "DRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 3)
                    significado = "Synchronous DRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 4)
                    significado = "Cache DRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 5)
                    significado = "EDO";
                else if (Convert.ToUInt16(result["MemoryType"]) == 6)
                    significado = "EDRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 7)
                    significado = "VRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 8)
                    significado = "SRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 9)
                    significado = "RAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 10)
                    significado = "ROM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 11)
                    significado = "Flash";
                else if (Convert.ToUInt16(result["MemoryType"]) == 12)
                    significado = "EEPROM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 13)
                    significado = "FEPROM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 14)
                    significado = "EPROM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 15)
                    significado = "CDRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 16)
                    significado = "3DRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 17)
                    significado = "SDRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 18)
                    significado = "SGRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 19)
                    significado = "RDRAM";
                else if (Convert.ToUInt16(result["MemoryType"]) == 20)
                    significado = "DDR";
                else if (Convert.ToUInt16(result["MemoryType"]) == 21)
                    significado = "DDR-2";
                else
                    significado = "Not Found!";

                Console.WriteLine("MemoryType : {0}", significado);
                Console.WriteLine("Speed : {0} ns", result["Speed"]);
                Console.WriteLine("TotalWidth : {0} Bits", result["TotalWidth"]);
                break;
            }

            //Declaração de objeto do tipo ManagementObject que contém dados sobre a memória cache.
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("select * from Win32_CacheMemory");
            ManagementObjectCollection results2 = searcher2.Get();

            Console.WriteLine();

            //Foreach para percorrer todo o objeto do tipo ManagementObject e capaturar algumas informações sobre a memória cache.
            foreach (ManagementObject result in results2)
            {
                Console.WriteLine("Name: {0}", result["Name"]);
                Console.WriteLine("Description: {0}", result["Description"]);
                Console.WriteLine("BlockSize : {0} Bytes", result["BlockSize"]);
                Console.WriteLine("CacheSpeed : {0} ns", result["CacheSpeed"]);
                Console.WriteLine("Number of Cache Memory Level: 3 (L1, L2, L3)");

                //Código para comparar os valores com os significados da tabela.
                if (Convert.ToUInt16(result["CacheType"]) == 1)
                    significado = "Other";
                else if (Convert.ToUInt16(result["CacheType"]) == 2)
                    significado = "Unknown";
                else if (Convert.ToUInt16(result["CacheType"]) == 3)
                    significado = "Instruction";
                else if (Convert.ToUInt16(result["CacheType"]) == 4)
                    significado = "Data";
                else if (Convert.ToUInt16(result["CacheType"]) == 5)
                    significado = "Unified";
                else
                    significado = "Not Found!";

                Console.WriteLine("CacheType : {0}", significado);

                //Código para comparar os valores com os significados da tabela.
                if (Convert.ToUInt16(result["Level"]) == 1)
                    significado = "Other";
                else if (Convert.ToUInt16(result["Level"]) == 2)
                    significado = "Unknown";
                else if (Convert.ToUInt16(result["Level"]) == 3)
                    significado = "Primary";
                else if (Convert.ToUInt16(result["Level"]) == 4)
                    significado = "Secondary";
                else if (Convert.ToUInt16(result["Level"]) == 5)
                    significado = "Tertiary";
                else if (Convert.ToUInt16(result["Level"]) == 6)
                    significado = "Windows Server 2003:  Not Applicable";
                else
                    significado = "Not Found!";

                Console.WriteLine("Level : {0}", significado);

                //Código para comparar os valores com os significados da tabela.
                if (Convert.ToUInt16(result["Associativity"]) == 1)
                    significado = "Other";
                else if (Convert.ToUInt16(result["Associativity"]) == 2)
                    significado = "Unknown";
                else if (Convert.ToUInt16(result["Associativity"]) == 3)
                    significado = "Direct Mapped";
                else if (Convert.ToUInt16(result["Associativity"]) == 4)
                    significado = "2-way Set-Associative";
                else if (Convert.ToUInt16(result["Associativity"]) == 5)
                    significado = "4-way Set-Associative";
                else if (Convert.ToUInt16(result["Associativity"]) == 6)
                    significado = "Fully Associative";
                else if (Convert.ToUInt16(result["Associativity"]) == 7)
                    significado = "Windows Server 2003:  8-way Set-Associative";
                else if (Convert.ToUInt16(result["Associativity"]) == 8)
                    significado = "Windows Server 2003:  16-way Set-Associative";
                else
                    significado = "Not Found!";

                Console.WriteLine("Associativity : {0}", significado);
                Console.WriteLine("MaxCacheSize : {0} KB", result["MaxCacheSize"]);
                Console.WriteLine("Purpose : {0}", result["Purpose"]);
                break;
            }

            //Declaração de objeto do tipo ManagementObject que contém dados sobre o drive de disco.
            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            ManagementObjectCollection results3 = searcher3.Get();

            Console.WriteLine("\nArmazenamento Secundário: \n");

            //Foreach para percorrer todo o objeto do tipo ManagementObject e capaturar algumas informações sobre o drive de disco.
            foreach (ManagementObject result in results3)
            {
                Console.WriteLine("Name: {0}", result["Name"]);
                Console.WriteLine("Description: {0}", result["Description"]);
                Console.WriteLine("Size : {0} Bytes", result["Size"]);
                Console.WriteLine("TotalSectors : {0}", result["TotalSectors"]);
                Console.WriteLine("BytesPerSector : {0} Bytes", result["BytesPerSector"]);
                Console.WriteLine("Rotation: ATA - 5400 r.p.m \n\t  SATA - 7200 r.p.m.");
                break;
            }

            //Declaração de objeto do tipo ManagementObject que contém dados sobre o disco lógico.
            ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("select * from Win32_LogicalDisk");
            ManagementObjectCollection results4 = searcher4.Get();

            Console.WriteLine();

            //Foreach para percorrer todo o objeto do tipo ManagementObject e capaturar algumas informações sobre o disco lógico.
            foreach (ManagementObject result in results4)
            {
                Console.WriteLine("Name: {0}", result["Name"]);
                Console.WriteLine("Description: {0}", result["Description"]);

                //Código para comparar os valores com os significados da tabela.
                if (Convert.ToUInt16(result["DriveType"]) == 0)
                    significado = "Unknown";
                else if (Convert.ToUInt16(result["DriveType"]) == 1)
                    significado = "No Root Directory";
                else if (Convert.ToUInt16(result["DriveType"]) == 2)
                    significado = "Removable Disk";
                else if (Convert.ToUInt16(result["DriveType"]) == 3)
                    significado = "Local Disk";
                else if (Convert.ToUInt16(result["DriveType"]) == 4)
                    significado = "Network Drive";
                else if (Convert.ToUInt16(result["DriveType"]) == 5)
                    significado = "Compact Disc";
                else if (Convert.ToUInt16(result["DriveType"]) == 6)
                    significado = "RAM Disk";
                else
                    significado = "Not Found!";

                Console.WriteLine("DriveType: {0}", significado);
                Console.WriteLine("Size : {0} Bytes", result["Size"]);
                Console.WriteLine("FreeSpace : {0} Bytes", result["FreeSpace"]);
                Console.WriteLine("BlockSize : {0} Bytes", result["BlockSize"]);
                break;
            }

            Console.ReadKey();
            //----FIM DO PROGRAMA
        }
    }
}
