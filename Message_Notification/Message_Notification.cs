namespace myproject
{
    public class Message_Notification
    {  
        public string solution(string message, int K)
        {
            if (message.Length <= K){
                return message;
            }
            else{
                message = message.Substring(0,K);
            }

            int index = 4;
            int len = message.Length;
            try{
                while (true){
                    char temp = message[len-index];
                    if (temp == ' '){
                        break;
                    }
                    index ++;
                }
                return message.Substring(0, len-index) + " ...";
            }
            catch(Exception e){
                return "...";
            }
        }

        static void Main(string[] args)
        {
            var prg = new Message_Notification();
            Console.WriteLine(prg.solution("And now here is my secret", 15));
            Console.WriteLine(prg.solution("There is an animal with four legs", 15));
            Console.WriteLine(prg.solution("super dog", 4));
            Console.WriteLine(prg.solution("how are you", 20));

        }   
    }
}

