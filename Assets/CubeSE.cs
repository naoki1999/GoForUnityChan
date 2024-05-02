using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSE : MonoBehaviour
{
    //SE
    public AudioSource audioSource;
        
    //Cube�̃I�u�W�F�N�g
    private GameObject Cube;

    //Ground�̃I�u�W�F�N�g
    private GameObject ground;

    // Start is called before the first frame update
    void Start()
    {
        //�I�[�f�B�I�R���|�[�l���g���擾����
        audioSource = GetComponent<AudioSource>();

        //�O���E���h�̃R���|�[�l���g���擾����
        this.ground = GetComponent<GameObject>();

        //�L���[�u�̃R���|�[�l���g���擾����
        this.Cube = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�������ꂽ�L���[�u���L���[�u�ƐڐG�����ꍇSE�𗬂�
        if (collision.gameObject.tag == "CubeTag")
        {
            audioSource.Play();
        }
        //�������ꂽ�L���[�u���n�ʂɒ��n�����ꍇ��SE�𗬂�
        if (collision.gameObject.tag == "GroundTag")
        {
            audioSource.Play();
        }
       
    }
}
