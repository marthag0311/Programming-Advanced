using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace _01_Duplicates
{
    internal class Program
    {
        /*
        Find all duplicates starting with a given sequence 
        in the given file Download the given file(already 
        in CodeGrade). Try to solve each exercise in 
        different ways, always start from the naive approach 
        first (brute force), and then try to work more 
        efficiently based on what we saw in the lesson! 
        Think what Big(O) could be!

        CodeGrade Setup = .Net framework 6.0

        input:
        aa
        output:
        aaaogvhosm aaarwdshpe aabetaeils aacfrlsdtd 
        aacguuwgmu aaddhroonm aadgjyuviz aafajokdlu 
        aafhakixki aaheyrnjzo aahkjrnvhr aahpixoayl 
        aahxwxcizt aalkylujbh aamdipybjk aamqfpmnqu 
        aaptqhdcwm aaqejjuict aaqnfgbglt aarfnsmwbd 
        aarnlwpfce aauckqruos aaukjnnsnb aavjvxzqhn 
        aavoilagcu aawwvajmny aaxktlbwye

        input:
        1
        output:
        No duplicates found.
         */
        static void Main(string[] args)
        {
            try
            {
                string start = Console.ReadLine();

                Assignment assignment = new Assignment();
                //Console.WriteLine(assignment.Duplicates(start, "words.txt"));
                //Console.WriteLine(assignment.BruteForce(start, "words.txt"));
                Console.WriteLine(assignment.BinarySearch(start, "words.txt"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}