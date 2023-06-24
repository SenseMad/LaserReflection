using UnityEngine;

namespace LazerReflection.Block
{
  /// <summary>
  /// Вращающийся блок
  /// </summary>
  public class RotatingBlock : Block
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

    /// <summary>
    /// Поворот блока
    /// </summary>
    public void BlockRotation()
    {
      transform.Rotate(Vector3.up, 90.0f);

      if (transform.rotation.y == 360.0f)
        transform.Rotate(Vector3.up, 0.0f);
    }

    //======================================

    public override void SetPositionBlock(Vector3Int parBlockPosition)
    {
      _blockPosition = parBlockPosition;
    }

    //======================================
  }
}