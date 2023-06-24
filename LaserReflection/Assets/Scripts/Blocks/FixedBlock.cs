using UnityEngine;

namespace LazerReflection.Block
{
  /// <summary>
  /// ����������� ����
  /// </summary>
  public class FixedBlock : Block
  {
    [SerializeField, Tooltip("��� �����")]
    private BlockType _blockType;

    [SerializeField, Tooltip("������� �����")]
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