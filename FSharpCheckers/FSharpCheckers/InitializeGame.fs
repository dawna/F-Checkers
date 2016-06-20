module InitializeGame

open CheckersGame

[<EntryPoint>]
let main argv =
    use g = new CheckersGame()
    g.Run()
    0