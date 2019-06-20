using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof(ThirdPersonCharacter))]

    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }
        public ThirdPersonCharacter character { get; private set; }
        public Transform target;
        Animator animator;

        GameObject gameManager;
        GameObject player;

        public float damagepersecond;

        bool playerdie = false;
        float elapsed = 0f;

        GameObject UI_Canvas;

        public int damageDistance;

        private void Start()
        {
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();
            animator = GetComponent<Animator>();

            gameManager = GameObject.Find("GameController");
            player = GameObject.Find("Player");


            agent.updateRotation = false;
            agent.updatePosition = true;
            UI_Canvas = GameObject.Find("UI");

            SetTarget(player.transform);
        }


        private void Update()
        {

            if (animator.GetBool("Dead"))
                SetTarget(agent.transform);

            if (gameManager.GetComponent<PlayerManager>().IsDead() && !playerdie)
            {
                target = gameManager.transform;
            }

            if (GameObject.Find("Player") != null)
                if (target != null && Vector3.Distance(transform.position, player.transform.position) > damageDistance)
                    agent.SetDestination(target.position);

            if (GameObject.Find("Player") != null)
            {
                if (agent.remainingDistance > agent.stoppingDistance)
                    character.Move(agent.desiredVelocity, false, false);
                else
                {
                    character.Move(Vector3.zero, false, false);
                    if (animator.GetBool("Attack") && (Vector3.Distance(transform.position, player.transform.position) <= damageDistance))
                    {
                        elapsed += Time.deltaTime;
                        transform.LookAt(target);
                        if (elapsed >= 1f)
                        {
                            elapsed = elapsed % 1f;
                            gameManager.GetComponent<PlayerManager>().TakeDamage(damagepersecond);
                            Debug.Log("PLAYER HIT FOR " + damagepersecond + " DAMAGE!");
                            UI_Canvas.transform.Find("Health").GetComponent<Animator>().Play("textpop", 0);
                        }
                    }
                }
            }
        }


        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
