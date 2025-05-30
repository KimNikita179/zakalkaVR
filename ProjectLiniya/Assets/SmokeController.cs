using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SmokeController : MonoBehaviour
{
    public ParticleSystem smokeParticles;  // �����ݬܬ� �߬� ��ڬ��֬ެ� ��Ѭ��ڬ�
    public float delaySeconds = 2f;       // ���Ѭլ֬�جܬ� �� ��֬ܬ�߬լѬ�

    // ����٬�ӬѬ֬��� ���� �߬ѬجѬ�ڬ� �ܬ߬��ܬ�
    public void StartSmokeAfterDelay()
    {
        Invoke("PlaySmoke", delaySeconds); // ���Ѭ���� �լ�ެ� ��֬�֬� 18 ��֬ܬ�߬�
    }

    private void PlaySmoke()
    {
        if (smokeParticles != null)
        {
            smokeParticles.Play();         // ���ܬݬ��ڬ�� �լ��
        }
        else
        {
            Debug.LogError("ParticleSystem �߬� �߬Ѭ٬߬Ѭ�֬�!");
        }
    }
}