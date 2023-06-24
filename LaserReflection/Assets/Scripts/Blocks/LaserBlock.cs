using UnityEngine;

namespace LazerReflection.Block
{
  /// <summary>
  /// Лазерный блок
  /// </summary>
  [RequireComponent(typeof(LineRenderer))]
  public class LaserBlock : Block
  {
    [SerializeField, Tooltip("Тип блока")]
    private BlockType _blockType;

    [SerializeField, Tooltip("Позиция блока")]
    private Vector3Int _blockPosition;

    [SerializeField, Tooltip("Точка выстрела")]
    private Transform _shotPoint;

    public bool test;

    //--------------------------------------

    private LineRenderer lineRenderer;

    private int maxRayLength = 100; // Максимальная длина луча

    //======================================

    public override BlockType GetBlockType() => _blockType;

    public override Vector3Int GetBlockPosition() => _blockPosition;

    //======================================

    private void Awake()
    {
      lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
      if (test)
        return;

      ReleaseLaser();
    }

    //======================================

    /// <summary>
    /// Выпустить лазер
    /// </summary>
    private void ReleaseLaser()
    {
      var ray = new Ray(transform.position, transform.forward);

      lineRenderer.positionCount = 1;
      lineRenderer.SetPosition(0, transform.position);

      while (true)
      {
        if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit, maxRayLength))
        {
          lineRenderer.positionCount += 1;
          var hitPoint = new Vector3(Mathf.Round(hit.point.x), Mathf.Round(hit.point.y), Mathf.Round(hit.point.z));
          lineRenderer.SetPosition(lineRenderer.positionCount - 1, hit.point);
          ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));

          var block = hit.collider.GetComponent<Block>();
          if (block.GetBlockType() == BlockType.LaserBlock || block.GetBlockType() == BlockType.FixedBlock || block.GetBlockType() == BlockType.FinishBlock)
            break;
        }
        else
        {
          lineRenderer.positionCount += 1;
          var pos = ray.origin + ray.direction * maxRayLength;
          var lazerPosition = new Vector3(Mathf.Round(pos.x), Mathf.Round(pos.y), Mathf.Round(pos.z));
          //lineRenderer.SetPosition(lineRenderer.positionCount - 1, lazerPosition);
          lineRenderer.SetPosition(lineRenderer.positionCount - 1, ray.origin + ray.direction * maxRayLength);
          break;
        }
      }
    }

    //======================================

    public override void SetPositionBlock(Vector3Int parBlockPosition)
    {
      _blockPosition = parBlockPosition;
    }

    //======================================
  }
}