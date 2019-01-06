namespace FSharp
open UnityEngine


type HelloFsharp() =
    inherit MonoBehaviour()
    [<DefaultValue>] val mutable mytext : string

    member this.Start() = Debug.Log("Hello World! jdoi");
    member this.Update() =

        this.mytext <- Time.deltaTime.ToString()