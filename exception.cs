using System;
using System.IO;
using System.Text;



namespace arraysdemo
{
    class exception
    {
        public static void Main(string[] args)
        {
            try
            {
                //int a = 10;
                //int b = 0;
                //int c = a / b;

                string str = string.Empty;
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("Wrong Data");
                }
                //int[] arr = { 10, 20, 30};
            }




            catch (Exception ex)
            {

                //Console.WriteLine("An Exception has occurred : {0}", ex.Message);

                ErrorLog(ex);
                ReadLog();
            }

        }

            public static void ErrorLog(Exception ex)
            {
                string strPath = @"D:\Aishu\ErrorLog.txt";
                if (!File.Exists(strPath))
                {
                    File.Create(strPath).Dispose();
                }
                using (StreamWriter sw = File.AppendText(strPath))

                {
                    //sw.WriteLine("=============Error Logging ==");
                    //sw.WriteLine("===========Start============= " + DateTime.Now);=========
                    sw.WriteLine("Error Message: " + ex.Message);
                    sw.WriteLine("Stack Trace: " + ex.StackTrace);
                   // sw.WriteLine("===========End============= " + DateTime.Now);

                }
            }

            public static void ReadLog()
            {
                string Path = @"D:\Aishu\ErrorLog.txt";
            using (StreamReader sr = new StreamReader(Path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }


