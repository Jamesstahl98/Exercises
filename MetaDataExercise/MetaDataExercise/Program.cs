using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Numerics;

namespace MetaDataExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckFileType();
        }

        static void CheckFileType()
        {
            Console.WriteLine("Write a file path");
            string path = Console.ReadLine();

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exists");
            }

            using (FileStream stream = File.OpenRead(path))
            {
                string first8Bytes = string.Empty;
                Console.WriteLine(stream.Length);

                byte[] data = new byte[stream.Length];
                stream.Read(data);

                for (int i = 0; i < 8; i++)
                {
                    first8Bytes += data[i].ToString();
                }

                if (first8Bytes == "13780787113102610")
                {
                    Console.WriteLine(GetPNGSize(path));
                }
            }
        }

        static Size GetPNGSize(string fileName)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(fileName));
            br.BaseStream.Position = 16;

            byte[] widthbytes = new byte[sizeof(int)];
            for (int i = 0; i < widthbytes.Length; i++)
            {
                widthbytes[widthbytes.Length - 1 - i] = br.ReadByte();
            }
            int width = BitConverter.ToInt32(widthbytes, 0);

            byte[] heightbytes = new byte[sizeof(int)];
            for (int i = 0; i < heightbytes.Length; i++)
            {
                heightbytes[heightbytes.Length - 1 - i] = br.ReadByte();
            }
            int height = BitConverter.ToInt32(heightbytes, 0);

            return new Size(width, height);
        }
    }
}
