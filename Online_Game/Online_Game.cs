using System;
using System.Linq;
using System.Collections.Generic;

namespace myproject
{
    public class Online_Game
    {    
        public int solution(string A, string B)
        {
            int startHour = int.Parse(A.Substring(0,2));
            int startMinute = int.Parse(A.Substring(3,2));

            if (startMinute > 45) {
                startMinute = 0;
                startHour += 1;
            }
            else if (startMinute > 30){
                startMinute = 45;
            }
            else if (startMinute > 15){
                startMinute = 30;
            }
            else if  (startMinute > 0){
                startMinute = 15;
            }

            int endHour = int.Parse(B.Substring(0,2));
            int endMinute = int.Parse(B.Substring(3,2));

            // if (endMinute > 45){
            //     endMinute = 45;
            // }
            // else if (endMinute > 30){
            //     endMinute = 30;
            // }
            // else if (endMinute > 15){
            //     endMinute = 15;
            // }
            // else if (endMinute > 0){
            //     endMinute = 0;
            // }
            endMinute = endMinute - (endMinute % 15);

            int playedMinutes = 0;

            if(endMinute >= startMinute && endHour >= startHour) {
                playedMinutes = endMinute - startMinute + (endHour-startHour) * 60;
            }
            else if (endMinute < startMinute && endHour >= startHour){
                playedMinutes = 60 - (startMinute - endMinute) + (endHour-startHour-1) * 60;
            }
            else if(endMinute >= startMinute && endHour < startHour) {
                playedMinutes = endMinute - startMinute + (24-startHour+endHour) * 60;
            }
            else{ // endMinute < startMinute && endHour < startHour
                playedMinutes = 60 - (startMinute - endMinute) + (24-startHour+endHour-1) * 60;
            }
            int nbrGames = playedMinutes/15;
            if (nbrGames >= 1){
                return  nbrGames;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            var prg = new Online_Game();
            string  A1 = "12:01";
            string  B1 = "12:44";
            string  A2 = "20:00";
            string  B2 = "06:00";
            string  A3 = "20:00";
            string  B3 = "00:00";
            string  A4 = "12:03";
            string  B4 = "12:03";
            string  A5 = "00:00";
            string  B5 = "23:59";
            Console.WriteLine("Between " + A1 + " and " + B1 + ", John is able to play " + prg.solution(A1, B1).ToString() + " full game rounds.");
            Console.WriteLine("Between " + A2 + " and " + B2 + ", John is able to play " + prg.solution(A2, B2).ToString() + " full game rounds.");
            Console.WriteLine("Between " + A3 + " and " + B3 + ", John is able to play " + prg.solution(A3, B3).ToString() + " full game rounds.");
            Console.WriteLine("Between " + A4 + " and " + B4 + ", John is able to play " + prg.solution(A4, B4).ToString() + " full game rounds.");
            Console.WriteLine("Between " + A5 + " and " + B5 + ", John is able to play " + prg.solution(A5, B5).ToString() + " full game rounds.");
        }   
    }
}

