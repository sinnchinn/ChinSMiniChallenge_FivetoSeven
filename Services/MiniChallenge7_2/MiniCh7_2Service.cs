namespace ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge7_2;

public class MiniCh7_2Service : IMiniCh7_2Service
{

    public string reverse = "";
    public string ReverseItPt2(string nums1)
    {
        bool isTrue = int.TryParse(nums1, out int realNums1);

            if(isTrue == true)
            {

                for(int i = realNums1.ToString().Length - 1; i >= 0; i--)
                {
                    reverse += realNums1.ToString()[i];
                }

                return $"you entered {realNums1}. here are those numbers in reverse: {reverse}";
            } else {
                return "these are not numbers!";
            }
    }
}
