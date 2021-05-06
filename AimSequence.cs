public class AimSequence
{
    public int Current { get; set; }
    public int Cap { get { return this.AimCount - 1; } }
    public int AimCount { get; set; }

    public AimSequence(int count)
    {
        this.AimCount = count;
    }

    public void Restore(int marker)
    {
        this.Current = marker % this.AimCount;
    }

    public void Reset()
    {
        this.Current = 0;
    }

    public void Increment()
    {
        this.Current++;

        if (this.Current > this.Cap)
            this.Current = 0;
    }

    public void Decrement()
    {
        this.Current--;

        if (this.Current < 0)
            this.Current = this.Cap;
    }

    public bool AtEnd()
    {
        return this.Current == this.Cap;
    }
}
