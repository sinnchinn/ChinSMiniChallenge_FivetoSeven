namespace ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge7_1
{
    public class MiniCh7_1Service : IMiniCh7_1Service
    {
        public string reverse = "";
        public string ReverseItPt1(string userInput)
        {
            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                reverse += userInput[i]; 
            }

            return $"you entered {userInput}. here is your input in reverse: {reverse}";
        }
    }
}