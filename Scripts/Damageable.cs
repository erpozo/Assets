using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damageable : MonoBehaviour {
    //Vida m�xima del objeto
    public float maxHealth;
    //Vida actual
    public float currentHealth;
    //Referencia a la barra de vida
    public Image healthBar;

    // Referencia al animator que tiene este GameObject;
    private Animator animator;

    public bool isDead = false;

    private void Awake() {
        animator = GetComponent<Animator>();
    }
    void Start() {
        currentHealth = maxHealth;

    }

    public void Death() {
        isDead = true;
        if (animator != null) {
            animator.SetTrigger("IsDead");
        } else {
            //Si no hay animator, destruimos el objeto
            Destroy(gameObject);
        }
    }

    public void GetDamage(float damage) {
        Debug.Log("Recibiendo " + damage + " de da�o");
        currentHealth -= damage;

        if (currentHealth <= 0) {
            Debug.Log("VidaInferiorA0");
            Death();
            Destroy(gameObject, 3);

        }

    }



}
