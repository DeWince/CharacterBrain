using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour
{
    [SerializeField] private Stranger strangerBrain;
    [SerializeField] private Pawn pawnBrain;
    public CharacterBrain currentBrain;
    public NavMeshAgent agent;
    // Update is called once per frame
    void Update()
    {
        if (currentBrain)
        {
            currentBrain.Think(this);
        }     
        if (Input.GetKeyDown(KeyCode.P))
        {
            SwitchBrain(pawnBrain);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SwitchBrain(strangerBrain);
        }
    }
    public void MoveTo(Vector3 point)
    {
        agent.SetDestination(point);
    }
    public void SwitchBrain(CharacterBrain brain)
    {
        currentBrain = brain;
    }

}
