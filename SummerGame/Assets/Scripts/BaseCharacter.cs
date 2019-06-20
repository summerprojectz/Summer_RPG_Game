using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    #region Fields
    Dictionary<string, int> _characteristics = new Dictionary<string, int>();
    #endregion

    #region Properties
    public Dictionary<string, int> Characteristics
    {
        get { return _characteristics; }
        set { _characteristics = value; }
    }
    #endregion

    #region Methods
    public virtual void Awake()
    {
        _characteristics.Add("WeaponSkill", 1);
        _characteristics.Add("BalisticSkill", 1);
        _characteristics.Add("Strength", 1);
        _characteristics.Add("Toughness", 1);
        _characteristics.Add("Agility", 1);
        _characteristics.Add("Intellegence", 1);
        _characteristics.Add("Perception", 1);
        _characteristics.Add("WillPower", 1);
        _characteristics.Add("Fellowship", 1);
    }
    #endregion
}
