using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacter : BaseCharacter
{
    #region Fields
    BaseClass _class;
    #endregion

    #region Properties
    public BaseClass Class
    {
        get { return _class; }
        set { _class = value; }
    }
    #endregion

    #region Methods
    public TestCharacter() : base()
    {
        Name = "Test Character";
        _class = new Voltmancer();
    }

    public override void Awake()
    {
        base.Awake();
        Debug.Log(Name);
        Debug.Log(Characteristics["Level"].ToString());
    }
    #endregion
}
