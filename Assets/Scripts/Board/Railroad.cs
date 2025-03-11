using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Railroad : Ownable
{
    [SerializeField] private Railroad[] otherRailroads;

    protected override int ChargePlayer()
    {
        // Determine how much to charge.  
        int toCharge = 25000;
        foreach (Railroad railroad in otherRailroads)
            if (railroad.owner == owner)
                toCharge *= 2;

        return toCharge;
    }

    private int semmi = 0;
    protected override int hazmegvetele()
    {
        return semmi;
    }

}
