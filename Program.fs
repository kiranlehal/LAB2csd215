type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy 
    | Fantasy 
    | Sport

type Dir = {
    Name: string
    Movies: int 
}

type Mov = {
    Name: string
    RunLngth: int
    Genre: Genre
    Dir: Dir
    IMDB: float
}
