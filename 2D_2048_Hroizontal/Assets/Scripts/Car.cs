//������:������r�A������
//�\��2021.10.17
//�}�o�� MAX 2021.10.17
using UnityEngine;  //�ޥ� Unity Engine API

// class ���O(�Ź�)�W�٭n���ɦW�ۦP�A�j�p�g�]�n�ۦP
public class Car : MonoBehaviour
{
    #region  ���y�k�P�|�j������
    //�{����� Field�A�x�s���
    //�y�k:
    //�׹��� ��������A���W�� �����Ÿ�
    //�`�ΰ򥻥|�j�������
    // 1. ���    �S���p���I�����t��� int     �w�]�� 0
    // 2. �B�I��  ���p���I�����t��� float     �w�]�� 0
    // 3. �r��    ��r��T string            �w�]�� ��
    // 4. ���L��  �O�P�_ true�Bfalse bool    �w�]�� false
    //�׹���
    //�p�H �ȭ������O�s�� Unity �����
    //���} �Ҧ����O�i�s�� Unity �|���

    // ����ݩ� Attritube
    // �y�k :
    // [�ݩʦW��(��)] - ������b���e���ΤW�@��
    // 1. ���D Header (�r��)
    // 2. ���� Tooltip (�r��)
    [Header("�T���� cc ��")] [Range(1000, 5000)]
    public int cc = 2000;
    [Tooltip("�o�O�T�������q�A�d��O 3 ~"), Range(3, 20)]
    public float weight = 3.5f;
    public string brand = "���h";
    public bool hasSkyWindow = true;
    #endregion

    #region �C�����`�θ������
    // �C�� Color
    public Color color1;
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpga = new Color(0, 1, 0, 0.3f);
    //�y�� Vector
    // Vector 2 - 4
    public Vector2 v2;
    public Vector2 v20ne = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2Custom = new Vector2(7, 9);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    // ���� KeyCode
    public KeyCode kc;
    public KeyCode KcW = KeyCode.W;
    public KeyCode KcML = KeyCode.Mouse0;

    // �C������ GameObject
    public GameObject carBox;
    public GameObject carOil;
    // ���� Component
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;
    #endregion

    #region �s������� Set Get

    //�{���J�f : �ƥ�
    //�}�l�ƥ� : ����C���ɰ���@���A��l�]�w
    private void Start()
    {
        print("���o�A�U�w");

        // ���o�����  �w�]�Ȥw�ݩʭ��O���D
        // �y�k:
        // ���W��:
        print("CC �� : " + cc);
        print(weight);

        // �s�� Srt �����
        // �y�k:
        // ���W�� ���w �� ;
        brand = "BMW";
        cc = 3500;
    }
    #endregion
}
