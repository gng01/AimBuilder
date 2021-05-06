using System;
using System.Collections.Generic;
using UnityEngine;

public class AimBuildInstructions0 : AimBuildInstructions
{
    public AimBuildInstructions0(CharacterLibrary characterLibrary, AnimationLibrary animationLibrary, ColorLibrary colorLibrary, Animator animator) : base(characterLibrary, animationLibrary, colorLibrary, animator) { }

    public override List<Func<Aim, Aim>> GetActions()
    {
	// these can be rearranged, skipped, repeated
        return new List<Func<Aim, Aim>>()
        {
            (Aim a)=>A1(a),
            (Aim a)=>A2(a),
            (Aim a)=>A3(a)
        };
    }


    Aim A1(Aim a)
    {
	// get 2 "generic1" characters, 1 colored red and the other green, and have them do the wiggle dance

        AimItem[] characters = this.ItemFactory.Get(
            new AimItemArgs(
                2,
                new AnimationClip[] { this.AnimationLibrary.Get("wiggle") },
                this.CharacterLibrary.Get("generic1"),
                1f,
                new Color[] { this.ColorLibrary.Get("red"), this.ColorLibrary.Get("green") }
                )
            );

	// have them fill in a circular formation

        characters = this.ItemFormation.Distributed(characters, 1);

        a.AddItems(characters);

        return a;
    }

    Aim A2(Aim a)
    {
	// set up aim

        return a;
    }

    Aim A3(Aim a)
    {
	// set up aim

        return a;
    }
}
