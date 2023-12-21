open System
open System.IdentityModel.Tokens.Jwt

[<EntryPoint>]
let main argv =
    try
        let token = Console.ReadLine() |> JwtSecurityToken |> string |> fun str -> str.Replace("}.{", "}\n{")
        Console.WriteLine(
            match argv |> Seq.tryHead with 
            | Some arg -> match Int32.TryParse arg with
                            | true, i -> token.Split("\n").[i]
                            | _ -> token
            | _ -> token
        )
        0
    with e -> 
        Console.Error.WriteLine e.Message
        1