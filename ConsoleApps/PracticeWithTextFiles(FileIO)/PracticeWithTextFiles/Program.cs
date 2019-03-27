using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeWithTextFiles
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> evenNumberedLines = new List<string>();
            StreamReader streamReader = null;
            try
            {
                streamReader = File.OpenText("ReadMe.txt");
                string line = streamReader.ReadLine();
                int i = 1;
                while (line != null)
                {
                    Console.WriteLine(line);
                    if (i % 2 == 0)
                    {
                        evenNumberedLines.Add(line);
                    }
                    i++;
                    line = streamReader.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
            StreamWriter streamWriter = File.CreateText("WriteMe");
            try
            {
                foreach (string l in evenNumberedLines)
                {
                    streamWriter.WriteLine(l);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

        }
    }
}
