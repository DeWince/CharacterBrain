using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Pawn",menuName ="CharacterBrains/Pawn")]
public class Pawn : CharacterBrain
{
    [SerializeField] LayerMask raycastMask;
    public override void Think(Character character)
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100, raycastMask.value))
            {
                character.MoveTo(hit.point);
            } 
        }

    }

}
