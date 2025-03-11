using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Atlanta : BoardLocation
{
    public static Atlanta instance;
    protected override void AdditionalInit()
    {
        instance = this;
    }

    public override void PassBy(Player player)
    {
    }

    public override IEnumerator LandOn(Player player)
    {
        yield return null;
    }
}
