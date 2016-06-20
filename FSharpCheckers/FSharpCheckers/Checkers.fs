module Checkers

let maxTileX = 8
let maxTileY = 8

type Point = {
    x: int;
    y: int;
}
type Checker = {
    position: Point;
    isKing: bool; 
    player: int;
}

let checkers = [] : List<Checker>

//Needs to be modified to include regular pieces.
let getValidImmediateMovePositionsKing pt =
    let possibleMoves = [ 
        {x=pt.x + 1; y = pt.y + 1};
        {x=pt.x; y = pt.y+ 1};
        {x=pt.x + 1; y = pt.y};
        {x=pt.x - 1; y = pt.y - 1};
        {x=pt.x; y =pt.y - 1};
        {x=pt.x - 1; y = pt.y};
    ]
    possibleMoves |> List.filter (fun move -> move.x <= 8 && 
                                              move.y <= 8 && 
                                              move.x >= 0 && 
                                              move.y >= 0)

//This is for a normal piece.  Not a king.
let getAllValidMoves selectedPosition moveToPosition li = 
    let rec loopThroughPositions currentPosition = 
        let possibleMoves = getValidImmediateMovePositions selectedPosition 
        let checkers = li |> List.filter (fun record -> record.position.x = selectedPosition.x &&
                                                        record.position.y = selectedPosition.y)
        
    loopThroughPositions selectedPosition 

let getJumpMove position otherPosition = 
    let positionDelta = (position.x - otherPosition.x, position.y - otherPosition.y)
    {x = position.x - fst positionDelta; y = position.y - snd positionDelta}

let test = getValidImmediateMovePositions {x=0;y=0};;