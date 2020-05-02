using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompresija
{
    class Program
    {
        static void Main(string[] args)
        {
            HuffmanKompresor huffman = new HuffmanKompresor();
            LZW lzw = new LZW();

            string vreme;

            #region engleski

            #region engleski100

            /*Console.WriteLine("Vreme izvšenja Huffman kompresije (100 engleskih reči): ");
            vreme = huffman.Kompresija("100-engleski.txt", "100-engleski komp(Huffman).txt", "100-engleski tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("100-engleski komp(Huffman).txt", "100-engleski dekomp(Huffman).txt", "100-engleski tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (100 engleskih reči): " + vreme + "\r\n");

            Console.WriteLine("Vreme izvšenja LZW kompresije (100 engleskih reči): ");
            vreme = lzw.Kompresija("100-engleski.txt", "100-engleski komp(LZW).txt", "100-engleski tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("100-engleski komp(LZW).txt", "100-engleski dekomp(LZW).txt", "100-engleski dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (100 engleskih reči): " + vreme + "\r\n");

            #endregion engleski100

            #region engleski1K

            /*Console.WriteLine("Vreme izvšenja Huffman kompresije (1K engleskih reči): ");
            vreme = huffman.Kompresija("1K-engleski.txt", "1K-engleski komp(Huffman).txt", "1K-engleski tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("1K-engleski komp(Huffman).txt", "1K-engleski dekomp(Huffman).txt", "1K-engleski tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (1K engleskih reči): " + vreme + "\r\n");

            Console.WriteLine("Vreme izvšenja LZW kompresije (1K engleskih reči): ");
            vreme = lzw.Kompresija("1K-engleski.txt", "1K-engleski komp(LZW).txt", "1K-engleski tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("1K-engleski komp(LZW).txt", "1K-engleski dekomp(LZW).txt", "1K-engleski dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (1K engleskih reči): " + vreme + "\r\n");*/

            #endregion engleski1K

            #region engleski10K

            Console.WriteLine("Vreme izvšenja Huffman kompresije (10K engleskih reči): ");
            vreme = huffman.Kompresija("10K-engleski.txt", "10K-engleski komp(Huffman).txt", "10K-engleski tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("10K-engleski komp(Huffman).txt", "10K-engleski dekomp(Huffman).txt", "10K-engleski tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (10K engleskih reči): " + vreme + "\r\n");

           /* Console.WriteLine("Vreme izvšenja LZW kompresije (10K engleskih reči): ");
            vreme = lzw.Kompresija("10K-engleski.txt", "10K-engleski komp(LZW).txt", "10K-engleski tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("10K-engleski komp(LZW).txt", "10K-engleski dekomp(LZW).txt", "10K-engleski dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (10K engleskih reči): " + vreme + "\r\n");*/

            #endregion engleski10K

            #region engleski100K

            /*Console.WriteLine("Vreme izvšenja Huffman kompresije (100K engleskih reči): ");
            vreme = huffman.Kompresija("100K-engleski.txt", "100K-engleski komp(Huffman).txt", "100K-engleski tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("100K-engleski komp(Huffman).txt", "100K-engleski dekomp(Huffman).txt", "100K-engleski tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (100K engleskih reči): " + vreme + "\r\n");

            Console.WriteLine("Vreme izvšenja LZW kompresije (100K engleskih reči): ");
            vreme = lzw.Kompresija("100K-engleski.txt", "100K-engleski komp(LZW).txt", "100K-engleski tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("100K-engleski komp(LZW).txt", "100K-engleski dekomp(LZW).txt", "100K-engleski dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (100K engleskih reči): " + vreme + "\r\n");*/

            #endregion engleski100K

            #region engleski1M

            /*Console.WriteLine("Vreme izvšenja Huffman kompresije (1M engleskih reči): ");
            vreme = huffman.Kompresija("1M-engleski.txt", "1M-engleski komp(Huffman).txt", "1M-engleski tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("1M-engleski komp(Huffman).txt", "1M-engleski dekomp(Huffman).txt", "1M-engleski tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (1M engleskih reči): " + vreme + "\r\n");*/

            Console.WriteLine("Vreme izvšenja LZW kompresije (1M engleskih reči): ");
            vreme = lzw.Kompresija("1M-engleski.txt", "1M-engleski komp(LZW).txt", "1M-engleski tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("1M-engleski komp(LZW).txt", "1M-engleski dekomp(LZW).txt", "1M-engleski dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (1M engleskih reči): " + vreme + "\r\n");

            #endregion engleski1M

            #endregion engleski

            #region random

            #region random-100

            Console.WriteLine("Vreme izvšenja Huffman kompresije (100 random reči): ");
            vreme = huffman.Kompresija("100-random.txt", "100-random komp(Huffman).txt", "100-random tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("100-random komp(Huffman).txt", "100-random dekomp(Huffman).txt", "100-random tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (100 random reči): " + vreme + "\r\n");

            Console.WriteLine("Vreme izvšenja LZW kompresije (100 random reči): ");
            vreme = lzw.Kompresija("100-random.txt", "100-random komp(LZW).txt", "100-random tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("100-random komp(LZW).txt", "100-random dekomp(LZW).txt", "100-random dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (100 random reči): " + vreme + "\r\n");

            #endregion random-100

            #region random-1K

            Console.WriteLine("Vreme izvšenja Huffman kompresije (1K random reči): ");
            vreme = huffman.Kompresija("1K-random.txt", "1K-random komp(Huffman).txt", "1K-random tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("1K-random komp(Huffman).txt", "1K-random dekomp(Huffman).txt", "1K-random tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (1K random reči): " + vreme + "\r\n");

            Console.WriteLine("Vreme izvšenja LZW kompresije (1K engleskih reči): ");
            vreme = lzw.Kompresija("1K-random.txt", "1K-random komp(LZW).txt", "1K-random tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("1K-random komp(LZW).txt", "1K-random dekomp(LZW).txt", "1K-random dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (1K random reči): " + vreme + "\r\n");

            #endregion random-1K

            #region random-10K

            Console.WriteLine("Vreme izvšenja Huffman kompresije (10K random reči): ");
            vreme = huffman.Kompresija("10K-random.txt", "10K-random komp(Huffman).txt", "10K-random tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("10K-random komp(Huffman).txt", "10K-random dekomp(Huffman).txt", "10K-random tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (10K engleskih reči): " + vreme + "\r\n");

            Console.WriteLine("Vreme izvšenja LZW kompresije (10K random reči): ");
            vreme = lzw.Kompresija("10K-random.txt", "10K-random komp(LZW).txt", "10K-random tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("10K-random komp(LZW).txt", "10K-random dekomp(LZW).txt", "10K-random dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (10K random reči): " + vreme + "\r\n");

            #endregion random-10K

            #region random-100K

            Console.WriteLine("Vreme izvšenja Huffman kompresije (100K random reči): ");
            vreme = huffman.Kompresija("100K-random.txt", "100K-random komp(Huffman).txt", "100K-random tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("100K-random komp(Huffman).txt", "100K-random dekomp(Huffman).txt", "100K-random tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (100K random reči): " + vreme + "\r\n");

            Console.WriteLine("Vreme izvšenja LZW kompresije (100K random reči): ");
            vreme = lzw.Kompresija("100K-random.txt", "100K-random komp(LZW).txt", "100K-random tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("100K-random komp(LZW).txt", "100K-random dekomp(LZW).txt", "100K-random dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (100K random reči): " + vreme + "\r\n");

            #endregion random-100K

            #region random-1M

            Console.WriteLine("Vreme izvšenja Huffman kompresije (1M random reči): ");
            vreme = huffman.Kompresija("1M-random.txt", "1M-random komp(Huffman).txt", "1M-random tabela(Huffman).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = huffman.Dekompresija("1M-random komp(Huffman).txt", "1M-random dekomp(Huffman).txt", "1M-random tabela(Huffman).txt");
            Console.WriteLine("Vreme izvšenja Huffman dekompresije (1M engleskih reči): " + vreme + "\r\n");

            Console.WriteLine("Vreme izvšenja LZW kompresije (1M engleskih reči): ");
            vreme = lzw.Kompresija("1M-random.txt", "1M-random komp(LZW).txt", "1M-random tabela(LZW).txt");
            Console.WriteLine(vreme + "\r\n");
            vreme = lzw.Dekompresija("1M-random komp(LZW).txt", "1M-random dekomp(LZW).txt", "1M-random dekompTabela(LZW).txt");
            Console.WriteLine("Vreme izvšenja LZW dekompresije (1M random reči): " + vreme + "\r\n");

            #endregion random-1M

            #endregion engleski
        }
    }
}
