using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawn
{
    public interface ISpawn
    {
        public void Spawn();

        public void Delete();
    }
}
