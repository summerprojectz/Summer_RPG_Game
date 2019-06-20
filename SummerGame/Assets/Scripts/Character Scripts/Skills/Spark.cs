using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : BaseSkill
{
    #region Fields
    int _baseDamage;

    #endregion

    #region Properties
    public int BaseDamage
    {
        get { return _baseDamage; }
        set { _baseDamage = value; }
    }
    #endregion

    #region Methods
    public Spark()
    {
        Name = "Spark";
        Description = "Sends a bold of lightning towards an enemy within medium range.";
        Element = "Plasma";
        SkillRange = Range.Medium;
        _baseDamage = 20;
    }
    #endregion
}
