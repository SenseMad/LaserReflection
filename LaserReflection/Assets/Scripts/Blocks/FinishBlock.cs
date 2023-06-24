using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LazerReflection.Block
{
  /// <summary>
  /// Финишный блок
  /// </summary>
  public class FinishBlock : Block
  {
    [SerializeField, Tooltip("Тип блока")]
    private BlockType _blockType;

    [SerializeField, Tooltip("Позиция блока")]
    private Vector3Int _blockPosition;

    //======================================

    public override BlockType GetBlockType() => _blockType;

    public override Vector3Int GetBlockPosition() => _blockPosition;

    //======================================



    //======================================

    public override void SetPositionBlock(Vector3Int parBlockPosition)
    {
      _blockPosition = parBlockPosition;
    }

    //======================================
  }
}