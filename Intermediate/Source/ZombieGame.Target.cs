using UnrealBuildTool;

public class ZombieGameTarget : TargetRules
{
	public ZombieGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ZombieGame");
	}
}
