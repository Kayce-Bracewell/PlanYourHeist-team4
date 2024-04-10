Console.WriteLine("Plan Your Heist!");


Console.WriteLine("Please enter team member's name:");
string recruitName = Console.ReadLine();
Console.WriteLine("Please enter team member's skill level:");
int recruitSkillLevel = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter team member's courage factor:");
decimal recruitCourageFactor = decimal.Parse(Console.ReadLine());

Console.WriteLine(@$"Recruited Team Member information:
Name: {recruitName}
Skill level: {recruitSkillLevel}
Courage factor: {recruitCourageFactor}");