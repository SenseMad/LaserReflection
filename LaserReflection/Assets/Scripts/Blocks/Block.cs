using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LazerReflection.Block
{
  public abstract class Block : MonoBehaviour
  {
    /// <summary>
    /// Получить тип блока
    /// </summary>
    public abstract BlockType GetBlockType();

    /// <summary>
    /// Получить позицию блока
    /// </summary>
    public abstract Vector3Int GetBlockPosition();

    /// <summary>
    /// Получить поворот блока
    /// </summary>
    //public abstract Vector3Int GetBlockRotation();

    //======================================

    /// <summary>
    /// Установить позицию блока
    /// </summary>
    public abstract void SetPositionBlock(Vector3Int parBlockPosition);

    /// <summary>
    /// Установить поворот блока
    /// </summary>
    //public abstract void SetRotationBlock(Vector3Int parBlockRotation);

    //======================================
  }
}