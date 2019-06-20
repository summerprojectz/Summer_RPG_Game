using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voltmancer : BaseClass
{
    #region Fields
    List<BaseSkill> _skills = new List<BaseSkill>();
    #endregion

    #region Properties
    #endregion

    #region Methods
    public Voltmancer()
    {
        _skills.Add(new Spark());
    }

    
    #endregion
}
