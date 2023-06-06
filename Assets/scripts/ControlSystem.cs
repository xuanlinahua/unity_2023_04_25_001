using Fungus;
using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    [Header("���ʳt��")]
    [Range(0,10)]
    public float moveSpeed = 3.5f;
    [Header("����")]
    public Rigidbody2D rig;
    [Header("�ʵe���")]
    public Animator ani;
    [Header("�]�B�Ѽ�")]
    public string parRun = "�}������"; 
    


    public void Awake()
    {
        print(25688);
        print("����");
        print($"{1 + 2}");
    }
    private void Start()
    {
        print("<color=yellow>�}�l�ƥ�</color>");
    }
    private void Update()
    {
        // print("<color=#899887>��s�ƥ�</color>");

        // �I�s���ʤ覡
        Move();
    }

	private void Move()
	{
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        rig.velocity = new Vector2(h, 0) * moveSpeed;

        // h ������ 0 �Ϊ� v ������ 0 �n����
        ani.SetBool(parRun, h != 0 || v != 0);

        // print(Input.GetKeyDown(KeyCode.A));

        // �p�G ���U A �Ϊ� ���U �� �N �]�w�� 180
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
            // print("���a���U A");
            transform.eulerAngles = new Vector3(0, 180, 0);
		}

        // �p�G ���U D �Ϊ� ���U �k �N �]�w�� 0
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // print("���a���U D");
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

}
