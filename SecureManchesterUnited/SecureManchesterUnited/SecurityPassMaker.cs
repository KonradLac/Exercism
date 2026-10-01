namespace SecureManchesterUnited;

internal class SecurityPassMaker
{
    public string GetDisplayName(TeamSupport teamSupport)
    {
        if(teamSupport is Manager)
        {
            return "Too Important for a Security Pass";
        }
        else if (teamSupport is Security && teamSupport.Title == "Security Team Member")
        {
            return $"{teamSupport.Title} Priority Personnel";
        }
        else
        {
            return teamSupport.Title;
        }
    }
}