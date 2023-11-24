// For more imformation see https://aka.ms/fsharp-console-apps
type Cch = {
    Name: string
    Formerplayer: bool
}

type Sts = {
    wins: int 
    losses: int
}

type tm = {
    Name: string
    Cch: Cch
    Sts: Sts
}

let tm = [
    { Name = "Boston Celtics"; Cch = {Name = "Joe Mazzulla"; Formerplayer = false}; Sts = {wins = 3570; losses = 2462}}
    { Name = "Charlotte Hornets"; Cch = {Name = "Steve Clifford"; Formerplayer = true}; Sts = {wins = 1153; losses = 1478}}
    { Name = "Cleveland Cavaliers"; Cch = {Name = "J.B. Bickerstaff"; Formerplayer = true}; Sts = {wins = 1984; losses = 2287}}
    { Name = "Denver Nuggets"; Cch = {Name = "Michael Malone"; Formerplayer = true}; Sts = {wins = 1897; losses = 1890}}
    { Name = "Golden State Warriors"; Cch = {Name = "Steve Kerr"; Formerplayer = true}; Sts = {wins = 2923; losses = 3098}}
]

let goodtm = tm |> List.filter (fun tm -> tm.Sts.wins > tm.Sts.losses)

//printfn "%A" goodtm

goodtm |> List.iter (fun tm -> printfn "tm Name: %s" tm.Name)
goodtm |> List.iter (fun tm -> printfn "tm wins: %d" tm.Sts.wins)

let calculateSuccpercent tm = float tm.Sts.wins / float (tm.Sts.wins + tm.Sts.losses) * 100.0
let Succpercent = goodtm |> List.map calculateSuccpercent
let av = List.average Succpercent

printfn "percentage of tm %f" av 

type Cui =
    | Korean
    | Turkish

type MovieType = 
    | Reg
    | IMAX
    | DBOX
    | RegWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks
type Act =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cui
    | LongDrive of int * float

let calculatebudg Act = 
    match Act  with 
    | BoardGame | Chill -> 0.0
    | Movie Regular -> 12.0
    | Movie IMAX -> 17.0
    | Movie DBOX -> 20.0
    | Movie _ -> 12.0 + 5.0
    | Restaurant Korean -> 70.0
    | Restaurant Turkish -> 65.0
    | LongDrive (km, fuelchrg) -> float km * fuelchrg

let eveAct = Restaurant Turkish
let budg = calculatebudg eveAct
printfn "Est budg: %.2f CAD" budg


