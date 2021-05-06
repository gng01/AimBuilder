using UnityEngine;

public class AimController : MonoBehaviour
{
    public CharacterLibrary characterLibrary;
    public AnimationLibrary animationLibrary;
    public ColorLibrary colorLibrary;

    public AimSequence Sequence { get; set; }

    AimBuildInstructions instructions;
    AimBuilder builder;

    public Aim ActiveAim { get; set; }

    public void Initialize(int aimSequenceMarker)
    {
        this.builder = new AimBuilder();

        this.instructions = new AimBuildInstructions0(this.characterLibrary, this.animationLibrary, this.colorLibrary, GetComponent<Animator>());

        this.Sequence = new AimSequence(this.instructions.GetActions().Count);

        this.Sequence.Restore(aimSequenceMarker);
    }

    public Aim BuildAim()
    {
        this.CleanUp();

        this.ActiveAim = this.builder.GetAim(this.instructions, this.Sequence.Current);

        return this.ActiveAim;
    }

    void CleanUp()
    {
        Destroy(this.ActiveAim ? this.ActiveAim.gameObject : null);
    }
}
