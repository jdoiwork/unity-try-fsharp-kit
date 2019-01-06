namespace FSharp
open UnityEngine

type HelloFsharp() =
    inherit MonoBehaviour()
    member this.Start() = Debug.Log("Hello World! jdoi2");