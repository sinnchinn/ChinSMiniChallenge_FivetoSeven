namespace ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge5;

public class MiniCh5Service : IMiniCh5Service
{
    public string MadLibs(string userName, string adj1, string verb1, string noun1, string verb2, string noun2, string adj2, string adj3, string noun3, string name2, string adj4)
    {
        return $"Hello {userName}! You're the main character of this story. Let's get started. {userName} was having a/an {adj1} morning. You woke up early and were able to {verb1} before 8am. It was time to head to {noun1}. You decided to {verb2} there instead of riding the bus like usual. On the way there, you saw that there was a/an {noun2} on the ground. It was {adj2} and smelled {adj3}. You decided to bring the {noun2} to {noun1} and stuffed it in your {noun3}. The people at {noun1} noticed the {noun2} and decided that you all should keep it. They named it {name2}. The {noun2} looked {adj4}. It spent the rest of its days at {noun1}.";
    }
}
