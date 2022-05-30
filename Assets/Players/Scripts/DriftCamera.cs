using System;
using UnityEngine;

public class DriftCamera : MonoBehaviour
{
    [Serializable]
    public class AdvancedOptions
    {
        public bool updateCameraInUpdate;
        public bool updateCameraInFixedUpdate = true;
        public bool updateCameraInLateUpdate;
        public KeyCode switchViewKey = KeyCode.C;
    }

    public float smoothing = 6f;
    public Transform cameraTarget;
    public Transform frowardView;
    public Transform topDownView;
    public AdvancedOptions advancedOptions;

    bool m_ShowingSideView;

    private void FixedUpdate ()
    {
        if(advancedOptions.updateCameraInFixedUpdate)
            UpdateCamera ();
    }

    private void Update ()
    {
        if (Input.GetKeyDown (advancedOptions.switchViewKey))
            m_ShowingSideView = !m_ShowingSideView;

        if(advancedOptions.updateCameraInUpdate)
            UpdateCamera ();
    }

    private void LateUpdate ()
    {
        if(advancedOptions.updateCameraInLateUpdate)
            UpdateCamera ();
    }

    private void UpdateCamera ()
    {
        if (m_ShowingSideView)
        {
            transform.position = topDownView.position;
            transform.rotation = topDownView.rotation;
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, frowardView.position, Time.deltaTime * smoothing);
            transform.LookAt(cameraTarget);
        }
    }
}
