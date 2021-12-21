using System.Collections;
using System.Collections.Generic;
using Character.Options;
using UnityEngine;

namespace Character.Options
{
    public class DamageController : MonoBehaviour
    {
        public int DamageForce;

        private HealthController _healthController = new HealthController();
        public void GetDamage()
        {
            _healthController.HealthCount -= DamageForce;
        }
    }
}
