using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    enum CombatState
    {
        Selection,
        Playout
    }

    CombatState _currentState;

    bool _inCombat;
    
    //Holds all combatents including player
    List<GameObject> _combatents;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = CombatState.Selection;
        _inCombat = true;
        _combatents = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        while (_inCombat == true)
        {
            switch (_currentState)
            {
                case CombatState.Selection:
                    break;
                case CombatState.Playout:
                    break;
            }
        }
    }


}
