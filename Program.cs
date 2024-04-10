List<TeamMember> teamMembers = new List<TeamMember>();

Console.WriteLine("Plan Your Heist!");


bool ContinueBool = true;
while (ContinueBool == true)
{
    Console.WriteLine("Please enter team member's name:");
    string recruitName = Console.ReadLine();
    if (recruitName == "")
    {
        ContinueBool = false;
        break;
    }
    Console.WriteLine("Please enter team member's skill level:");
    int recruitSkillLevel = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter team member's courage factor:");
    decimal recruitCourageFactor = decimal.Parse(Console.ReadLine());

    Console.WriteLine(@$"Recruited Team Member information:
    Name: {recruitName}
    Skill level: {recruitSkillLevel}
    Courage factor: {recruitCourageFactor}");

    teamMembers.Add(
        new TeamMember
        {
            Name = recruitName,
            SkillLevel = recruitSkillLevel,
            CourageFactor = recruitCourageFactor
        }
    );
}

Console.WriteLine($"Number of team members: {teamMembers.Count}");
foreach (TeamMember teamMember in teamMembers)
{
    Console.WriteLine($"{teamMember.Name} has a skill level of {teamMember.SkillLevel} and a courage factor of {teamMember.CourageFactor}");
}