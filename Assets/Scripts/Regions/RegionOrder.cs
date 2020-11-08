using System;
using UnityEngine;

public class RegionOrder : MonoBehaviour
{
    #region Public variables

    public Action EventSample;

    public int PublicPropertySample { get; set; }

    private string publicVariableSample;
    public String Entisdfsd__ { get; private set; }

    #endregion

    #region Private variables

    private string _privateVariableSample;

    #endregion

    #region Unity methods

    private void Awake()
    {

    } 

    public void Start()
    {

    }

    #endregion

    #region Private methods

    private void PrivateSampleMethod()
    {

    }

    #endregion


    #region PublicMethods

    public void PublicSampleMethod()
    {

    }

    #endregion



    #region Events

    private void OnEventSample()
    {
        if (EventSample != null)
        {
            EventSample.Invoke();
        }
    } 

    #endregion
}
