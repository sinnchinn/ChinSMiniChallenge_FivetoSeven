namespace ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge6
{
    public class MiniCh6Service : IMiniCh6Service
    {
        public string OddOrEven(string num1)
        {
            bool isTrue = int.TryParse(num1, out int realNum1);

            if(isTrue == true)
            {
                if(realNum1 % 2 == 0)
                {
                    return $"{realNum1} is an even number!";
                } else {
                    return $"{realNum1} is an odd number!";
                }
            } else {
                return $"that is not a number!";
            }
        }
    }
}