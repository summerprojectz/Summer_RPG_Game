using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSkill : MonoBehaviour
{
    #region Fields
    public enum Range
    {
        Touch, 
        Close,
        Medium,
        Long
    }

    Range _skillRange;

    string _name, _description, _element;

    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Element
    {
        get { return _element; }
        set { _element = value; }
    }

    public Range SkillRange
    {
        get { return _skillRange; }
        set { _skillRange = value; }
    }
    #endregion

    #region Methods
    public BaseSkill()
    {
        _name = "";
        _description = "";
        _element = "";
    }
    #endregion
}
