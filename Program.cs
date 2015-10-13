using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace Console_Serial_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SerialPort comPort = new SerialPort("COM8", 9600, Parity.None, 8, StopBits.One))
            {
                string buffer = "";
                char tegn = '*';

                comPort.Open();

                while (comPort.IsOpen)
                {
                    tegn = (char)comPort.ReadChar();
                    buffer += tegn;

                    if (tegn == '#')
                    {
                        Console.WriteLine(buffer);
                        buffer = "";
                    }

                }
            }
        }
    }
}
