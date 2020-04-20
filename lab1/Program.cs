using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace TraženjeStringova
{
    class Program
    {
        static void Main(string[] args)
        {
            // text (Ovo ne utiče na RK i KMP)
            String textH100, textH1K, textH10K, textH100K, text100, text1K, text10K, text100K;
            using(StreamReader stream = new StreamReader("100-hex.txt")) { textH100 = stream.ReadToEnd(); }
            textH100 = textH100.Replace("\t", String.Empty).Replace("\r\n", String.Empty).Replace("\r", String.Empty).
                Replace("\n", String.Empty).Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").
                Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace("   ", " ").Replace("  ", " ").Trim(' ');
            using (StreamReader stream = new StreamReader("1k-hex.txt")) { textH1K = stream.ReadToEnd(); }
            textH1K = textH1K.Replace("\t", String.Empty).Replace("\r\n", String.Empty).Replace("\r", String.Empty).
                Replace("\n", String.Empty).Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").
                Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace("   ", " ").Replace("  ", " ").Trim(' ');
            using (StreamReader stream = new StreamReader("10k-hex.txt")) { textH10K = stream.ReadToEnd(); }
            textH10K = textH10K.Replace("\t", String.Empty).Replace("\r\n", String.Empty).Replace("\r", String.Empty).
                Replace("\n", String.Empty).Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").
                Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace("   ", " ").Replace("  ", " ").Trim(' ');
            using (StreamReader stream = new StreamReader("100k-hex.txt")) { textH100K = stream.ReadToEnd(); }
            textH100K = textH100K.Replace("\t", String.Empty).Replace("\r\n", String.Empty).Replace("\r", String.Empty).
                Replace("\n", String.Empty).Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").
                Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace("   ", " ").Replace("  ", " ").Trim(' ');

            using (StreamReader stream = new StreamReader("100-lorem.txt")) { text100 = stream.ReadToEnd(); }
            text100 = text100.Replace("\t", String.Empty).Replace("\r\n", String.Empty).Replace("\r", String.Empty).
                Replace("\n", String.Empty).Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").
                Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace("   ", " ").Replace("  ", " ").Trim(' ');
            using (StreamReader stream = new StreamReader("1k-lorem.txt")) { text1K = stream.ReadToEnd(); }
            text1K = text1K.Replace("\t", String.Empty).Replace("\r\n", String.Empty).Replace("\r", String.Empty).
                Replace("\n", String.Empty).Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").
                Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace("   ", " ").Replace("  ", " ").Trim(' ');
            using (StreamReader stream = new StreamReader("10k-lorem.txt")) { text10K = stream.ReadToEnd(); }
            text10K = text10K.Replace("\t", String.Empty).Replace("\r\n", String.Empty).Replace("\r", String.Empty).
                Replace("\n", String.Empty).Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").
                Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace("   ", " ").Replace("  ", " ").Trim(' ');
            using (StreamReader stream = new StreamReader("115k-mobydick.txt")) { text100K = stream.ReadToEnd(); }
            text100K = text100K.Replace("\t", String.Empty).Replace("\r\n", String.Empty).Replace("\r", String.Empty).
                Replace("\n", String.Empty).Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").
                Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace("{", " ").Replace("}", " ").
                Replace("-", " ").Replace("&", String.Empty).Replace("   ", " ").Replace("  ", " ").Trim(' ');

            // pattern
            String pattern5, pattern10, pattern20, pattern50, patternHex5, patternHex10, patternHex20, patternHex50;

            #region Hex

            #region H100
            /*patternHex5 = "94b25"; patternHex10 = "9d2247f55f"; patternHex20 = "2cc235148d2cdd26fc4e";
            patternHex50 = "94b25fe19b2cbb451dde6782a13151803f4c89652cc235148d";*/

            patternHex5 = "B647C"; patternHex10 = "A4746DEB4A"; patternHex20 = "B8B1A1CD42279C52E975";
            patternHex50 = "C487B8B8A18909045B84D3587DB9045B84D3587DB69123C3D";

            RabinKarp(textH100, patternHex5, "RK-Hex100P5.txt", 16);
            KnuthMorrisPratt(textH100, patternHex5, "KMP-Hex100P5.txt");
            RabinKarp(textH100, patternHex10, "RK-Hex100P10.txt", 16);
            KnuthMorrisPratt(textH100, patternHex10, "KMP-Hex100P10.txt");
            RabinKarp(textH100, patternHex20, "RK-Hex100P20.txt", 16); 
            KnuthMorrisPratt(textH100, patternHex20, "KMP-Hex100P20.txt");
            RabinKarp(textH100, patternHex50, "RK-Hex100P50.txt", 16); 
            KnuthMorrisPratt(textH100, patternHex50, "KMP-Hex100P50.txt");

            RabinKarp(textH1K, patternHex5, "RK-Hex1KP5.txt", 16);
            KnuthMorrisPratt(textH1K, patternHex5, "KMP-Hex1KP5.txt");
            RabinKarp(textH1K, patternHex10, "RK-Hex1KP10.txt", 16);
            KnuthMorrisPratt(textH1K, patternHex10, "KMP-Hex1KP10.txt");
            RabinKarp(textH1K, patternHex20, "RK-Hex1KP20.txt", 16);
            KnuthMorrisPratt(textH1K, patternHex20, "KMP-Hex1KP20.txt");
            RabinKarp(textH1K, patternHex50, "RK-Hex1KP50.txt", 16);
            KnuthMorrisPratt(textH1K, patternHex50, "KMP-Hex1KP50.txt");

            RabinKarp(textH10K, patternHex5, "RK-Hex10KP5.txt", 16);
            KnuthMorrisPratt(textH10K, patternHex5, "KMP-Hex10KP5.txt");
            RabinKarp(textH10K, patternHex10, "RK-Hex10KP10.txt", 16);
            KnuthMorrisPratt(textH10K, patternHex10, "KMP-Hex10KP10.txt");
            RabinKarp(textH10K, patternHex20, "RK-Hex10KP20.txt", 16);
            KnuthMorrisPratt(textH10K, patternHex20, "KMP-Hex10KP20.txt");
            RabinKarp(textH10K, patternHex50, "RK-Hex10KP50.txt", 16);
            KnuthMorrisPratt(textH10K, patternHex50, "KMP-Hex10KP50.txt");

            RabinKarp(textH100K, patternHex5, "RK-Hex100KP5.txt", 16);
            KnuthMorrisPratt(textH100K, patternHex5, "KMP-Hex100KP5.txt");
            RabinKarp(textH100K, patternHex10, "RK-Hex10KP100.txt", 16);
            KnuthMorrisPratt(textH100K, patternHex10, "KMP-Hex100KP10.txt");
            RabinKarp(textH100K, patternHex20, "RK-Hex100KP20.txt", 16);
            KnuthMorrisPratt(textH100K, patternHex20, "KMP-Hex100KP20.txt");
            RabinKarp(textH100K, patternHex50, "RK-Hex100KP50.txt", 16);
            KnuthMorrisPratt(textH100K, patternHex50, "KMP-Hex100KP50.txt");

            #endregion H100

            #endregion Hex


            #region Text
            pattern5 = "ipsum"; pattern10 = "consectetu"; pattern20 = "Nunc iaculis finibus";
            pattern50 = "Nulla augue ante porttitor ac arcu ut condimentu";

            #region pat5
            RabinKarp(text100, pattern5, "RK-Text100P5.txt");
            KnuthMorrisPratt(text100, pattern5, "KMP-Text100P5.txt");
            SoundEx(text100, pattern5, "Sound-Text100P5.txt");
            Levenstein(text100, pattern5, "Lev-Text100P5.txt");
            RabinKarp(text1K, pattern5, "RK-Text1KP5.txt");
            KnuthMorrisPratt(text1K, pattern5, "KMP-Text1KP5.txt");
            SoundEx(text1K, pattern5, "Sound-Text1KP5.txt");
            Levenstein(text1K, pattern5, "Lev-Text1KP5.txt");
            RabinKarp(text10K, pattern5, "RK-Text10KP5.txt");
            KnuthMorrisPratt(text10K, pattern5, "KMP-Text10KP5.txt");
            SoundEx(text10K, pattern5, "Sound-Text10KP5.txt");
            Levenstein(text10K, pattern5, "Lev-Text10KP5.txt");
            
            #endregion pat5

            #region pat10
            RabinKarp(text100, pattern10, "RK-Text100P10.txt");
            KnuthMorrisPratt(text100, pattern10, "KMP-Text100P10.txt");
            SoundEx(text100, pattern10, "Sound-Text100P10.txt");
            Levenstein(text100, pattern10, "Lev-Text100P10.txt");
            RabinKarp(text1K, pattern10, "RK-Text1KP10.txt");
            KnuthMorrisPratt(text1K, pattern10, "KMP-Text1KP10.txt");
            SoundEx(text1K, pattern10, "Sound-Text1KP10.txt");
            Levenstein(text1K, pattern10, "Lev-Text1KP10.txt");
            RabinKarp(text10K, pattern10, "RK-Text10KP10.txt");
            KnuthMorrisPratt(text10K, pattern10, "KMP-Text10KP10.txt");
            SoundEx(text10K, pattern10, "Sound-Text10KP10.txt");
            Levenstein(text10K, pattern10, "Lev-Text10KP10.txt");
            
            #endregion pat10

            #region pat20
            RabinKarp(text100, pattern20, "RK-Text100P20.txt");
            KnuthMorrisPratt(text100, pattern20, "KMP-Text100P20.txt");
            SoundEx(text100, pattern20, "Sound-Text100P20.txt");
            Levenstein(text100, pattern20, "Lev-Text100P20.txt");
            RabinKarp(text1K, pattern20, "RK-Text1KP20.txt");
            KnuthMorrisPratt(text1K, pattern20, "KMP-Text1KP20.txt");
            SoundEx(text1K, pattern20, "Sound-Text1KP20.txt");
            Levenstein(text1K, pattern20, "Lev-Text1KP20.txt");
            RabinKarp(text10K, pattern20, "RK-Text10KP20.txt");
            KnuthMorrisPratt(text10K, pattern20, "KMP-Text10KP20.txt");
            SoundEx(text10K, pattern20, "Sound-Text10KP20.txt");
            Levenstein(text10K, pattern20, "Lev-Text10KP20.txt");
            
            #endregion pat20

            #region pat50
            RabinKarp(text100, pattern50, "RK-Text100P50.txt");
            KnuthMorrisPratt(text100, pattern50, "KMP-Text100P50.txt");
            SoundEx(text100, pattern50, "Sound-Text100P50.txt");
            Levenstein(text100, pattern50, "Lev-Text100P50.txt");
            RabinKarp(text1K, pattern50, "RK-Text1KP50.txt");
            KnuthMorrisPratt(text1K, pattern50, "KMP-Text1KP50.txt");
            SoundEx(text1K, pattern50, "Sound-Text1KP50.txt");
            Levenstein(text1K, pattern50, "Lev-Text1KP50.txt");
            RabinKarp(text10K, pattern50, "RK-Text10KP50.txt");
            KnuthMorrisPratt(text10K, pattern50, "KMP-Text10KP50.txt");
            SoundEx(text10K, pattern50, "Sound-Text10KP50.txt");
            Levenstein(text10K, pattern50, "Lev-Text10KP50.txt");

            #endregion pat50

            #region 100k
            #endregion 100k
            pattern5 = "while"; pattern10 = "generation"; pattern20 = "Several whales have ";
            pattern50 = "was the squire of little Flask who looked like a";

            RabinKarp(text100K, pattern5, "RK-Text100KP5.txt");
            KnuthMorrisPratt(text100K, pattern5, "KMP-Text100KP5.txt");
            //SoundEx(text100K, pattern5, "Sound-Text100KP5.txt");
            Levenstein(text100K, pattern5, "Lev-Text100KP5.txt");

            RabinKarp(text100K, pattern10, "RK-Text100KP10.txt");
            KnuthMorrisPratt(text100K, pattern10, "KMP-Text100KP10.txt");
            //SoundEx(text100K, pattern10, "Sound-Text100KP10.txt");
            Levenstein(text100K, pattern10, "Lev-Text100KP10.txt");

            RabinKarp(text100K, pattern20, "RK-Text100KP20.txt");
            KnuthMorrisPratt(text100K, pattern20, "KMP-Text100KP20.txt");
           // SoundEx(text100K, pattern20, "Sound-Text100KP20.txt");
            Levenstein(text100K, pattern20, "Lev-Text100KP20.txt");

            RabinKarp(text100K, pattern50, "RK-Text100KP50.txt");
            KnuthMorrisPratt(text100K, pattern50, "KMP-Text100KP50.txt");
            SoundEx(text100K, pattern50, "Sound-Text100KP50.txt");
            Levenstein(text100K, pattern50, "Lev-Text100KP50.txt");
            
            #endregion Text

        }

        static void RabinKarp(String text, String pattern, String imeFajla, uint R = 256)
        {
            const uint q = 7919;
            //String[] patternWords = pattern.Split(' ', ';', '.', ':', '!', '?', '-', '_');
            Queue<int> patternPositions = new Queue<int>();
            Queue<String> times = new Queue<String>();
            Stopwatch stopwatch = new Stopwatch();

            // algoritam
            stopwatch.Start();

            uint patternHash = 0;
            byte[] patternBytes = Encoding.ASCII.GetBytes(pattern);
            uint leadingNumber = 1; // osnova za vodeću cifru (koristi se kad se uklanja prva cifra)
            for (int i = 0; i < pattern.Length; i++)
            {
                patternHash = ((patternHash * R) + patternBytes[i]) % q;
                if (i == 0) { continue; }
                leadingNumber = (leadingNumber * R) % q;
            }
            /*foreach (String word in patternWords)
            {
                byte[] patternBytes = Encoding.ASCII.GetBytes(word);
                for (int i = 0; i < patternBytes.Length; i++)
                {
                    patternHash = (patternHash << 8 + patternBytes[i]) % q;
                }
            }*/

            // uint[] charHash = new uint[pattern.Length];
            byte[] textBytes = Encoding.ASCII.GetBytes(text);
            uint currentHash = 0;
            for (int i = 0; i < text.Length - pattern.Length; i++)
            {
                if (i < pattern.Length) { currentHash = ((currentHash * R) + textBytes[i]) % q;}
                else 
                {
                    // greška
                    //currentHash = (((currentHash - textBytes[i - pattern.Length] * leadingNumber) * R) + textBytes[i]) % q;
                    currentHash = ((currentHash + q - (textBytes[i - pattern.Length] * leadingNumber) % q) * R + textBytes[i]) % q;
                }

                if (i >= pattern.Length - 1)
                {
                    if (currentHash == patternHash)
                    {
                        bool equal = true;
                        for (int k = 0; k < pattern.Length; k++)
                        {
                            if (pattern[k] != text[k + i - pattern.Length + 1])
                            {
                                equal = false;
                                break;
                            }
                        }
                        if (equal) 
                        { 
                            patternPositions.Enqueue(i - pattern.Length + 1);
                            times.Enqueue(stopwatch.Elapsed + "");
                        }
                    }
                }
            }
            
            stopwatch.Stop();
            times.Enqueue(stopwatch.Elapsed + "");

            // upis u fajl
            using (StreamWriter stream = new StreamWriter(imeFajla))
            {
                string line = "";
                int position, startPosition, endPosition;

                stream.WriteLine("Finding pattern:'" + pattern + "'\r\n");
                while (patternPositions.Count > 0)
                {
                    line = "Time = " + times.Dequeue() + "ms Sentence: '";
                    position = patternPositions.Dequeue();

                    startPosition = position - 10;
                    if (startPosition < 0) { startPosition = 0; }
                    endPosition = position + 10 + pattern.Length;
                    if (endPosition > text.Length) { endPosition = text.Length; }

                    line = line + text.Substring(startPosition, endPosition - startPosition) + "'";
                    stream.WriteLine(line);
                }
                stream.WriteLine();
                if (times.Count > 0)
                {
                    stream.WriteLine("Total time = " + times.Dequeue() + "ms");
                }
            }

        }

        static void KnuthMorrisPratt(String text, String pattern, String imeFajla)
        {
            Queue<int> patternPositions = new Queue<int>();
            Queue<String> times = new Queue<String>();
            Stopwatch stopwatch = new Stopwatch();
            //text = text.ToUpper();
            //pattern = pattern.ToUpper();

            // algoritam
            stopwatch.Start();

            // preprocesiranje:
            int[] lsp = new int[pattern.Length];
            lsp[0] = 0;
            int k = 0;
            for (int q = 1; q < pattern.Length; q++)
            {
                while (k > 0 && pattern[k] != pattern[q]) { k = lsp[k]; }
                if (pattern[k] == pattern[q]) { k++; }
                lsp[q] = k;
            }

            // pretraga
            int equalChars = 0;
            for (int i = 0; i < text.Length; i++)
            {
                while (equalChars > 0 && pattern[equalChars] != text[i]) { equalChars = lsp[equalChars]; }
                if (pattern[equalChars] == text[i]) { equalChars++; }
                if (equalChars == pattern.Length) 
                { 
                    patternPositions.Enqueue(i - pattern.Length + 1);
                    times.Enqueue(stopwatch.Elapsed + "");

                    equalChars = lsp[equalChars - 1];
                }
            }
            times.Enqueue(stopwatch.Elapsed + "");
            stopwatch.Stop();

            // upis u fajl:
            using (StreamWriter stream = new StreamWriter(imeFajla))
            {
                string line = "";
                int position, startPosition, endPosition;

                stream.WriteLine("Finding pattern:'" + pattern + "'\r\n");
                while (patternPositions.Count > 0)
                {
                    line = "Time = " + times.Dequeue() + "ms Sentence: '";
                    position = patternPositions.Dequeue();

                    startPosition = position - 10;
                    if (startPosition < 0) { startPosition = 0; }
                    endPosition = position + 10 + pattern.Length;
                    if (endPosition > text.Length) { endPosition = text.Length; }

                    line = line + text.Substring(startPosition, endPosition - startPosition) + "'";
                    stream.WriteLine(line);
                }
                stream.WriteLine();
                if (times.Count > 0)
                {
                    stream.WriteLine("Total time = " + times.Dequeue() + "ms");
                }
            }


        }

        static void Levenstein(String text, String pattern, String imeFajla)
        {
            Queue<int> patternPositions = new Queue<int>();
            Queue<String> times = new Queue<String>();
            Stopwatch stopwatch = new Stopwatch();
            char[] separators = { ' ', ';', '.', ':', '!', '?', ',', '-' };
            String upperPattern = pattern.ToUpper();
            upperPattern = upperPattern.Replace(",", " ").Replace("  ", " ");
            String[] patternWords = upperPattern.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            String upperText = text.ToUpper();
            String[] textWords = upperText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // pretraga
            stopwatch.Start();
            for (int i = 0; i < textWords.Length - patternWords.Length; i++)
            {
                bool patternMatch = true;
                for (int k = 0; k < patternWords.Length; k++)
                {
                    if (getLevensteinDistance(textWords[i + k], patternWords[k]) > 3)
                    {
                        patternMatch = false;
                        break;
                    }
                }
                if (patternMatch) 
                { 
                    patternPositions.Enqueue(i);
                    times.Enqueue(stopwatch.Elapsed + "");
                }
            }
            
            stopwatch.Stop();
            times.Enqueue(stopwatch.Elapsed + "");

            //upis u fajl
            using (StreamWriter stream = new StreamWriter(imeFajla))
            {
                string line = "";
                int position, startPosition, endPosition;

                stream.WriteLine("Finding pattern:'" + pattern + "'\r\n");
                while (patternPositions.Count > 0)
                {
                    line = "Time = " + times.Dequeue() + "ms Sentence: '";
                    position = patternPositions.Dequeue();

                    startPosition = position - 1;
                    if (startPosition < 0) { startPosition = 0; }
                    endPosition = position + 1 + patternWords.Length;
                    if (endPosition > textWords.Length) { endPosition = textWords.Length; }

                    for (int k = startPosition; k < endPosition; k++)
                    {
                        line = line + textWords[k] + " ";
                    }
                    line = line + "'";
                    stream.WriteLine(line);
                }
                stream.WriteLine();
                if (times.Count > 0)
                {
                    stream.WriteLine("Total time = " + times.Dequeue() + "ms");
                }
            }


        }

        static int getLevensteinDistance(string first, string second)
        {
            int[,] distanceMatrix = new int[first.Length, second.Length];

            // prva kolona/vrsta
            for (int i = 0; i < first.Length; i++) { distanceMatrix[i, 0] = i; }
            for (int k = 0; k < second.Length; k++) { distanceMatrix[0, k] = k; }

            // poređenje stringova:
            for(int k = 1; k < second.Length; k++)
            {
                for (int i = 1; i < first.Length; i++)
                {
                    int cost = 0, distance;
                    int insertion = distanceMatrix[i - 1, k] + 1, deletion = distanceMatrix[i, k - 1] + 1, substitution;

                    if (second[k] == first[i]) { cost = 0; }
                    else { cost = 1; }
                    substitution = distanceMatrix[i - 1, k - 1] + cost;

                    if (insertion < substitution)
                    {
                        if (insertion < deletion) { distance = insertion; }
                        else { distance = deletion; }
                    }
                    else
                    {
                        if (substitution < deletion) { distance = substitution; }
                        else { distance = deletion; }
                    }

                    distanceMatrix[i, k] = distance;
                }
            }

            return distanceMatrix[first.Length - 1, second.Length - 1];
        }

        static void SoundEx(String text, String pattern, String imeFajla)
        {
            Queue<int> patternPositions = new Queue<int>();
            Queue<String> times = new Queue<String>();
            Stopwatch stopwatch = new Stopwatch();
            //                   a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z
            char[] charValues = 
                { '0', '1', '2', '3', '0', '1', '2', '0', '0', '2', '2',
                '4', '5', '5', '0', '1', '2', '6', '2', '3', '0', '1', '0', '2', '0', '2' };
            char[] separators = { ' ', ';', '.', ':', '!', '?', ',', '-' };
            String upperPattern = pattern.ToUpper();
            upperPattern = upperPattern.Replace(",", " ").Replace("  ", " ");
            String[] patternWords = upperPattern.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            String upperText = text.ToUpper();
            String[] textWords = upperText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            // algoritam
            stopwatch.Start();

            // kodiranje pattern- a

            int[] patternCodes = new int[patternWords.Length];

            int ind = 0;
            foreach(String word in patternWords)
            {
                /*int codeIndex = 1;
                patternCodes[ind] = word[0];

                for (int i = 1; i < word.Length; i++)
                {
                    char charValue = charValues[word[i] - 65];
                    if (charValue == '0') { continue; }
                    if (charValue == charValues[word[i - 1] - 65]) { continue; }
                    if ((word[i - 1] == 'h' || word[i - 1] == 'w') && (charValue == charValues[word[i - 2] - 65])) { continue; }

                    patternCodes[ind] = patternCodes[ind] << 8 + charValue;
                    codeIndex++;
                    if (codeIndex == 4) { break; }
                }
                if (codeIndex < 4)
                {
                    for (int i = codeIndex; i < 4; i++)
                    {
                        patternCodes[ind] = patternCodes[ind] << 8 + '0';
                    }
                }*/
                patternCodes[ind++] = getSoundExCode(word, charValues);
            }

            // pretraga

            int[] textCodes = new int[textWords.Length];
            int firstWordIndex = patternWords.Length - 1;
            for (int i = firstWordIndex; i < textWords.Length; i++)
            {
                textCodes[i] = getSoundExCode(textWords[i], charValues);
                if (textCodes[i] != patternCodes[patternCodes.Length - 1]) { continue; } // poredi se poslednja reč u pattern-u

                // provera celog pattern-a
                bool patternMatch = true;
                int patternIndex = patternCodes.Length - 2;
                for (int k = i - 1; k > i - patternWords.Length + 1; k--)
                {
                    int currentCode;
                    if (firstWordIndex <= k) { currentCode = textCodes[k]; }
                    else { currentCode = textCodes[k] = getSoundExCode(textWords[k], charValues);}

                    if (currentCode != patternCodes[patternIndex--])
                    {
                        patternMatch = false;
                        break;
                    }
                }
                if (patternMatch) 
                { 
                    patternPositions.Enqueue(i - patternCodes.Length + 1);
                    times.Enqueue(stopwatch.Elapsed + "");
                }
            }
            
            stopwatch.Stop();
            times.Enqueue(stopwatch.Elapsed + "");

            // upis u fajl
            using (StreamWriter stream = new StreamWriter(imeFajla))
            {
                string line = "";
                int position, startPosition, endPosition;

                stream.WriteLine("Finding pattern:'" + pattern + "'\r\n");
                while (patternPositions.Count > 0)
                {
                    line = "Time = " + times.Dequeue() + "ms Sentence: '";
                    position = patternPositions.Dequeue();

                    startPosition = position - 1;
                    if (startPosition < 0) { startPosition = 0; }
                    endPosition = position + 1 + patternWords.Length;
                    if (endPosition > textWords.Length) { endPosition = textWords.Length; }

                    for (int k = startPosition; k < endPosition; k++)
                    {
                        line = line + textWords[k] + " ";
                    }
                    line = line + "'";
                    stream.WriteLine(line);
                }
                stream.WriteLine();
                if (times.Count > 0)
                {
                    stream.WriteLine("Total time = " + times.Dequeue() + "ms");
                }
            }

        }

        static int getSoundExCode(string word, char[] charValues)
        {
            if (int.TryParse(word, out _)) { return 0; }

            int code;

            int codeIndex = 1;
            code = word[0];

            for (int i = 1; i < word.Length; i++)
            {
                char charValue = charValues[word[i] - 65];
                if (charValue == '0') { continue; }
                if (charValue == charValues[word[i - 1] - 65]) { continue; }
                if ((word[i - 1] == 'h' || word[i - 1] == 'w') && (charValue == charValues[word[i - 2] - 65])) { continue; }

                code = (code << 8) + charValue;
                codeIndex++;
                if (codeIndex == 4) { break; }
            }
            if (codeIndex < 4)
            {
                for (int i = codeIndex; i < 4; i++)
                {
                    code = (code << 8) + '0';
                }
            }

            return code;
        }
    }
}
