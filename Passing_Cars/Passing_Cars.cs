using System;
using System.Linq;
using System.Collections.Generic;

namespace myproject
{
    public class Passing_Cars
    {    
        public int solution(string S)
        {
            int nbrPassedCameras = 0;
            int nbrDriveBys = 0;
            foreach (char s in S){
                if (s == '.'){
                  nbrPassedCameras ++;  
                }
                else if (s == '<'){
                    nbrDriveBys += nbrPassedCameras;
                }
            }
            nbrPassedCameras = 0;
            for (int i = S.Length-1; i>-1; i--){
                if (S[i] == '.'){
                    nbrPassedCameras ++;
                }
                else if (S[i] == '>'){
                    nbrDriveBys += nbrPassedCameras;
                }
            }
            return nbrDriveBys;
        }

        static void Main(string[] args)
        {
            var prg = new Passing_Cars();
            string  A = ".>...";  //3
            string  B = ".>.<.>"; // 2
            string  C = ">>>.<<<"; //6
            string  D = ".<.>.<.>>.."; // 1 + 3 + 4 + 2 + 2 = 12
            string  E = ">...<<>..<..<..>>.<<.>.<>.>..<"; // 15 + 12 + 6 + 6 + 4 + 3 + 2 + 15 + 12 + 10 + 10 + 7 + 5 + 3 + 3 = 113
            Console.WriteLine("Result for array A = " + prg.solution(A).ToString());
            Console.WriteLine("Result for array B = " + prg.solution(B).ToString());
            Console.WriteLine("Result for array C = " + prg.solution(C).ToString());
            Console.WriteLine("Result for array D = " + prg.solution(D).ToString());
            Console.WriteLine("Result for array D = " + prg.solution(E).ToString());
        }   
    }
}

