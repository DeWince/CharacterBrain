using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stranger", menuName = "CharacterBrains/Stranger")]
public class Stranger : CharacterBrain
{
    [SerializeField] private float moveRadius;
    [SerializeField] private float positionChangeInterval =5;
    private float positionChangeTime =0;
    public override void Think(Character character)
    {
        positionChangeTime -= Time.deltaTime;
        if (positionChangeTime<0)
        {
            positionChangeTime = positionChangeInterval;
            Vector3 randomDirection = new Vector3(Random.Range(-1f,1f), 0, Random.Range(-1f, 1f)).normalized;
            character.MoveTo(character.transform.position + randomDirection * moveRadius);
        }

    }
}
