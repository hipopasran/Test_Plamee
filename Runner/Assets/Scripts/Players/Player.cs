using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D),typeof(BoxCollider2D),typeof(SpriteRenderer))]
public abstract class Player : MonoBehaviour
{
    const string GAME_OVER_SCENE = "GameOver";
    const string OBSTACLES_TAG = "Obstacle";

    [SerializeField]
    protected Color color;
    [SerializeField]
    protected LayerMask floorLayerMask;

    protected Rigidbody2D rigibody2d;
    protected BoxCollider2D boxCollider2d;
    protected SpriteRenderer spriteRenderer;
    protected bool doUpdateVelocity;

    protected float counter = 0;
    protected float delayTime = 1f;
    protected float currentVelocity = 0;
    protected float curVelocityFuncValue = 0;

    public float Velocity { get; set; }
    public Color JumpColor { get; set; }

    void OnEnable()
    {
        InputManager.OnClicked += Jump;
    }

    void OnDisable()
    {
        InputManager.OnClicked -= Jump;
    }

    void Awake()
    {
        rigibody2d = this.GetComponent<Rigidbody2D>();
        boxCollider2d = this.GetComponent<BoxCollider2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        Velocity = 20f;
    }

    void Update()
    {
        if(IsGrounded())
        {
            spriteRenderer.color = Color.white;
        }
        else
        {
            spriteRenderer.color = color;
        }
    }

    void FixedUpdate()
    {
        Run();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == OBSTACLES_TAG)
            SceneManager.LoadScene(GAME_OVER_SCENE);

    }

    public virtual void UpdateVelocity()
    {
        if (currentVelocity < Velocity)
        {
            if (!doUpdateVelocity)
            {
                StartCoroutine(WaitForGrow());
            }

            if(counter > delayTime && doUpdateVelocity)
            {
                counter = 0;
                curVelocityFuncValue++;
                currentVelocity = curVelocityFuncValue;
                doUpdateVelocity = false;
            }

            counter += Time.deltaTime;
        }
    }

    public virtual void Run()
    {
        UpdateVelocity();
        transform.Translate(Vector3.right * currentVelocity * Time.deltaTime);
    }

    public virtual void Jump()
    {
        if (IsGrounded())
        {
            rigibody2d.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
    }

    public virtual bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f,floorLayerMask);
        return raycastHit2d.collider != null;
    }

    protected IEnumerator WaitForGrow()
    {
        yield return new WaitForSeconds(delayTime);
        doUpdateVelocity = true;
    }
}
