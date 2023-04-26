using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject key, moveDoor, nomoveDoor;
    public HingeJoint hinge;

    public void GrabKey()
    {
        StartCoroutine(LevelEnd());
        hinge = moveDoor.GetComponent<HingeJoint>();
        hinge.useMotor = false;
    }

    IEnumerator LevelEnd()
    {
        yield return new WaitForSeconds(3.0f);

        key.SetActive(false);
        nomoveDoor.SetActive(false);

        moveDoor.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        hinge.useMotor = true;
    }
}
