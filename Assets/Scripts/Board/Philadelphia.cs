using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Philadelphia : BoardLocation
{
    public static Philadelphia instance;
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
