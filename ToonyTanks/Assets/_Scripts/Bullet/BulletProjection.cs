using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjection : MonoBehaviour
{
    [SerializeField] float InitialVelocity;
    [SerializeField] float Angle;

    private void Update()
    {
        InputsCheck();
    }

    private void InputsCheck()
    {
        if( Input.GetKeyDown(KeyCode.Space))
        {
            float angle = Angle * Mathf.Deg2Rad;
            StopAllCoroutines();
            StartCoroutine(CoroutineMovement(InitialVelocity, angle));
        }
    }

    IEnumerator CoroutineMovement(float v0, float angle)
    {
        float t = 0;
        while(t< 100)
        {
            float x = v0 * t * Mathf.Cos(angle);
            float y = v0 * t * Mathf.Sin(angle) - (1f / 2f) * -Physics.gravity.y * Mathf.Pow(t, 2);
            transform.position = new Vector3(x, y, 0);
            t += Time.deltaTime;
            yield return null;
        }
    }
}
