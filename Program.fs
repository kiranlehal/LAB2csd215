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
    { Name = "Boston Celtics"; Cch = {Name = "Joe Mazzulla"; Formerplayer = false}; Sts = {wins = 3,570; losses = 2,462}}
    { Name = "Charlotte Hornets"; Cch = {Name = "Steve Clifford"; Formerplayer = true}; Sts = {wins = 1,153; losses = 1,478}}
    { Name = "Cleveland Cavaliers"; Cch = {Name = "J.B. Bickerstaff"; Formerplayer = true}; Sts = {wins = 1,984; losses = 2,287}}
    { Name = "	Denver Nuggets"; Cch = {Name = "Michael Malone"; Formerplayer = true}; Sts = {wins = 1,897; losses = 1,890}}
    { Name = "Golden State Warriors"; Cch = {Name = "Steve Kerr"; Formerplayer = true}; Sts = {wins = 2,923; losses = 3,098}}
]

