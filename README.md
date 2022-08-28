# Kogane UniTask Delay Seconds

UniTask.DelaySeconds を使えるようにするパッケージ

## 使用例

### Before

```csharp
using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Example : MonoBehaviour
{
    private async UniTaskVoid Start()
    {
        await UniTask.Delay( TimeSpan.FromSeconds( 1 ) );
    }
}
```

### After

```csharp
using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Example : MonoBehaviour
{
    private async UniTaskVoid Start()
    {
        await UniTask.DelaySeconds( 1 );
    }
}
```