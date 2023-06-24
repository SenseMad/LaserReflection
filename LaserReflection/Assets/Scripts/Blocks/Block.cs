using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LazerReflection.Block
{
  public abstract class Block : MonoBehaviour
  {
    /// <summary>
    /// �������� ��� �����
    /// </summary>
    public abstract BlockType GetBlockType();

    /// <summary>
    /// �������� ������� �����
    /// </summary>
    public abstract Vector3Int GetBlockPosition();

    /// <summary>
    /// �������� ������� �����
    /// </summary>
    //public abstract Vector3Int GetBlockRotation();

    //======================================

    /// <summary>
    /// ���������� ������� �����
    /// </summary>
    public abstract void SetPositionBlock(Vector3Int parBlockPosition);

    /// <summary>
    /// ���������� ������� �����
    /// </summary>
    //public abstract void SetRotationBlock(Vector3Int parBlockRotation);

    //======================================
  }
}