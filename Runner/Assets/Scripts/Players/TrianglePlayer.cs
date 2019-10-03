using UnityEngine;

public class TrianglePlayer : Player
{
    public override void UpdateVelocity()
    {
        if (currentVelocity < Velocity)
        {
            if (!doUpdateVelocity)
            {
                StartCoroutine(WaitForGrow());
            }

            if (counter > delayTime && doUpdateVelocity)
            {
                counter = 0;
                doUpdateVelocity = false;
                if (currentVelocity < Velocity / 2)
                {
                    curVelocityFuncValue++;
                    currentVelocity = curVelocityFuncValue;
                }
                else
                {
                    curVelocityFuncValue++;

                    var nextValue = Mathf.Pow((curVelocityFuncValue), 2);
                    if (currentVelocity + nextValue > Velocity)
                    {
                        currentVelocity = Velocity;
                    }
                    else
                    {
                        currentVelocity = nextValue;
                    }
                }
            }

            counter += Time.deltaTime;
        }
    }
}
