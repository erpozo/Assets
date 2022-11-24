using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour {
    //Variable que almacena el daño que va a hacer
    public float damage;
    //Boleana para determinar si el objeto es destuible o no.
    public bool isDestructible;



    private void OnTriggerEnter2D(Collider2D collision) {
        //Si colisiona...
        if (collision.gameObject.TryGetComponent(out Damageable damageable)) {
            //Ejecuta el método que hace daño.
            damageable.GetDamage(damage);
            if (isDestructible) {

                Destroy(gameObject);

            }


        }



    }

}
