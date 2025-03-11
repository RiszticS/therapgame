using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomeTax : BoardLocation 
{
    public override void PassBy(Player player)
    {
    }

    public override IEnumerator LandOn(Player player)
    {
        yield return MessageAlert.instance.DisplayAlert("Szerzőí jogdíj!  Fizess $20 000-t!", Color.red);
        player.AdjustBalanceBy(-20000);
    }
}
