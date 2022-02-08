namespace MinimalJwt.Services

module IMovieService =
    open MinimalJwt.Models.Movie
    // Some kind of interface from csharp
    type IMovieService =
        abstract member Create : movie: Movie -> Movie
        abstract member Get : id: int -> Option<Movie>
        abstract member List : unit -> list<Movie>
        abstract member Update : newMovie: Movie -> Movie
        abstract member Delete : id: int -> bool
