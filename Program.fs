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
