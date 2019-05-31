using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Pencil : IPencil
    {

        private int maxToWrite;
        private int nrOfCharsWritten;


        public Pencil(int max = 8)
        {
            this.maxToWrite = max;
            nrOfCharsWritten = 0;
        }

        public bool CanWrite
        {
            get
            {
                return  nrOfCharsWritten<= maxToWrite;
            }
        }

        public void Write(string message)
        {
            //foreach (char chr in message)
            //{
            //    if (CanWrite)
            //    {
            //        //.. 
            //    }
            //    nrOfCharsWritten++;
            //}




            if (message == "sharpen")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sharpening the pencil...");
                Console.ResetColor();
            }
            else
            {

                if (nrOfCharsWritten + message.Length <= maxToWrite)
                {
                    Console.WriteLine(message);
                    nrOfCharsWritten += message.Length;
                }
                else
                {

                    int temp = maxToWrite - nrOfCharsWritten;
                    string s = new string('#', message.Length - temp);

                    Console.WriteLine(message.Substring(0, temp) + s);

                    nrOfCharsWritten += temp;
                }
                //nrOfCharsWritten += message.Length;

                //int chartoadd = nrOfCharsWritten % maxToWrite;

                //string k = message.Substring(0, maxToWrite-nrOfCharsWritten);
                //string s = new string('#', chartoadd);
                //Console.WriteLine("{0}{1}", k,s);

                //                StringBuilder myStringBuilder = new StringBuilder("");
                //                myStringBuilder.Insert(maxToWrite+1, "# ",chartoadd);
                //                Console.WriteLine(myStringBuilder);
                ///
            }


        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;

        }

    }
}
