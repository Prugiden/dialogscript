using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public AudioClip replik;
    public AudioSource aus;
    public GameObject textpers;
    //����� ��������
    public float zaderzhka;
    //������� ������� ����� � ����� �����������
    public float zaderzhka2;
    void Start()
    {
        aus = GetComponent<AudioSource>();
        Invoke("govorit", zaderzhka);
    }
    public void govorit()
    {
        textpers.SetActive(true);
        Invoke("stopping", zaderzhka2);
        aus.PlayOneShot(replik);
    }
   public void stopping()
    {
        textpers.SetActive(false);
    }
}
