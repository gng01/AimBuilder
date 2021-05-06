public class AimBuilder
{
    public Aim GetAim(AimBuildInstructions instructions, int i)
    {
        Aim aim = this.CreateAim();
        return instructions.GetActions()[i](aim);
    }

    Aim CreateAim()
    {
        Aim aim = new UnityEngine.GameObject().AddComponent<Aim>();

        aim.Initialize();

        return aim;
    }
}
