using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBoss : MonoBehaviour
{

    StateMachineDIA stateMachine;
    SubBoss_GoTowardsPlayerState goTowardsPlayerState;
    SubBoss_ShootState shootState;


    public SubBoss()
    {
        stateMachine = new StateMachineDIA();

    }

    // Start is called before the first frame update
    void Start() 
    {
        //initializeing states
        goTowardsPlayerState = new SubBoss_GoTowardsPlayerState(this);
        shootState = new SubBoss_ShootState(this);

        //switchin to gotowardsplayer
        stateMachine.SwitchState(goTowardsPlayerState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
